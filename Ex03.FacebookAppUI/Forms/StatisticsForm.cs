using System.Threading;
using System.Collections.Generic;
using System.Windows.Forms;
using Ex03.FacebookAppLogic.Classes;
using Ex03.FacebookAppUI.Loaders;
using FacebookWrapper.ObjectModel;
using Ex03.FacebookAppUI.Enums;
using Ex03.FacebookAppUI.Interfaces;
using Ex03.FacebookAppUI.Classes;

namespace Ex03.FacebookAppUI.Forms
{
    public partial class StatisticsForm : Form
    {
        // ATTRIBUTES
        private readonly List<List<PropertyCounter>> r_ListOfPropertyCounterLists;
        private ILoaderAdapter<Checkin> m_CheckinLoaderAdapter;
        private ILoaderAdapter<User> m_FriendLoaderAdapter;
        private User m_LoggedInUser;
        private bool m_IsSecondStatisticsLoaded = false;
        private PropertyCountCalculator m_PropertyCountCalculator;
        private Loader<Checkin> m_CheckinsPieChartLoader;
        private Loader<User> m_TaggedFriendsPieChartLoader;

        // CTOR
        public StatisticsForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
            this.r_ListOfPropertyCounterLists = new List<List<PropertyCounter>>() { new List<PropertyCounter>(), new List<PropertyCounter>() };
            this.m_CheckinLoaderAdapter = new LoaderAdapter<Checkin>();
            this.m_FriendLoaderAdapter = new LoaderAdapter<User>();
            fillFriendsTaggedInPostsCountersList();
            // doesnt work since we cant get place attribute from Facebook API
            //fillCheckinsCountersList();
            this.m_PropertyCountCalculator = new PropertyCountCalculator();
            this.m_CheckinsPieChartLoader = this.m_CheckinLoaderAdapter.FormToLoaderAdapt(eLoaderFactoryContext.CreatePieChartLoader, this.m_LoggedInUser.Checkins, this.r_ListOfPropertyCounterLists[0], this.locationPieChart, "Checkins location distribution", "locationPieChartInfo");
            this.m_TaggedFriendsPieChartLoader = this.m_FriendLoaderAdapter.FormToLoaderAdapt(eLoaderFactoryContext.CreatePieChartLoader, this.m_LoggedInUser.Friends, this.r_ListOfPropertyCounterLists[1], this.friendsTaggedInPostsPieChart, "Friends tagged in posts distribution", "friendsTaggedInPostsPieChartInfo");
        }

        // PRIVATE METHODS
        private void fillCheckinsCountersList()
        {
            foreach (Checkin checkin in this.m_LoggedInUser.Checkins)
            {
                this.r_ListOfPropertyCounterLists[0].Add(new PropertyCounter(checkin.Place.Location.Country));
            }
        }

        private void fillFriendsTaggedInPostsCountersList()
        {
            foreach (User friend in this.m_LoggedInUser.Friends)
            {
                this.r_ListOfPropertyCounterLists[1].Add(new PropertyCounter(friend.Name));
            }
        }

        private bool checkIfLocationIsNotInLocationCountersList(Checkin i_CheckinToCheck, ref string io_UniquePropertyString)
        {
            bool result = true;

            foreach (PropertyCounter locationCounter in this.r_ListOfPropertyCounterLists[0])
            {
                if (locationCounter.PropertyName == i_CheckinToCheck.Place.Location.Country)
                {
                    result = false;
                    locationCounter.Counter++;
                    break;
                }
            }

            if (result)
            {
                io_UniquePropertyString = i_CheckinToCheck.Place.Location.Country;
            }

            return result;
        }

        private bool checkIfFriendNotTaggedInPostCountersList(User i_FriendToCheck, ref string io_UniquePropertyString)
        {
            bool result = false;
            PropertyCounter friendPropertyCounterPtr = getFriendCounterByName(i_FriendToCheck.Name);

            foreach (Post post in this.m_LoggedInUser.Posts)
            {
                if (post.Message != null && post.Message.Contains(i_FriendToCheck.Name))
                {
                    friendPropertyCounterPtr.Counter++;
                }
            }

            return result;
        }

        private PropertyCounter getFriendCounterByName(string i_FriendName)
        {
            PropertyCounter friendToFind = null;

            foreach (PropertyCounter propertyCounter in this.r_ListOfPropertyCounterLists[1])
            {
                if (propertyCounter.PropertyName == i_FriendName)
                {
                    friendToFind = propertyCounter;
                    break;
                }
            }

            return friendToFind;
        }

        private void loadCheckinsPieChart()
        {
            this.m_PropertyCountCalculator.PropertyCountCalculatorStrategy = new CheckinPropertyCountCalculatorStrategy(this.m_LoggedInUser.Checkins, this.r_ListOfPropertyCounterLists[0]);
            this.m_PropertyCountCalculator.CalculatePropertyCountValues(getDistinctCheckinsList());
            this.m_TaggedFriendsPieChartLoader.LoadProperties(null);
        }

        private void loadTaggedFriendsPieChart()
        {
            if (!this.m_IsSecondStatisticsLoaded)
            {
                this.m_IsSecondStatisticsLoaded = true;
                this.m_PropertyCountCalculator.PropertyCountCalculatorStrategy = new TaggedFriendsPropertyCountCalculatorStrategy(this.m_LoggedInUser.Posts, this.r_ListOfPropertyCounterLists[1]);
                this.m_PropertyCountCalculator.CalculatePropertyCountValues(this.m_LoggedInUser.Friends);
                this.m_TaggedFriendsPieChartLoader.LoadProperties(null);
            }
        }

        private FacebookObjectCollection<Checkin> getDistinctCheckinsList()
        {
            FacebookObjectCollection<Checkin> distinctCheckinsList = new FacebookObjectCollection<Checkin>();
            List<string> duplicateCheckinsNamesList = new List<string>();

            foreach (Checkin checkin in this.m_LoggedInUser.Checkins)
            {
                if (!isCheckinInDuplicateCheckinsNamesList(duplicateCheckinsNamesList, checkin))
                {
                    duplicateCheckinsNamesList.Add(checkin.Place.Location.Country);
                    distinctCheckinsList.Add(checkin);
                }
            }


            return distinctCheckinsList;
        }

        private bool isCheckinInDuplicateCheckinsNamesList(List<string> i_DuplicateCheckinsNamesList, Checkin i_CheckinToCheck)
        {
            bool result = false;

            foreach (string checkinName in i_DuplicateCheckinsNamesList)
            {
                if (i_CheckinToCheck.Place.Location.Country == checkinName)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        // EVENTS
        private void StatisticsForm_Load(object sender, System.EventArgs e)
        {
            // doesnt work since we cant get place attribute from Facebook API
            //new Thread(() => calculateDataAndShowItInPieChart<Checkin>(this.m_LoggedInUser.Checkins, "checkins", this.m_CheckinPropertyCountCalculator, this.m_CheckinsPieChartLoader)).Start();
        }

        private void tabPanel_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            new Thread(loadTaggedFriendsPieChart).Start();
        }
    }
}
using System.Collections.Generic;
using System.Windows.Forms;
using Ex02.FacebookAppLogic.Classes;
using Ex02.FacebookAppUI.Loaders;
using FacebookWrapper.ObjectModel;
using Ex02.FacebookAppUI.Enums;
using System.Threading;
using Ex02.FacebookAppUI.Interfaces;
using Ex02.FacebookAppUI.Classes;

namespace Ex02.FacebookAppUI.Forms
{
    public partial class StatisticsForm : Form
    {
        // ATTRIBUTES
        private ILoaderAdapter<Checkin> m_CheckinLoaderAdapter;
        private ILoaderAdapter<User> m_FriendLoaderAdapter;
        private readonly List<List<PropertyCounter>> r_ListOfPropertyCounterLists;
        private User m_LoggedInUser;
        private bool m_IsSecondStatisticsLoaded = false;
        private PropertyCountCalculator<Checkin> m_CheckinPropertyCountCalculator;
        private PropertyCountCalculator<User> m_TaggedFriendsPropertyCountCalculator;
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
            this.m_CheckinPropertyCountCalculator = new PropertyCountCalculator<Checkin>(this.m_LoggedInUser.Checkins, this.r_ListOfPropertyCounterLists[0]);
            this.m_CheckinPropertyCountCalculator.DuplicatePropertyCheckingMethodIsNeeded += checkIfLocationIsNotInLocationCountersList;
            m_TaggedFriendsPropertyCountCalculator = new PropertyCountCalculator<User>(this.m_LoggedInUser.Friends, this.r_ListOfPropertyCounterLists[1]);
            this.m_TaggedFriendsPropertyCountCalculator.DuplicatePropertyCheckingMethodIsNeeded += checkIfFriendNotTaggedInPostCountersList;
            this.m_CheckinsPieChartLoader = this.m_CheckinLoaderAdapter.FormToLoaderAdapt(eLoaderFactoryContext.CreatePieChartLoader, this.m_LoggedInUser.Checkins, this.r_ListOfPropertyCounterLists[0], this.locationPieChart, "Checkins location distribution", "locationPieChartInfo");
            this.m_TaggedFriendsPieChartLoader = this.m_FriendLoaderAdapter.FormToLoaderAdapt(eLoaderFactoryContext.CreatePieChartLoader, this.m_LoggedInUser.Friends, this.r_ListOfPropertyCounterLists[1], this.friendsTaggedInPostsPieChart, "Friends tagged in posts distribution", "friendsTaggedInPostsPieChartInfo");
        }

        // PRIVATE METHODS
        private void fillFriendsTaggedInPostsCountersList()
        {
            foreach (User friend in this.m_LoggedInUser.Friends)
            {
                this.r_ListOfPropertyCounterLists[1].Add(new PropertyCounter(friend.Name, 0));
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

        private void calculateDataAndShowItInPieChart<T>(FacebookObjectCollection<T> i_FacebookObjectCollection, string i_InfoName, PropertyCountCalculator<T> i_PropertyCountCalculator, Loader<T> i_PieChartLoader)
        {
            if (i_FacebookObjectCollection.Count != 0)
            {
                i_PropertyCountCalculator.CalculatePropertyCountValues();
                i_PieChartLoader.LoadProperties(null);
            }
            else
            {
                MessageBox.Show(string.Format("{0}, you do not have any {1}!", this.m_LoggedInUser.FirstName, i_InfoName));
            }
        }

        private void loadTaggedFriendsPieChart()
        {
            if (!this.m_IsSecondStatisticsLoaded)
            {
                this.m_IsSecondStatisticsLoaded = true;
                calculateDataAndShowItInPieChart<User>(this.m_LoggedInUser.Friends, "friends", this.m_TaggedFriendsPropertyCountCalculator, this.m_TaggedFriendsPieChartLoader);
            }
        }

        // EVENTS
        private void StatisticsForm_Load(object sender, System.EventArgs e)
        {
            // doesnt work since we cant get place attribute from Facebook API
            new Thread(() => calculateDataAndShowItInPieChart<Checkin>(this.m_LoggedInUser.Checkins, "checkins", this.m_CheckinPropertyCountCalculator, this.m_CheckinsPieChartLoader)).Start();
        }

        private void tabPanel_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            new Thread(loadTaggedFriendsPieChart).Start();
        }
    }
}
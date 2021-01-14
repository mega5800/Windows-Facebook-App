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
        private readonly FacebookObjectCollection<Checkin> r_DistinctCheckinsList;
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
            this.r_DistinctCheckinsList = new FacebookObjectCollection<Checkin>();
            // doesnt work since we cant get place attribute from Facebook API
            //fillDistinctCheckinsListAndPropertyCounterList();
            fillFriendsTaggedInPostsCountersList();
            this.m_PropertyCountCalculator = new PropertyCountCalculator();
            this.m_CheckinsPieChartLoader = this.m_CheckinLoaderAdapter.FormToLoaderAdapt(eLoaderFactoryContext.CreatePieChartLoader, this.m_LoggedInUser.Checkins, this.r_ListOfPropertyCounterLists[0], this.locationPieChart, "Checkins location distribution", "locationPieChartInfo");
            this.m_TaggedFriendsPieChartLoader = this.m_FriendLoaderAdapter.FormToLoaderAdapt(eLoaderFactoryContext.CreatePieChartLoader, this.m_LoggedInUser.Friends, this.r_ListOfPropertyCounterLists[1], this.friendsTaggedInPostsPieChart, "Friends tagged in posts distribution", "friendsTaggedInPostsPieChartInfo");
        }

        // PRIVATE METHODS
        private void fillDistinctCheckinsListAndPropertyCounterList()
        {
            List<string> duplicateCheckinsNamesList = new List<string>();

            foreach (Checkin checkin in this.m_LoggedInUser.Checkins)
            {
                if (!isCheckinInDuplicateCheckinsNamesList(duplicateCheckinsNamesList, checkin))
                {
                    this.r_ListOfPropertyCounterLists[0].Add(new PropertyCounter(checkin.Place.Location.Country));
                    duplicateCheckinsNamesList.Add(checkin.Place.Location.Country);
                    this.r_DistinctCheckinsList.Add(checkin);
                }
            }
        }

        private void fillFriendsTaggedInPostsCountersList()
        {
            foreach (User friend in this.m_LoggedInUser.Friends)
            {
                this.r_ListOfPropertyCounterLists[1].Add(new PropertyCounter(friend.Name));
            }
        }

        private void loadCheckinsPieChart()
        {
            this.m_PropertyCountCalculator.PropertyCountCalculatorStrategy = new CheckinPropertyCountCalculatorStrategy(this.m_LoggedInUser.Checkins, this.r_ListOfPropertyCounterLists[0]);
            this.m_PropertyCountCalculator.CalculatePropertyCountValues(this.r_DistinctCheckinsList);
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
            //new Thread(loadCheckinsPieChart).Start();
        }

        private void tabPanel_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            new Thread(loadTaggedFriendsPieChart).Start();
        }
    }
}
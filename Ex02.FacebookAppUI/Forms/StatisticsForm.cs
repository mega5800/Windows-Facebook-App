using System.Collections.Generic;
using System.Windows.Forms;
using Ex02.FacebookAppLogic.Classes;
using FacebookWrapper.ObjectModel;

namespace Ex02.FacebookAppUI.Forms
{
    public partial class StatisticsForm : Form
    {
        // ATTRIBUTES
        private readonly List<PropertyCounter> r_LocationCountersList;
        private readonly List<PropertyCounter> r_FriendsTaggedInPostsCountersList;
        private User m_LoggedInUser;
        private bool m_IsSecondStatisticsLoaded = false;
        private PieChartDataLoadingComponent<Checkin> m_PieChartCheckinsDataLoadingComponent;
        private PieChartDataLoadingComponent<User> m_PieChartFriendsTaggedInPostsDataLoadingComponent;

        // CTOR
        public StatisticsForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
            this.r_LocationCountersList = new List<PropertyCounter>();
            this.r_FriendsTaggedInPostsCountersList = new List<PropertyCounter>();
            this.r_FriendsTaggedInPostsCountersList = new List<PropertyCounter>();
            fillFriendsTaggedInPostsCountersList();
            this.m_PieChartCheckinsDataLoadingComponent = new PieChartDataLoadingComponent<Checkin>(this.locationPieChart, this.m_LoggedInUser.Checkins, "Checkins location distribution", this.r_LocationCountersList, "locationPieChartInfo");
            this.m_PieChartCheckinsDataLoadingComponent.DuplicatePropertyCheckingMethodIsNeeded += checkIfLocationIsNotInLocationCountersList;
            m_PieChartFriendsTaggedInPostsDataLoadingComponent = new PieChartDataLoadingComponent<User>(this.friendsTaggedInPostsPieChart, this.m_LoggedInUser.Friends, "Friends tagged in posts distribution", this.r_FriendsTaggedInPostsCountersList, "friendsTaggedInPostsPieChartInfo");
            this.m_PieChartFriendsTaggedInPostsDataLoadingComponent.DuplicatePropertyCheckingMethodIsNeeded += checkIfFriendNotTaggedInPostCountersList;
        }

        // PRIVATE METHODS
        private void fillFriendsTaggedInPostsCountersList()
        {
            foreach (User friend in this.m_LoggedInUser.Friends)
            {
                this.r_FriendsTaggedInPostsCountersList.Add(new PropertyCounter(friend.Name, 0));
            }
        }

        private bool checkIfLocationIsNotInLocationCountersList(Checkin i_CheckinToCheck, ref string io_UniquePropertyString)
        {
            bool result = true;

            foreach (PropertyCounter locationCounter in this.r_LocationCountersList)
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

            foreach (PropertyCounter propertyCounter in this.r_FriendsTaggedInPostsCountersList)
            {
                if (propertyCounter.PropertyName == i_FriendName)
                {
                    friendToFind = propertyCounter;
                    break;
                }
            }

            return friendToFind;
        }

        // EVENTS
        private void StatisticsForm_Load(object sender, System.EventArgs e)
        {
            if (!this.m_PieChartCheckinsDataLoadingComponent.LoadDataIntoPieChart())
            {
                MessageBox.Show(string.Format("{0}, you do not have any checkins!", this.m_LoggedInUser.FirstName));
            }
        }

        private void tabPanel_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (!this.m_IsSecondStatisticsLoaded)
            {
                this.m_IsSecondStatisticsLoaded = true;
                if (!this.m_PieChartFriendsTaggedInPostsDataLoadingComponent.LoadDataIntoPieChart())
                {
                    MessageBox.Show(string.Format("{0}, you do not have any posts!", this.m_LoggedInUser.FirstName));
                }
            }
        }
    }
}
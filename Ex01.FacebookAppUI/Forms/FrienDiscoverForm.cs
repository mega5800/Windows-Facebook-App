using Ex01.FacebookAppLogic.Classes;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace Ex01.FacebookAppUI.Forms
{
    public partial class FrienDiscoverForm : Form
    {
        private User m_LoggedInUser;

        public FrienDiscoverForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
        }

        // PRIVATE METHODS
        private void fetchFrienDiscoverInfo()
        {
            Random r1 = new Random();
            User chosenFriendFirstDegree = null;
            while (chosenFriendFirstDegree == null || checkIfRandFriendIsSelf(chosenFriendFirstDegree))
            {
                int firstDegreeRandFriendIndex = r1.Next(0, this.m_LoggedInUser.Friends.Count);
                chosenFriendFirstDegree = this.m_LoggedInUser.Friends[firstDegreeRandFriendIndex];
            }
            this.firstChosenFriendLabel.Text = string.Format("Your known friend chosen was {0}:", chosenFriendFirstDegree.Name);
            
            Random r2 = new Random();
            User chosenFriendSecondDegree = null;
            while (chosenFriendSecondDegree == null || checkIfRandFriendIsSelf(chosenFriendSecondDegree))
            {
                int secondDegreeRandFriendIndex = r2.Next(0, chosenFriendFirstDegree.Friends.Count);
                chosenFriendSecondDegree = chosenFriendFirstDegree.Friends[secondDegreeRandFriendIndex];
            }
            this.secondChosenFriendLabel.Text = string.Format("And your new potential friend is -{0}- :", chosenFriendSecondDegree.Name);

            if (this.m_LoggedInUser.Friends.Count == 0)
            {
                MessageBox.Show("The user does not have any friends!");
            }
        }

        private bool checkIfRandFriendIsSelf(User i_UserToCheck)
        {
            bool isSelf = false;

            if (i_UserToCheck.Id == this.m_LoggedInUser.Id)
            {
                isSelf = true;
            }

            return isSelf;
        }

        // EVENTS
        private void frienDiscoverForm_Load(object sender, EventArgs e)
        {
            fetchFrienDiscoverInfo();
        }

        private void profilePageBtn_Click(object sender, EventArgs e)
        {

        }

        private void reDiscoverBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

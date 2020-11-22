using Ex01.FacebookAppLogic.Classes;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace Ex01.FacebookAppUI.Forms
{
    public partial class FrienDiscoverForm : Form
    {
        // ATTRIBUTES
        private User m_LoggedInUser;
        private User m_ChosenFriendFirstDegree = null;
        private User m_ChosenFriendSecondDegree = null;
        private Thread m_StartThread;
        private readonly Random r_RandomFactor;
        private readonly List<int> r_LoggedInUserFriendsIndexList;
        private readonly List<int> r_ChosenFriendFirstDegreeFriendsIndexList;
        private const string k_FirstFriendName = "The system selected your friend {0} to help find new friend!";
        private const string k_FacebookUrl = "http://facebook.com/{0}";

        // CTOR
        public FrienDiscoverForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
            this.r_RandomFactor = new Random();
            this.r_LoggedInUserFriendsIndexList = new List<int>();
            this.m_StartThread = new Thread(new ThreadStart(pickFirstDegreeAndSecondDegreeFriends));
            this.r_ChosenFriendFirstDegreeFriendsIndexList = new List<int>();
        }

        // PRIVATE METHODS
        private void fillUserFriendsIndexList(User i_User, List<int> i_ListToFill)
        {
            i_ListToFill.Clear();
            for (int i = 0; i < i_User.Friends.Count; i++)
            {
                i_ListToFill.Add(i);
            }
        }

        private void pickFirstDegreeAndSecondDegreeFriends()
        {
            bool isSecondDegreeRandomFriendSelected = false;
            int firstDegreeRandomFriendIndex, secondDegreeRandomFriendIndex;

            fillUserFriendsIndexList(this.m_LoggedInUser, this.r_LoggedInUserFriendsIndexList);
            while (!isSecondDegreeRandomFriendSelected && this.r_LoggedInUserFriendsIndexList.Count > 0)
            {
                firstDegreeRandomFriendIndex = getRandomFriendIndexAndSetValuesToSelectedFriend(this.r_LoggedInUserFriendsIndexList,
                    this.m_LoggedInUser, ref this.m_ChosenFriendFirstDegree);
                fillUserFriendsIndexList(this.m_ChosenFriendFirstDegree, this.r_ChosenFriendFirstDegreeFriendsIndexList);
                this.firstDegreeFriendNameLbl.Visible = true;
                this.firstDegreeFriendNameLbl.Text = string.Format(k_FirstFriendName, this.m_ChosenFriendFirstDegree.Name);
                while (!isSecondDegreeRandomFriendSelected && this.r_ChosenFriendFirstDegreeFriendsIndexList.Count > 0)
                {
                    secondDegreeRandomFriendIndex = getRandomFriendIndexAndSetValuesToSelectedFriend(this.r_ChosenFriendFirstDegreeFriendsIndexList,
                        this.m_ChosenFriendFirstDegree, ref this.m_ChosenFriendSecondDegree);
                    isSecondDegreeRandomFriendSelected = checkIfSecondDegreeRandomFriendIsNotLoggedInUser();
                    if (!isSecondDegreeRandomFriendSelected || checkIfPotentialFriendIsAlreadyMyFriend())// you can disable checkIfPotentialFriendIsAlreadyMyFriend
                    {                                                                                     // and see how the feature works!
                        this.r_ChosenFriendFirstDegreeFriendsIndexList.Remove(secondDegreeRandomFriendIndex);
                        this.m_ChosenFriendSecondDegree = null;
                    }
                }

                if (this.m_ChosenFriendSecondDegree == null)
                {
                    this.r_LoggedInUserFriendsIndexList.Remove(firstDegreeRandomFriendIndex);
                }
            }

            if (this.m_ChosenFriendSecondDegree == null)
            {
                this.newFriendPictureBox.Visible = false;
                setEmptyTextAndSetVisibleToFalse(this.firstDegreeFriendNameLbl);
                setEmptyTextAndSetVisibleToFalse(this.newFriendAboutLbl);
                setEmptyTextAndSetVisibleToFalse(this.newFriendAgeLbl);
                setEmptyTextAndSetVisibleToFalse(this.newFriendNameLbl);
                MessageBox.Show(string.Format("{0}, unfortunately the system couldn't find you a suitable new person to meet :("
                    , this.m_LoggedInUser.FirstName));
            }
            else
            {
                loadPotentialNewFriendDataIntoForm();
            }
        }

        private void setEmptyTextAndSetVisibleToFalse(Label i_LabelToChangeProperties)
        {
            i_LabelToChangeProperties.Text = "";
            i_LabelToChangeProperties.Visible = false;
        }

        private void loadPotentialNewFriendDataIntoForm()
        {
            this.newFriendNameLbl.Text = string.Format("Name: {0}", this.m_ChosenFriendSecondDegree.Name);
            this.newFriendAgeLbl.Text = string.Format("Age: {0}", getNewFriendAge());
            this.newFriendAboutLbl.Text = string.Format("About:{0}{1}", Environment.NewLine, this.m_ChosenFriendSecondDegree.About);
            this.newFriendPictureBox.LoadAsync(this.m_ChosenFriendSecondDegree.PictureNormalURL);
        }

        private int getNewFriendAge()
        {
            string newFriendBirthDate;
            int newFriendBirthYear, currentYear;

            newFriendBirthDate = this.m_ChosenFriendSecondDegree.Birthday;
            currentYear = DateTime.Now.Year;
            newFriendBirthYear = int.Parse(newFriendBirthDate.Substring(6));

            return currentYear - newFriendBirthYear;
        }

        private bool checkIfSecondDegreeRandomFriendIsNotLoggedInUser()
        {
            bool result = true;

            if (this.m_LoggedInUser.Id == this.m_ChosenFriendSecondDegree.Id)
            {
                result = false;
            }

            return result;
        }

        private int getRandomFriendIndexAndSetValuesToSelectedFriend(List<int> i_UserFriendChooserList, User i_UserFriendChooser, ref User i_ChosenFriendPointer)
        {
            int randomFriendIndex = 0;

            randomFriendIndex = this.r_RandomFactor.Next(0, i_UserFriendChooserList.Count);
            randomFriendIndex = i_UserFriendChooserList[randomFriendIndex];
            i_ChosenFriendPointer = i_UserFriendChooser.Friends[randomFriendIndex];

            return randomFriendIndex;
        }

        private void goToNewFriendFacebookProfile()
        {
            if (this.m_ChosenFriendSecondDegree == null)
            {
                MessageBox.Show(string.Format("{0}, you need to find a new friend first!", this.m_LoggedInUser.FirstName));
            }
            else
            {
                Process.Start(string.Format(k_FacebookUrl, this.m_ChosenFriendSecondDegree.UserName));// cant get user name
            }   
        }

        private bool checkIfPotentialFriendIsAlreadyMyFriend()
        {
            bool result = false;

            foreach (User friend in this.m_LoggedInUser.Friends)
            {
                if (this.m_ChosenFriendSecondDegree.Id == friend.Id)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        // EVENTS
        private void FrienDiscoverForm_Load(object sender, EventArgs e)
        {
            this.m_StartThread.Start();
        }

        private void getRandomPersonBtn_Click(object sender, EventArgs e)
        {
            pickFirstDegreeAndSecondDegreeFriends();
        }

        private void goToRandomPersonProfileBtn_Click(object sender, EventArgs e)
        {
            goToNewFriendFacebookProfile();
        }
    }
}
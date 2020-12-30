using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using Ex03.FacebookAppLogic.Classes;
using FacebookWrapper.ObjectModel;
using Ex03.FacebookAppLogic.Facades;

namespace Ex03.FacebookAppUI.Forms
{
    public partial class FrienDiscoverForm : Form
    {
        // ATTRIBUTES
        private const string k_FirstFriendName = "The system selected your friend {0} to help find a new friend!";
        private const string k_FacebookUrl = "http://facebook.com/{0}";
        private readonly FrienDiscoverLogicComponentFacade r_FrienDiscoverLogicComponentFacade;
        private User m_LoggedInUser;
        private User m_ChosenFriendFirstDegree = null;
        private User m_ChosenFriendSecondDegree = null;

        // CTOR
        public FrienDiscoverForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
            this.r_FrienDiscoverLogicComponentFacade = new FrienDiscoverLogicComponentFacade();
        }

        // PRIVATE METHODS
        private void getResultFromFrienDiscoverLogicComponentFacade()
        {
            this.r_FrienDiscoverLogicComponentFacade.PickFirstDegreeAndSecondDegreeFriends(ref this.m_ChosenFriendFirstDegree, ref this.m_ChosenFriendSecondDegree);
            if (this.m_ChosenFriendSecondDegree == null)
            {
                MessageBox.Show(string.Format("{0}, unfortunately the system couldn't find you a suitable new person to meet :(", this.m_LoggedInUser.FirstName));
            }
            else
            {
                this.newPersonInfoPanel.Invoke(new Action(() => prepareUIToShowNewFriendData()));
            }
        }

        private void prepareUIToShowNewFriendData()
        {
            this.firstDegreeFriendNameLbl.Visible = true;
            this.firstDegreeFriendNameLbl.Text = string.Format(k_FirstFriendName, this.m_ChosenFriendFirstDegree.Name);
            setUIVisible(true);
            loadPotentialNewFriendDataIntoForm();
        }

        private void setUIVisible(bool i_BoolValue)
        {
            this.newFriendPictureBox.Visible = i_BoolValue;
            this.firstDegreeFriendNameLbl.Visible = i_BoolValue;
            this.newFriendAboutLbl.Visible = i_BoolValue;
            this.newFriendAgeLbl.Visible = i_BoolValue;
            this.newFriendNameLbl.Visible = i_BoolValue;
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

        private void goToNewFriendFacebookProfile()
        {
            if (this.m_ChosenFriendSecondDegree == null)
            {
                MessageBox.Show(string.Format("{0}, you need to find a new friend first!", this.m_LoggedInUser.FirstName));
            }
            else
            {
                Process.Start(string.Format(k_FacebookUrl, this.m_ChosenFriendSecondDegree.UserName));
            }   
        }

        // EVENTS
        private void FrienDiscoverForm_Load(object sender, EventArgs e)
        {
            new Thread(getResultFromFrienDiscoverLogicComponentFacade).Start();
        }

        private void getRandomPersonBtn_Click(object sender, EventArgs e)
        {
            setUIVisible(false);
            new Thread(getResultFromFrienDiscoverLogicComponentFacade).Start();
        }

        private void goToRandomPersonProfileBtn_Click(object sender, EventArgs e)
        {
            goToNewFriendFacebookProfile();
        }
    }
}
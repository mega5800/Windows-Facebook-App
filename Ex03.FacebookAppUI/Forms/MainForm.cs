using System;
using System.ComponentModel;
using System.Windows.Forms;
using Ex03.FacebookAppUI.Interfaces;
using Ex03.FacebookAppLogic.Classes;
using Ex03.FacebookAppUI.Classes;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Ex03.FacebookAppUI.Forms
{
    public partial class MainForm : Form
    {
        // ATTRIBUTES
        private Form m_ActiveForm = null;
        private User m_LoggedInUser;
        private AppSettings m_AppSettings;

        // CTOR
        public MainForm()
        {
            InitializeComponent();
            this.m_AppSettings = AppSettings.Instance;
            this.m_LoggedInUser = LoggedInUser.Instance;
            fetchAppSettingsInfo();
        }

        // PRIVATE METHODS
        private void fetchUserInfo()
        {
            this.userNameLabel.Text = this.m_LoggedInUser.Name;
            this.profilePictureBox.LoadAsync(this.m_LoggedInUser.PictureNormalURL);
            this.statusLabel.Text = string.Format("What's on your mind {0}?", m_LoggedInUser.FirstName);
            this.statusTextBox.Text = "-Post a Status-";
        }

        private void fetchAppSettingsInfo()
        {
            this.Location = this.m_AppSettings.LastWindowLocation;
            this.checkBoxRememberUser.Checked = this.m_AppSettings.RememberUser;
        }

        private void openFormInActivityPanel(Form i_FormToDisplay)
        {
            if (m_ActiveForm != null)
            {
                m_ActiveForm.Close();
            }

            this.m_ActiveForm = i_FormToDisplay;
            i_FormToDisplay.TopLevel = false;
            i_FormToDisplay.FormBorderStyle = FormBorderStyle.None;
            i_FormToDisplay.Dock = DockStyle.Fill;
            this.activityPanel.Controls.Add(i_FormToDisplay);
            this.activityPanel.Tag = i_FormToDisplay;
            i_FormToDisplay.BringToFront();
            i_FormToDisplay.Show();
        }

        private void checkIfUserHasFriendsAndRunFrienDiscoverFormIfSo()
        {
            if (this.m_LoggedInUser.Friends.Count == 0)
            {
                MessageBox.Show(string.Format("{0}, you need to have at least one friend to use this feature!", this.m_LoggedInUser.FirstName));
            }
            else
            {
                openFormInActivityPanel(new FrienDiscoverForm());
            }
        }

        private void closingFormActions()
        {
            this.m_AppSettings.LastWindowLocation = this.Location;
            this.m_AppSettings.RememberUser = this.checkBoxRememberUser.Checked;
            if (!this.m_AppSettings.RememberUser)
            {
                this.m_AppSettings.LastAccessToken = null;
            }

            this.m_AppSettings.SaveToFile();
        }

        private void logoutBtnActions()
        {
            LoginForm loginForm = new LoginForm();
            this.Dispose();
            loginForm.ShowDialog();
        }

        private void refreshPictureBoxActions()
        {
            if (this.m_ActiveForm == null)
            {
                MessageBox.Show("Please select a form first", "Refresh button error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                (this.m_ActiveForm as IRefreshable).RefreshDataInForm();
            }
        }

        // EVENTS
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (this.m_AppSettings.RememberUser && !string.IsNullOrEmpty(this.m_AppSettings.LastAccessToken))
            {
                LoginResult loginResult = FacebookService.Connect(this.m_AppSettings.LastAccessToken);
                LoggedInUser.ConvertToLoggedInUserObject(ref loginResult);
                this.m_LoggedInUser = LoggedInUser.Instance;
            }

            fetchUserInfo();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            closingFormActions();
        }

        private void postsBtn_Click(object sender, EventArgs e)
        {
            openFormInActivityPanel(new PostsForm());
        }

        private void friendsBtn_Click(object sender, EventArgs e)
        {
            openFormInActivityPanel(new FriendsForm());
        }

        private void groupsBtn_Click(object sender, EventArgs e)
        {
            openFormInActivityPanel(new GroupsForm());
        }

        private void albumsBtn_Click(object sender, EventArgs e)
        {
            openFormInActivityPanel(new AlbumsForm());
        }

        private void likedPagesBtn_Click(object sender, EventArgs e)
        {
            openFormInActivityPanel(new LikedPagesForm());
        }

        private void eventsBtn_Click(object sender, EventArgs e)
        {
            openFormInActivityPanel(new EventsForm());
        }

        private void frienDiscoverBtn_Click(object sender, EventArgs e)
        {
            checkIfUserHasFriendsAndRunFrienDiscoverFormIfSo();
        }

        private void statisticsBtn_Click(object sender, EventArgs e)
        {
            openFormInActivityPanel(new StatisticsForm());
        }

        private void postStatusButton_Click(object sender, EventArgs e)
        {
            // # Currently doesn't seem to work, throws an exception from facebook/wrapper side
            Status postedStatus = this.m_LoggedInUser.PostStatus(this.statusTextBox.Text);
            MessageBox.Show("Status posted successfully");
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            closingFormActions();
            logoutBtnActions();
        }

        private void statusTextBox_Enter(object sender, EventArgs e)
        {
            if (this.statusTextBox.Text == "-Post a Status-")
            {
                this.statusTextBox.Text = string.Empty;
            }
        }

        private void statusTextBox_Leave(object sender, EventArgs e)
        {
            if (this.statusTextBox.Text.Trim() == string.Empty)
            {
                this.statusTextBox.Text = "-Post a Status-";
            }
        }

        private void refreshPictureBox_Click(object sender, EventArgs e)
        {
            refreshPictureBoxActions();
        }
    }
}
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace A21_Ex01_Sharon_323600296_Tomer_205972946.Forms
{
    public partial class mainForm : Form
    {
        private readonly Size r_SmallSize = new Size(700, 169);
        private readonly Size r_BigSize = new Size(700, 706);
        private Form m_ActiveForm = null;
        private User m_LoggedInUser;
        private LoginResult m_LoginResult;
        private const string k_AppId = "359957661732863";
        private readonly string[] r_PermissionsArray = new string[]
        {
          "public_profile", "email", "user_birthday", "user_videos",
          "user_age_range", "user_gender", "user_link", "user_tagged_places",
          "user_friends", "user_events", "user_likes", "user_location",
          "user_photos", "user_posts", "user_hometown"
        };

        public mainForm()
        {
            InitializeComponent();
            this.Size = r_SmallSize;
        }

        // PRIVATE METHODS
        private void prepareFormForUserInfoDisplay()
        {
            this.Size = r_BigSize;
            CenterToScreen();
            this.activityPanel.Visible = true;
            this.functionsPanel.Visible = true;
            this.userNameLabel.Visible = true;
            this.loginBtn.Visible = false;
            this.statusLabel.Visible = true;
            this.statusTextBox.Visible = true;
            this.postStatusButton.Visible = true;
            statusTextBox.Text = "-Post a Status-";
        }

        private void fetchUserInfo()
        {
            this.userNameLabel.Text = this.m_LoggedInUser.Name;
            this.profilePictureBox.LoadAsync(this.m_LoggedInUser.PictureNormalURL);
            statusLabel.Text = string.Format("What's on your mind {0}?", m_LoggedInUser.FirstName);
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

        // EVENTS
        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.m_LoginResult = FacebookService.Login(k_AppId, r_PermissionsArray);
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                prepareFormForUserInfoDisplay();
                fetchUserInfo();
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage);
            }
        }

        private void postsBtn_Click(object sender, EventArgs e)
        {
            openFormInActivityPanel(new postsForm(this.m_LoggedInUser));
        }

        private void eventsBtn_Click(object sender, EventArgs e)
        {
            openFormInActivityPanel(new eventsForm(this.m_LoggedInUser));
        }

        private void postStatusButton_Click(object sender, EventArgs e)
        {
            // # Currently doesn't seem to work, throws an exception from facebook/wrapper side
            Status postedStatus = this.m_LoggedInUser.PostStatus(this.statusTextBox.Text);
            MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
        }

        private void statusTextBox_Enter(object sender, EventArgs e)
        {
            if (this.statusTextBox.Text == "-Post a Status-")
            {
                this.statusTextBox.Text = "";
            }
        }

        private void statusTextBox_Leave(object sender, EventArgs e)
        {
            if (this.statusTextBox.Text.Trim() == "")
            {
                this.statusTextBox.Text = "-Post a Status-";
            }
        }

        private void friendsBtn_Click(object sender, EventArgs e)
        {
            openFormInActivityPanel(new friendsForm(this.m_LoggedInUser));
        }
    }
}

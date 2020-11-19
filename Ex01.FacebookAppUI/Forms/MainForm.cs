﻿using Ex01.FacebookAppLogic.Classes;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace Ex01.FacebookAppUI.Forms
{
    public partial class MainForm : Form
    {
        private Form m_ActiveForm = null;
        private User m_LoggedInUser;

        public MainForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
        }

        // PRIVATE METHODS
        private void fetchUserInfo()
        {
            this.userNameLabel.Text = this.m_LoggedInUser.Name;
            this.profilePictureBox.LoadAsync(this.m_LoggedInUser.PictureNormalURL);
            statusLabel.Text = string.Format("What's on your mind {0}?", m_LoggedInUser.FirstName);
            this.statusTextBox.Text = "-Post a Status-";
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
        private void MainForm_Load(object sender, EventArgs e)
        {
            fetchUserInfo();
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

        private void postStatusButton_Click(object sender, EventArgs e)
        {
            // # Currently doesn't seem to work, throws an exception from facebook/wrapper side
            Status postedStatus = this.m_LoggedInUser.PostStatus(this.statusTextBox.Text);
            MessageBox.Show("Status posted successfully");
        }

        // # placeholder textBox enabling methods # 
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
    }
}
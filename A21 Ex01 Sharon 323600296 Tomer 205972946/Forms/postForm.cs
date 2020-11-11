using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace A21_Ex01_Sharon_323600296_Tomer_205972946
{
    public partial class postForm : Form
    {
        private User m_LoggedInUser;

        public postForm(User i_LoggedInUser)
        {
            InitializeComponent();
            this.m_LoggedInUser = i_LoggedInUser;
            fetchUserPosts();
        }

        // PRIVATE METHODS
        private void fetchUserPosts()
        {
            foreach (Post post in this.m_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    this.listBoxUserPosts.Items.Add(post.Message);
                }
                else
                if (post.Caption != null)
                {
                    this.listBoxUserPosts.Items.Add(String.Format("Caption: {0}", post.Caption));
                }
                else
                {
                    this.listBoxUserPosts.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (this.m_LoggedInUser.Posts.Count == 0)
            {
                MessageBox.Show("The user has made no posts.");
            }
        }

        // EVENTS
        private void postForm_Load(object sender, EventArgs e)
        {
            statusTextBox.Text = "-Post a Status-";
            statusLabel.Text = string.Format("What's on your mind {0}?", m_LoggedInUser.FirstName);
        }

        private void postStatusButton_Click(object sender, EventArgs e)
        {
            // # Currently doesn't seem to work, throws an exception from facebook/wrapper side
            Status postedStatus = this.m_LoggedInUser.PostStatus(statusTextBox.Text);
            MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
        }

        private void statusTextBox_Enter(object sender, EventArgs e)
        {
            if (statusTextBox.Text == "-Post a Status-")
            {
                statusTextBox.Text = "";
            }
        }

        private void statusTextBox_Leave(object sender, EventArgs e)
        {
            if (statusTextBox.Text.Trim() == "")
            {
                statusTextBox.Text = "-Post a Status-";
            }
        }
    }
}

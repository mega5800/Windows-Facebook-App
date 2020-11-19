using Ex01.FacebookAppLogic.Classes;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace Ex01.FacebookAppUI.Forms
{
    public partial class PostsForm : Form
    {
        private User m_LoggedInUser;

        public PostsForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
        }

        // PRIVATE METHODS
        private void fetchUserPosts()
        {
            foreach (Post post in this.m_LoggedInUser.Posts)
            {
                this.listBoxUserPosts.Items.Add(post.Message);
            }

            if (this.m_LoggedInUser.Posts.Count == 0)
            {
                MessageBox.Show("The user has made no posts!");
            }
        }

        // EVENTS
        private void PostsForm_Load(object sender, EventArgs e)
        {
            fetchUserPosts();
        }
    }
}
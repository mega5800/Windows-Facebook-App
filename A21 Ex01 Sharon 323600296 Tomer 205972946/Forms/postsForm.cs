using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace Ex01.FacebookAppUI.Forms
{
    public partial class PostsForm : Form
    {
        private User m_LoggedInUser;

        public PostsForm(User i_LoggedInUser)
        {
            InitializeComponent();
            this.m_LoggedInUser = i_LoggedInUser;
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
                    this.listBoxUserPosts.Items.Add(string.Format("Caption: {0}", post.Caption));
                }
                else
                {
                    this.listBoxUserPosts.Items.Add(string.Format("[{0}]", post.Type));
                }
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
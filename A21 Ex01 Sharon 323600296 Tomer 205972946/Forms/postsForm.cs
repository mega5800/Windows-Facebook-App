using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace A21_Ex01_Sharon_323600296_Tomer_205972946.Forms
{
    public partial class postsForm : Form
    {
        private User m_LoggedInUser;

        public postsForm(User i_LoggedInUser)
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
                MessageBox.Show("The user has made no posts!");
            }
        }
    }
}

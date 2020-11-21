using Ex01.FacebookAppLogic.Classes;
using Ex01.FacebookAppUI.Classes;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace Ex01.FacebookAppUI.Forms
{
    public partial class PostsForm : Form
    {
        // ATTRIBUTES
        private User m_LoggedInUser;
        private TextLoader<Post> m_TextLoader;

        // CTOR
        public PostsForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
            this.m_TextLoader = new TextLoader<Post>(this.m_LoggedInUser.Posts, this.listBoxUserPosts, "{0}");
        }

        // EVENTS
        private void PostsForm_Load(object sender, EventArgs e)
        {
            if (this.m_LoggedInUser.Posts.Count != 0)
            {
                this.m_TextLoader.LoadTextProperty("Message");
            }
            else
            {
                MessageBox.Show(string.Format("{0}, you do not have any posts!", this.m_LoggedInUser.FirstName));
            }
        }
    }
}
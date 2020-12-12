using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Ex02.FacebookAppLogic.Classes;
using Ex02.FacebookAppUI.Enums;
using Ex02.FacebookAppUI.Loaders;
using FacebookWrapper.ObjectModel;

namespace Ex02.FacebookAppUI.Forms
{
    public partial class PostsForm : Form
    {
        // ATTRIBUTES
        private readonly Thread r_StartThread;
        private readonly List<object> r_ParamsList;
        private User m_LoggedInUser;
        private Loader<Post> m_TextLoader;

        // CTOR
        public PostsForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
            this.r_ParamsList = new List<object>() { this.m_LoggedInUser.Posts, this.listBoxUserPosts, "{0}" };
            this.r_StartThread = new Thread(new ThreadStart(loadForm));
            this.m_TextLoader = LoaderFactory<Post>.CreateLoader(eLoaderFactoryContext.CreateTextLoader, this.r_ParamsList);
        }

        // PRIVATE METHODS
        private void loadForm()
        {
            /*if (this.m_LoggedInUser.Posts.Count != 0)
            {
                this.m_TextLoader.LoadProperties("Message");
            }
            else
            {
                MessageBox.Show(string.Format("{0}, you do not have any posts!", this.m_LoggedInUser.FirstName));
            }*/
            postBindingSource.DataSource = this.m_LoggedInUser.Posts;
        }

        // EVENTS
        private void PostsForm_Load(object sender, EventArgs e)
        {
            this.r_StartThread.Start();
        }
    }
}
using System;
using System.Threading;
using System.Windows.Forms;
using Ex02.FacebookAppLogic.Classes;
using FacebookWrapper.ObjectModel;

namespace Ex02.FacebookAppUI.Forms
{
    public partial class PostsForm : Form
    {
        // ATTRIBUTES
        private readonly Thread r_StartThread;
        private User m_LoggedInUser;

        // CTOR
        public PostsForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
            this.r_StartThread = new Thread(new ThreadStart(loadForm));
        }

        // PRIVATE METHODS
        private void loadForm()
        {
            postBindingSource.DataSource = this.m_LoggedInUser.Posts;
        }

        // EVENTS
        private void PostsForm_Load(object sender, EventArgs e)
        {
            this.r_StartThread.Start();
        }
    }
}
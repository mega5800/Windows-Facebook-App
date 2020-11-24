﻿using System;
using System.Threading;
using System.Windows.Forms;
using Ex01.FacebookAppLogic.Classes;
using Ex01.FacebookAppUI.Classes;
using FacebookWrapper.ObjectModel;

namespace Ex01.FacebookAppUI.Forms
{
    public partial class PostsForm : Form
    {
        // ATTRIBUTES
        private readonly Thread r_StartThread;
        private User m_LoggedInUser;
        private TextLoader<Post> m_TextLoader;

        // CTOR
        public PostsForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
            this.r_StartThread = new Thread(new ThreadStart(loadForm));
            this.m_TextLoader = new TextLoader<Post>(this.m_LoggedInUser.Posts, this.listBoxUserPosts, "{0}");
        }

        // PRIVATE METHODS
        private void loadForm()
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

        // EVENTS
        private void PostsForm_Load(object sender, EventArgs e)
        {
            this.r_StartThread.Start();
        }
    }
}
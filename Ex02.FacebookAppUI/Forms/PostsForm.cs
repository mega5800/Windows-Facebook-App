﻿using System.Windows.Forms;
using Ex02.FacebookAppLogic.Classes;
using FacebookWrapper.ObjectModel;

namespace Ex02.FacebookAppUI.Forms
{
    public partial class PostsForm : Form
    {
        // ATTRIBUTES
        private User m_LoggedInUser;

        // CTOR
        public PostsForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
            postBindingSource.DataSource = this.m_LoggedInUser.Posts;
        }
    }
}
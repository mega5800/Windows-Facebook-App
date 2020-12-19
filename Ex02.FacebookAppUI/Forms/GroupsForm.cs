﻿using System.Windows.Forms;
using Ex02.FacebookAppLogic.Classes;
using FacebookWrapper.ObjectModel;

namespace Ex02.FacebookAppUI.Forms
{
    public partial class GroupsForm : Form
    {
        // ATTRIBUTES
        private User m_LoggedInUser;

        // CTOR
        public GroupsForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
            groupBindingSource.DataSource = this.m_LoggedInUser.Groups;
        }
    }
}
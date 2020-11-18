using Ex01.FacebookAppLogic.Classes;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace Ex01.FacebookAppUI.Forms
{
    public partial class GroupsForm : Form
    {
        private User m_LoggedInUser;

        public GroupsForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
        }

        // PRIVATE METHODS
        private void fetchUserGroups()
        {
            foreach (Group fbGroup in this.m_LoggedInUser.Groups)
            {
                this.listBoxUserGroups.Items.Add(string.Format("Name: {0} | Description: {1}", fbGroup.Name, fbGroup.Description));
            }

            if (this.m_LoggedInUser.Groups.Count == 0)
            {
                MessageBox.Show("The user is not a member of any groups!");
            }
        }

        // EVENTS
        private void GroupsForm_Load(object sender, EventArgs e)
        {
            fetchUserGroups();
        }
    }
}

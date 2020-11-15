using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace Ex01.FacebookAppUI.Forms
{
    public partial class GroupsForm : Form
    {
        private User m_LoggedInUser;

        public GroupsForm(User i_LoggedInUser)
        {
            InitializeComponent();
            this.m_LoggedInUser = i_LoggedInUser;
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

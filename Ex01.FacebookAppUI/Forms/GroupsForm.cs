using Ex01.FacebookAppLogic.Classes;
using Ex01.FacebookAppUI.Classes;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace Ex01.FacebookAppUI.Forms
{
    public partial class GroupsForm : Form
    {
        // ATTRIBUTES
        private User m_LoggedInUser;
        private TextLoader<Group> m_TextLoader;

        // CTOR
        public GroupsForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
            this.m_TextLoader = new TextLoader<Group>(this.m_LoggedInUser.Groups, this.listBoxUserGroups, "Name: {0} | Description: {1}");
        }

        // EVENTS
        private void GroupsForm_Load(object sender, EventArgs e)
        {
            if (this.m_LoggedInUser.Groups.Count != 0)
            {
                this.m_TextLoader.LoadTextProperty("Name", "Description");
            }
            else
            {
                MessageBox.Show(string.Format("{0}, you are not a member of any group!", this.m_LoggedInUser.FirstName));
            }
        }
    }
}
using System;
using System.Threading;
using System.Windows.Forms;
using Ex02.FacebookAppLogic.Classes;
using Ex02.FacebookAppUI.Loaders;
using FacebookWrapper.ObjectModel;

namespace Ex02.FacebookAppUI.Forms
{
    public partial class GroupsForm : Form
    {
        // ATTRIBUTES
        private readonly Thread r_StartThread;
        private User m_LoggedInUser;
        private Loader<Group> m_TextLoader;

        // CTOR
        public GroupsForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
            this.r_StartThread = new Thread(new ThreadStart(loadForm));
            this.m_TextLoader = new TextLoader<Group>(this.m_LoggedInUser.Groups, this.listBoxUserGroups, "Name: {0} | Description: {1}");
        }

        // PRIVATE METHODS
        private void loadForm()
        {
            if (this.m_LoggedInUser.Groups.Count != 0)
            {
                this.m_TextLoader.LoadProperties("Name", "Description");
            }
            else
            {
                MessageBox.Show(string.Format("{0}, you are not a member of any group!", this.m_LoggedInUser.FirstName));
            }
        }

        // EVENTS
        private void GroupsForm_Load(object sender, EventArgs e)
        {
            this.r_StartThread.Start();
        }
    }
}
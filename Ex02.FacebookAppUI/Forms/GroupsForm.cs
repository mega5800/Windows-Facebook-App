using System;
using System.Threading;
using System.Windows.Forms;
using Ex02.FacebookAppLogic.Classes;
using FacebookWrapper.ObjectModel;

namespace Ex02.FacebookAppUI.Forms
{
    public partial class GroupsForm : Form
    {
        // ATTRIBUTES
        private readonly Thread r_StartThread;
        private User m_LoggedInUser;

        // CTOR
        public GroupsForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
            this.r_StartThread = new Thread(new ThreadStart(loadForm));
        }

        // PRIVATE METHODS
        private void loadForm()
        {
            groupBindingSource.DataSource = this.m_LoggedInUser.Groups;
        }

        // EVENTS
        private void GroupsForm_Load(object sender, EventArgs e)
        {
            this.r_StartThread.Start();
        }

        private void nameTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
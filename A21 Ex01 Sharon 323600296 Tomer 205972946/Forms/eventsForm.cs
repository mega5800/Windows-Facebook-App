using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace A21_Ex01_Sharon_323600296_Tomer_205972946.Forms
{
    public partial class eventsForm : Form
    {
        private User m_LoggedInUser;

        public eventsForm(User i_LoggedInUser)
        {
            InitializeComponent();
            this.m_LoggedInUser = i_LoggedInUser;
            fetchUserEvents();
        }

        // PRIVATE METHODS
        private void fetchUserEvents()
        {
            this.listBoxUserEvents.Items.Clear();
            this.listBoxUserEvents.DisplayMember = "Name";
            foreach (Event fbEvent in m_LoggedInUser.Events)
            {
                this.listBoxUserEvents.Items.Add(string.Format("{0} | Time range: {1} - {2}"/*, {3} invited participants*/,fbEvent.Name, fbEvent.StartTime, fbEvent.EndTime/*, fbEvent.InvitedUsers*/));
            }

            if (m_LoggedInUser.Events.Count == 0)
            {
                MessageBox.Show("The user does not have any events!");
            }
        }
    }
}

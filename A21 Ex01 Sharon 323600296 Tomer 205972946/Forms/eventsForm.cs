using FacebookWrapper.ObjectModel;
using System.Windows.Forms;

namespace Ex01.FacebookAppUI.Forms
{
    public partial class EventsForm : Form
    {
        private User m_LoggedInUser;

        public EventsForm(User i_LoggedInUser)
        {
            InitializeComponent();
            this.m_LoggedInUser = i_LoggedInUser;
        }

        // PRIVATE METHODS
        private void fetchUserEvents()
        {
            foreach (Event fbEvent in m_LoggedInUser.Events)
            {
                this.listBoxUserEvents.Items.Add(string.Format("{0} | Time range: {1} - {2}"/*, {3} invited participants*/, fbEvent.Name, fbEvent.StartTime, fbEvent.EndTime/*, fbEvent.InvitedUsers*/));
            }

            if (this.m_LoggedInUser.Events.Count == 0)
            {
                MessageBox.Show("The user does not have any events!");
            }
        }

        // EVENTS
        private void EventsForm_Load(object sender, System.EventArgs e)
        {
            fetchUserEvents();
        }
    }
}
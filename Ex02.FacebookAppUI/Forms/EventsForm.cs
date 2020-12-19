using System.Windows.Forms;
using Ex02.FacebookAppLogic.Classes;
using FacebookWrapper.ObjectModel;

namespace Ex02.FacebookAppUI.Forms
{
    public partial class EventsForm : Form
    {
        // ATTRIBUTES
        private User m_LoggedInUser;
        
        // CTOR
        public EventsForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
            eventBindingSource.DataSource = this.m_LoggedInUser.Events;
        }
    }
}
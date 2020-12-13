using System.Threading;
using System.Windows.Forms;
using Ex02.FacebookAppLogic.Classes;
using FacebookWrapper.ObjectModel;

namespace Ex02.FacebookAppUI.Forms
{
    public partial class EventsForm : Form
    {
        // ATTRIBUTES
        private readonly Thread r_StartThread;
        private User m_LoggedInUser;
        
        // CTOR
        public EventsForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
            this.r_StartThread = new Thread(new ThreadStart(loadForm));
        }

        // PRIVATE METHODS
        private void loadForm()
        {
            eventBindingSource.DataSource = this.m_LoggedInUser.Events;
        }

        // EVENTS
        private void EventsForm_Load(object sender, System.EventArgs e)
        {
            this.r_StartThread.Start();
        }
    }
}
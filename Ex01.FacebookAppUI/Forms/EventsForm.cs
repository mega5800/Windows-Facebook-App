using Ex01.FacebookAppLogic.Classes;
using Ex01.FacebookAppUI.Classes;
using FacebookWrapper.ObjectModel;
using System.Threading;
using System.Windows.Forms;

namespace Ex01.FacebookAppUI.Forms
{
    public partial class EventsForm : Form
    {
        // ATTRIBUTES
        private User m_LoggedInUser;
        private TextLoader<Event> m_TextLoader;
        private Thread m_StartThread;

        // CTOR
        public EventsForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
            this.m_StartThread = new Thread(new ThreadStart(loadForm));
            this.m_TextLoader = new TextLoader<Event>(this.m_LoggedInUser.Events, this.listBoxUserEvents, "{0} | Time range: {1} - {2}");
        }

        // PRIVATE METHODS
        private void loadForm()
        {
            if (this.m_LoggedInUser.Events.Count != 0)
            {
                this.m_TextLoader.LoadTextProperty("Name", "StartTime", "EndTime");
            }
            else
            {
                MessageBox.Show(string.Format("{0}, you do not have any events!", this.m_LoggedInUser.FirstName));
            }
        }

        // EVENTS
        private void EventsForm_Load(object sender, System.EventArgs e)
        {
            this.m_StartThread.Start();
        }
    }
}
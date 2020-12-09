using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Ex02.FacebookAppLogic.Classes;
using Ex02.FacebookAppUI.Enums;
using Ex02.FacebookAppUI.Loaders;
using FacebookWrapper.ObjectModel;

namespace Ex02.FacebookAppUI.Forms
{
    public partial class EventsForm : Form
    {
        // ATTRIBUTES
        private readonly Thread r_StartThread;
        private readonly List<object> r_ParamsList;
        private User m_LoggedInUser;
        private Loader<Event> m_TextLoader;
        
        // CTOR
        public EventsForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
            this.r_ParamsList = new List<object>() { this.m_LoggedInUser.Events, this.listBoxUserEvents, "{0} | Time range: {1} - {2}" };
            this.r_StartThread = new Thread(new ThreadStart(loadForm));
            this.m_TextLoader = LoaderFactory<Event>.CreateLoader(eLoaderFactoryContext.CreateTextLoader, this.r_ParamsList);
        }

        // PRIVATE METHODS
        private void loadForm()
        {
            if (this.m_LoggedInUser.Events.Count != 0)
            {
                this.m_TextLoader.LoadProperties("Name", "StartTime", "EndTime");
            }
            else
            {
                MessageBox.Show(string.Format("{0}, you do not have any events!", this.m_LoggedInUser.FirstName));
            }
        }

        // EVENTS
        private void EventsForm_Load(object sender, System.EventArgs e)
        {
            this.r_StartThread.Start();
        }
    }
}
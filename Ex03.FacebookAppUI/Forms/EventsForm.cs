using System.Windows.Forms;
using Ex03.FacebookAppLogic.Classes;
using Ex03.FacebookAppUI.Interfaces;
using FacebookWrapper.ObjectModel;

namespace Ex03.FacebookAppUI.Forms
{
    public partial class EventsForm : Form, IRefreshable
    {
        // ATTRIBUTES
        private User m_LoggedInUser;
        
        // CTOR
        public EventsForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
            setDataBindingSource();
        }

        // PRIVATE METHODS
        private void setDataBindingSource()
        {
            eventBindingSource.DataSource = this.m_LoggedInUser.Events;
        }

        // IREFRESHABLE IMPLEMENTATION
        public void RefreshDataInForm()
        {
            this.m_LoggedInUser.ReFetch();
            setDataBindingSource();
        }
    }
}
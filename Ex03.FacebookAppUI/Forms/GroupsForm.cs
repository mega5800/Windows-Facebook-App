using System.Windows.Forms;
using Ex03.FacebookAppLogic.Classes;
using Ex03.FacebookAppUI.Interfaces;
using FacebookWrapper.ObjectModel;

namespace Ex03.FacebookAppUI.Forms
{
    public partial class GroupsForm : Form, IRefreshable
    {
        // ATTRIBUTES
        private User m_LoggedInUser;

        // CTOR
        public GroupsForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
            setDataBindingSource();
        }

        // PRIVATE METHODS
        private void setDataBindingSource()
        {
            groupBindingSource.DataSource = this.m_LoggedInUser.Groups;
        }

        // IREFRESHABLE IMPLEMENTATION
        void IRefreshable.RefreshDataInForm()
        {
            this.m_LoggedInUser.ReFetch();
            setDataBindingSource();
        }
    }
}
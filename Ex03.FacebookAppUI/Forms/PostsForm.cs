using System.Windows.Forms;
using Ex03.FacebookAppUI.Interfaces;
using Ex03.FacebookAppLogic.Classes;
using FacebookWrapper.ObjectModel;

namespace Ex03.FacebookAppUI.Forms
{
    public partial class PostsForm : Form, IRefreshable
    {
        // ATTRIBUTES
        private User m_LoggedInUser;

        // CTOR
        public PostsForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
            setDataBindingSource();
        }

        // PRIVATE METHODS
        private void setDataBindingSource()
        {
            postBindingSource.DataSource = this.m_LoggedInUser.Posts;
        }

        // IREFRESHABLE IMPLEMENTATION
        void IRefreshable.RefreshDataInForm()
        {
            this.m_LoggedInUser.ReFetch();
            setDataBindingSource();
        }
    }
}
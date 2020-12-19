using System.Windows.Forms;
using Ex02.FacebookAppLogic.Classes;
using FacebookWrapper.ObjectModel;

namespace Ex02.FacebookAppUI.Forms
{
    public partial class LikedPagesForm : Form
    {
        // ATTRIBUTES
        private User m_LoggedInUser;

        // CTOR
        public LikedPagesForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
            pageBindingSource.DataSource = this.m_LoggedInUser.LikedPages;
        }
    }
}
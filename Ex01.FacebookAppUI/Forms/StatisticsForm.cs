using Ex01.FacebookAppLogic.Classes;
using FacebookWrapper.ObjectModel;
using System.Windows.Forms;

namespace Ex01.FacebookAppUI.Forms
{
    public partial class StatisticsForm : Form
    {
        private User m_LoggedInUser;

        public StatisticsForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
        }
    }
}
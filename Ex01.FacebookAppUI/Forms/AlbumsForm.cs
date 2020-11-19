using Ex01.FacebookAppLogic.Classes;
using Ex01.FacebookAppUI.Classes;
using FacebookWrapper.ObjectModel;
using System.Threading;
using System.Windows.Forms;

namespace Ex01.FacebookAppUI.Forms
{
    public partial class AlbumsForm : Form
    {
        private User m_LoggedInUser;
        private readonly Thread r_PopulateListViewThread;
        private ImageLoader<Album> m_PropertyLoader;

        public AlbumsForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
            this.m_PropertyLoader = new ImageLoader<Album>(this.m_LoggedInUser.Albums, this.albumsListView);
            this.r_PopulateListViewThread = new Thread(() => this.m_PropertyLoader.LoadImageAndTextProperties("ImageAlbum", "Name"));
        }

        // EVENTS
        private void albumsListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedItemIndex = albumsListView.SelectedItems[0].ImageIndex;

            SelectedAlbumForm selectedAlbumForm = new SelectedAlbumForm(this.m_LoggedInUser.Albums[selectedItemIndex].Photos
                , this.m_LoggedInUser.Albums[selectedItemIndex].Name);

            selectedAlbumForm.ShowDialog();
        }

        private void AlbumsForm_Load(object sender, System.EventArgs e)
        {
            this.r_PopulateListViewThread.Start();
        }
    }
}
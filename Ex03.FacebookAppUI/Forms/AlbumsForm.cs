using System.Threading;
using System.Windows.Forms;
using Ex03.FacebookAppLogic.Classes;
using Ex03.FacebookAppUI.Classes;
using Ex03.FacebookAppUI.Enums;
using Ex03.FacebookAppUI.Interfaces;
using Ex03.FacebookAppUI.Loaders;
using FacebookWrapper.ObjectModel;

namespace Ex03.FacebookAppUI.Forms
{
    public partial class AlbumsForm : Form
    {
        // ATTRIBUTES
        private ILoaderAdapter<Album> m_LoaderAdapter;
        private User m_LoggedInUser;
        private Loader<Album> m_ImageLoader;
        private SelectedAlbumForm m_SelectedAlbumForm;

        // CTOR
        public AlbumsForm()
        {
            InitializeComponent();
            this.m_LoaderAdapter = new LoaderAdapter<Album>();
            this.m_LoggedInUser = LoggedInUser.Instance;
            this.m_ImageLoader = this.m_LoaderAdapter.FormToLoaderAdapt(eLoaderFactoryContext.CreateImageLoader, this.m_LoggedInUser.Albums, this.albumsListView);
        }

        // EVENTS
        private void albumsListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedItemIndex = albumsListView.SelectedItems[0].ImageIndex;

            this.m_SelectedAlbumForm = new SelectedAlbumForm(this.m_LoggedInUser.Albums[selectedItemIndex].Photos, this.m_LoggedInUser.Albums[selectedItemIndex].Name);
            this.m_SelectedAlbumForm.ShowDialog();
        }

        private void AlbumsForm_Load(object sender, System.EventArgs e)
        {
            new Thread(() => this.m_ImageLoader.LoadProperties("ImageAlbum", "Name")).Start();
        }
    }
}
using Ex01.FacebookAppUI.Classes;
using FacebookWrapper.ObjectModel;
using System.Threading;
using System.Windows.Forms;

namespace Ex01.FacebookAppUI.Forms
{
    public partial class SelectedAlbumForm : Form
    {
        // ATTRIBUTES
        private string m_AlbumName;
        private readonly Thread r_PopulateListViewThread;
        private FacebookObjectCollection<Photo> m_PhotosAlbum;
        private ImageLoader<Photo> m_ImageLoader;
        
        // CTOR
        public SelectedAlbumForm(FacebookObjectCollection<Photo> i_PhotosAlbum, string i_AlbumName)
        {
            InitializeComponent();
            this.m_PhotosAlbum = i_PhotosAlbum;
            this.m_AlbumName = i_AlbumName;
            this.m_ImageLoader = new ImageLoader<Photo>(this.m_PhotosAlbum, this.selectedAlbumlistView);
            this.r_PopulateListViewThread = new Thread(() => this.m_ImageLoader.LoadImageAndTextProperties("ImageAlbum", "Name"));
        }

        // EVENTS
        private void SelectedAlbumForm_Load(object sender, System.EventArgs e)
        {
            CenterToScreen();
            this.Text = m_AlbumName;
            this.r_PopulateListViewThread.Start();
        }
    }
}
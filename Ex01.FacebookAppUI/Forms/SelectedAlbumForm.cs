using System.Threading;
using System.Windows.Forms;
using Ex02.FacebookAppUI.Classes;
using FacebookWrapper.ObjectModel;

namespace Ex02.FacebookAppUI.Forms
{
    public partial class SelectedAlbumForm : Form
    {
        // ATTRIBUTES
        private readonly Thread r_StartThread;
        private string m_AlbumName;
        private FacebookObjectCollection<Photo> m_PhotosAlbum;
        private ImageLoader<Photo> m_ImageLoader;
        
        // CTOR
        public SelectedAlbumForm(FacebookObjectCollection<Photo> i_PhotosAlbum, string i_AlbumName)
        {
            InitializeComponent();
            this.m_PhotosAlbum = i_PhotosAlbum;
            this.m_AlbumName = i_AlbumName;
            this.m_ImageLoader = new ImageLoader<Photo>(this.m_PhotosAlbum, this.selectedAlbumlistView);
            this.r_StartThread = new Thread(() => this.m_ImageLoader.LoadImageAndTextProperties("ImageAlbum", "Name"));
        }

        // EVENTS
        private void SelectedAlbumForm_Load(object sender, System.EventArgs e)
        {
            CenterToScreen();
            this.Text = m_AlbumName;
            this.r_StartThread.Start();
        }
    }
}
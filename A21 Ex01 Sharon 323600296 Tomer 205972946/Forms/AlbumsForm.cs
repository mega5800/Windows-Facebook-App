﻿using Ex01.FacebookAppLogic.Classes;
using FacebookWrapper.ObjectModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Ex01.FacebookAppUI.Forms
{
    public partial class AlbumsForm : Form
    {
        private User m_LoggedInUser;
        // code copy!!!!
        private readonly Thread r_PopulateListViewThread;
        private ImageList m_AlbumsPicturesList;
        private readonly Size r_PictureSize = new Size(100, 100);
        private int m_AlbumPictureCounter = 0;

        public AlbumsForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
            this.m_AlbumsPicturesList = new ImageList();
            m_AlbumsPicturesList.ImageSize = r_PictureSize;
            m_AlbumsPicturesList.ColorDepth = ColorDepth.Depth32Bit;
            this.r_PopulateListViewThread = new Thread(new ThreadStart(populateAlbumsListView));
            this.r_PopulateListViewThread.Start();
        }

        // PRIVATE METHODS
        private void populateAlbumsListView()
        {
            foreach (Album album in this.m_LoggedInUser.Albums)
            {
                this.m_AlbumsPicturesList.Images.Add(album.ImageAlbum);
            }

            this.albumsListView.LargeImageList = this.m_AlbumsPicturesList;
            foreach (Album album in this.m_LoggedInUser.Albums)
            {
                this.albumsListView.Items.Add(album.Name, this.m_AlbumPictureCounter);
                this.m_AlbumPictureCounter++;
            }
        }

        private void albumsListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedItemIndex = albumsListView.SelectedItems[0].ImageIndex;

            SelectedAlbumForm selectedAlbumForm = new SelectedAlbumForm(this.m_LoggedInUser.Albums[selectedItemIndex].Photos
                , this.m_LoggedInUser.Albums[selectedItemIndex].Name);

            selectedAlbumForm.ShowDialog();
        }
    }
}
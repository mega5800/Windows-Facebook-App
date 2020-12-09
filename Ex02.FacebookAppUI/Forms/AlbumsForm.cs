﻿using System.Threading;
using System.Windows.Forms;
using Ex02.FacebookAppLogic.Classes;
using Ex02.FacebookAppUI.Loaders;
using FacebookWrapper.ObjectModel;

namespace Ex02.FacebookAppUI.Forms
{
    public partial class AlbumsForm : Form
    {
        // ATTRIBUTES
        private readonly Thread r_StartThread;
        private User m_LoggedInUser;
        private Loader<Album> m_ImageLoader;
        private SelectedAlbumForm m_SelectedAlbumForm;

        // CTOR
        public AlbumsForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
            this.m_ImageLoader = new ImageLoader<Album>(this.m_LoggedInUser.Albums, this.albumsListView);
            this.r_StartThread = new Thread(() => this.m_ImageLoader.LoadProperties("ImageAlbum", "Name"));
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
            this.r_StartThread.Start();
        }
    }
}
namespace AppUI
{
    using System.Windows.Forms;
    using System;
    using FacebookWrapper.ObjectModel;

    public partial class FormAlbum : Form
    {
        private const string k_LoadingErrorMsg = "Sorry. there is a problam with loading the picture. please try again later.";

        public Album Album { get; }

        public FormAlbum(Album i_Album)
        {
            InitializeComponent();
            Album = i_Album;
        }

        private void populatePhotos()
        {
            int top = 15;
            int left = 15;
            int photoInRowCounter = 0;
            const int k_PhotosInRowLimit = 3;
            const int k_Space = 15;

            foreach (Photo photo in Album.Photos)
            {
                ProxyPictureBox picBox = new ProxyPictureBox();
                picBox.PhotoSelected += LoadSelectedPhoto;
                picBox.Size = new System.Drawing.Size(200, 200);
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;

                picBox.Left = left;
                picBox.Top = top;
                photoInRowCounter++;

                if (photoInRowCounter < k_PhotosInRowLimit)
                {
                    left = picBox.Right + k_Space;
                }
                else
                {
                    photoInRowCounter = 0;
                    left = k_Space;
                    top = picBox.Bottom + k_Space;
                }
                
                picBox.Load(photo.PictureNormalURL);
                panelAlbumPhotos.Controls.Add(picBox);
            }
        }

        private void albumDisplay_Load(object sender, EventArgs e)
        {
            try
            {
                populatePhotos();
            }
            catch
            {
                this.Close();
                MessageBox.Show(k_LoadingErrorMsg);
            }
        }

        public void LoadSelectedPhoto(object sender, PhotoSelectedEventArgs e)
        {
            pictureBoxSelectedPhoto.Load(e.URL);
        }
    }
}

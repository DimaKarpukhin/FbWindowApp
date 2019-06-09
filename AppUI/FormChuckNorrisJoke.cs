namespace AppUI
{
    using System;
    using System.Windows.Forms;
    using AppLogic;
    using FacebookWrapper.ObjectModel;

    public partial class FormChuckNorrisJoke : Form
    {
        private string k_PictureURL = "https://ibb.co/kgtHWa";
        private string k_PostConfirm = "The joke was posted to your friend {0}";
        private string k_ErrorPost = "Sorry. Unable to post joke.";

        public User Friend { get; }

        public FormChuckNorrisJoke(User i_Friend, string i_Joke)
        {
            InitializeComponent();
            Friend = i_Friend;
            labelJoke.Text = i_Joke;
            pictureBoxChuckNorris.Image = Properties.Resources.chucknorrispicture;
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            bool isPostingSucceeded = true;

            try
            {
                AppSevices.Instance.PostStatus(labelJoke.Text, k_PictureURL, Friend);
            }
            catch
            {
                isPostingSucceeded = false;
                MessageBox.Show(k_ErrorPost);
            }
            
            this.Close();
            if (isPostingSucceeded)
            {
                MessageBox.Show(string.Format(k_PostConfirm, Friend.Name));
            }
        }
    }
}

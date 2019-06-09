namespace AppUI
{
    using System;
    using System.Threading;
    using System.Windows.Forms;
    using System.Collections.Generic;
    using FacebookWrapper.ObjectModel;
    using Adapters;
    using AppLogic;

    public class UIManager
    {       
        private const int k_AmountToFetch = 10000;
        private const string k_LoginErrorMsg = "Sorry. Unable to login.";
        private const string k_StatusPostedMsg = "Status Posted! ID: {0}";
        private const string k_FetchDataErrorMsg = "Sorry. Unable to fetch data.";
        private readonly FormMain r_FormMain;

        public UIManager()
        {
            r_FormMain = new FormMain();

            r_FormMain.SetFormWithAppSettings();
            AppSevices.Instance.SetAmountToFetch(k_AmountToFetch);

            r_FormMain.FormClosed += CloseApplication;
            r_FormMain.FormOpen += OpenApplication;
            r_FormMain.ButtonLoginClicked += LoginToFacebook;
            r_FormMain.ButtonLogoutClicked += LogoutFromFacebook;
            r_FormMain.ButtonPostStatusClicked += PostStatus;
            r_FormMain.ButtonZodiacClicked += FindFriendZodiac;
            r_FormMain.ButtonChuckNorrisClicked += GetChuckNorris;
            r_FormMain.ButtonAlbumDisplayClick += ShowAlbum;

            Application.Run(r_FormMain);
        }

        public void OpenApplication(object sender, EventArgs e)
        {
            if (AppSettings.Instance.RememberUser
                && !string.IsNullOrEmpty(AppSettings.Instance.LastAccessToken))
            {
                AppSevices.Instance.ConnectUserToFacebook(AppSettings.Instance.LastAccessToken);
                r_FormMain.PopulateUIFromFacebookData();
            }
        }

        public void CloseApplication(object sender, EventArgs e)
        {
            AppSettings.Instance.LastWindowSize = r_FormMain.Size;
            AppSettings.Instance.LastWindowLocation = r_FormMain.Location;
            AppSettings.Instance.RememberUser = r_FormMain.IsRememberUser;

            if (AppSettings.Instance.RememberUser)
            {
                AppSettings.Instance.LastAccessToken = AppSevices.Instance.LoginResult.AccessToken;
            }
            else
            {
                if (AppSevices.Instance.IsUserLoggedIn())
                {
                    AppSevices.Instance.LogoutUserFromFacebook();
                }

                AppSettings.Instance.LastAccessToken = null;
            }

            AppSettings.Instance.SaveToFile();
        }

        public void LoginToFacebook(object sender, EventArgs e)
        {
            try
            {
                bool isLoginSucceed = AppSevices.Instance.LoginAndInit();
                if (isLoginSucceed)
                {
                    r_FormMain.PopulateUIFromFacebookData();
                }
                else
                {
                    MessageBox.Show(k_LoginErrorMsg);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("ERRRRRR" + exception.Message);
                Thread.Sleep(10000);
            }
        }

        public void LogoutFromFacebook(object sender, EventArgs e)
        {
            r_FormMain.ClearUIFromFacebookData();
            closeAllSubForms();
            AppSevices.Instance.LogoutUserFromFacebook();
            AppSettings.Instance.RememberUser = false;
        }

        public void PostStatus(object sender, EventArgsPostStatus e)
        {
            string postedStatusID = string.Empty;

            postedStatusID = AppSevices.Instance.PostStatus(e.Text);
            MessageBox.Show(string.Format(k_StatusPostedMsg, postedStatusID));
        }

        public void FindFriendZodiac(object sender, EventArgsSelectedItem e)
        {
            string zodiacResult = string.Empty;

            closeSimilarForm<FormUserZodiac>();
            User selectedFriend = (e.Item as AdapterFacebookUser).User;
            if (AppSevices.FetchZodiacSign(selectedFriend, out zodiacResult))
            {
                FormUserZodiac zodiacForm = new FormUserZodiac(zodiacResult);
                zodiacForm.Show();
            }
            else
            {
                MessageBox.Show(k_FetchDataErrorMsg);
            }
        }

        public void GetChuckNorris(object sender, EventArgsSelectedItem e)
        {
            string joke = string.Empty;

            closeSimilarForm<FormChuckNorrisJoke>();
            if (AppSevices.FetchChuckNorrisJoke(out joke))
            {
                User selectedFriend = (e.Item as AdapterFacebookUser).User;
                FormChuckNorrisJoke jokeForm = new FormChuckNorrisJoke(selectedFriend, joke);
                jokeForm.Show();
            }
            else
            {
                MessageBox.Show(k_FetchDataErrorMsg);
            }
        }

        public void ShowAlbum(object sender, EventArgsSelectedItem e)
        {
            closeSimilarForm<FormAlbum>();
            AdapterFacebookAlbum adapter = e.Item as AdapterFacebookAlbum;
            FormAlbum displayForm = new FormAlbum(adapter.Album);
            displayForm.Show();
        }

        private void closeSimilarForm<T>()
        {
            FormCollection formsOpen = Application.OpenForms;
            Form formToClose = null;
            bool isSimilarFormFound = false;

            foreach (Form frm in formsOpen)
            {
                if (frm.GetType() == typeof(T))
                {
                    formToClose = frm;
                    isSimilarFormFound = true;
                }
            }

            if (isSimilarFormFound)
            {
                formToClose.Close();
            }
        }

        private void closeAllSubForms()
        {
            FormCollection formsOpen = Application.OpenForms;
            List<Form> formsToClose = new List<Form>();

            foreach (Form frm in formsOpen)
            {
                if (frm.GetType() != typeof(FormMain))
                {
                    formsToClose.Add(frm);
                }
            }

            for (int i = 0; i < formsToClose.Count; i++)
            {
                formsToClose[i].Close();
            }
        }
    }
}

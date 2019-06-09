namespace AppUI
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Collections;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Adapters; 
    using AppLogic;

    public delegate void SelectedItemEventHandler(object sender, EventArgsSelectedItem e);

    public delegate void PostStatusEventHandler(object sender, EventArgsPostStatus e);

    public partial class FormMain : Form
    {
        public bool IsRememberUser { get; private set; }

        private const string k_NotLoggedInMsg = "Please Login";

        private const string k_WelcomeMsg = "Welcome {0} !";

        private const string k_FriendChoiceMsg = "Please Choose a friend from the list.";

        public FormMain()
        {
            InitializeComponent();
            changeFormState(false);
        }

        public void SetFormWithAppSettings()
        {
            StartPosition = FormStartPosition.Manual;
            Size = AppSettings.Instance.LastWindowSize;
            Location = AppSettings.Instance.LastWindowLocation;
            checkBoxRememberUser.Checked = AppSettings.Instance.RememberUser;
        }

        private void changeFormState(bool i_IsLoggedIn)
        {
            tabControlApp.Visible = i_IsLoggedIn;
            buttonLogin.Enabled = !i_IsLoggedIn;
            buttonLogout.Enabled = i_IsLoggedIn;
            checkBoxRememberUser.Enabled = i_IsLoggedIn;
            textBoxStatus.Enabled = i_IsLoggedIn;
            buttonPost.Enabled = i_IsLoggedIn;
            progressBarTaggedFriends.Visible = !i_IsLoggedIn;
            progressBarTaggedFriends.Value = 0;
            checkBoxRememberUser.Checked = i_IsLoggedIn ? IsRememberUser : i_IsLoggedIn;
            if (!i_IsLoggedIn)
            {
                labelHeadline.Text = k_NotLoggedInMsg;
            }

            if (i_IsLoggedIn)
            {
                listBoxPosts.SelectedIndex = -1;
            }
        }

        public void ClearUIFromFacebookData()
        {
            foreach (TabPage tab in tabControlApp.TabPages)
            {
                clearDataFromPanels(tab);
            }

            changeFormState(false);
            pictureBoxProfile.ImageLocation = null;
        }

        private void clearDataFromPanels(Panel i_Panel)
        {
            foreach (Control ctrl in i_Panel.Controls)
            {
                if (ctrl.GetType() == typeof(Panel))
                {
                    clearDataFromPanels(ctrl as Panel);
                }
                else if (ctrl.GetType() == typeof(TextBox))
                {
                    (ctrl as TextBox).Clear();
                }
                else if (ctrl.GetType() == typeof(PictureBox))
                {
                    (ctrl as PictureBox).Image = null;
                }
                else if (ctrl.GetType() == typeof(DataGridView))
                {
                    (ctrl as DataGridView).Rows.Clear();
                }
            }
        }

        // ------------------------------------------ Populate Methods -----------------------------------------------
        public void PopulateUIFromFacebookData()
        {
            changeFormState(true);
            labelHeadline.Text = string.Format(k_WelcomeMsg, AppSevices.Instance.LoggedInUser.FirstName);
            pictureBoxProfile.ImageLocation = AppSevices.Instance.LoggedInUser.PictureNormalURL;

            new Thread(populatePosts).Start();
            new Thread(populateFriends).Start();
            new Thread(populateAlbums).Start();
            new Thread(populatePages).Start();
            new Thread(populateEvents).Start();
        }

        private void populatePosts()
        {
            try
            {
                List<AdapterFacebookObject> listOfPosts = AppSevices.Instance.FetchPosts();
                if (listOfPosts.Count() == 0)
                {
                    MessageBox.Show("A current user profile has no any public posts");
                }
                else
                {
                    attachBindingSourceToListBox(listBoxPosts, postAdapterBindingSource, listOfPosts);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR in populatePosts() method =>"+ Environment.NewLine + e.Message.ToString());
            }
        }

        private void populateFriends()
        {
            try
            {
                List<AdapterFacebookObject> listOfFriends = AppSevices.Instance.FetchFriends();
                if (listOfFriends.Count() == 0)
                {
                    MessageBox.Show("A current user profile has no any friends");
                }
                else
                {
                    attachBindingSourceToListBox(listBoxFriends, userAdapterBindingSource, listOfFriends);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR in populateFriends() method =>" + Environment.NewLine + e.Message.ToString());
            }
        }

        private void populateAlbums()
        {
            try
            {
                List<AdapterFacebookObject> listOfAlbums = AppSevices.Instance.FetchAlbums();
                if (listOfAlbums.Count() == 0)
                {
                    MessageBox.Show("A current user profile has no any public albums");
                }
                else
                {
                    attachBindingSourceToListBox(listBoxAlbums, albumAdapterBindingSource, listOfAlbums);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR in populateAlbums() method =>" + Environment.NewLine + e.Message.ToString());
            }
        }

        private void populatePages()
        {
            try
            {
                List<AdapterFacebookObject> listOfPages = AppSevices.Instance.FetchPages();
                if (listOfPages.Count() == 0)
                {
                    MessageBox.Show("A current user profile has no any public pages");
                }
                else
                {
                    attachBindingSourceToListBox(listBoxPages, pageAdapterBindingSource, listOfPages);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR in populatePages() method =>" + Environment.NewLine + e.Message.ToString());
            }
        }

        private void populateEvents()
        {
            try
            {
                List<AdapterFacebookObject> listOfEvents = AppSevices.Instance.FetchEvents();
                if (listOfEvents.Count() == 0)
                {
                    MessageBox.Show("A current user profile has no upcoming events");
                }
                else
                {
                    attachBindingSourceToListBox(listBoxEvents, eventAdapterBindingSource, listOfEvents);
                }     
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR in populateEvents() method =>" + Environment.NewLine + e.Message.ToString());
            }
        }

        private void attachBindingSourceToListBox(ListBox i_ListBox, BindingSource i_Source, List<AdapterFacebookObject> i_Items)
        {
            if (!i_ListBox.InvokeRequired)
            {
                i_Source.DataSource = i_Items;
            }
            else
            {
                i_ListBox.Invoke(new Action(() =>
                {
                    i_Source.DataSource = i_Items;
                    i_ListBox.SelectedIndex = 0;
                }));
            }
        }

        // notifing that the form was opened.
        public event EventHandler FormOpen;        

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            FormOpen(this, e);
        }

        // notifing that the form was closed.
        public event EventHandler FormClosed;    

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            FormClosed(this, e);
        }

        private void formMain_Closing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
        
        // notifing that the buttonLogin was clicked.
        public event EventHandler ButtonLoginClicked; 

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            ButtonLoginClicked(this, e);
        }

        // notifing that the buttonLogout was clicked.
        public event EventHandler ButtonLogoutClicked; 

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            ButtonLogoutClicked(this, e);
        }

        // notifing that the buttonPost was clicked.
        public event PostStatusEventHandler ButtonPostStatusClicked; 

        private void buttonPost_Click(object sender, EventArgs e)
        {
            EventArgsPostStatus arg = new EventArgsPostStatus();
            arg.Text = textBoxStatus.Text;
            ButtonPostStatusClicked(this, arg);
        }

        private void checkBoxRememberUser_CheckedChanged(object sender, EventArgs e)
        {
            IsRememberUser = checkBoxRememberUser.Checked;
        }

        // -------------------------------------- ListBox selectedIndexChanged Methods ----------------------------------------
        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdapterFacebookPost selectedPost = listBoxPosts.SelectedItem as AdapterFacebookPost;
            if (attachDataToBindingSource(postBindingSource, selectedPost))
            {
                if (selectedPost.Post.PictureURL != null)
                {
                    pictureBoxPost.LoadAsync(selectedPost.Post.PictureURL);
                }
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            attachDataToBindingSource(userBindingSource, listBoxFriends.SelectedItem as AdapterFacebookUser);
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            attachDataToBindingSource(albumBindingSource, listBoxAlbums.SelectedItem as AdapterFacebookAlbum);
        }

        private void listBoxPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            attachDataToBindingSource(pageBindingSource, listBoxPages.SelectedItem as AdapterFacebookPage);
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            attachDataToBindingSource(eventBindingSource, listBoxEvents.SelectedItem as AdapterFacebookEvent);
        }

        private bool attachDataToBindingSource(BindingSource i_Source, AdapterFacebookObject i_AdapterData)
        {
            bool toReturn = false;
            
            if (i_AdapterData != null)
            {
                i_Source.DataSource = i_AdapterData.FacebookObject;
                toReturn = true;
            }

            return toReturn;
        }

        // ------------------------------------------ User Functions Methods -----------------------------------------------
        // notifing that the buttonFriendZodiac was clicked.
        public event SelectedItemEventHandler ButtonZodiacClicked; 

        private void buttonFriendZodiac_Click(object sender, EventArgs e)
        {
            preformFunctionOnSelectedItem(listBoxFriends, ButtonZodiacClicked);
        }

        // notifing that the buttonChuckNorris was clicked.
        public event SelectedItemEventHandler ButtonChuckNorrisClicked; 

        private void buttonChuckNorris_Click(object sender, EventArgs e)
        {
            preformFunctionOnSelectedItem(listBoxFriends, ButtonChuckNorrisClicked);
        }

        // notifing that the buttonAlbumDisplay was clicked.
        public event SelectedItemEventHandler ButtonAlbumDisplayClick; 

        private void buttonViewAlbum_Click(object sender, EventArgs e)
        {
            preformFunctionOnSelectedItem(listBoxAlbums, ButtonAlbumDisplayClick);
        }
        
        private void preformFunctionOnSelectedItem(ListBox i_ListBox, SelectedItemEventHandler i_Event)
        {
            if (i_ListBox.SelectedItem != null)
            {
                EventArgsSelectedItem args = new EventArgsSelectedItem();
                args.Item = i_ListBox.SelectedItem as AdapterFacebookObject;
                i_Event(this, args);
            }
            else
            {
                MessageBox.Show(k_FriendChoiceMsg); 
            }
        }

        private void buttonFindBestTaggedFriend_Click(object sender, EventArgs e)
        {
            progressBarTaggedFriends.Visible = true;
            new Thread(showTaggedFriendsResults).Start();
        }

        private void showTaggedFriendsResults()
        {
            AppSevices.Instance.TaggedFriendsProcessPercentageUpdated += updateProgressBarTaggedFriends;

            try
            {
                TaggedFriends taggedFriends = AppSevices.Instance.CalculateLikesPerEachTaggedFriend();

                var allTaggedFriends = from friend in taggedFriends
                                       orderby friend.Likes descending
                                       select friend;

                dataGridViewTaggedFriends.Invoke(new Action(() => dataGridViewTaggedFriends.Rows.Clear()));
                dataGridViewTaggedFriends.Invoke(new Action(() => dataGridViewTaggedFriends.Refresh()));

                foreach (var friend in allTaggedFriends)
                {
                    dataGridViewTaggedFriends.Invoke(new Action(() => addTaggedFriendToDataGridView(friend)));
                }

                IEnumerator bestTaggedFriends = allTaggedFriends.Take(3).GetEnumerator();
                showBestTaggedFriendsResults(bestTaggedFriends);
            }
            catch(Exception e)
            {
                MessageBox.Show("ERROR in showTaggedFriendsResults() method =>" + Environment.NewLine + e.Message.ToString());
            }
        }

        private void showBestTaggedFriendsResults(IEnumerator i_BestTaggedFriends)
        {
            i_BestTaggedFriends.MoveNext();
            updateWinnerPlace(labelNameFirstPlace, pictureBoxFirstPlace, i_BestTaggedFriends.Current as TaggedFriend);
            i_BestTaggedFriends.MoveNext();
            updateWinnerPlace(labelNameSecondPlace, pictureBoxSecondPlace, i_BestTaggedFriends.Current as TaggedFriend);
            i_BestTaggedFriends.MoveNext();
            updateWinnerPlace(labelNameThirdPlace, pictureBoxThirdPlace, i_BestTaggedFriends.Current as TaggedFriend);

            labelConclusion.Invoke(new Action(() => labelConclusion.Visible = true));
        }

        private void updateProgressBarTaggedFriends(object sender, EventArgsProcessPercentage e)
        {
            progressBarTaggedFriends.Invoke(new Action(() => progressBarTaggedFriends.Value = e.Percentage));
        }

        private void addTaggedFriendToDataGridView(TaggedFriend i_Friend)
        {
            int newRow = dataGridViewTaggedFriends.Rows.Add();

            dataGridViewTaggedFriends.Rows[newRow].Cells[0].Value = i_Friend.User.Name;
            dataGridViewTaggedFriends.Rows[newRow].Cells[1].Value = i_Friend.Likes;
            dataGridViewTaggedFriends.Rows[newRow].Cells[2].Value = i_Friend.Photos.Count;
        }

        private void updateWinnerPlace(Label i_Label, PictureBox i_picBox, TaggedFriend i_Friend)
        {
            if (i_Friend != null)
            {
                i_picBox.Invoke(new Action(
                    () => i_picBox.LoadAsync(i_Friend.User.PictureNormalURL)));
                i_Label.Invoke(new Action(() => i_Label.Text = i_Friend.User.Name));
                i_Label.Invoke(new Action(() => i_Label.Visible = true));
            }
            else
            {
                MessageBox.Show("ERROR in updateWinnerPlace() method =>" + Environment.NewLine + "NULL exception: NULL TaggedFriend object reference");
            }
        }
    }
}

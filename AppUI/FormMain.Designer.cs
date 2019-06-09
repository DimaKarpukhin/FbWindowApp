using System;

namespace AppUI
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label displayNameLabelPost;
            System.Windows.Forms.Label pictureURLLabelPost;
            System.Windows.Forms.Label descriptionLabelPost;
            System.Windows.Forms.Label birthdayLabelFriend;
            System.Windows.Forms.Label displayNameLabelFriend;
            System.Windows.Forms.Label descriptionLabelAlbum;
            System.Windows.Forms.Label displayNameLabelAlbum;
            System.Windows.Forms.Label createdTimeLabelAlbum;
            System.Windows.Forms.Label countLabelAlbum;
            System.Windows.Forms.Label createdTimeLabelPost;
            System.Windows.Forms.Label displayNameLabelPage;
            System.Windows.Forms.Label descriptionLabelPage;
            System.Windows.Forms.Label displayNameLabelEvent;
            System.Windows.Forms.Label descriptionLabelEvent;
            System.Windows.Forms.Label startTimeLabelEvent;
            System.Windows.Forms.Label endTimeLabelEvent;
            System.Windows.Forms.Label locationLabelEvent;
            this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
            this.buttonLogin = new AppUI.ProxyButton();
            this.buttonLogout = new AppUI.ProxyButton();
            this.tabControlApp = new System.Windows.Forms.TabControl();
            this.tabPosts = new System.Windows.Forms.TabPage();
            this.panelPost = new System.Windows.Forms.Panel();
            this.createdTimeTextBoxPost = new System.Windows.Forms.TextBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionTextBoxPost = new System.Windows.Forms.TextBox();
            this.pictureBoxPost = new System.Windows.Forms.PictureBox();
            this.displayNameTextBoxPost = new System.Windows.Forms.TextBox();
            this.postAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.tabFriends = new System.Windows.Forms.TabPage();
            this.panelFriend = new System.Windows.Forms.Panel();
            this.birthdayTextBoxUser = new System.Windows.Forms.TextBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullNameTextBoxUser = new System.Windows.Forms.TextBox();
            this.userAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonChuckNorris = new AppUI.ProxyButton();
            this.imageNormalPictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.buttonFriendZodiac = new AppUI.ProxyButton();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.tabAlbums = new System.Windows.Forms.TabPage();
            this.panelAlbum = new System.Windows.Forms.Panel();
            this.buttonViewAlbum = new AppUI.ProxyButton();
            this.displayNameTextBoxAlbum = new System.Windows.Forms.TextBox();
            this.albumAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countLabelAlbumPhotos = new System.Windows.Forms.Label();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createdTimeLabelAlbumTime = new System.Windows.Forms.Label();
            this.imageAlbumPictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionTextBoxAlbum = new System.Windows.Forms.TextBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.tabPhotos = new System.Windows.Forms.TabPage();
            this.progressBarTaggedFriends = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFindBestTaggedFriend = new AppUI.ProxyButton();
            this.panelPodiumResults = new System.Windows.Forms.Panel();
            this.labelConclusion = new System.Windows.Forms.Label();
            this.labelNameSecondPlace = new System.Windows.Forms.Label();
            this.labelNameFirstPlace = new System.Windows.Forms.Label();
            this.labelNameThirdPlace = new System.Windows.Forms.Label();
            this.pictureBoxSecondPlace = new System.Windows.Forms.PictureBox();
            this.pictureBoxFirstPlace = new System.Windows.Forms.PictureBox();
            this.pictureBoxThirdPlace = new System.Windows.Forms.PictureBox();
            this.pictureBoxPodium = new System.Windows.Forms.PictureBox();
            this.dataGridViewTaggedFriends = new System.Windows.Forms.DataGridView();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLikes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPhotosCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPages = new System.Windows.Forms.TabPage();
            this.panelPage = new System.Windows.Forms.Panel();
            this.displayNameTextBoxPage = new System.Windows.Forms.TextBox();
            this.pageAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageNormalPictureBoxPage = new System.Windows.Forms.PictureBox();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionTextBoxPage = new System.Windows.Forms.TextBox();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.panelEvent = new System.Windows.Forms.Panel();
            this.displayNameTextBoxEvent = new System.Windows.Forms.TextBox();
            this.eventAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageNormalPictureBoxEvent = new System.Windows.Forms.PictureBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationLabelEventValue = new System.Windows.Forms.Label();
            this.endTimeLabelEventValue = new System.Windows.Forms.Label();
            this.startTimeLabelEventValue = new System.Windows.Forms.Label();
            this.descriptionTextBoxEvent = new System.Windows.Forms.TextBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.buttonPost = new AppUI.ProxyButton();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelHeadline = new System.Windows.Forms.Label();
            displayNameLabelPost = new System.Windows.Forms.Label();
            pictureURLLabelPost = new System.Windows.Forms.Label();
            descriptionLabelPost = new System.Windows.Forms.Label();
            birthdayLabelFriend = new System.Windows.Forms.Label();
            displayNameLabelFriend = new System.Windows.Forms.Label();
            descriptionLabelAlbum = new System.Windows.Forms.Label();
            displayNameLabelAlbum = new System.Windows.Forms.Label();
            createdTimeLabelAlbum = new System.Windows.Forms.Label();
            countLabelAlbum = new System.Windows.Forms.Label();
            createdTimeLabelPost = new System.Windows.Forms.Label();
            displayNameLabelPage = new System.Windows.Forms.Label();
            descriptionLabelPage = new System.Windows.Forms.Label();
            displayNameLabelEvent = new System.Windows.Forms.Label();
            descriptionLabelEvent = new System.Windows.Forms.Label();
            startTimeLabelEvent = new System.Windows.Forms.Label();
            endTimeLabelEvent = new System.Windows.Forms.Label();
            locationLabelEvent = new System.Windows.Forms.Label();
            this.tabControlApp.SuspendLayout();
            this.tabPosts.SuspendLayout();
            this.panelPost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postAdapterBindingSource)).BeginInit();
            this.tabFriends.SuspendLayout();
            this.panelFriend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBoxFriend)).BeginInit();
            this.tabAlbums.SuspendLayout();
            this.panelAlbum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).BeginInit();
            this.tabPhotos.SuspendLayout();
            this.panelPodiumResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSecondPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFirstPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThirdPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPodium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaggedFriends)).BeginInit();
            this.tabPages.SuspendLayout();
            this.panelPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBoxPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            this.tabEvents.SuspendLayout();
            this.panelEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBoxEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // displayNameLabelPost
            // 
            displayNameLabelPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            displayNameLabelPost.AutoSize = true;
            displayNameLabelPost.Location = new System.Drawing.Point(63, 32);
            displayNameLabelPost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            displayNameLabelPost.Name = "displayNameLabelPost";
            displayNameLabelPost.Size = new System.Drawing.Size(39, 17);
            displayNameLabelPost.TabIndex = 0;
            displayNameLabelPost.Text = "Title:";
            // 
            // pictureURLLabelPost
            // 
            pictureURLLabelPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            pictureURLLabelPost.AutoSize = true;
            pictureURLLabelPost.Location = new System.Drawing.Point(63, 314);
            pictureURLLabelPost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pictureURLLabelPost.Name = "pictureURLLabelPost";
            pictureURLLabelPost.Size = new System.Drawing.Size(56, 17);
            pictureURLLabelPost.TabIndex = 4;
            pictureURLLabelPost.Text = "Picture:";
            // 
            // descriptionLabelPost
            // 
            descriptionLabelPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            descriptionLabelPost.AutoSize = true;
            descriptionLabelPost.Location = new System.Drawing.Point(63, 123);
            descriptionLabelPost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descriptionLabelPost.Name = "descriptionLabelPost";
            descriptionLabelPost.Size = new System.Drawing.Size(83, 17);
            descriptionLabelPost.TabIndex = 6;
            descriptionLabelPost.Text = "Description:";
            // 
            // birthdayLabelFriend
            // 
            birthdayLabelFriend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            birthdayLabelFriend.AutoSize = true;
            birthdayLabelFriend.Location = new System.Drawing.Point(44, 58);
            birthdayLabelFriend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            birthdayLabelFriend.Name = "birthdayLabelFriend";
            birthdayLabelFriend.Size = new System.Drawing.Size(64, 17);
            birthdayLabelFriend.TabIndex = 2;
            birthdayLabelFriend.Text = "Birthday:";
            // 
            // displayNameLabelFriend
            // 
            displayNameLabelFriend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            displayNameLabelFriend.AutoSize = true;
            displayNameLabelFriend.Location = new System.Drawing.Point(44, 26);
            displayNameLabelFriend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            displayNameLabelFriend.Name = "displayNameLabelFriend";
            displayNameLabelFriend.Size = new System.Drawing.Size(49, 17);
            displayNameLabelFriend.TabIndex = 3;
            displayNameLabelFriend.Text = "Name:";
            // 
            // descriptionLabelAlbum
            // 
            descriptionLabelAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            descriptionLabelAlbum.AutoSize = true;
            descriptionLabelAlbum.Location = new System.Drawing.Point(77, 85);
            descriptionLabelAlbum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descriptionLabelAlbum.Name = "descriptionLabelAlbum";
            descriptionLabelAlbum.Size = new System.Drawing.Size(83, 17);
            descriptionLabelAlbum.TabIndex = 4;
            descriptionLabelAlbum.Text = "Description:";
            // 
            // displayNameLabelAlbum
            // 
            displayNameLabelAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            displayNameLabelAlbum.AutoSize = true;
            displayNameLabelAlbum.Location = new System.Drawing.Point(77, 37);
            displayNameLabelAlbum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            displayNameLabelAlbum.Name = "displayNameLabelAlbum";
            displayNameLabelAlbum.Size = new System.Drawing.Size(39, 17);
            displayNameLabelAlbum.TabIndex = 5;
            displayNameLabelAlbum.Text = "Title:";
            // 
            // createdTimeLabelAlbum
            // 
            createdTimeLabelAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            createdTimeLabelAlbum.AutoSize = true;
            createdTimeLabelAlbum.Location = new System.Drawing.Point(77, 222);
            createdTimeLabelAlbum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            createdTimeLabelAlbum.Name = "createdTimeLabelAlbum";
            createdTimeLabelAlbum.Size = new System.Drawing.Size(97, 17);
            createdTimeLabelAlbum.TabIndex = 9;
            createdTimeLabelAlbum.Text = "Created Time:";
            // 
            // countLabelAlbum
            // 
            countLabelAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            countLabelAlbum.AutoSize = true;
            countLabelAlbum.Location = new System.Drawing.Point(77, 181);
            countLabelAlbum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            countLabelAlbum.Name = "countLabelAlbum";
            countLabelAlbum.Size = new System.Drawing.Size(95, 17);
            countLabelAlbum.TabIndex = 10;
            countLabelAlbum.Text = "Photos count:";
            // 
            // createdTimeLabelPost
            // 
            createdTimeLabelPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            createdTimeLabelPost.AutoSize = true;
            createdTimeLabelPost.Location = new System.Drawing.Point(63, 261);
            createdTimeLabelPost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            createdTimeLabelPost.Name = "createdTimeLabelPost";
            createdTimeLabelPost.Size = new System.Drawing.Size(97, 17);
            createdTimeLabelPost.TabIndex = 7;
            createdTimeLabelPost.Text = "Created Time:";
            // 
            // displayNameLabelPage
            // 
            displayNameLabelPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            displayNameLabelPage.AutoSize = true;
            displayNameLabelPage.Location = new System.Drawing.Point(60, 38);
            displayNameLabelPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            displayNameLabelPage.Name = "displayNameLabelPage";
            displayNameLabelPage.Size = new System.Drawing.Size(39, 17);
            displayNameLabelPage.TabIndex = 0;
            displayNameLabelPage.Text = "Title:";
            // 
            // descriptionLabelPage
            // 
            descriptionLabelPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            descriptionLabelPage.AutoSize = true;
            descriptionLabelPage.Location = new System.Drawing.Point(60, 89);
            descriptionLabelPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descriptionLabelPage.Name = "descriptionLabelPage";
            descriptionLabelPage.Size = new System.Drawing.Size(83, 17);
            descriptionLabelPage.TabIndex = 2;
            descriptionLabelPage.Text = "Description:";
            // 
            // displayNameLabelEvent
            // 
            displayNameLabelEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            displayNameLabelEvent.AutoSize = true;
            displayNameLabelEvent.Location = new System.Drawing.Point(40, 25);
            displayNameLabelEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            displayNameLabelEvent.Name = "displayNameLabelEvent";
            displayNameLabelEvent.Size = new System.Drawing.Size(39, 17);
            displayNameLabelEvent.TabIndex = 0;
            displayNameLabelEvent.Text = "Title:";
            // 
            // descriptionLabelEvent
            // 
            descriptionLabelEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            descriptionLabelEvent.AutoSize = true;
            descriptionLabelEvent.Location = new System.Drawing.Point(40, 68);
            descriptionLabelEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descriptionLabelEvent.Name = "descriptionLabelEvent";
            descriptionLabelEvent.Size = new System.Drawing.Size(83, 17);
            descriptionLabelEvent.TabIndex = 2;
            descriptionLabelEvent.Text = "Description:";
            // 
            // startTimeLabelEvent
            // 
            startTimeLabelEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            startTimeLabelEvent.AutoSize = true;
            startTimeLabelEvent.Location = new System.Drawing.Point(40, 251);
            startTimeLabelEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            startTimeLabelEvent.Name = "startTimeLabelEvent";
            startTimeLabelEvent.Size = new System.Drawing.Size(77, 17);
            startTimeLabelEvent.TabIndex = 4;
            startTimeLabelEvent.Text = "Start Time:";
            // 
            // endTimeLabelEvent
            // 
            endTimeLabelEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            endTimeLabelEvent.AutoSize = true;
            endTimeLabelEvent.Location = new System.Drawing.Point(40, 290);
            endTimeLabelEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            endTimeLabelEvent.Name = "endTimeLabelEvent";
            endTimeLabelEvent.Size = new System.Drawing.Size(72, 17);
            endTimeLabelEvent.TabIndex = 6;
            endTimeLabelEvent.Text = "End Time:";
            // 
            // locationLabelEvent
            // 
            locationLabelEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            locationLabelEvent.AutoSize = true;
            locationLabelEvent.Location = new System.Drawing.Point(40, 215);
            locationLabelEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            locationLabelEvent.Name = "locationLabelEvent";
            locationLabelEvent.Size = new System.Drawing.Size(66, 17);
            locationLabelEvent.TabIndex = 8;
            locationLabelEvent.Text = "Location:";
            // 
            // checkBoxRememberUser
            // 
            this.checkBoxRememberUser.AutoSize = true;
            this.checkBoxRememberUser.Location = new System.Drawing.Point(40, 111);
            this.checkBoxRememberUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxRememberUser.Name = "checkBoxRememberUser";
            this.checkBoxRememberUser.Size = new System.Drawing.Size(122, 21);
            this.checkBoxRememberUser.TabIndex = 0;
            this.checkBoxRememberUser.Text = "Remember Me";
            this.checkBoxRememberUser.UseVisualStyleBackColor = true;
            this.checkBoxRememberUser.CheckedChanged += new System.EventHandler(this.checkBoxRememberUser_CheckedChanged);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(40, 33);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 28);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(40, 70);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(100, 28);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // tabControlApp
            // 
            this.tabControlApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlApp.Controls.Add(this.tabPosts);
            this.tabControlApp.Controls.Add(this.tabFriends);
            this.tabControlApp.Controls.Add(this.tabAlbums);
            this.tabControlApp.Controls.Add(this.tabPhotos);
            this.tabControlApp.Controls.Add(this.tabPages);
            this.tabControlApp.Controls.Add(this.tabEvents);
            this.tabControlApp.Location = new System.Drawing.Point(8, 170);
            this.tabControlApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlApp.Name = "tabControlApp";
            this.tabControlApp.SelectedIndex = 0;
            this.tabControlApp.Size = new System.Drawing.Size(1108, 636);
            this.tabControlApp.TabIndex = 3;
            // 
            // tabPosts
            // 
            this.tabPosts.AutoScroll = true;
            this.tabPosts.BackColor = System.Drawing.Color.White;
            this.tabPosts.Controls.Add(this.panelPost);
            this.tabPosts.Controls.Add(this.listBoxPosts);
            this.tabPosts.Location = new System.Drawing.Point(4, 25);
            this.tabPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPosts.Name = "tabPosts";
            this.tabPosts.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPosts.Size = new System.Drawing.Size(1100, 607);
            this.tabPosts.TabIndex = 0;
            this.tabPosts.Text = "Posts";
            // 
            // panelPost
            // 
            this.panelPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPost.Controls.Add(this.createdTimeTextBoxPost);
            this.panelPost.Controls.Add(createdTimeLabelPost);
            this.panelPost.Controls.Add(descriptionLabelPost);
            this.panelPost.Controls.Add(this.descriptionTextBoxPost);
            this.panelPost.Controls.Add(pictureURLLabelPost);
            this.panelPost.Controls.Add(this.pictureBoxPost);
            this.panelPost.Controls.Add(displayNameLabelPost);
            this.panelPost.Controls.Add(this.displayNameTextBoxPost);
            this.panelPost.Location = new System.Drawing.Point(393, 6);
            this.panelPost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelPost.Name = "panelPost";
            this.panelPost.Size = new System.Drawing.Size(716, 580);
            this.panelPost.TabIndex = 1;
            // 
            // createdTimeTextBoxPost
            // 
            this.createdTimeTextBoxPost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "CreatedTime", true));
            this.createdTimeTextBoxPost.Location = new System.Drawing.Point(171, 257);
            this.createdTimeTextBoxPost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createdTimeTextBoxPost.Name = "createdTimeTextBoxPost";
            this.createdTimeTextBoxPost.ReadOnly = true;
            this.createdTimeTextBoxPost.Size = new System.Drawing.Size(255, 22);
            this.createdTimeTextBoxPost.TabIndex = 9;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // descriptionTextBoxPost
            // 
            this.descriptionTextBoxPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBoxPost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Description", true));
            this.descriptionTextBoxPost.Location = new System.Drawing.Point(171, 119);
            this.descriptionTextBoxPost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionTextBoxPost.Multiline = true;
            this.descriptionTextBoxPost.Name = "descriptionTextBoxPost";
            this.descriptionTextBoxPost.ReadOnly = true;
            this.descriptionTextBoxPost.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBoxPost.Size = new System.Drawing.Size(527, 107);
            this.descriptionTextBoxPost.TabIndex = 7;
            // 
            // pictureBoxPost
            // 
            this.pictureBoxPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPost.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.postBindingSource, "PictureURL", true));
            this.pictureBoxPost.Location = new System.Drawing.Point(171, 314);
            this.pictureBoxPost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxPost.Name = "pictureBoxPost";
            this.pictureBoxPost.Size = new System.Drawing.Size(528, 185);
            this.pictureBoxPost.TabIndex = 5;
            this.pictureBoxPost.TabStop = false;
            // 
            // displayNameTextBoxPost
            // 
            this.displayNameTextBoxPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.displayNameTextBoxPost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postAdapterBindingSource, "DisplayName", true));
            this.displayNameTextBoxPost.Location = new System.Drawing.Point(171, 28);
            this.displayNameTextBoxPost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayNameTextBoxPost.Multiline = true;
            this.displayNameTextBoxPost.Name = "displayNameTextBoxPost";
            this.displayNameTextBoxPost.ReadOnly = true;
            this.displayNameTextBoxPost.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displayNameTextBoxPost.Size = new System.Drawing.Size(527, 67);
            this.displayNameTextBoxPost.TabIndex = 1;
            // 
            // postAdapterBindingSource
            // 
            this.postAdapterBindingSource.DataSource = typeof(Adapters.AdapterFacebookPost);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPosts.DataSource = this.postAdapterBindingSource;
            this.listBoxPosts.DisplayMember = "DisplayName";
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(5, 5);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(380, 580);
            this.listBoxPosts.TabIndex = 0;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // tabFriends
            // 
            this.tabFriends.Controls.Add(this.panelFriend);
            this.tabFriends.Controls.Add(this.listBoxFriends);
            this.tabFriends.Location = new System.Drawing.Point(4, 25);
            this.tabFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabFriends.Name = "tabFriends";
            this.tabFriends.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabFriends.Size = new System.Drawing.Size(1100, 607);
            this.tabFriends.TabIndex = 1;
            this.tabFriends.Text = "Friends";
            this.tabFriends.UseVisualStyleBackColor = true;
            // 
            // panelFriend
            // 
            this.panelFriend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFriend.Controls.Add(this.birthdayTextBoxUser);
            this.panelFriend.Controls.Add(this.fullNameTextBoxUser);
            this.panelFriend.Controls.Add(this.buttonChuckNorris);
            this.panelFriend.Controls.Add(this.imageNormalPictureBoxFriend);
            this.panelFriend.Controls.Add(this.buttonFriendZodiac);
            this.panelFriend.Controls.Add(displayNameLabelFriend);
            this.panelFriend.Controls.Add(birthdayLabelFriend);
            this.panelFriend.Location = new System.Drawing.Point(399, 7);
            this.panelFriend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelFriend.Name = "panelFriend";
            this.panelFriend.Size = new System.Drawing.Size(692, 578);
            this.panelFriend.TabIndex = 13;
            // 
            // birthdayTextBoxUser
            // 
            this.birthdayTextBoxUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayTextBoxUser.Location = new System.Drawing.Point(116, 54);
            this.birthdayTextBoxUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.birthdayTextBoxUser.Name = "birthdayTextBoxUser";
            this.birthdayTextBoxUser.ReadOnly = true;
            this.birthdayTextBoxUser.Size = new System.Drawing.Size(245, 22);
            this.birthdayTextBoxUser.TabIndex = 14;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // fullNameTextBoxUser
            // 
            this.fullNameTextBoxUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userAdapterBindingSource, "DisplayName", true));
            this.fullNameTextBoxUser.Location = new System.Drawing.Point(116, 22);
            this.fullNameTextBoxUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fullNameTextBoxUser.Name = "fullNameTextBoxUser";
            this.fullNameTextBoxUser.ReadOnly = true;
            this.fullNameTextBoxUser.Size = new System.Drawing.Size(245, 22);
            this.fullNameTextBoxUser.TabIndex = 13;
            // 
            // userAdapterBindingSource
            // 
            this.userAdapterBindingSource.DataSource = typeof(Adapters.AdapterFacebookUser);
            // 
            // buttonChuckNorris
            // 
            this.buttonChuckNorris.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChuckNorris.Location = new System.Drawing.Point(48, 310);
            this.buttonChuckNorris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonChuckNorris.Name = "buttonChuckNorris";
            this.buttonChuckNorris.Size = new System.Drawing.Size(175, 28);
            this.buttonChuckNorris.TabIndex = 12;
            this.buttonChuckNorris.Text = "Hit with Chuck Norris";
            this.buttonChuckNorris.UseVisualStyleBackColor = true;
            this.buttonChuckNorris.Click += new System.EventHandler(this.buttonChuckNorris_Click);
            // 
            // imageNormalPictureBoxFriend
            // 
            this.imageNormalPictureBoxFriend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageNormalPictureBoxFriend.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.imageNormalPictureBoxFriend.Location = new System.Drawing.Point(48, 90);
            this.imageNormalPictureBoxFriend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageNormalPictureBoxFriend.Name = "imageNormalPictureBoxFriend";
            this.imageNormalPictureBoxFriend.Size = new System.Drawing.Size(183, 158);
            this.imageNormalPictureBoxFriend.TabIndex = 5;
            this.imageNormalPictureBoxFriend.TabStop = false;
            // 
            // buttonFriendZodiac
            // 
            this.buttonFriendZodiac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFriendZodiac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonFriendZodiac.Location = new System.Drawing.Point(48, 271);
            this.buttonFriendZodiac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFriendZodiac.Name = "buttonFriendZodiac";
            this.buttonFriendZodiac.Size = new System.Drawing.Size(175, 28);
            this.buttonFriendZodiac.TabIndex = 11;
            this.buttonFriendZodiac.Text = "Find friend\'s zodiac";
            this.buttonFriendZodiac.UseVisualStyleBackColor = true;
            this.buttonFriendZodiac.Click += new System.EventHandler(this.buttonFriendZodiac_Click);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFriends.DataSource = this.userAdapterBindingSource;
            this.listBoxFriends.DisplayMember = "DisplayName";
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(5, 5);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(385, 580);
            this.listBoxFriends.TabIndex = 1;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // tabAlbums
            // 
            this.tabAlbums.AutoScroll = true;
            this.tabAlbums.Controls.Add(this.panelAlbum);
            this.tabAlbums.Controls.Add(this.listBoxAlbums);
            this.tabAlbums.Location = new System.Drawing.Point(4, 25);
            this.tabAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAlbums.Name = "tabAlbums";
            this.tabAlbums.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAlbums.Size = new System.Drawing.Size(1100, 607);
            this.tabAlbums.TabIndex = 2;
            this.tabAlbums.Text = "Albums";
            this.tabAlbums.UseVisualStyleBackColor = true;
            // 
            // panelAlbum
            // 
            this.panelAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAlbum.Controls.Add(this.buttonViewAlbum);
            this.panelAlbum.Controls.Add(this.displayNameTextBoxAlbum);
            this.panelAlbum.Controls.Add(countLabelAlbum);
            this.panelAlbum.Controls.Add(this.countLabelAlbumPhotos);
            this.panelAlbum.Controls.Add(createdTimeLabelAlbum);
            this.panelAlbum.Controls.Add(this.createdTimeLabelAlbumTime);
            this.panelAlbum.Controls.Add(this.imageAlbumPictureBox);
            this.panelAlbum.Controls.Add(displayNameLabelAlbum);
            this.panelAlbum.Controls.Add(descriptionLabelAlbum);
            this.panelAlbum.Controls.Add(this.descriptionTextBoxAlbum);
            this.panelAlbum.Location = new System.Drawing.Point(399, 7);
            this.panelAlbum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelAlbum.Name = "panelAlbum";
            this.panelAlbum.Size = new System.Drawing.Size(708, 578);
            this.panelAlbum.TabIndex = 2;
            // 
            // buttonViewAlbum
            // 
            this.buttonViewAlbum.Location = new System.Drawing.Point(185, 491);
            this.buttonViewAlbum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonViewAlbum.Name = "buttonViewAlbum";
            this.buttonViewAlbum.Size = new System.Drawing.Size(124, 28);
            this.buttonViewAlbum.TabIndex = 13;
            this.buttonViewAlbum.Text = "View Album";
            this.buttonViewAlbum.UseVisualStyleBackColor = true;
            this.buttonViewAlbum.Click += new System.EventHandler(this.buttonViewAlbum_Click);
            // 
            // displayNameTextBoxAlbum
            // 
            this.displayNameTextBoxAlbum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumAdapterBindingSource, "DisplayName", true));
            this.displayNameTextBoxAlbum.Location = new System.Drawing.Point(185, 33);
            this.displayNameTextBoxAlbum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayNameTextBoxAlbum.Name = "displayNameTextBoxAlbum";
            this.displayNameTextBoxAlbum.ReadOnly = true;
            this.displayNameTextBoxAlbum.Size = new System.Drawing.Size(505, 22);
            this.displayNameTextBoxAlbum.TabIndex = 12;
            // 
            // albumAdapterBindingSource
            // 
            this.albumAdapterBindingSource.DataSource = typeof(Adapters.AdapterFacebookAlbum);
            // 
            // countLabelAlbumPhotos
            // 
            this.countLabelAlbumPhotos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.countLabelAlbumPhotos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Count", true));
            this.countLabelAlbumPhotos.Location = new System.Drawing.Point(185, 181);
            this.countLabelAlbumPhotos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countLabelAlbumPhotos.Name = "countLabelAlbumPhotos";
            this.countLabelAlbumPhotos.Size = new System.Drawing.Size(133, 28);
            this.countLabelAlbumPhotos.TabIndex = 11;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // createdTimeLabelAlbumTime
            // 
            this.createdTimeLabelAlbumTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createdTimeLabelAlbumTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "CreatedTime", true));
            this.createdTimeLabelAlbumTime.Location = new System.Drawing.Point(185, 222);
            this.createdTimeLabelAlbumTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createdTimeLabelAlbumTime.Name = "createdTimeLabelAlbumTime";
            this.createdTimeLabelAlbumTime.Size = new System.Drawing.Size(133, 28);
            this.createdTimeLabelAlbumTime.TabIndex = 10;
            // 
            // imageAlbumPictureBox
            // 
            this.imageAlbumPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageAlbumPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumBindingSource, "ImageAlbum", true));
            this.imageAlbumPictureBox.Location = new System.Drawing.Point(185, 261);
            this.imageAlbumPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageAlbumPictureBox.Name = "imageAlbumPictureBox";
            this.imageAlbumPictureBox.Size = new System.Drawing.Size(507, 223);
            this.imageAlbumPictureBox.TabIndex = 7;
            this.imageAlbumPictureBox.TabStop = false;
            // 
            // descriptionTextBoxAlbum
            // 
            this.descriptionTextBoxAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBoxAlbum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Description", true));
            this.descriptionTextBoxAlbum.Location = new System.Drawing.Point(185, 81);
            this.descriptionTextBoxAlbum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionTextBoxAlbum.Multiline = true;
            this.descriptionTextBoxAlbum.Name = "descriptionTextBoxAlbum";
            this.descriptionTextBoxAlbum.ReadOnly = true;
            this.descriptionTextBoxAlbum.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBoxAlbum.Size = new System.Drawing.Size(505, 75);
            this.descriptionTextBoxAlbum.TabIndex = 5;
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxAlbums.DataSource = this.albumAdapterBindingSource;
            this.listBoxAlbums.DisplayMember = "DisplayName";
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 16;
            this.listBoxAlbums.Location = new System.Drawing.Point(5, 5);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(385, 580);
            this.listBoxAlbums.TabIndex = 1;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // tabPhotos
            // 
            this.tabPhotos.Controls.Add(this.progressBarTaggedFriends);
            this.tabPhotos.Controls.Add(this.label1);
            this.tabPhotos.Controls.Add(this.buttonFindBestTaggedFriend);
            this.tabPhotos.Controls.Add(this.panelPodiumResults);
            this.tabPhotos.Controls.Add(this.dataGridViewTaggedFriends);
            this.tabPhotos.Location = new System.Drawing.Point(4, 25);
            this.tabPhotos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPhotos.Name = "tabPhotos";
            this.tabPhotos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPhotos.Size = new System.Drawing.Size(1100, 607);
            this.tabPhotos.TabIndex = 5;
            this.tabPhotos.Text = "Photos";
            this.tabPhotos.UseVisualStyleBackColor = true;
            // 
            // progressBarTaggedFriends
            // 
            this.progressBarTaggedFriends.Location = new System.Drawing.Point(135, 44);
            this.progressBarTaggedFriends.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBarTaggedFriends.Name = "progressBarTaggedFriends";
            this.progressBarTaggedFriends.Size = new System.Drawing.Size(215, 28);
            this.progressBarTaggedFriends.TabIndex = 10;
            this.progressBarTaggedFriends.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Click \'Find\' to know how many likes gained each one of the friends you are tagged" +
    " with.";
            // 
            // buttonFindBestTaggedFriend
            // 
            this.buttonFindBestTaggedFriend.Location = new System.Drawing.Point(25, 44);
            this.buttonFindBestTaggedFriend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFindBestTaggedFriend.Name = "buttonFindBestTaggedFriend";
            this.buttonFindBestTaggedFriend.Size = new System.Drawing.Size(100, 28);
            this.buttonFindBestTaggedFriend.TabIndex = 0;
            this.buttonFindBestTaggedFriend.Text = "Find";
            this.buttonFindBestTaggedFriend.UseVisualStyleBackColor = true;
            this.buttonFindBestTaggedFriend.Click += new System.EventHandler(this.buttonFindBestTaggedFriend_Click);
            // 
            // panelPodiumResults
            // 
            this.panelPodiumResults.Controls.Add(this.labelConclusion);
            this.panelPodiumResults.Controls.Add(this.labelNameSecondPlace);
            this.panelPodiumResults.Controls.Add(this.labelNameFirstPlace);
            this.panelPodiumResults.Controls.Add(this.labelNameThirdPlace);
            this.panelPodiumResults.Controls.Add(this.pictureBoxSecondPlace);
            this.panelPodiumResults.Controls.Add(this.pictureBoxFirstPlace);
            this.panelPodiumResults.Controls.Add(this.pictureBoxThirdPlace);
            this.panelPodiumResults.Controls.Add(this.pictureBoxPodium);
            this.panelPodiumResults.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPodiumResults.Location = new System.Drawing.Point(640, 4);
            this.panelPodiumResults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelPodiumResults.Name = "panelPodiumResults";
            this.panelPodiumResults.Size = new System.Drawing.Size(456, 599);
            this.panelPodiumResults.TabIndex = 6;
            // 
            // labelConclusion
            // 
            this.labelConclusion.AutoSize = true;
            this.labelConclusion.Location = new System.Drawing.Point(1, 439);
            this.labelConclusion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConclusion.Name = "labelConclusion";
            this.labelConclusion.Size = new System.Drawing.Size(456, 17);
            this.labelConclusion.TabIndex = 7;
            this.labelConclusion.Text = "These are your best friends which you should upload more photos with!";
            this.labelConclusion.Visible = false;
            // 
            // labelNameSecondPlace
            // 
            this.labelNameSecondPlace.AutoSize = true;
            this.labelNameSecondPlace.Location = new System.Drawing.Point(308, 169);
            this.labelNameSecondPlace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameSecondPlace.Name = "labelNameSecondPlace";
            this.labelNameSecondPlace.Size = new System.Drawing.Size(128, 17);
            this.labelNameSecondPlace.TabIndex = 6;
            this.labelNameSecondPlace.Text = "NameSecondPlace";
            this.labelNameSecondPlace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNameSecondPlace.Visible = false;
            // 
            // labelNameFirstPlace
            // 
            this.labelNameFirstPlace.AutoSize = true;
            this.labelNameFirstPlace.Location = new System.Drawing.Point(159, 145);
            this.labelNameFirstPlace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameFirstPlace.Name = "labelNameFirstPlace";
            this.labelNameFirstPlace.Size = new System.Drawing.Size(107, 17);
            this.labelNameFirstPlace.TabIndex = 5;
            this.labelNameFirstPlace.Text = "NameFirstPlace";
            this.labelNameFirstPlace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNameFirstPlace.Visible = false;
            // 
            // labelNameThirdPlace
            // 
            this.labelNameThirdPlace.AutoSize = true;
            this.labelNameThirdPlace.Location = new System.Drawing.Point(11, 192);
            this.labelNameThirdPlace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameThirdPlace.Name = "labelNameThirdPlace";
            this.labelNameThirdPlace.Size = new System.Drawing.Size(113, 17);
            this.labelNameThirdPlace.TabIndex = 4;
            this.labelNameThirdPlace.Text = "NameThirdPlace";
            this.labelNameThirdPlace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNameThirdPlace.Visible = false;
            // 
            // pictureBoxSecondPlace
            // 
            this.pictureBoxSecondPlace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSecondPlace.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSecondPlace.Location = new System.Drawing.Point(312, 192);
            this.pictureBoxSecondPlace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxSecondPlace.MaximumSize = new System.Drawing.Size(133, 123);
            this.pictureBoxSecondPlace.MinimumSize = new System.Drawing.Size(133, 123);
            this.pictureBoxSecondPlace.Name = "pictureBoxSecondPlace";
            this.pictureBoxSecondPlace.Size = new System.Drawing.Size(133, 123);
            this.pictureBoxSecondPlace.TabIndex = 3;
            this.pictureBoxSecondPlace.TabStop = false;
            // 
            // pictureBoxFirstPlace
            // 
            this.pictureBoxFirstPlace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFirstPlace.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFirstPlace.Location = new System.Drawing.Point(163, 167);
            this.pictureBoxFirstPlace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxFirstPlace.MaximumSize = new System.Drawing.Size(133, 123);
            this.pictureBoxFirstPlace.MinimumSize = new System.Drawing.Size(133, 123);
            this.pictureBoxFirstPlace.Name = "pictureBoxFirstPlace";
            this.pictureBoxFirstPlace.Size = new System.Drawing.Size(133, 123);
            this.pictureBoxFirstPlace.TabIndex = 2;
            this.pictureBoxFirstPlace.TabStop = false;
            // 
            // pictureBoxThirdPlace
            // 
            this.pictureBoxThirdPlace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxThirdPlace.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxThirdPlace.Location = new System.Drawing.Point(15, 217);
            this.pictureBoxThirdPlace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxThirdPlace.MaximumSize = new System.Drawing.Size(133, 123);
            this.pictureBoxThirdPlace.MinimumSize = new System.Drawing.Size(133, 123);
            this.pictureBoxThirdPlace.Name = "pictureBoxThirdPlace";
            this.pictureBoxThirdPlace.Size = new System.Drawing.Size(133, 123);
            this.pictureBoxThirdPlace.TabIndex = 1;
            this.pictureBoxThirdPlace.TabStop = false;
            // 
            // pictureBoxPodium
            // 
            this.pictureBoxPodium.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPodium.Image = global::AppUI.Properties.Resources.podiumPicture;
            this.pictureBoxPodium.Location = new System.Drawing.Point(8, 261);
            this.pictureBoxPodium.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxPodium.MaximumSize = new System.Drawing.Size(444, 215);
            this.pictureBoxPodium.MinimumSize = new System.Drawing.Size(444, 215);
            this.pictureBoxPodium.Name = "pictureBoxPodium";
            this.pictureBoxPodium.Size = new System.Drawing.Size(444, 215);
            this.pictureBoxPodium.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPodium.TabIndex = 0;
            this.pictureBoxPodium.TabStop = false;
            // 
            // dataGridViewTaggedFriends
            // 
            this.dataGridViewTaggedFriends.AllowUserToAddRows = false;
            this.dataGridViewTaggedFriends.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTaggedFriends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTaggedFriends.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ColLikes,
            this.ColPhotosCount});
            this.dataGridViewTaggedFriends.Location = new System.Drawing.Point(27, 80);
            this.dataGridViewTaggedFriends.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewTaggedFriends.MultiSelect = false;
            this.dataGridViewTaggedFriends.Name = "dataGridViewTaggedFriends";
            this.dataGridViewTaggedFriends.Size = new System.Drawing.Size(603, 492);
            this.dataGridViewTaggedFriends.TabIndex = 1;
            // 
            // ColName
            // 
            this.ColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColName.HeaderText = "Name";
            this.ColName.Name = "ColName";
            // 
            // ColLikes
            // 
            this.ColLikes.HeaderText = "Likes gained";
            this.ColLikes.Name = "ColLikes";
            // 
            // ColPhotosCount
            // 
            this.ColPhotosCount.HeaderText = "Number of photos";
            this.ColPhotosCount.Name = "ColPhotosCount";
            this.ColPhotosCount.Width = 115;
            // 
            // tabPages
            // 
            this.tabPages.AutoScroll = true;
            this.tabPages.Controls.Add(this.panelPage);
            this.tabPages.Controls.Add(this.listBoxPages);
            this.tabPages.Location = new System.Drawing.Point(4, 25);
            this.tabPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPages.Name = "tabPages";
            this.tabPages.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPages.Size = new System.Drawing.Size(1100, 607);
            this.tabPages.TabIndex = 3;
            this.tabPages.Text = "Pages";
            this.tabPages.UseVisualStyleBackColor = true;
            // 
            // panelPage
            // 
            this.panelPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPage.Controls.Add(this.displayNameTextBoxPage);
            this.panelPage.Controls.Add(this.imageNormalPictureBoxPage);
            this.panelPage.Controls.Add(descriptionLabelPage);
            this.panelPage.Controls.Add(this.descriptionTextBoxPage);
            this.panelPage.Controls.Add(displayNameLabelPage);
            this.panelPage.Location = new System.Drawing.Point(399, 7);
            this.panelPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelPage.Name = "panelPage";
            this.panelPage.Size = new System.Drawing.Size(696, 578);
            this.panelPage.TabIndex = 2;
            // 
            // displayNameTextBoxPage
            // 
            this.displayNameTextBoxPage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageAdapterBindingSource, "DisplayName", true));
            this.displayNameTextBoxPage.Location = new System.Drawing.Point(152, 34);
            this.displayNameTextBoxPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayNameTextBoxPage.Name = "displayNameTextBoxPage";
            this.displayNameTextBoxPage.ReadOnly = true;
            this.displayNameTextBoxPage.Size = new System.Drawing.Size(520, 22);
            this.displayNameTextBoxPage.TabIndex = 6;
            // 
            // pageAdapterBindingSource
            // 
            this.pageAdapterBindingSource.DataSource = typeof(Adapters.AdapterFacebookPage);
            // 
            // imageNormalPictureBoxPage
            // 
            this.imageNormalPictureBoxPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageNormalPictureBoxPage.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageNormal", true));
            this.imageNormalPictureBoxPage.Location = new System.Drawing.Point(152, 203);
            this.imageNormalPictureBoxPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageNormalPictureBoxPage.Name = "imageNormalPictureBoxPage";
            this.imageNormalPictureBoxPage.Size = new System.Drawing.Size(521, 164);
            this.imageNormalPictureBoxPage.TabIndex = 5;
            this.imageNormalPictureBoxPage.TabStop = false;
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // descriptionTextBoxPage
            // 
            this.descriptionTextBoxPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBoxPage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Description", true));
            this.descriptionTextBoxPage.Location = new System.Drawing.Point(152, 85);
            this.descriptionTextBoxPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionTextBoxPage.Multiline = true;
            this.descriptionTextBoxPage.Name = "descriptionTextBoxPage";
            this.descriptionTextBoxPage.ReadOnly = true;
            this.descriptionTextBoxPage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBoxPage.Size = new System.Drawing.Size(520, 89);
            this.descriptionTextBoxPage.TabIndex = 3;
            // 
            // listBoxPages
            // 
            this.listBoxPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPages.DataSource = this.pageAdapterBindingSource;
            this.listBoxPages.DisplayMember = "DisplayName";
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.ItemHeight = 16;
            this.listBoxPages.Location = new System.Drawing.Point(5, 5);
            this.listBoxPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(385, 580);
            this.listBoxPages.TabIndex = 1;
            this.listBoxPages.SelectedIndexChanged += new System.EventHandler(this.listBoxPages_SelectedIndexChanged);
            // 
            // tabEvents
            // 
            this.tabEvents.Controls.Add(this.panelEvent);
            this.tabEvents.Controls.Add(this.listBoxEvents);
            this.tabEvents.Location = new System.Drawing.Point(4, 25);
            this.tabEvents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabEvents.Name = "tabEvents";
            this.tabEvents.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabEvents.Size = new System.Drawing.Size(1100, 607);
            this.tabEvents.TabIndex = 4;
            this.tabEvents.Text = "Events";
            this.tabEvents.UseVisualStyleBackColor = true;
            // 
            // panelEvent
            // 
            this.panelEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEvent.Controls.Add(this.displayNameTextBoxEvent);
            this.panelEvent.Controls.Add(this.imageNormalPictureBoxEvent);
            this.panelEvent.Controls.Add(locationLabelEvent);
            this.panelEvent.Controls.Add(this.locationLabelEventValue);
            this.panelEvent.Controls.Add(endTimeLabelEvent);
            this.panelEvent.Controls.Add(this.endTimeLabelEventValue);
            this.panelEvent.Controls.Add(startTimeLabelEvent);
            this.panelEvent.Controls.Add(this.startTimeLabelEventValue);
            this.panelEvent.Controls.Add(descriptionLabelEvent);
            this.panelEvent.Controls.Add(this.descriptionTextBoxEvent);
            this.panelEvent.Controls.Add(displayNameLabelEvent);
            this.panelEvent.Location = new System.Drawing.Point(400, 9);
            this.panelEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEvent.Name = "panelEvent";
            this.panelEvent.Size = new System.Drawing.Size(689, 577);
            this.panelEvent.TabIndex = 8;
            // 
            // displayNameTextBoxEvent
            // 
            this.displayNameTextBoxEvent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventAdapterBindingSource, "DisplayName", true));
            this.displayNameTextBoxEvent.Location = new System.Drawing.Point(120, 21);
            this.displayNameTextBoxEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayNameTextBoxEvent.Name = "displayNameTextBoxEvent";
            this.displayNameTextBoxEvent.ReadOnly = true;
            this.displayNameTextBoxEvent.Size = new System.Drawing.Size(540, 22);
            this.displayNameTextBoxEvent.TabIndex = 12;
            // 
            // eventAdapterBindingSource
            // 
            this.eventAdapterBindingSource.DataSource = typeof(Adapters.AdapterFacebookEvent);
            // 
            // imageNormalPictureBoxEvent
            // 
            this.imageNormalPictureBoxEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageNormalPictureBoxEvent.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageNormal", true));
            this.imageNormalPictureBoxEvent.Location = new System.Drawing.Point(125, 322);
            this.imageNormalPictureBoxEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageNormalPictureBoxEvent.Name = "imageNormalPictureBoxEvent";
            this.imageNormalPictureBoxEvent.Size = new System.Drawing.Size(536, 154);
            this.imageNormalPictureBoxEvent.TabIndex = 11;
            this.imageNormalPictureBoxEvent.TabStop = false;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // locationLabelEventValue
            // 
            this.locationLabelEventValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.locationLabelEventValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Location", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "Unknown"));
            this.locationLabelEventValue.Location = new System.Drawing.Point(125, 215);
            this.locationLabelEventValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locationLabelEventValue.Name = "locationLabelEventValue";
            this.locationLabelEventValue.Size = new System.Drawing.Size(133, 28);
            this.locationLabelEventValue.TabIndex = 9;
            // 
            // endTimeLabelEventValue
            // 
            this.endTimeLabelEventValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.endTimeLabelEventValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "EndTime", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "Unknown"));
            this.endTimeLabelEventValue.Location = new System.Drawing.Point(125, 290);
            this.endTimeLabelEventValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endTimeLabelEventValue.Name = "endTimeLabelEventValue";
            this.endTimeLabelEventValue.Size = new System.Drawing.Size(133, 28);
            this.endTimeLabelEventValue.TabIndex = 7;
            // 
            // startTimeLabelEventValue
            // 
            this.startTimeLabelEventValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startTimeLabelEventValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "StartTime", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "Unknown"));
            this.startTimeLabelEventValue.Location = new System.Drawing.Point(125, 251);
            this.startTimeLabelEventValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startTimeLabelEventValue.Name = "startTimeLabelEventValue";
            this.startTimeLabelEventValue.Size = new System.Drawing.Size(133, 28);
            this.startTimeLabelEventValue.TabIndex = 5;
            // 
            // descriptionTextBoxEvent
            // 
            this.descriptionTextBoxEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBoxEvent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true));
            this.descriptionTextBoxEvent.Location = new System.Drawing.Point(125, 64);
            this.descriptionTextBoxEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionTextBoxEvent.Multiline = true;
            this.descriptionTextBoxEvent.Name = "descriptionTextBoxEvent";
            this.descriptionTextBoxEvent.ReadOnly = true;
            this.descriptionTextBoxEvent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBoxEvent.Size = new System.Drawing.Size(535, 136);
            this.descriptionTextBoxEvent.TabIndex = 3;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEvents.DataSource = this.eventAdapterBindingSource;
            this.listBoxEvents.DisplayMember = "DisplayName";
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(7, 5);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(385, 580);
            this.listBoxEvents.TabIndex = 7;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxProfile.Location = new System.Drawing.Point(937, 14);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(173, 166);
            this.pictureBoxProfile.TabIndex = 4;
            this.pictureBoxProfile.TabStop = false;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStatus.Location = new System.Drawing.Point(296, 110);
            this.textBoxStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(504, 22);
            this.textBoxStatus.TabIndex = 5;
            // 
            // buttonPost
            // 
            this.buttonPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPost.Location = new System.Drawing.Point(808, 107);
            this.buttonPost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(100, 28);
            this.buttonPost.TabIndex = 6;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(240, 112);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(52, 17);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Status:";
            // 
            // labelHeadline
            // 
            this.labelHeadline.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelHeadline.AutoSize = true;
            this.labelHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeadline.Location = new System.Drawing.Point(440, 21);
            this.labelHeadline.Name = "labelHeadline";
            this.labelHeadline.Size = new System.Drawing.Size(215, 39);
            this.labelHeadline.TabIndex = 8;
            this.labelHeadline.Text = "Please Login";
            this.labelHeadline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1124, 814);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.labelHeadline);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.tabControlApp);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.checkBoxRememberUser);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1338, 1293);
            this.MinimumSize = new System.Drawing.Size(861, 789);
            this.Name = "MainForm";
            this.Text = "Facebook Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMain_Closing);
            this.tabControlApp.ResumeLayout(false);
            this.tabPosts.ResumeLayout(false);
            this.panelPost.ResumeLayout(false);
            this.panelPost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postAdapterBindingSource)).EndInit();
            this.tabFriends.ResumeLayout(false);
            this.panelFriend.ResumeLayout(false);
            this.panelFriend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBoxFriend)).EndInit();
            this.tabAlbums.ResumeLayout(false);
            this.panelAlbum.ResumeLayout(false);
            this.panelAlbum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).EndInit();
            this.tabPhotos.ResumeLayout(false);
            this.tabPhotos.PerformLayout();
            this.panelPodiumResults.ResumeLayout(false);
            this.panelPodiumResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSecondPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFirstPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThirdPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPodium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaggedFriends)).EndInit();
            this.tabPages.ResumeLayout(false);
            this.panelPage.ResumeLayout(false);
            this.panelPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBoxPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            this.tabEvents.ResumeLayout(false);
            this.panelEvent.ResumeLayout(false);
            this.panelEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBoxEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.CheckBox checkBoxRememberUser;
        private ProxyButton buttonLogin;
        private ProxyButton buttonLogout;
        private System.Windows.Forms.TabControl tabControlApp;
        private System.Windows.Forms.TabPage tabPosts;
        private System.Windows.Forms.TabPage tabFriends;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.TextBox textBoxStatus;
        private ProxyButton buttonPost;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelHeadline;
        private System.Windows.Forms.TabPage tabAlbums;
        private System.Windows.Forms.TabPage tabPages;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.ListBox listBoxPages;
        private System.Windows.Forms.TabPage tabEvents;
        private System.Windows.Forms.ListBox listBoxEvents;
        private ProxyButton buttonFriendZodiac;
        private ProxyButton buttonChuckNorris;
        private System.Windows.Forms.Panel panelPost;
        private System.Windows.Forms.TextBox descriptionTextBoxPost;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.PictureBox pictureBoxPost;
        private System.Windows.Forms.TextBox displayNameTextBoxPost;
        private System.Windows.Forms.Panel panelFriend;
        private System.Windows.Forms.PictureBox imageNormalPictureBoxFriend;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Panel panelAlbum;
        private System.Windows.Forms.Label createdTimeLabelAlbumTime;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.PictureBox imageAlbumPictureBox;
        private System.Windows.Forms.TextBox descriptionTextBoxAlbum;
        private System.Windows.Forms.Label countLabelAlbumPhotos;
        private System.Windows.Forms.Panel panelPage;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.PictureBox imageNormalPictureBoxPage;
        private System.Windows.Forms.TextBox descriptionTextBoxPage;
        private System.Windows.Forms.Panel panelEvent;
        private System.Windows.Forms.PictureBox imageNormalPictureBoxEvent;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.Label locationLabelEventValue;
        private System.Windows.Forms.Label endTimeLabelEventValue;
        private System.Windows.Forms.Label startTimeLabelEventValue;
        private System.Windows.Forms.TextBox descriptionTextBoxEvent;
        private System.Windows.Forms.TabPage tabPhotos;
        private ProxyButton buttonFindBestTaggedFriend;
        private System.Windows.Forms.TextBox displayNameTextBoxAlbum;
        private System.Windows.Forms.TextBox displayNameTextBoxPage;
        private System.Windows.Forms.TextBox displayNameTextBoxEvent;
        private ProxyButton buttonViewAlbum;
        private System.Windows.Forms.BindingSource postAdapterBindingSource;
        private System.Windows.Forms.BindingSource userAdapterBindingSource;
        private System.Windows.Forms.BindingSource albumAdapterBindingSource;
        private System.Windows.Forms.BindingSource pageAdapterBindingSource;
        private System.Windows.Forms.BindingSource eventAdapterBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewTaggedFriends;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLikes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPhotosCount;
        private System.Windows.Forms.Panel panelPodiumResults;
        private System.Windows.Forms.PictureBox pictureBoxPodium;
        private System.Windows.Forms.PictureBox pictureBoxThirdPlace;
        private System.Windows.Forms.Label labelNameSecondPlace;
        private System.Windows.Forms.Label labelNameFirstPlace;
        private System.Windows.Forms.Label labelNameThirdPlace;
        private System.Windows.Forms.PictureBox pictureBoxSecondPlace;
        private System.Windows.Forms.PictureBox pictureBoxFirstPlace;
        private System.Windows.Forms.Label labelConclusion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarTaggedFriends;
        private System.Windows.Forms.TextBox createdTimeTextBoxPost;
        private System.Windows.Forms.TextBox birthdayTextBoxUser;
        private System.Windows.Forms.TextBox fullNameTextBoxUser;
    }
}
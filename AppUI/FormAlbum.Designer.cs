namespace AppUI
{
    partial class FormAlbum
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
            this.panelAlbumPhotos = new System.Windows.Forms.Panel();
            this.pictureBoxSelectedPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAlbumPhotos
            // 
            this.panelAlbumPhotos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelAlbumPhotos.AutoScroll = true;
            this.panelAlbumPhotos.Location = new System.Drawing.Point(12, 12);
            this.panelAlbumPhotos.Name = "panelAlbumPhotos";
            this.panelAlbumPhotos.Size = new System.Drawing.Size(686, 446);
            this.panelAlbumPhotos.TabIndex = 0;
            // 
            // pictureBoxSelectedPhoto
            // 
            this.pictureBoxSelectedPhoto.Location = new System.Drawing.Point(704, 12);
            this.pictureBoxSelectedPhoto.Name = "pictureBoxSelectedPhoto";
            this.pictureBoxSelectedPhoto.Size = new System.Drawing.Size(690, 446);
            this.pictureBoxSelectedPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSelectedPhoto.TabIndex = 1;
            this.pictureBoxSelectedPhoto.TabStop = false;
            // 
            // AlbumDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 470);
            this.Controls.Add(this.pictureBoxSelectedPhoto);
            this.Controls.Add(this.panelAlbumPhotos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AlbumDisplay";
            this.Text = "AlbumReview";
            this.Load += new System.EventHandler(this.albumDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAlbumPhotos;
        private System.Windows.Forms.PictureBox pictureBoxSelectedPhoto;
    }
}
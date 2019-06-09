namespace AppUI
{
    partial class FormChuckNorrisJoke
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
            this.pictureBoxChuckNorris = new System.Windows.Forms.PictureBox();
            this.labelJoke = new System.Windows.Forms.Label();
            this.buttonPost = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChuckNorris)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxChuckNorris
            // 
            this.pictureBoxChuckNorris.Location = new System.Drawing.Point(303, 12);
            this.pictureBoxChuckNorris.Name = "pictureBoxChuckNorris";
            this.pictureBoxChuckNorris.Size = new System.Drawing.Size(100, 107);
            this.pictureBoxChuckNorris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxChuckNorris.TabIndex = 0;
            this.pictureBoxChuckNorris.TabStop = false;
            // 
            // labelJoke
            // 
            this.labelJoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJoke.Location = new System.Drawing.Point(13, 13);
            this.labelJoke.Name = "labelJoke";
            this.labelJoke.Size = new System.Drawing.Size(284, 106);
            this.labelJoke.TabIndex = 1;
            this.labelJoke.Text = "Joke";
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(159, 134);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(90, 26);
            this.buttonPost.TabIndex = 2;
            this.buttonPost.Text = "Post to friend";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // ChuckNorrisResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 172);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.labelJoke);
            this.Controls.Add(this.pictureBoxChuckNorris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChuckNorrisResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChuckNorris)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxChuckNorris;
        private System.Windows.Forms.Label labelJoke;
        private System.Windows.Forms.Button buttonPost;
    }
}
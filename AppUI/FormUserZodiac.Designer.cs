namespace AppUI
{
    partial class FormUserZodiac
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
            this.pictureBoxZodiacSign = new System.Windows.Forms.PictureBox();
            this.labelZodiacSign = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZodiacSign)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxZodiacSign
            // 
            this.pictureBoxZodiacSign.Location = new System.Drawing.Point(92, 58);
            this.pictureBoxZodiacSign.Name = "pictureBoxZodiacSign";
            this.pictureBoxZodiacSign.Size = new System.Drawing.Size(90, 85);
            this.pictureBoxZodiacSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxZodiacSign.TabIndex = 0;
            this.pictureBoxZodiacSign.TabStop = false;
            // 
            // labelZodiacSign
            // 
            this.labelZodiacSign.AutoSize = true;
            this.labelZodiacSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZodiacSign.Location = new System.Drawing.Point(99, 21);
            this.labelZodiacSign.Name = "labelZodiacSign";
            this.labelZodiacSign.Size = new System.Drawing.Size(76, 25);
            this.labelZodiacSign.TabIndex = 2;
            this.labelZodiacSign.Text = "label1";
            // 
            // ZodiacUserResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 170);
            this.Controls.Add(this.labelZodiacSign);
            this.Controls.Add(this.pictureBoxZodiacSign);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ZodiacUserResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zodiac Result";
            this.Load += new System.EventHandler(this.zodiacUserResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZodiacSign)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxZodiacSign;
        private System.Windows.Forms.Label labelZodiacSign;
    }
}
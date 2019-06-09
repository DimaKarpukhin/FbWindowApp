namespace AppUI
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class FormUserZodiac : Form
    {
        public string ZodiacSign { get; }

        public FormUserZodiac(string i_Result)
        {
            InitializeComponent();
            ZodiacSign = i_Result;
        }

        private void zodiacUserResultForm_Load(object sender, EventArgs e)
        {
            labelZodiacSign.Text = ZodiacSign;
            try
            {
                pictureBoxZodiacSign.Image = chooseZodiacPicture();
            }
            catch
            {
                MessageBox.Show("An error occured during picture fetching.");
            }
        }

        private Image chooseZodiacPicture()
        {
            object obj = Properties.Resources.ResourceManager.GetObject(ZodiacSign);

            return obj as Image;
        }
    }
}

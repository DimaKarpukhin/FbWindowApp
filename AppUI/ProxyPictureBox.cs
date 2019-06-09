namespace AppUI
{
    using System;
    using System.Windows.Forms;

    public class PhotoSelectedEventArgs : EventArgs
    {
        public string URL;
    }

    public delegate void PhotoSelectedEventHandler(object sender, PhotoSelectedEventArgs e);

    public class ProxyPictureBox : PictureBox, IEmphasizable
    {
        public string URL { get; set; }

        private Emphasizer m_Emphasizer;

        public ProxyPictureBox()
        {
            m_Emphasizer = new Emphasizer();
            MouseHover += mouseHoverDesign;
            MouseLeave += mouseLeaveDesign;
        }

        public new void Load(string i_UrlToLoad)
        {
            URL = i_UrlToLoad;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (ImageLocation == null)
            {
                ImageLocation = URL;
            }

            base.OnPaint(e);
        }

        public event PhotoSelectedEventHandler PhotoSelected;

        private void mouseHoverDesign(object sender, EventArgs e)
        {
            PhotoSelectedEventArgs args = new PhotoSelectedEventArgs();
            args.URL = URL;

            PhotoSelected(this, args);
            m_Emphasizer.Emphasize(this);
        }

        private void mouseLeaveDesign(object sender, EventArgs e)
        {
            m_Emphasizer.Deemphasize(this);
        }
    }
}

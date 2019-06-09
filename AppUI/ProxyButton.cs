namespace AppUI
{
    using System;
    using System.Windows.Forms;

    public class ProxyButton : Button, IEmphasizable
    {
        private Emphasizer m_Emphasizer;

        public ProxyButton()
        {
            m_Emphasizer = new Emphasizer();
            MouseHover += mouseHoverDesign;
            MouseLeave += mouseLeaveDesign;
        }

        private void mouseHoverDesign(object sender, EventArgs e)
        {
            m_Emphasizer.Emphasize(this);
        }

        private void mouseLeaveDesign(object sender, EventArgs e)
        {
            m_Emphasizer.Deemphasize(this);
        }
    }
}

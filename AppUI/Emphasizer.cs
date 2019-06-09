namespace AppUI
{
    using System.Drawing;
    using System.Windows.Forms;

    public class Emphasizer
    {
        private const int k_Padding = 2;
        private const int k_Enlarge = 10;
        private Color m_SavedColor;
        private int m_LocationOffset;
        private bool m_IsEmphasized;

        public void Emphasize(IEmphasizable i_Item)
        {
            m_LocationOffset = k_Enlarge / 2;
            m_SavedColor = i_Item.BackColor;
            m_IsEmphasized = true;

            i_Item.BackColor = SystemColors.Highlight;
            i_Item.Padding = new Padding(k_Padding);
            i_Item.Size = new Size(i_Item.Size.Width + k_Enlarge, i_Item.Size.Height + k_Enlarge);
            i_Item.Location = new Point(i_Item.Location.X - m_LocationOffset, i_Item.Location.Y - m_LocationOffset);
        }

        public void Deemphasize(IEmphasizable i_Item)
        {
            if (m_IsEmphasized)
            {
                m_IsEmphasized = false;

                i_Item.BackColor = m_SavedColor;
                i_Item.Padding = new Padding((-1) * k_Padding);
                i_Item.Size = new Size(i_Item.Size.Width - k_Enlarge, i_Item.Size.Height - k_Enlarge);
                i_Item.Location = new Point(i_Item.Location.X + m_LocationOffset, i_Item.Location.Y + m_LocationOffset);
            }
        }
    }
}

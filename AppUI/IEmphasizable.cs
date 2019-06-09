namespace AppUI
{
    using System.Windows.Forms;
    using System.Drawing;

    public interface IEmphasizable
    {
        Padding Padding { get; set; }

        Color BackColor { get; set; }

        Size Size { get; set; }

        Point Location { get; set; }
    }
}

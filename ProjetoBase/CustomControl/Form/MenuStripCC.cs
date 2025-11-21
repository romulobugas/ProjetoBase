using ProjetoBase.Config;
using ProjetoBase.CustomControl.Form;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoBase.CustomControls
{
    public class MenuStripCC : MenuStrip
    {
        public MenuStripCC()
        {
            this.Renderer = new MyRenderer();
            this.BackColor = LayoutManager.corItemMenuStrip;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.BackColor = LayoutManager.corItemMenuStrip;
        }
    }

    public class MyRenderer : ToolStripProfessionalRenderer
    {
        public MyRenderer() : base(new MyColors()) { }
    }

    public class MyColors : ProfessionalColorTable
    {
        public override Color MenuItemSelected => LayoutManager.corSelecaoItemMenuStrip;
        public override Color ToolStripDropDownBackground => LayoutManager.corItemMenuStrip;

        public override Color ImageMarginGradientBegin => LayoutManager.corItemMenuStrip;
        public override Color ImageMarginGradientEnd => LayoutManager.corItemMenuStrip;
        public override Color ImageMarginGradientMiddle => LayoutManager.corItemMenuStrip;

        public override Color MenuItemSelectedGradientBegin => LayoutManager.corSelecaoItemMenuStrip;
        public override Color MenuItemSelectedGradientEnd => LayoutManager.corSelecaoItemMenuStrip;

        public override Color MenuItemPressedGradientBegin => LayoutManager.corSelecaoItemMenuStrip;
        public override Color MenuItemPressedGradientMiddle => LayoutManager.corSelecaoItemMenuStrip;
        public override Color MenuItemPressedGradientEnd => LayoutManager.corSelecaoItemMenuStrip;

        public override Color MenuItemBorder => LayoutManager.corSelecaoItemMenuStrip;
    }

    /// <summary>
    /// Menu customizado que mantém estilo visual,
    /// mas herda o sistema de acesso corretamente.
    /// </summary>
    public class ToolStripMenuItemCC : MenuItemAcessivel
    {
        public ToolStripMenuItemCC()
        {
            this.ForeColor = LayoutManager.corTextoStrip;
        }
    }
}

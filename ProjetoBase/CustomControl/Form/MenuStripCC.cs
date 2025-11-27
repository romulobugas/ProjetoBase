using ProjetoBase.Config;
using ProjetoBase.Enumeradores;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoBase.CustomControl
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
        public override Color MenuItemSelected
        {
            get { return LayoutManager.corSelecaoItemMenuStrip; }
        }

        public override Color ToolStripDropDownBackground
        {
            get { return LayoutManager.corItemMenuStrip; }
        }

        public override Color ImageMarginGradientBegin
        {
            get { return LayoutManager.corItemMenuStrip; }
        }

        public override Color ImageMarginGradientEnd
        {
            get { return LayoutManager.corItemMenuStrip; }
        }

        public override Color ImageMarginGradientMiddle
        {
            get { return LayoutManager.corItemMenuStrip; }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get { return LayoutManager.corSelecaoItemMenuStrip; }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return LayoutManager.corSelecaoItemMenuStrip; }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get { return LayoutManager.corSelecaoItemMenuStrip; }
        }

        public override Color MenuItemPressedGradientMiddle
        {
            get { return LayoutManager.corSelecaoItemMenuStrip; }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get { return LayoutManager.corSelecaoItemMenuStrip; }
        }

        public override Color MenuItemBorder
        {
            get { return LayoutManager.corSelecaoItemMenuStrip; }
        }

    }

    public class ToolStripMenuItemCC : ToolStripMenuItem
    {
        // PROPRIEDADE pública (não campo)
        public EnumNivelDeAcesso[] NiveisDeAcesso { get; set; } = new EnumNivelDeAcesso[0];

        public ToolStripMenuItemCC()
        {
            this.ForeColor = LayoutManager.corTextoStrip;
        }

        // Atalho para um único nível
        public EnumNivelDeAcesso NivelDeAcesso
        {
            get => NiveisDeAcesso != null && NiveisDeAcesso.Length > 0
                ? NiveisDeAcesso[0]
                : 0;
            set => NiveisDeAcesso = new[] { value };
        }

        public bool PossuiAcesso(EnumNivelDeAcesso nivelUsuario)
        {
            // Admin vê tudo
            if (nivelUsuario == EnumNivelDeAcesso.Administrador)
                return true;

            // Se não configurou nada, libera
            if (NiveisDeAcesso == null || NiveisDeAcesso.Length == 0)
                return true;

            return NiveisDeAcesso.Contains(nivelUsuario);
        }
    }
}
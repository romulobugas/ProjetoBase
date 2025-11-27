using ProjetoBase.CustomControls;
using System.Windows.Forms;

namespace ProjetoBase.CustomControl
{
    partial class MenuCC
    {
        private System.ComponentModel.IContainer components = null;

        private MenuStripCC menuStrip1;
        public BackgroundWorkerCC backgroundWorkerUpdate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.menuStrip1 = new MenuStripCC();
            this.backgroundWorkerUpdate = new BackgroundWorkerCC();

            this.SuspendLayout();

            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = DockStyle.Top;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            // 
            // MenuCC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuCC";
            this.Text = "Menu";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

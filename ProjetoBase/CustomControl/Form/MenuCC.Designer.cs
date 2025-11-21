using ProjetoBase.CustomControls;
using ProjetoBase.DataBase.Dominio.Funcionario;
using ProjetoBase.Enumeradores;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoBase.CustomControl.Form
{
    partial class MenuCC
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

        #region Inicializacao de variaveis

        private MenuStripCC menuStrip1;
        private ToolStripMenuItemCC cadastroToolStripMenuItem;
        private ToolStripMenuItemCC relatoriosToolStripMenuItem;
        private ToolStripMenuItemCC administracaoToolStripMenuItem;
        private ToolStripMenuItemCC rHToolStripMenuItem;
        private ToolStripMenuItemCC cRMToolStripMenuItem;
        private ToolStripMenuItemCC cargoToolStripMenuItem;
        private ToolStripMenuItemCC usuarioToolStripMenuItem;
        private ToolStripMenuItemCC clienteToolStripMenuItem;
        private ToolStripMenuItemCC funcionarioToolStripMenuItem;
        private ToolStripMenuItemCC perfilDeAcessoToolStripMenuItem;
        private ToolStripMenuItemCC clienteRelatoriosToolStripMenuItem;
        public BackgroundWorkerCC backgroundWorkerUpdate;
        private EnumNivelDeAcesso _nivelUsuarioLogado;

        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new ProjetoBase.CustomControls.MenuStripCC();

            this.cadastroToolStripMenuItem = new ProjetoBase.CustomControls.ToolStripMenuItemCC();
            this.relatoriosToolStripMenuItem = new ProjetoBase.CustomControls.ToolStripMenuItemCC();

            this.administracaoToolStripMenuItem = new ProjetoBase.CustomControls.ToolStripMenuItemCC();
            this.rHToolStripMenuItem = new ProjetoBase.CustomControls.ToolStripMenuItemCC();
            this.cRMToolStripMenuItem = new ProjetoBase.CustomControls.ToolStripMenuItemCC();

            this.cargoToolStripMenuItem = new ProjetoBase.CustomControls.ToolStripMenuItemCC();
            this.usuarioToolStripMenuItem = new ProjetoBase.CustomControls.ToolStripMenuItemCC();
            this.funcionarioToolStripMenuItem = new ProjetoBase.CustomControls.ToolStripMenuItemCC();
            this.clienteToolStripMenuItem = new ProjetoBase.CustomControls.ToolStripMenuItemCC();
            this.clienteRelatoriosToolStripMenuItem = new ProjetoBase.CustomControls.ToolStripMenuItemCC();
            this.perfilDeAcessoToolStripMenuItem = new ProjetoBase.CustomControls.ToolStripMenuItemCC();

            this.backgroundWorkerUpdate = new ProjetoBase.CustomControls.BackgroundWorkerCC();

            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();

            // evento global de clique
            this.menuStrip1.ItemClicked += Menu_ItemClicked;

            // =======================
            // CONFIGURAÇÃO DOS MENUS
            // =======================

            // MENU CADASTRO -------------
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.ForeColor = Color.White;
            this.cadastroToolStripMenuItem.NiveisDeAcesso = new[]
            {
        EnumNivelDeAcesso.Administrador,
        EnumNivelDeAcesso.RecursosHumanos
    };

            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
        this.administracaoToolStripMenuItem,
        this.rHToolStripMenuItem,
        this.cRMToolStripMenuItem
            });

            // MENU RELATÓRIOS ------------
            this.relatoriosToolStripMenuItem.Text = "Relatórios";
            this.relatoriosToolStripMenuItem.ForeColor = Color.White;
            this.relatoriosToolStripMenuItem.NiveisDeAcesso = new[]
            {
        EnumNivelDeAcesso.Administrador,
        EnumNivelDeAcesso.CRM
    };

            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
        this.clienteRelatoriosToolStripMenuItem
            });

            // SUBMENU Administração -------
            this.administracaoToolStripMenuItem.Text = "Administração";
            this.administracaoToolStripMenuItem.ForeColor = Color.White;
            this.administracaoToolStripMenuItem.NiveisDeAcesso = new[]
            {
        EnumNivelDeAcesso.Administrador
    };

            this.administracaoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
        this.usuarioToolStripMenuItem,
        this.perfilDeAcessoToolStripMenuItem
            });

            // SUBMENU RH ------------------
            this.rHToolStripMenuItem.Text = "RH";
            this.rHToolStripMenuItem.ForeColor = Color.White;
            this.rHToolStripMenuItem.NiveisDeAcesso = new[]
            {
        EnumNivelDeAcesso.Administrador,
        EnumNivelDeAcesso.RecursosHumanos
    };

            this.rHToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
        this.cargoToolStripMenuItem,
        this.funcionarioToolStripMenuItem
            });

            // SUBMENU CRM -----------------
            this.cRMToolStripMenuItem.Text = "CRM";
            this.cRMToolStripMenuItem.ForeColor = Color.White;
            this.cRMToolStripMenuItem.NiveisDeAcesso = new[]
            {
        EnumNivelDeAcesso.Administrador,
        EnumNivelDeAcesso.CRM
    };

            this.cRMToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
        this.clienteToolStripMenuItem
            });

            // SUBSUBMENUS -----------------

            this.usuarioToolStripMenuItem.Text = "Usuário";
            this.usuarioToolStripMenuItem.ForeColor = Color.White;
            this.usuarioToolStripMenuItem.NiveisDeAcesso = new[]
            {
        EnumNivelDeAcesso.Administrador
    };

            this.perfilDeAcessoToolStripMenuItem.Text = "Perfil de Acesso";
            this.perfilDeAcessoToolStripMenuItem.ForeColor = Color.White;
            this.perfilDeAcessoToolStripMenuItem.NiveisDeAcesso = new[]
            {
        EnumNivelDeAcesso.Administrador
    };

            this.cargoToolStripMenuItem.Text = "Cargo";
            this.cargoToolStripMenuItem.ForeColor = Color.White;
            this.cargoToolStripMenuItem.NiveisDeAcesso = new[]
            {
        EnumNivelDeAcesso.Administrador,
        EnumNivelDeAcesso.RecursosHumanos
    };

            this.funcionarioToolStripMenuItem.Text = "Funcionário";
            this.funcionarioToolStripMenuItem.ForeColor = Color.White;
            this.funcionarioToolStripMenuItem.NiveisDeAcesso = new[]
            {
        EnumNivelDeAcesso.Administrador,
        EnumNivelDeAcesso.RecursosHumanos
    };

            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.ForeColor = Color.White;
            this.clienteToolStripMenuItem.NiveisDeAcesso = new[]
            {
        EnumNivelDeAcesso.Administrador,
        EnumNivelDeAcesso.CRM
    };

            this.clienteRelatoriosToolStripMenuItem.Text = "Clientes";
            this.clienteRelatoriosToolStripMenuItem.ForeColor = Color.White;
            this.clienteRelatoriosToolStripMenuItem.NiveisDeAcesso = new[]
            {
        EnumNivelDeAcesso.Administrador,
        EnumNivelDeAcesso.CRM
    };


            // MENUSTRIP FINAL --------------
            this.menuStrip1.Items.AddRange(new ToolStripItem[]
            {
        this.cadastroToolStripMenuItem,
        this.relatoriosToolStripMenuItem
            });

            // FORM -------------------------
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem is MenuItemAcessivel menu)
            {
                if (!menu.Enabled)
                {
                    MessageBox.Show(
                        "Você não tem acesso a esta área do sistema.",
                        "Acesso negado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }
            }
        }

        public void ConfigurarAcessos(EnumNivelDeAcesso nivel)
        {
            _nivelUsuarioLogado = nivel;

            AplicarPermissaoNosMenus(menuStrip1.Items);
        }

        private void AplicarPermissaoNosMenus(ToolStripItemCollection itens)
        {
            foreach (ToolStripItem item in itens)
            {
                if (item is MenuItemAcessivel menu)
                {
                    // ADMINISTRADOR TEM ACESSO TOTAL
                    if (_nivelUsuarioLogado != EnumNivelDeAcesso.Administrador)
                    {
                        // Se o menu tiver restrições e o usuário não estiver na lista → bloquear
                        if (menu.NiveisDeAcesso.Any() &&
                            !menu.NiveisDeAcesso.Contains(_nivelUsuarioLogado))
                        {
                            menu.Enabled = false;
                        }
                    }

                    // Recursão para submenus
                    if (menu.DropDownItems.Count > 0)
                        AplicarPermissaoNosMenus(menu.DropDownItems);
                }
            }
        }

        #endregion
    }

    public class MenuItemAcessivel : ToolStripMenuItem
    {
        public EnumNivelDeAcesso[] NiveisDeAcesso { get; set; } = Array.Empty<EnumNivelDeAcesso>();
    }
}



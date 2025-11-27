using ProjetoBase.CustomControl.Input;
using ProjetoBase.Enumeradores;
using ProjetoBase.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ProjetoBase.CustomControl
{
    public partial class MenuCC : FormCC
    {
        public DataGridViewCC tabela;
        int? indexLinhaSelecionada = null;
        int? posicaoScroll = null;
        int? qtdLinhasTabela = null;

        private EnumNivelDeAcesso _nivelUsuarioLogado;

        #region Construtores

        public MenuCC(EnumNivelDeAcesso nivel)
        {
            _nivelUsuarioLogado = nivel;
            InitializeComponent();
            Inicializar();
        }

        public MenuCC()
        {
            _nivelUsuarioLogado = EnumNivelDeAcesso.CRM;
            InitializeComponent();
            Inicializar();
        }

        #endregion

        #region Inicialização

        private void Inicializar()
        {
            this.menuStrip1.ItemClicked -= Menu_ItemClicked;
            this.menuStrip1.ItemClicked += Menu_ItemClicked;

            // Se tiver lógica específica de backgroundWorker, manter aqui
            if (backgroundWorkerUpdate != null)
            {
                // ...
            }

            ConfigurarAcessos(_nivelUsuarioLogado);
        }

        private void MenuCC_Load(object sender, EventArgs e)
        {
        }

        #endregion

        #region Clique dos menus

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CargoMenu CargoMenu = new CargoMenu(_nivelUsuarioLogado);
                CargoMenu.Show();
                fecharMenu();
            }
            catch { }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteMenu ClienteMenu = new ClienteMenu(_nivelUsuarioLogado);
                ClienteMenu.Show();
                fecharMenu();
            }
            catch { }
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: abrir tela de Usuário
        }

        private void perfilDeAcessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: abrir tela de Perfil de Acesso
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioMenu FuncionarioMenu = new FuncionarioMenu(_nivelUsuarioLogado);
                FuncionarioMenu.Show();
                fecharMenu();
            }
            catch { }
        }

        private void clienteRelatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: abrir relatório de Clientes
        }

        #endregion

        #region Fechar / BackgroundWorker / Update

        public void fecharMenu()
        {
            if (!backgroundWorkerUpdate.IsBusy)
            {
                this.Dispose();
            }
            else
            {
                this.Hide();
                backgroundWorkerUpdate.RunWorkerCompleted += BackgroundWorkerUpdate_RunWorkerCompleted1;
            }
        }

        private void BackgroundWorkerUpdate_RunWorkerCompleted1(object sender, RunWorkerCompletedEventArgs e)
        {
            if (tabela != null &&
                tabela.Rows.Count > 0 &&
                tabela.Rows.Count == qtdLinhasTabela &&
                posicaoScroll != null &&
                indexLinhaSelecionada != null)
            {
                tabela.Rows[(int)indexLinhaSelecionada].Selected = true;
                tabela.FirstDisplayedScrollingRowIndex = (int)posicaoScroll;
            }

            qtdLinhasTabela = tabela?.Rows.Count;
        }

        public void update()
        {
            if (tabela != null)
            {
                tabela.Enabled = false;
            }

            if (backgroundWorkerUpdate.IsBusy)
            {
                backgroundWorkerUpdate.CancelAsync();
                backgroundWorkerUpdate.setAtualizacaoPendente();
            }
            else
            {
                if (tabela?.SelectedRows?.Count > 0)
                {
                    indexLinhaSelecionada = tabela.SelectedRows[0].Index;
                    posicaoScroll = tabela.FirstDisplayedScrollingRowIndex;
                }

                qtdLinhasTabela = tabela?.Rows.Count;
                backgroundWorkerUpdate.RunWorkerAsync();
            }
        }

        public void backgroundWorkerUpdate_DoWork(object sender, DoWorkEventArgs e)
        {
        }

        #endregion

        #region Configuração de Acesso (MENU DINÂMICO)

        // Nó de configuração do menu (estrutura “modelo”)
        private class MenuNode
        {
            public string Texto { get; }
            public EnumNivelDeAcesso[] Niveis { get; }
            public EventHandler Click { get; }
            public List<MenuNode> Filhos { get; } = new List<MenuNode>();

            public MenuNode(string texto,
                            EnumNivelDeAcesso[] niveis,
                            EventHandler click = null)
            {
                Texto = texto;
                Niveis = niveis;
                Click = click;
            }
        }

        // Ponto de entrada: monta o menu conforme o nível logado
        public void ConfigurarAcessos(EnumNivelDeAcesso nivel)
        {
            _nivelUsuarioLogado = nivel;

            if (menuStrip1 == null)
                return;

            var config = ObterConfiguracaoMenu();
            ConstruirMenu(menuStrip1, _nivelUsuarioLogado, config);
        }

        // Descrição da estrutura de menus + regras de acesso
        private IEnumerable<MenuNode> ObterConfiguracaoMenu()
        {
            return new[]
            {
                // ======== CADASTRO ========
                new MenuNode(
                    "Cadastro",
                    new[]
                    {
                        EnumNivelDeAcesso.Administrador,
                        EnumNivelDeAcesso.RecursosHumanos,
                        EnumNivelDeAcesso.CRM
                    })
                {
                    Filhos =
                    {
                        // Administração -> só Admin (Usuário, Perfil de Acesso)
                        new MenuNode(
                            "Administração",
                            new[] { EnumNivelDeAcesso.Administrador })
                        {
                            Filhos =
                            {
                                new MenuNode(
                                    "Usuário",
                                    new[] { EnumNivelDeAcesso.Administrador },
                                    usuarioToolStripMenuItem_Click),

                                new MenuNode(
                                    "Perfil de Acesso",
                                    new[] { EnumNivelDeAcesso.Administrador },
                                    perfilDeAcessoToolStripMenuItem_Click)
                            }
                        },

                        // RH -> Admin + RH (Cargo, Funcionário)
                        new MenuNode(
                            "RH",
                            new[]
                            {
                                EnumNivelDeAcesso.Administrador,
                                EnumNivelDeAcesso.RecursosHumanos
                            })
                        {
                            Filhos =
                            {
                                new MenuNode(
                                    "Cargo",
                                    new[]
                                    {
                                        EnumNivelDeAcesso.Administrador,
                                        EnumNivelDeAcesso.RecursosHumanos
                                    },
                                    cargoToolStripMenuItem_Click),

                                new MenuNode(
                                    "Funcionário",
                                    new[]
                                    {
                                        EnumNivelDeAcesso.Administrador,
                                        EnumNivelDeAcesso.RecursosHumanos
                                    },
                                    funcionarioToolStripMenuItem_Click)
                            }
                        },

                        // CRM -> Admin + CRM (Cliente)
                        new MenuNode(
                            "CRM",
                            new[]
                            {
                                EnumNivelDeAcesso.Administrador,
                                EnumNivelDeAcesso.CRM
                            })
                        {
                            Filhos =
                            {
                                new MenuNode(
                                    "Cliente",
                                    new[]
                                    {
                                        EnumNivelDeAcesso.Administrador,
                                        EnumNivelDeAcesso.CRM
                                    },
                                    clienteToolStripMenuItem_Click)
                            }
                        }
                    }
                },

                // ======== RELATÓRIOS ========
                // Admin e CRM têm acesso à aba Relatórios
                new MenuNode(
                    "Relatórios",
                    new[]
                    {
                        EnumNivelDeAcesso.Administrador,
                        EnumNivelDeAcesso.CRM
                    })
                {
                    Filhos =
                    {
                        new MenuNode(
                            "Clientes",
                            new[]
                            {
                                EnumNivelDeAcesso.Administrador,
                                EnumNivelDeAcesso.CRM
                            },
                            clienteRelatoriosToolStripMenuItem_Click)
                    }
                }
            };
        }

        // Constrói o MenuStrip a partir da configuração
        private void ConstruirMenu(MenuStrip strip,
                                   EnumNivelDeAcesso nivelUsuario,
                                   IEnumerable<MenuNode> raiz)
        {
            strip.Items.Clear();

            foreach (var node in raiz)
            {
                var item = CriarItem(node, nivelUsuario);
                if (item != null)
                    strip.Items.Add(item);
            }
        }

        // Cria um item (e seus filhos) se o usuário tiver acesso
        private ToolStripMenuItemCC CriarItem(MenuNode node, EnumNivelDeAcesso nivelUsuario)
        {
            bool permitido = UsuarioTemAcesso(node.Niveis, nivelUsuario);

            var filhosPermitidos = new List<ToolStripMenuItemCC>();
            foreach (var filho in node.Filhos)
            {
                var filhoItem = CriarItem(filho, nivelUsuario);
                if (filhoItem != null)
                    filhosPermitidos.Add(filhoItem);
            }

            // não tem acesso e não sobrou nenhum filho visível -> não cria
            if (!permitido && filhosPermitidos.Count == 0)
                return null;

            var item = new ToolStripMenuItemCC
            {
                Text = node.Texto,
                NiveisDeAcesso = node.Niveis
            };

            if (node.Click != null)
                item.Click += node.Click;

            if (filhosPermitidos.Count > 0)
                item.DropDownItems.AddRange(filhosPermitidos.ToArray());

            return item;
        }

        private bool UsuarioTemAcesso(EnumNivelDeAcesso[] niveisPermitidos, EnumNivelDeAcesso nivelUsuario)
        {
            if (nivelUsuario == EnumNivelDeAcesso.Administrador)
                return true;

            if (niveisPermitidos == null || niveisPermitidos.Length == 0)
                return true;

            foreach (var n in niveisPermitidos)
            {
                if (n == nivelUsuario)
                    return true;
            }

            return false;
        }

        #endregion

        #region ItemClicked genérico

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Como o menu é construído só com itens permitidos,
            // não há necessidade de validar Enabled aqui.
        }

        #endregion
    }
}

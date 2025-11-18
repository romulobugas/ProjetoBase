using NHibernate.Transform;
using ProjetoBase.CustomControl.Form;
using ProjetoBase.CustomControls;
using ProjetoBase.CustomControls.Validacao;
using ProjetoBase.DataBase;
using ProjetoBase.DataBase.Dominio.Cliente;
using ProjetoBase.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace ProjetoBase.Formularios
{
    public partial class ClienteMenu : MenuCC, InterfaceMenu
    {

        public ClienteMenu()
        {
            InitializeComponent();

            //Eventos
            btn_cadastrar.Botao.Click += botao_cadastrar_Click;
            btn_alterar.Botao.Click += botao_alterar_Click;
            //Eventos

            backgroundWorkerUpdate.setMenu(this);
        }


        void botao_cadastrar_Click(object sender, EventArgs e)
        {
            if (ValidacaoNivelDeAcesso.acessoPermitido(btn_cadastrar.NivelDeAcesso))
            {
                ClienteCadastro ClienteCadastro = new ClienteCadastro(null);
                ClienteCadastro.ShowDialog();
                update();
            }
        }

        void botao_alterar_Click(object sender, EventArgs e)
        {
            if (ValidacaoNivelDeAcesso.acessoPermitido(btn_alterar.NivelDeAcesso))
            {
                if (dgv_cliente.SelectedRows.Count > 0)
                {
                    Cliente cliente = (Cliente)dgv_cliente.SelectedRows[0].Cells[0].Value;
                    if (cliente != null)
                    {
                        ClienteAlterar ClienteAlterar = new ClienteAlterar(cliente);
                        ClienteAlterar.ShowDialog();
                        update();
                    }
                }
            }
        }

        private void PessoaMenu_Load(object sender, EventArgs e)
        {
            BarraLateralBotoes.configurarBotoes();
            update();
        }

     
        //Detecta duplo clique na tabela
        private void dgv_pessoa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            botao_alterar_Click(btn_alterar, null);
        }
            

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private static IList<Cliente> procurarClientes()
        {
            IList<Cliente> clientes = null;

            clientes = SessionFactory.Session().QueryOver<Cliente>()
              .TransformUsing(Transformers.DistinctRootEntity)
              .OrderBy(c => c.Id).Asc
              .List<Cliente>();

            return clientes;
        }

        //Detecta o botão de pesquisa
        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            update();
        }

        private void dgv_pessoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void backgroundWorkerUpdate_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                IList<Cliente> clientes = procurarClientes();

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ENTIDADE", typeof(Cliente));
                dataTable.Columns.Add("ID");
                dataTable.Columns.Add("NOME");
                dataTable.Columns.Add("CPFCNPJ");
                dataTable.Columns.Add("RGIE");
                dataTable.Columns.Add("ENDEREÇO");
                dataTable.Columns.Add("CONTATO");
                dataTable.Columns.Add("EMAIL");
                dataTable.Columns.Add("OUTROS");

                for (int contadorPosicao = 0; contadorPosicao < clientes.Count; contadorPosicao++)
                {
                    if (backgroundWorkerUpdate.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                    Cliente cliente = (Cliente)clientes[contadorPosicao];
                    dataTable.Rows.Add(cliente, cliente.Id, cliente.Nome, cliente.CpfCnpj,cliente.RgIe,cliente.Endereço,cliente.Contato,cliente.Email,cliente.Outros);
                }
                this.dgv_cliente.BeginInvoke((MethodInvoker)delegate () { this.dgv_cliente.DataSource = dataTable; ; });
            }
            catch (Exception excecao)
            {
                ExceptionManager.tratarExcecao(excecao);
            }
        }

      
    }
}

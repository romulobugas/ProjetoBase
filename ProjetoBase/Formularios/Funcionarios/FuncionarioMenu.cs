using NHibernate.Transform;
using ProjetoBase.CustomControl;
using ProjetoBase.CustomControl.Validacao;
using ProjetoBase.DataBase;
using ProjetoBase.DataBase.Dominio.Funcionario;
using ProjetoBase.Enumeradores;
using ProjetoBase.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace ProjetoBase.Formularios
{
    public partial class FuncionarioMenu : MenuCC, InterfaceMenu
    {

        public FuncionarioMenu(EnumNivelDeAcesso nivelUsuario) : base(nivelUsuario)
        {
            InitializeComponent();

            //Eventos
            btn_cadastrar.Botao.Click += botao_cadastrar_Click;
            btn_alterar.Botao.Click += botao_alterar_Click;

            backgroundWorkerUpdate.setMenu((InterfaceMenu)this);
        }

        void botao_cadastrar_Click(object sender, EventArgs e)
        {
            if (ValidacaoNivelDeAcesso.acessoPermitido(btn_cadastrar.NivelDeAcesso))
            {
                FuncionarioCadastro funcionarioCadastro = new FuncionarioCadastro(null);
                funcionarioCadastro.ShowDialog();
                update();
            }
        }

        void botao_alterar_Click(object sender, EventArgs e)
        {
            if (ValidacaoNivelDeAcesso.acessoPermitido(btn_alterar.NivelDeAcesso))
            {
                if (dgv_funcionario.SelectedRows.Count > 0)
                {
                    Funcionario funcionario = (Funcionario)dgv_funcionario.SelectedRows[0].Cells[0].Value;
                    if (funcionario != null)
                    {
                        FuncionarioCadastro FuncionarioCadastro = new FuncionarioCadastro(funcionario);
                        FuncionarioCadastro.ShowDialog();
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

        private static IList<Funcionario> procurarFuncionarios()
        {
            IList<Funcionario> funcionarios = null;

            funcionarios = SessionFactory.Session().QueryOver<Funcionario>()
              .TransformUsing(Transformers.DistinctRootEntity)
              .OrderBy(c => c.Id).Asc
              .List<Funcionario>();

            return funcionarios;
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
                IList<Funcionario> funcionarios = procurarFuncionarios();

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ENTIDADE", typeof(Funcionario));
                dataTable.Columns.Add("ID");
                dataTable.Columns.Add("NOME");

                for (int contadorPosicao = 0; contadorPosicao < funcionarios.Count; contadorPosicao++)
                {
                    if (backgroundWorkerUpdate.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                    Funcionario funcionario = (Funcionario)funcionarios[contadorPosicao];
                    dataTable.Rows.Add(funcionario, funcionario.Id, funcionario.Nome);
                }
                this.dgv_funcionario.BeginInvoke((MethodInvoker)delegate () { this.dgv_funcionario.DataSource = dataTable; ; });
            }
            catch (Exception excecao)
            {
                ExceptionManager.tratarExcecao(excecao);
            }
        }

      
    }
}

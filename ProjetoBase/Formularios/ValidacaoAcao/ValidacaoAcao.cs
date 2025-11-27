using NHibernate.Criterion;
using NHibernate.Transform;
using ProjetoBase.CustomControl;
using ProjetoBase.DataBase;
using ProjetoBase.DataBase.Dominio.Funcionario;
using ProjetoBase.DataBase.Dominio.Interface;
using ProjetoBase.Ferramentas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ProjetoBase.Enumeradores;

namespace ProjetoBase.Formularios.Ferramentas
{
    public partial class ValidacaoAcao : FormCC
    {
        public Funcionario funcionarioResponsavel = null;

        Boolean salvarLog = false;
        String acao;
        String resumo;
        EnumAutorizacaoAcao? autorizacao;

        public Boolean permitirAutoAutorizacao = true;

        public ValidacaoAcao()
        {
            InitializeComponent();

        }

        public ValidacaoAcao(String acao, String resumo)
        {
            InitializeComponent();
            this.salvarLog = true;
            this.acao = acao;
            this.resumo = resumo;
        }


        public ValidacaoAcao(String acao, String resumo, EnumAutorizacaoAcao autorizacao)
        {
            InitializeComponent();
            this.salvarLog = true;
            this.acao = acao;
            this.resumo = resumo;
            this.autorizacao = autorizacao;
        }

        public ValidacaoAcao(String acao, String resumo, Boolean permitirAutoAutorizacao)
        {
            InitializeComponent();
            this.salvarLog = true;
            this.acao = acao;
            this.resumo = resumo;
            this.permitirAutoAutorizacao = permitirAutoAutorizacao;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        public Boolean acaoValidada()
        {
            Boolean validado = false;

            if (autorizacao != null)
            {
                var qtd = SessionFactory.UnflushedSession().CreateSQLQuery($"select count(*) from autorizacao_acao_funcionario where funcionario_id = {SessaoSistema.funcionario.Id} and EnumAutorizacaoAcao = {Convert.ToInt32(autorizacao)}").UniqueResult<int>();
                if (qtd == 1)
                {
                    validado = true;
                    funcionarioResponsavel = SessaoSistema.funcionario;
                    return validado;
                }
            }

            if (SessaoSistema.funcionario?.usuario?.Administrador == true && permitirAutoAutorizacao)
            {
                if (MessageBox.Show("Deseja autorizar esta ação com o usuario: " + SessaoSistema.funcionario.Nome + "?", "Autorizar Ação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    funcionarioResponsavel = SessaoSistema.funcionario;
                    fechar(DialogResult.Yes);
                    validado = true;
                }
            }
            else
            {
                var nivelDinamico = SessionFactory.UnflushedSession().QueryOver<NivelDeAcessoDinamico>().Where(x => x.Acao == acao).TransformUsing(Transformers.DistinctRootEntity).SingleOrDefault();

                if (nivelDinamico?.Funcionarios?.Where(x => x.Id == SessaoSistema.funcionario.Id).Count() > 0)
                {
                    if (MessageBox.Show("Deseja autorizar esta ação com o usuario: " + SessaoSistema.funcionario.Nome + "?", "Autorizar Ação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        funcionarioResponsavel = SessaoSistema.funcionario;
                        fechar(DialogResult.Yes);
                        validado = true;
                    }
                }
            }

            if (validado == false)
            {

                DialogResult resultado = this.ShowDialog();
                if (resultado == DialogResult.Yes)
                {
                    validado = true;
                }
            }
            return validado;

        }

        Boolean modoSimples = false;
        internal void ModoSimples()
        {
            modoSimples = true;
        }

        public Funcionario FuncionariaResponsavel()
        {
            DialogResult resultado = this.ShowDialog();
            if (resultado == DialogResult.Yes)
            {
                return funcionarioResponsavel;
            }
            else
            {
                return null;
            }
        }


        private void ValidacaoAcao_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Usuario usuario = getUsuario();
            var nivelDinamico = SessionFactory.UnflushedSession().QueryOver<NivelDeAcessoDinamico>().Where(x => x.Acao == acao).TransformUsing(Transformers.DistinctRootEntity).SingleOrDefault();

            if (usuario != null)
            {
                if (usuario.Administrador)
                {
                    funcionarioResponsavel = SessionFactory.UnflushedSession().QueryOver<Funcionario>().Where(x => x.usuario == usuario).TransformUsing(Transformers.DistinctRootEntity).SingleOrDefault();
                    fechar(DialogResult.Yes);
                }
                else if (SessionFactory.UnflushedSession().CreateSQLQuery($"select count(*) from autorizacao_acao_funcionario where funcionario_id = {SessaoSistema.funcionario.Id} and EnumAutorizacaoAcao = {Convert.ToInt32(autorizacao)}").UniqueResult<int>() == 1)
                {
                    funcionarioResponsavel = SessionFactory.UnflushedSession().QueryOver<Funcionario>().Where(x => x.usuario == usuario).TransformUsing(Transformers.DistinctRootEntity).SingleOrDefault();
                    fechar(DialogResult.Yes);
                }
                else if (nivelDinamico?.Funcionarios?.Where(x => x.Id == SessaoSistema.funcionario.Id).Count() > 0)
                {
                    if (MessageBox.Show("Deseja autorizar esta ação com o usuario: " + SessaoSistema.funcionario.Nome + "?", "Autorizar Ação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        funcionarioResponsavel = SessaoSistema.funcionario;
                        fechar(DialogResult.Yes);
                    }
                }
                else
                {
                    MessageBox.Show("Este usuario não tem permissão para realizar esta ação.", "Contate um Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fechar(DialogResult.No);
                }
            }
            else
            {
                MessageBox.Show("Login ou senha invalidos!", "Tente novamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        public Usuario getUsuario()
        {
            Usuario usuario = null;

            IList<Usuario> listaUsuario = SessionFactory.UnflushedSession().QueryOver<Usuario>()
                 .Where(
               Restrictions.On<Usuario>(c => c.Login).IsLike(txt_login.Texto) &&
               Restrictions.On<Usuario>(c => c.Senha).IsLike(txt_senha.Texto)
               )
                .TransformUsing(Transformers.RootEntity)
                .Take(1)
                .List<Usuario>();


            if (listaUsuario.Count == 1)
            {
                usuario = listaUsuario[0];
            }

            return usuario;
        }

        private void btn_configurar_autorizacao_Click(object sender, EventArgs e)
        {

        }

        private void NivelAcessoDinamicoCadastro_OnSalvo(Entidade entidade)
        {

        }

        private void ValidacaoAcao_Shown(object sender, EventArgs e)
        {
            var nivelAcesso = SessionFactory.UnflushedSession().QueryOver<NivelDeAcessoDinamico>().TransformUsing(Transformers.DistinctRootEntity).Where(x => x.Acao == acao).SingleOrDefault();

            if (nivelAcesso == null && modoSimples == false)
            {
                this.Size = new Size(224, 252);
            }
        }

        private void txt_login_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

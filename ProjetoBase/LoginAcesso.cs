using NHibernate.Criterion;
using ProjetoBase.CustomControls;
using ProjetoBase.DataBase;
using ProjetoBase.DataBase.Dominio.Funcionario;
using ProjetoBase.Ferramentas;
using ProjetoBase.Ferramentas.Seguranca;
using System;
using System.Windows.Forms;

namespace ProjetoBase.Formularios.Ferramentas
{
    public partial class LoginAcesso : FormCC
    {
        public Usuario UsuarioLogado { get; private set; }

        public LoginAcesso()
        {
            InitializeComponent();
        }

        // ============================================
        // BOTÃO SAIR
        // ============================================
        private void btn_sair_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        // ============================================
        // BOTÃO CONFIRMAR LOGIN
        // ============================================
        private void btn_ok_Click(object sender, EventArgs e)
        {
            Usuario usuario = VerificarLogin();

            if (usuario != null)
            {
                UsuarioLogado = usuario;
                DialogResult = DialogResult.Yes;
                MenuInicial MenuInicial = new MenuInicial();
                this.Close();
                MenuInicial.Show();
            }
            else
            {
                MessageBox.Show(
                    "Usuário ou senha inválidos!",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        // ============================================
        // MÉTODO PARA VALIDAR LOGIN
        // ============================================
        private Usuario VerificarLogin()
        {
            string loginDigitado = txt_login.Texto?.Trim();
            string senhaDigitada = txt_senha.Texto?.Trim();

            if (string.IsNullOrWhiteSpace(loginDigitado) || string.IsNullOrWhiteSpace(senhaDigitada))
                return null;

            // 1) BUSCA EXATA PELO LOGIN (Login é único)
            Usuario usuario = SessionFactory.UnflushedSession()
                .QueryOver<Usuario>()
                .Where(u => u.Login == loginDigitado)
                .Take(1)
                .SingleOrDefault();

            if (usuario == null)
                return null;

            // 2) VALIDA SENHA USANDO O HASH
            bool senhaValida = Criptografia.VerificarSenha(senhaDigitada, usuario.Senha);

            return senhaValida ? usuario : null;
        }

        // ============================================
        // CADASTRO DE USUÁRIO
        // ============================================
        private void btn_cadastrar_usuario_Click(object sender, EventArgs e)
        {
            using (var tela = new CadastroUsuario())
            {
                if (tela.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show(
                        "Usuário cadastrado com sucesso!",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
        }
    }
}

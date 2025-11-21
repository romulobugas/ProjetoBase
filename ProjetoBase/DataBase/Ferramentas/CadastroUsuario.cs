using ProjetoBase.CustomControls;
using ProjetoBase.DataBase;
using ProjetoBase.DataBase.Dominio.Funcionario;
using ProjetoBase.Ferramentas.Rede;
using ProjetoBase.Ferramentas.Seguranca;
using System;
using System.Windows.Forms;

namespace ProjetoBase.Formularios.Ferramentas
{
    public partial class CadastroUsuario : FormCC
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                var modelo = new CadastroUsuarioModel()
                {
                    Login = txt_login.Texto,
                    Senha = txt_senha.Texto,
                    ConfirmarSenha = txt_confirmarSenha.Texto,
                    NomeCompleto = txt_nome.Texto,
                    Administrador = chk_admin.Checked
                };

                modelo.Validar();

                string senhaCriptografada = Criptografia.GerarHashSenha(modelo.Senha);
                string ipHost = InfoRede.ObterIpHost();

                var usuario = new Usuario()
                {
                    Login = modelo.Login,
                    Senha = senhaCriptografada,
                    Administrador = modelo.Administrador,
                    IpHost = ipHost
                };

                var funcionario = new Funcionario()
                {
                    Nome = modelo.NomeCompleto,
                    usuario = usuario
                };

                usuario.Funcionario = funcionario;

                using (var sessao = SessionFactory.UnflushedSession())
                {
                    sessao.Save(usuario);
                    sessao.Save(funcionario);
                    sessao.Flush();
                }

                MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao salvar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

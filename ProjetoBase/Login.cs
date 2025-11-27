using ProjetoBase.CustomControl;
using ProjetoBase.DataBase;
using ProjetoBase.Formularios.Ferramentas;
using System;

namespace ProjetoBase
{
    public partial class Login : FormCC
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            SessionFactory.UnflushedSession();
            LoginAcesso LoginAcesso = new LoginAcesso();
            LoginAcesso.Show();
            this.Hide();
        }
    }
}

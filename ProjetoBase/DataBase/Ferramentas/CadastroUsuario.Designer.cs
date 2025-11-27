namespace ProjetoBase.Formularios.Ferramentas
{
    partial class CadastroUsuario
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            this.txt_login = new ProjetoBase.CustomControl.TextboxLabelCC();
            this.txt_senha = new ProjetoBase.CustomControl.TextboxLabelCC();
            this.txt_confirmarSenha = new ProjetoBase.CustomControl.TextboxLabelCC();
            this.txt_nome = new ProjetoBase.CustomControl.TextboxLabelCC();
            this.chk_admin = new System.Windows.Forms.CheckBox();
            this.btn_salvar = new ProjetoBase.CustomControl.BotaoCC();
            this.btn_cancelar = new ProjetoBase.CustomControl.BotaoCC();
            this.SuspendLayout();
            // 
            // txt_login
            // 
            this.txt_login.Caixa = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_login.CorLabel = System.Drawing.Color.Black;
            this.txt_login.Location = new System.Drawing.Point(12, 12);
            this.txt_login.MultiLinha = false;
            this.txt_login.Name = "txt_login";
            this.txt_login.NomeDisplay = "Login";
            this.txt_login.Obrigatorio = false;
            this.txt_login.PedirSenhaAlterarSomenteLeitura = true;
            this.txt_login.PermitirAlterarSomenteLeitura = false;
            this.txt_login.PermitirValorNegativo = false;
            this.txt_login.Senha = false;
            this.txt_login.Size = new System.Drawing.Size(250, 38);
            this.txt_login.SomenteLeitura = false;
            this.txt_login.TabIndex = 6;
            this.txt_login.TamanhoMaximo = 255;
            this.txt_login.TamanhoTextBox = null;
            this.txt_login.Texto = null;
            this.txt_login.TipoTextBox = ProjetoBase.Enumeradores.TipoTextBox.Texto;
            //this.txt_login.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_login_paint);
            // 
            // txt_senha
            // 
            this.txt_senha.Caixa = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_senha.CorLabel = System.Drawing.Color.Black;
            this.txt_senha.Location = new System.Drawing.Point(12, 56);
            this.txt_senha.MultiLinha = false;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.NomeDisplay = "Senha";
            this.txt_senha.Obrigatorio = false;
            this.txt_senha.PedirSenhaAlterarSomenteLeitura = true;
            this.txt_senha.PermitirAlterarSomenteLeitura = false;
            this.txt_senha.PermitirValorNegativo = false;
            this.txt_senha.Senha = true;
            this.txt_senha.Size = new System.Drawing.Size(250, 38);
            this.txt_senha.SomenteLeitura = false;
            this.txt_senha.TabIndex = 5;
            this.txt_senha.TamanhoMaximo = 255;
            this.txt_senha.TamanhoTextBox = null;
            this.txt_senha.Texto = null;
            this.txt_senha.TipoTextBox = ProjetoBase.Enumeradores.TipoTextBox.Texto;
            // 
            // txt_confirmarSenha
            // 
            this.txt_confirmarSenha.Caixa = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_confirmarSenha.CorLabel = System.Drawing.Color.Black;
            this.txt_confirmarSenha.Location = new System.Drawing.Point(12, 100);
            this.txt_confirmarSenha.MultiLinha = false;
            this.txt_confirmarSenha.Name = "txt_confirmarSenha";
            this.txt_confirmarSenha.NomeDisplay = "Confirmar Senha";
            this.txt_confirmarSenha.Obrigatorio = false;
            this.txt_confirmarSenha.PedirSenhaAlterarSomenteLeitura = true;
            this.txt_confirmarSenha.PermitirAlterarSomenteLeitura = false;
            this.txt_confirmarSenha.PermitirValorNegativo = false;
            this.txt_confirmarSenha.Senha = true;
            this.txt_confirmarSenha.Size = new System.Drawing.Size(250, 38);
            this.txt_confirmarSenha.SomenteLeitura = false;
            this.txt_confirmarSenha.TabIndex = 4;
            this.txt_confirmarSenha.TamanhoMaximo = 255;
            this.txt_confirmarSenha.TamanhoTextBox = null;
            this.txt_confirmarSenha.Texto = null;
            this.txt_confirmarSenha.TipoTextBox = ProjetoBase.Enumeradores.TipoTextBox.Texto;
            // 
            // txt_nome
            // 
            this.txt_nome.Caixa = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nome.CorLabel = System.Drawing.Color.Black;
            this.txt_nome.Location = new System.Drawing.Point(12, 144);
            this.txt_nome.MultiLinha = false;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.NomeDisplay = "Nome Completo";
            this.txt_nome.Obrigatorio = false;
            this.txt_nome.PedirSenhaAlterarSomenteLeitura = true;
            this.txt_nome.PermitirAlterarSomenteLeitura = false;
            this.txt_nome.PermitirValorNegativo = false;
            this.txt_nome.Senha = false;
            this.txt_nome.Size = new System.Drawing.Size(250, 38);
            this.txt_nome.SomenteLeitura = false;
            this.txt_nome.TabIndex = 3;
            this.txt_nome.TamanhoMaximo = 255;
            this.txt_nome.TamanhoTextBox = null;
            this.txt_nome.Texto = null;
            this.txt_nome.TipoTextBox = ProjetoBase.Enumeradores.TipoTextBox.Texto;
            // 
            // chk_admin
            // 
            this.chk_admin.AutoSize = true;
            this.chk_admin.Location = new System.Drawing.Point(12, 188);
            this.chk_admin.Name = "chk_admin";
            this.chk_admin.Size = new System.Drawing.Size(89, 17);
            this.chk_admin.TabIndex = 2;
            this.chk_admin.Text = "Administrador";
            // 
            // btn_salvar
            // 
            this.btn_salvar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btn_salvar.Location = new System.Drawing.Point(137, 220);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.NivelDeAcesso = null;
            this.btn_salvar.Size = new System.Drawing.Size(125, 35);
            this.btn_salvar.TabIndex = 1;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btn_cancelar.Location = new System.Drawing.Point(12, 220);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.NivelDeAcesso = null;
            this.btn_cancelar.Size = new System.Drawing.Size(125, 35);
            this.btn_cancelar.TabIndex = 0;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // CadastroUsuario
            // 
            this.ClientSize = new System.Drawing.Size(274, 267);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.chk_admin);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_confirmarSenha);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_login);
            this.Name = "CadastroUsuario";
            this.Nome_janela = "Cadastro de Usuário";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControl.TextboxLabelCC txt_login;
        private CustomControl.TextboxLabelCC txt_senha;
        private CustomControl.TextboxLabelCC txt_confirmarSenha;
        private CustomControl.TextboxLabelCC txt_nome;
        private System.Windows.Forms.CheckBox chk_admin;
        private CustomControl.BotaoCC btn_salvar;
        private CustomControl.BotaoCC btn_cancelar;
    }
}

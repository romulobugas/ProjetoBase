using ProjetoBase.CustomControl;

namespace ProjetoBase.Formularios
{
    partial class FuncionarioAlterar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        #region Windows Form Designer generated code

        private System.ComponentModel.IContainer components = null;
        private ProjetoBase.CustomControl.BotaoCC btn_alterar;
        private ProjetoBase.CustomControl.BotaoCC btn_cancelar;
        private System.Windows.Forms.Panel panel_funcionario;
        private CustomControl.TextboxLabelCC textboxLabel_Nome;
        private CustomControl.TextboxLabelCC textboxLabel_Cpf;
        private CustomControl.TextboxLabelCC textboxLabel_Rg;
        private CustomControl.TextboxLabelCC textboxLabel_Telefone;
        private CustomControl.TextboxLabelCC textboxLabel_Email;
        private CustomControl.TextboxLabelCC textboxLabel_DataAdmissao;

        #endregion

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_funcionario = new System.Windows.Forms.Panel();
            this.textboxLabel_Nome = new ProjetoBase.CustomControl.TextboxLabelCC();
            this.textboxLabel_Cpf = new ProjetoBase.CustomControl.TextboxLabelCC();
            this.textboxLabel_Rg = new ProjetoBase.CustomControl.TextboxLabelCC();
            this.textboxLabel_DataAdmissao = new ProjetoBase.CustomControl.TextboxLabelCC();
            this.textboxLabel_Telefone = new ProjetoBase.CustomControl.TextboxLabelCC();
            this.textboxLabel_Email = new ProjetoBase.CustomControl.TextboxLabelCC();
            this.btn_cancelar = new ProjetoBase.CustomControl.BotaoCC();
            this.btn_alterar = new ProjetoBase.CustomControl.BotaoCC();
            this.SuspendLayout();
            // 
            // panel_cliente
            // 
            this.panel_funcionario.Location = new System.Drawing.Point(4, 2);
            this.panel_funcionario.Name = "panel_funcionario";
            this.panel_funcionario.Size = new System.Drawing.Size(303, 86);
            this.panel_funcionario.TabIndex = 0;
            // 
            // textboxLabel_Nome
            // 
            this.textboxLabel_Nome.Caixa = System.Windows.Forms.CharacterCasing.Upper;
            this.textboxLabel_Nome.CorLabel = System.Drawing.Color.Black;
            this.textboxLabel_Nome.Location = new System.Drawing.Point(64, 45);
            this.textboxLabel_Nome.MultiLinha = false;
            this.textboxLabel_Nome.Name = "textboxLabel_Nome";
            this.textboxLabel_Nome.NomeDisplay = "Nome Completo";
            this.textboxLabel_Nome.Obrigatorio = false;
            this.textboxLabel_Nome.PedirSenhaAlterarSomenteLeitura = true;
            this.textboxLabel_Nome.PermitirAlterarSomenteLeitura = false;
            this.textboxLabel_Nome.PermitirValorNegativo = false;
            this.textboxLabel_Nome.Senha = false;
            this.textboxLabel_Nome.Size = new System.Drawing.Size(732, 42);
            this.textboxLabel_Nome.SomenteLeitura = false;
            this.textboxLabel_Nome.TabIndex = 3;
            this.textboxLabel_Nome.TamanhoMaximo = 255;
            this.textboxLabel_Nome.TamanhoTextBox = null;
            this.textboxLabel_Nome.Texto = null;
            this.textboxLabel_Nome.TipoTextBox = ProjetoBase.Enumeradores.TipoTextBox.Texto;
            this.textboxLabel_Nome.Paint += new System.Windows.Forms.PaintEventHandler(this.textboxLabel_Nome_Paint);
            // 
            // textboxLabel_Cpf
            // 
            this.textboxLabel_Cpf.Caixa = System.Windows.Forms.CharacterCasing.Upper;
            this.textboxLabel_Cpf.CorLabel = System.Drawing.Color.Black;
            this.textboxLabel_Cpf.Location = new System.Drawing.Point(64, 93);
            this.textboxLabel_Cpf.MultiLinha = false;
            this.textboxLabel_Cpf.Name = "textboxLabel_Cpf";
            this.textboxLabel_Cpf.NomeDisplay = "CPF";
            this.textboxLabel_Cpf.Obrigatorio = false;
            this.textboxLabel_Cpf.PedirSenhaAlterarSomenteLeitura = true;
            this.textboxLabel_Cpf.PermitirAlterarSomenteLeitura = false;
            this.textboxLabel_Cpf.PermitirValorNegativo = false;
            this.textboxLabel_Cpf.Senha = false;
            this.textboxLabel_Cpf.Size = new System.Drawing.Size(337, 38);
            this.textboxLabel_Cpf.SomenteLeitura = false;
            this.textboxLabel_Cpf.TabIndex = 4;
            this.textboxLabel_Cpf.TamanhoMaximo = 255;
            this.textboxLabel_Cpf.TamanhoTextBox = null;
            this.textboxLabel_Cpf.Texto = null;
            this.textboxLabel_Cpf.TipoTextBox = ProjetoBase.Enumeradores.TipoTextBox.Texto;
            // 
            // textboxLabel_Rg
            // 
            this.textboxLabel_Rg.Caixa = System.Windows.Forms.CharacterCasing.Upper;
            this.textboxLabel_Rg.CorLabel = System.Drawing.Color.Black;
            this.textboxLabel_Rg.Location = new System.Drawing.Point(407, 93);
            this.textboxLabel_Rg.MultiLinha = false;
            this.textboxLabel_Rg.Name = "textboxLabel_Rg";
            this.textboxLabel_Rg.NomeDisplay = "RG";
            this.textboxLabel_Rg.Obrigatorio = false;
            this.textboxLabel_Rg.PedirSenhaAlterarSomenteLeitura = true;
            this.textboxLabel_Rg.PermitirAlterarSomenteLeitura = false;
            this.textboxLabel_Rg.PermitirValorNegativo = false;
            this.textboxLabel_Rg.Senha = false;
            this.textboxLabel_Rg.Size = new System.Drawing.Size(389, 38);
            this.textboxLabel_Rg.SomenteLeitura = false;
            this.textboxLabel_Rg.TabIndex = 5;
            this.textboxLabel_Rg.TamanhoMaximo = 255;
            this.textboxLabel_Rg.TamanhoTextBox = null;
            this.textboxLabel_Rg.Texto = null;
            this.textboxLabel_Rg.TipoTextBox = ProjetoBase.Enumeradores.TipoTextBox.Texto;
            // 
            // textboxLabel_DataAdmissao
            // 
            this.textboxLabel_DataAdmissao.Caixa = System.Windows.Forms.CharacterCasing.Upper;
            this.textboxLabel_DataAdmissao.CorLabel = System.Drawing.Color.Black;
            this.textboxLabel_DataAdmissao.Location = new System.Drawing.Point(64, 137);
            this.textboxLabel_DataAdmissao.MultiLinha = false;
            this.textboxLabel_DataAdmissao.Name = "textboxLabel_DataAdmissao";
            this.textboxLabel_DataAdmissao.NomeDisplay = "Data de Admissao";
            this.textboxLabel_DataAdmissao.Obrigatorio = false;
            this.textboxLabel_DataAdmissao.PedirSenhaAlterarSomenteLeitura = true;
            this.textboxLabel_DataAdmissao.PermitirAlterarSomenteLeitura = false;
            this.textboxLabel_DataAdmissao.PermitirValorNegativo = false;
            this.textboxLabel_DataAdmissao.Senha = false;
            this.textboxLabel_DataAdmissao.Size = new System.Drawing.Size(337, 38);
            this.textboxLabel_DataAdmissao.SomenteLeitura = false;
            this.textboxLabel_DataAdmissao.TabIndex = 6;
            this.textboxLabel_DataAdmissao.TamanhoMaximo = 255;
            this.textboxLabel_DataAdmissao.TamanhoTextBox = null;
            this.textboxLabel_DataAdmissao.Texto = null;
            this.textboxLabel_DataAdmissao.TipoTextBox = ProjetoBase.Enumeradores.TipoTextBox.Texto;
            // 
            // textboxLabel_Telefone
            // 
            this.textboxLabel_Telefone.Caixa = System.Windows.Forms.CharacterCasing.Upper;
            this.textboxLabel_Telefone.CorLabel = System.Drawing.Color.Black;
            this.textboxLabel_Telefone.Location = new System.Drawing.Point(407, 137);
            this.textboxLabel_Telefone.MultiLinha = false;
            this.textboxLabel_Telefone.Name = "textboxLabel_Telefone";
            this.textboxLabel_Telefone.NomeDisplay = "Telefone";
            this.textboxLabel_Telefone.Obrigatorio = false;
            this.textboxLabel_Telefone.PedirSenhaAlterarSomenteLeitura = true;
            this.textboxLabel_Telefone.PermitirAlterarSomenteLeitura = false;
            this.textboxLabel_Telefone.PermitirValorNegativo = false;
            this.textboxLabel_Telefone.Senha = false;
            this.textboxLabel_Telefone.Size = new System.Drawing.Size(389, 38);
            this.textboxLabel_Telefone.SomenteLeitura = false;
            this.textboxLabel_Telefone.TabIndex = 7;
            this.textboxLabel_Telefone.TamanhoMaximo = 255;
            this.textboxLabel_Telefone.TamanhoTextBox = null;
            this.textboxLabel_Telefone.Texto = null;
            this.textboxLabel_Telefone.TipoTextBox = ProjetoBase.Enumeradores.TipoTextBox.Texto;           
            // 
            // textboxLabel_Email
            // 
            this.textboxLabel_Email.Caixa = System.Windows.Forms.CharacterCasing.Upper;
            this.textboxLabel_Email.CorLabel = System.Drawing.Color.Black;
            this.textboxLabel_Email.Location = new System.Drawing.Point(64, 181);
            this.textboxLabel_Email.MultiLinha = false;
            this.textboxLabel_Email.Name = "textboxLabel_Email";
            this.textboxLabel_Email.NomeDisplay = "Email";
            this.textboxLabel_Email.Obrigatorio = false;
            this.textboxLabel_Email.PedirSenhaAlterarSomenteLeitura = true;
            this.textboxLabel_Email.PermitirAlterarSomenteLeitura = false;
            this.textboxLabel_Email.PermitirValorNegativo = false;
            this.textboxLabel_Email.Senha = false;
            this.textboxLabel_Email.Size = new System.Drawing.Size(337, 38);
            this.textboxLabel_Email.SomenteLeitura = false;
            this.textboxLabel_Email.TabIndex = 8;
            this.textboxLabel_Email.TamanhoMaximo = 255;
            this.textboxLabel_Email.TamanhoTextBox = null;
            this.textboxLabel_Email.Texto = null;
            this.textboxLabel_Email.TipoTextBox = ProjetoBase.Enumeradores.TipoTextBox.Texto;            
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btn_cancelar.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_cancelar.Location = new System.Drawing.Point(407, 354);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.NivelDeAcesso = null;
            this.btn_cancelar.Size = new System.Drawing.Size(148, 35);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TipoBotao = ProjetoBase.Enumeradores.TipoBotao.Cancelar;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_alterar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_alterar.Location = new System.Drawing.Point(253, 354);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.NivelDeAcesso = null;
            this.btn_alterar.Size = new System.Drawing.Size(140, 35);
            this.btn_alterar.TabIndex = 1;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.TipoBotao = ProjetoBase.Enumeradores.TipoBotao.Alterar;
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // FuncionarioAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BotaoEnter = this.btn_alterar;
            this.BotaoEscape = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(819, 408);
            this.Controls.Add(this.textboxLabel_Email);
            this.Controls.Add(this.textboxLabel_Telefone);
            this.Controls.Add(this.textboxLabel_DataAdmissao);
            this.Controls.Add(this.textboxLabel_Rg);
            this.Controls.Add(this.textboxLabel_Cpf);
            this.Controls.Add(this.textboxLabel_Nome);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_alterar);
            this.Name = "FuncionarioAlterar";
            this.Nome_janela = "Funcionario";
            this.Text = "Funcionario";
            this.Load += new System.EventHandler(this.PessoaNovo_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
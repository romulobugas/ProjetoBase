using ProjetoBase.CustomControl;

namespace ProjetoBase.Formularios
{
    partial class ClienteCadastro
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_cliente = new System.Windows.Forms.Panel();
            this.textboxLabel_Nome = new ProjetoBase.CustomControl.TextboxLabelCC();
            this.textboxLabel_CnpjCpf = new ProjetoBase.CustomControl.TextboxLabelCC();
            this.textboxLabel_RgIe = new ProjetoBase.CustomControl.TextboxLabelCC();
            this.textboxLabel_DataDeNasc = new ProjetoBase.CustomControl.TextboxLabelCC();
            this.textboxLabel_Endereco = new ProjetoBase.CustomControl.TextboxLabelCC();
            this.textboxLabel_Contato = new ProjetoBase.CustomControl.TextboxLabelCC();
            this.textboxLabel_Email = new ProjetoBase.CustomControl.TextboxLabelCC();
            this.textboxLabel_Outros = new ProjetoBase.CustomControl.TextboxLabelCC();
            this.btn_cancelar = new ProjetoBase.CustomControl.BotaoCC();
            this.btn_cadastrar = new ProjetoBase.CustomControl.BotaoCC();
            this.SuspendLayout();
            // 
            // panel_cliente
            // 
            this.panel_cliente.Location = new System.Drawing.Point(4, 2);
            this.panel_cliente.Name = "panel_cliente";
            this.panel_cliente.Size = new System.Drawing.Size(303, 86);
            this.panel_cliente.TabIndex = 0;
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
            // textboxLabel_CnpjCpf
            // 
            this.textboxLabel_CnpjCpf.Caixa = System.Windows.Forms.CharacterCasing.Upper;
            this.textboxLabel_CnpjCpf.CorLabel = System.Drawing.Color.Black;
            this.textboxLabel_CnpjCpf.Location = new System.Drawing.Point(64, 93);
            this.textboxLabel_CnpjCpf.MultiLinha = false;
            this.textboxLabel_CnpjCpf.Name = "textboxLabel_CnpjCpf";
            this.textboxLabel_CnpjCpf.NomeDisplay = "CNPJ/CPF";
            this.textboxLabel_CnpjCpf.Obrigatorio = false;
            this.textboxLabel_CnpjCpf.PedirSenhaAlterarSomenteLeitura = true;
            this.textboxLabel_CnpjCpf.PermitirAlterarSomenteLeitura = false;
            this.textboxLabel_CnpjCpf.PermitirValorNegativo = false;
            this.textboxLabel_CnpjCpf.Senha = false;
            this.textboxLabel_CnpjCpf.Size = new System.Drawing.Size(337, 38);
            this.textboxLabel_CnpjCpf.SomenteLeitura = false;
            this.textboxLabel_CnpjCpf.TabIndex = 4;
            this.textboxLabel_CnpjCpf.TamanhoMaximo = 255;
            this.textboxLabel_CnpjCpf.TamanhoTextBox = null;
            this.textboxLabel_CnpjCpf.Texto = null;
            this.textboxLabel_CnpjCpf.TipoTextBox = ProjetoBase.Enumeradores.TipoTextBox.Texto;
            // 
            // textboxLabel_RgIe
            // 
            this.textboxLabel_RgIe.Caixa = System.Windows.Forms.CharacterCasing.Upper;
            this.textboxLabel_RgIe.CorLabel = System.Drawing.Color.Black;
            this.textboxLabel_RgIe.Location = new System.Drawing.Point(407, 93);
            this.textboxLabel_RgIe.MultiLinha = false;
            this.textboxLabel_RgIe.Name = "textboxLabel_RgIe";
            this.textboxLabel_RgIe.NomeDisplay = "RG/IE";
            this.textboxLabel_RgIe.Obrigatorio = false;
            this.textboxLabel_RgIe.PedirSenhaAlterarSomenteLeitura = true;
            this.textboxLabel_RgIe.PermitirAlterarSomenteLeitura = false;
            this.textboxLabel_RgIe.PermitirValorNegativo = false;
            this.textboxLabel_RgIe.Senha = false;
            this.textboxLabel_RgIe.Size = new System.Drawing.Size(389, 38);
            this.textboxLabel_RgIe.SomenteLeitura = false;
            this.textboxLabel_RgIe.TabIndex = 5;
            this.textboxLabel_RgIe.TamanhoMaximo = 255;
            this.textboxLabel_RgIe.TamanhoTextBox = null;
            this.textboxLabel_RgIe.Texto = null;
            this.textboxLabel_RgIe.TipoTextBox = ProjetoBase.Enumeradores.TipoTextBox.Texto;
            // 
            // textboxLabel_DataDeNasc
            // 
            this.textboxLabel_DataDeNasc.Caixa = System.Windows.Forms.CharacterCasing.Upper;
            this.textboxLabel_DataDeNasc.CorLabel = System.Drawing.Color.Black;
            this.textboxLabel_DataDeNasc.Location = new System.Drawing.Point(64, 137);
            this.textboxLabel_DataDeNasc.MultiLinha = false;
            this.textboxLabel_DataDeNasc.Name = "textboxLabel_DataDeNasc";
            this.textboxLabel_DataDeNasc.NomeDisplay = "Data de Nascimento";
            this.textboxLabel_DataDeNasc.Obrigatorio = false;
            this.textboxLabel_DataDeNasc.PedirSenhaAlterarSomenteLeitura = true;
            this.textboxLabel_DataDeNasc.PermitirAlterarSomenteLeitura = false;
            this.textboxLabel_DataDeNasc.PermitirValorNegativo = false;
            this.textboxLabel_DataDeNasc.Senha = false;
            this.textboxLabel_DataDeNasc.Size = new System.Drawing.Size(337, 38);
            this.textboxLabel_DataDeNasc.SomenteLeitura = false;
            this.textboxLabel_DataDeNasc.TabIndex = 6;
            this.textboxLabel_DataDeNasc.TamanhoMaximo = 255;
            this.textboxLabel_DataDeNasc.TamanhoTextBox = null;
            this.textboxLabel_DataDeNasc.Texto = null;
            this.textboxLabel_DataDeNasc.TipoTextBox = ProjetoBase.Enumeradores.TipoTextBox.Texto;
            // 
            // textboxLabel_Endereco
            // 
            this.textboxLabel_Endereco.Caixa = System.Windows.Forms.CharacterCasing.Upper;
            this.textboxLabel_Endereco.CorLabel = System.Drawing.Color.Black;
            this.textboxLabel_Endereco.Location = new System.Drawing.Point(407, 137);
            this.textboxLabel_Endereco.MultiLinha = false;
            this.textboxLabel_Endereco.Name = "textboxLabel_Endereco";
            this.textboxLabel_Endereco.NomeDisplay = "Endereço";
            this.textboxLabel_Endereco.Obrigatorio = false;
            this.textboxLabel_Endereco.PedirSenhaAlterarSomenteLeitura = true;
            this.textboxLabel_Endereco.PermitirAlterarSomenteLeitura = false;
            this.textboxLabel_Endereco.PermitirValorNegativo = false;
            this.textboxLabel_Endereco.Senha = false;
            this.textboxLabel_Endereco.Size = new System.Drawing.Size(389, 38);
            this.textboxLabel_Endereco.SomenteLeitura = false;
            this.textboxLabel_Endereco.TabIndex = 7;
            this.textboxLabel_Endereco.TamanhoMaximo = 255;
            this.textboxLabel_Endereco.TamanhoTextBox = null;
            this.textboxLabel_Endereco.Texto = null;
            this.textboxLabel_Endereco.TipoTextBox = ProjetoBase.Enumeradores.TipoTextBox.Texto;
            // 
            // textboxLabel_Contato
            // 
            this.textboxLabel_Contato.Caixa = System.Windows.Forms.CharacterCasing.Upper;
            this.textboxLabel_Contato.CorLabel = System.Drawing.Color.Black;
            this.textboxLabel_Contato.Location = new System.Drawing.Point(407, 181);
            this.textboxLabel_Contato.MultiLinha = false;
            this.textboxLabel_Contato.Name = "textboxLabel_Contato";
            this.textboxLabel_Contato.NomeDisplay = "Contato";
            this.textboxLabel_Contato.Obrigatorio = false;
            this.textboxLabel_Contato.PedirSenhaAlterarSomenteLeitura = true;
            this.textboxLabel_Contato.PermitirAlterarSomenteLeitura = false;
            this.textboxLabel_Contato.PermitirValorNegativo = false;
            this.textboxLabel_Contato.Senha = false;
            this.textboxLabel_Contato.Size = new System.Drawing.Size(389, 38);
            this.textboxLabel_Contato.SomenteLeitura = false;
            this.textboxLabel_Contato.TabIndex = 9;
            this.textboxLabel_Contato.TamanhoMaximo = 255;
            this.textboxLabel_Contato.TamanhoTextBox = null;
            this.textboxLabel_Contato.Texto = null;
            this.textboxLabel_Contato.TipoTextBox = ProjetoBase.Enumeradores.TipoTextBox.Texto;
            // 
            // textboxLabel_Outros
            // 
            this.textboxLabel_Outros.Caixa = System.Windows.Forms.CharacterCasing.Upper;
            this.textboxLabel_Outros.CorLabel = System.Drawing.Color.Black;
            this.textboxLabel_Outros.Location = new System.Drawing.Point(64, 225);
            this.textboxLabel_Outros.MultiLinha = false;
            this.textboxLabel_Outros.Name = "textboxLabel_Outros";
            this.textboxLabel_Outros.NomeDisplay = "Outros";
            this.textboxLabel_Outros.Obrigatorio = false;
            this.textboxLabel_Outros.PedirSenhaAlterarSomenteLeitura = true;
            this.textboxLabel_Outros.PermitirAlterarSomenteLeitura = false;
            this.textboxLabel_Outros.PermitirValorNegativo = false;
            this.textboxLabel_Outros.Senha = false;
            this.textboxLabel_Outros.Size = new System.Drawing.Size(732, 38);
            this.textboxLabel_Outros.SomenteLeitura = false;
            this.textboxLabel_Outros.TabIndex = 9;
            this.textboxLabel_Outros.TamanhoMaximo = 255;
            this.textboxLabel_Outros.TamanhoTextBox = null;
            this.textboxLabel_Outros.Texto = null;
            this.textboxLabel_Outros.TipoTextBox = ProjetoBase.Enumeradores.TipoTextBox.Texto;
            this.textboxLabel_Outros.Paint += new System.Windows.Forms.PaintEventHandler(this.textboxLabel_Outros_Paint);
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
            // btn_cadastrar
            // 
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btn_cadastrar.ForeColor = System.Drawing.Color.Blue;
            this.btn_cadastrar.Location = new System.Drawing.Point(253, 354);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.NivelDeAcesso = null;
            this.btn_cadastrar.Size = new System.Drawing.Size(148, 35);
            this.btn_cadastrar.TabIndex = 1;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.TipoBotao = ProjetoBase.Enumeradores.TipoBotao.Cadastrar;
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);           
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
            // ClienteCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BotaoEnter = this.btn_cadastrar;
            this.BotaoEscape = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(819, 408);
            this.Controls.Add(this.textboxLabel_Outros);
            this.Controls.Add(this.textboxLabel_Contato);
            this.Controls.Add(this.textboxLabel_Email);
            this.Controls.Add(this.textboxLabel_Endereco);
            this.Controls.Add(this.textboxLabel_DataDeNasc);
            this.Controls.Add(this.textboxLabel_RgIe);
            this.Controls.Add(this.textboxLabel_CnpjCpf);
            this.Controls.Add(this.textboxLabel_Nome);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_cadastrar);
            this.Name = "ClienteCadastro";
            this.Nome_janela = "Cliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.PessoaNovo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        #region Windows Form Designer generated code
        //private ProjetoBase.CustomControl.TextboxLabelCC txt_nome;
        //private ProjetoBase.CustomControl.TextboxLabelCC txt_codigo;
        //private ProjetoBase.CustomControl.TextboxLabelCC txt_cpfCnpj;
        //private ProjetoBase.CustomControl.TextboxLabelCC txt_rgIe;
        //private ProjetoBase.CustomControl.TextboxLabelCC txt_dataNascFund;
        //private ProjetoBase.CustomControl.TextboxLabelCC txt_endereco;
        //private ProjetoBase.CustomControl.TextboxLabelCC txt_contato;
        //private ProjetoBase.CustomControl.TextboxLabelCC txt_email;
        //private ProjetoBase.CustomControl.TextboxLabelCC txt_outros;
        private ProjetoBase.CustomControl.BotaoCC btn_cadastrar;
        private ProjetoBase.CustomControl.BotaoCC btn_cancelar;
        private System.Windows.Forms.Panel panel_cliente;




        #endregion

        private CustomControl.TextboxLabelCC textboxLabel_Nome;
        private CustomControl.TextboxLabelCC textboxLabel_CnpjCpf;
        private CustomControl.TextboxLabelCC textboxLabel_RgIe;
        private CustomControl.TextboxLabelCC textboxLabel_DataDeNasc;
        private CustomControl.TextboxLabelCC textboxLabel_Endereco;
        private CustomControl.TextboxLabelCC textboxLabel_Email;
        private CustomControl.TextboxLabelCC textboxLabel_Contato;
        private CustomControl.TextboxLabelCC textboxLabel_Outros;
    }
}
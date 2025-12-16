using ProjetoBase.CustomControl;

namespace ProjetoBase.Formularios
{
    partial class CargoAlterar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>

        #region Windows Form Designer generated code

        private System.ComponentModel.IContainer components = null;
        private ProjetoBase.CustomControl.BotaoCC btn_alterar;
        private ProjetoBase.CustomControl.BotaoCC btn_cancelar;
        private System.Windows.Forms.Panel panel_cargo;
        private CustomControl.TextboxLabelCC textboxLabel_Nome;
        private CustomControl.TextboxLabelCC textboxLabel_Codigo;

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
            this.panel_cargo = new System.Windows.Forms.Panel();
            this.textboxLabel_Nome = new ProjetoBase.CustomControl.TextboxLabelCC();
            this.textboxLabel_Codigo = new ProjetoBase.CustomControl.TextboxLabelCC();
            this.btn_cancelar = new ProjetoBase.CustomControl.BotaoCC();
            this.btn_alterar = new ProjetoBase.CustomControl.BotaoCC();
            this.SuspendLayout();
            // 
            // panel_cargo
            // 
            this.panel_cargo.Location = new System.Drawing.Point(4, 2);
            this.panel_cargo.Name = "panel_cargo";
            this.panel_cargo.Size = new System.Drawing.Size(303, 86);
            this.panel_cargo.TabIndex = 0;
            // 
            // textboxLabel_Nome
            // 
            this.textboxLabel_Nome.Caixa = System.Windows.Forms.CharacterCasing.Upper;
            this.textboxLabel_Nome.CorLabel = System.Drawing.Color.Black;
            this.textboxLabel_Nome.Location = new System.Drawing.Point(64, 112);
            this.textboxLabel_Nome.MultiLinha = false;
            this.textboxLabel_Nome.Name = "textboxLabel_Nome";
            this.textboxLabel_Nome.NomeDisplay = "Nome";
            this.textboxLabel_Nome.Obrigatorio = false;
            this.textboxLabel_Nome.PedirSenhaAlterarSomenteLeitura = true;
            this.textboxLabel_Nome.PermitirAlterarSomenteLeitura = false;
            this.textboxLabel_Nome.PermitirValorNegativo = false;
            this.textboxLabel_Nome.Senha = false;
            this.textboxLabel_Nome.Size = new System.Drawing.Size(305, 42);
            this.textboxLabel_Nome.SomenteLeitura = false;
            this.textboxLabel_Nome.TabIndex = 3;
            this.textboxLabel_Nome.TamanhoMaximo = 255;
            this.textboxLabel_Nome.TamanhoTextBox = null;
            this.textboxLabel_Nome.Texto = null;
            this.textboxLabel_Nome.TipoTextBox = ProjetoBase.Enumeradores.TipoTextBox.Texto;
            this.textboxLabel_Nome.Paint += new System.Windows.Forms.PaintEventHandler(this.textboxLabel_Nome_Paint);
            // 
            // textboxLabel_Codigo
            // 
            this.textboxLabel_Codigo.Caixa = System.Windows.Forms.CharacterCasing.Upper;
            this.textboxLabel_Codigo.CorLabel = System.Drawing.Color.Black;
            this.textboxLabel_Codigo.Location = new System.Drawing.Point(64, 57);
            this.textboxLabel_Codigo.MultiLinha = false;
            this.textboxLabel_Codigo.Name = "textboxLabel_Codigo";
            this.textboxLabel_Codigo.NomeDisplay = "Codigo";
            this.textboxLabel_Codigo.Obrigatorio = false;
            this.textboxLabel_Codigo.PedirSenhaAlterarSomenteLeitura = true;
            this.textboxLabel_Codigo.PermitirAlterarSomenteLeitura = false;
            this.textboxLabel_Codigo.PermitirValorNegativo = false;
            this.textboxLabel_Codigo.Senha = false;
            this.textboxLabel_Codigo.Size = new System.Drawing.Size(51, 38);
            this.textboxLabel_Codigo.SomenteLeitura = true;
            this.textboxLabel_Codigo.TabIndex = 9;
            this.textboxLabel_Codigo.TamanhoMaximo = 255;
            this.textboxLabel_Codigo.TamanhoTextBox = null;
            this.textboxLabel_Codigo.Texto = null;
            this.textboxLabel_Codigo.TipoTextBox = ProjetoBase.Enumeradores.TipoTextBox.Texto;
            this.textboxLabel_Codigo.Paint += new System.Windows.Forms.PaintEventHandler(this.textboxLabel_Outros_Paint);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btn_cancelar.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_cancelar.Location = new System.Drawing.Point(221, 190);
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
            this.btn_alterar.Location = new System.Drawing.Point(64, 190);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.NivelDeAcesso = null;
            this.btn_alterar.Size = new System.Drawing.Size(140, 35);
            this.btn_alterar.TabIndex = 1;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.TipoBotao = ProjetoBase.Enumeradores.TipoBotao.Alterar;
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // CargoAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BotaoEnter = this.btn_alterar;
            this.BotaoEscape = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(435, 240);
            this.Controls.Add(this.textboxLabel_Codigo);
            this.Controls.Add(this.textboxLabel_Nome);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_alterar);
            this.Name = "CargoAlterar";
            this.Nome_janela = "Cargo";
            this.Text = "Cargo";
            this.Load += new System.EventHandler(this.PessoaNovo_Load);
            this.ResumeLayout(false);

        }

        #endregion       

    }
}
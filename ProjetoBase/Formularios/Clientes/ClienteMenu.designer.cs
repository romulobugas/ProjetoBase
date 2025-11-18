using ProjetoBase.Config;
using TecnoCart.CustomControls.Input;
using TecnoCart.CustomControls.Input.BotaoNavegacao;

namespace ProjetoBase.Formularios
{
    partial class ClienteMenu
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
            this.dgv_cliente = new ProjetoBase.CustomControls.Input.DataGridViewCC();
            this.BarraLateralBotoes = new TecnoCart.CustomControls.Input.FlowLayoutPanelBotoesCC();
            this.btn_cadastrar = new TecnoCart.CustomControls.Input.BotaoNavegacao.BotaoAcaoCC();
            this.btn_alterar = new TecnoCart.CustomControls.Input.BotaoNavegacao.BotaoAcaoCC();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CpfCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_cliente
            // 
            this.dgv_cliente.AllowUserToAddRows = false;
            this.dgv_cliente.AllowUserToResizeRows = false;
            this.dgv_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.CpfCnpj,
            this.Column4,
            this.Column2});
            this.dgv_cliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_cliente.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_cliente.Location = new System.Drawing.Point(90, 24);
            this.dgv_cliente.MultiSelect = false;
            this.dgv_cliente.Name = "dgv_cliente";
            this.dgv_cliente.NomeDisplay = null;
            this.dgv_cliente.Obrigatorio = false;
            this.dgv_cliente.RowHeadersVisible = false;
            this.dgv_cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cliente.Size = new System.Drawing.Size(1814, 1018);
            this.dgv_cliente.SomenteLeitura = false;
            this.dgv_cliente.TabIndex = 4;
            this.dgv_cliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pessoa_CellContentClick);
            this.dgv_cliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pessoa_CellDoubleClick);
            // 
            // BarraLateralBotoes
            // 
            this.BarraLateralBotoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.BarraLateralBotoes.BotoesAcao = new TecnoCart.CustomControls.Input.BotaoNavegacao.BotaoAcaoCC[] {
        this.btn_cadastrar,
        this.btn_alterar};
            this.BarraLateralBotoes.ConfigurarAtalho = false;
            this.BarraLateralBotoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarraLateralBotoes.Location = new System.Drawing.Point(0, 24);
            this.BarraLateralBotoes.Name = "BarraLateralBotoes";
            this.BarraLateralBotoes.Size = new System.Drawing.Size(90, 1018);
            this.BarraLateralBotoes.TabIndex = 10;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(0, 0);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.NivelDeAcesso = null;
            this.btn_cadastrar.Size = new System.Drawing.Size(0, 0);
            this.btn_cadastrar.TabIndex = 0;
            this.btn_cadastrar.Tamanho = null;
            this.btn_cadastrar.Text = "botaoNavegacaoCC1";
            this.btn_cadastrar.TipoBotao = ProjetoBase.Enumeradores.EnumTipoBotaoAcao.Cadastrar;
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(0, 0);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.NivelDeAcesso = null;
            this.btn_alterar.Size = new System.Drawing.Size(0, 0);
            this.btn_alterar.TabIndex = 0;
            this.btn_alterar.Tamanho = null;
            this.btn_alterar.Text = "botaoNavegacaoCC2";
            this.btn_alterar.TipoBotao = ProjetoBase.Enumeradores.EnumTipoBotaoAcao.Alterar;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ENTIDADE";
            this.Column1.HeaderText = "ENTIDADE";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // CpfCnpj
            // 
            this.CpfCnpj.DataPropertyName = "CPFCNPJ";
            this.CpfCnpj.HeaderText = "CpfCnpj";
            this.CpfCnpj.Name = "CpfCnpj";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ID";
            this.Column4.HeaderText = "Codigo";
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NOME";
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.Width = 600;
            // 
            // ClienteMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1042);
            this.Controls.Add(this.dgv_cliente);
            this.Controls.Add(this.BarraLateralBotoes);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ClienteMenu";
            this.Nome_janela = "Cliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.PessoaMenu_Load);
            this.Controls.SetChildIndex(this.BarraLateralBotoes, 0);
            this.Controls.SetChildIndex(this.dgv_cliente, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.Input.DataGridViewCC dgv_cliente;
        private FlowLayoutPanelBotoesCC BarraLateralBotoes;
        private BotaoAcaoCC btn_cadastrar;
        private BotaoAcaoCC btn_alterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CpfCnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
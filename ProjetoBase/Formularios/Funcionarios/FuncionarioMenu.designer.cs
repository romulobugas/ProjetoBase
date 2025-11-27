using ProjetoBase.Config;
using TecnoCart.CustomControl.Input;
using TecnoCart.CustomControl.Input.BotaoNavegacao;

namespace ProjetoBase.Formularios
{
    partial class FuncionarioMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private CustomControl.Input.DataGridViewCC dgv_funcionario;
        private FlowLayoutPanelBotoesCC BarraLateralBotoes;
        private BotaoAcaoCC btn_cadastrar;
        private BotaoAcaoCC btn_alterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;

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
            this.dgv_funcionario = new ProjetoBase.CustomControl.Input.DataGridViewCC();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarraLateralBotoes = new TecnoCart.CustomControl.Input.FlowLayoutPanelBotoesCC();
            this.btn_cadastrar = new TecnoCart.CustomControl.Input.BotaoNavegacao.BotaoAcaoCC();
            this.btn_alterar = new TecnoCart.CustomControl.Input.BotaoNavegacao.BotaoAcaoCC();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_funcionario
            // 
            this.dgv_funcionario.AllowUserToAddRows = false;
            this.dgv_funcionario.AllowUserToResizeRows = false;
            this.dgv_funcionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_funcionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2});
            this.dgv_funcionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_funcionario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_funcionario.Location = new System.Drawing.Point(90, 24);
            this.dgv_funcionario.MultiSelect = false;
            this.dgv_funcionario.Name = "dgv_funcionario";
            this.dgv_funcionario.NomeDisplay = null;
            this.dgv_funcionario.Obrigatorio = false;
            this.dgv_funcionario.RowHeadersVisible = false;
            this.dgv_funcionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_funcionario.Size = new System.Drawing.Size(1814, 1018);
            this.dgv_funcionario.SomenteLeitura = false;
            this.dgv_funcionario.TabIndex = 4;
            this.dgv_funcionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pessoa_CellContentClick);
            this.dgv_funcionario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pessoa_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ENTIDADE";
            this.Column1.HeaderText = "ENTIDADE";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
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
            // BarraLateralBotoes
            // 
            this.BarraLateralBotoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.BarraLateralBotoes.BotoesAcao = new TecnoCart.CustomControl.Input.BotaoNavegacao.BotaoAcaoCC[] {
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
            // CargoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1042);
            this.Controls.Add(this.dgv_funcionario);
            this.Controls.Add(this.BarraLateralBotoes);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CargoMenu";
            this.Nome_janela = "Cargo";
            this.Text = "Cargo";
            this.Load += new System.EventHandler(this.PessoaMenu_Load);
            this.Controls.SetChildIndex(this.BarraLateralBotoes, 0);
            this.Controls.SetChildIndex(this.dgv_funcionario, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}
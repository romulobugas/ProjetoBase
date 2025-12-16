using ProjetoBase.CustomControl;
using ProjetoBase.CustomControl.Validacao;
using ProjetoBase.DataBase.Dominio.Funcionario;
using ProjetoBase.DataBase.Ferramentas;
using ProjetoBase.Enumeradores;
using System;
using System.Collections.Generic;

namespace ProjetoBase.Formularios
{
    public partial class FuncionarioAlterar : FormCC
    {
        Funcionario funcionario = null;

        public FuncionarioAlterar(Funcionario funcionario)
        {
            InitializeComponent();
            this.funcionario = funcionario;
            carregarFuncionario();
        }

        public void carregarFuncionario()
        {
            if (funcionario != null)
            {
                textboxLabel_Nome.Texto = funcionario.Nome;
                textboxLabel_Cpf.Texto = funcionario.Cpf;
                textboxLabel_Rg.Texto = funcionario.Rg;
                textboxLabel_Telefone.Texto = funcionario.Telefone;
                textboxLabel_Email.Texto = funcionario.Email;
                textboxLabel_DataAdmissao.Texto = funcionario.DataAdmissao?.ToString("dd/MM/yyyy");

                btn_alterar.TipoBotao = TipoBotao.Alterar;
            }
        }

        private void PessoaNovo_Load(object sender, EventArgs e)
        {

        }
      
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                var mensagensErro = new List<string>();

                RetornoValidacaoDados retorno = ValidacaoDadosObrigatorios.validarPanelObrigatorio(panel_funcionario);
                if (retorno.Valido)
                {
                    Repositorios.Funcionario.ProcurarPorID(funcionario.Id);

                    if (funcionario.Id != 0)
                    {
                        funcionario.Nome = textboxLabel_Nome.Texto;
                        funcionario.Cpf = textboxLabel_Cpf.Texto;
                        funcionario.Rg = textboxLabel_Rg.Texto;
                        funcionario.Telefone = textboxLabel_Telefone.Texto;
                        funcionario.Email = textboxLabel_Email.Texto;

                        if (textboxLabel_DataAdmissao.Texto.TryConvertToDate(out DateTime data))
                        {
                            if (data != default)
                            {
                                funcionario.DataAdmissao = DateTime.TryParse(textboxLabel_DataAdmissao.Texto, out var dataAd)
                                               ? data
                                               : (DateTime?)null;
                            }
                        }
                        else
                        {
                            mensagensErro.Add("Data incompleta, preencha dia, mês e ano.");
                        }

                        EnumResultadoQuery retornoQuery = Repositorios.Funcionario.Salvar(funcionario);
                        DispararEventoSalvo(funcionario);
                        mostrarMensagemResultado(retornoQuery);           
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            cancelarEdicao(funcionario);
        }

        private void btn_add_tipo_ato_Click(object sender, EventArgs e)
        {

        }

        private void txt_codigo_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void textboxLabel_Nome_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void textboxLabel_Outros_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void botaoCC1_Click(object sender, EventArgs e)
        {

        }
    }
}

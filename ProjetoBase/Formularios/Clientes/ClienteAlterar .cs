using ProjetoBase.CustomControls;
using ProjetoBase.CustomControls.Validacao;
using ProjetoBase.DataBase.Dominio.Cliente;
using ProjetoBase.DataBase.Ferramentas;
using ProjetoBase.Enumeradores;
using System;

namespace ProjetoBase.Formularios
{
    public partial class ClienteAlterar : FormCC
    {
        Cliente cliente = null;

        public ClienteAlterar(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            carregarCliente();
        }

        //Carrega dados de um Cliente se ja cadastrado
        public void carregarCliente()
        {
            if (cliente != null)
            {
                //txt_codigo.Name = cliente.Codigo;
                textboxLabel_Nome.Texto = cliente.Nome;
                textboxLabel_CnpjCpf.Texto = cliente.CpfCnpj;
                textboxLabel_RgIe.Texto = cliente.RgIe;
                textboxLabel_DataDeNasc.Texto = cliente.DataNascFund?.ToString("dd/MM/yyyy");
                textboxLabel_Endereco.Texto = cliente.Endereço;
                textboxLabel_Contato.Texto = cliente.Contato;
                textboxLabel_Email.Texto = cliente.Email;
                textboxLabel_Outros.Texto = cliente.Outros;

                btn_alterar.TipoBotao = TipoBotao.Alterar;
            }
        }

        private void PessoaNovo_Load(object sender, EventArgs e)
        {

        }

        //Alterar cliente      
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                RetornoValidacaoDados retorno = ValidacaoDadosObrigatorios.validarPanelObrigatorio(panel_cliente);
                if (retorno.Valido)
                {
                    Repositorios.Cliente.ProcurarPorID(cliente.Id);

                    if (cliente.Id != 0)
                    {
                        cliente.Nome = textboxLabel_Nome.Texto;
                        cliente.CpfCnpj = textboxLabel_CnpjCpf.Texto;
                        cliente.RgIe = textboxLabel_RgIe.Texto;
                        cliente.Endereço = textboxLabel_Endereco.Texto;
                        cliente.Contato = textboxLabel_Contato.Texto;
                        cliente.Email = textboxLabel_Email.Texto;
                        cliente.Outros = textboxLabel_Outros.Texto;
                        cliente.DataNascFund = DateTime.TryParse(textboxLabel_DataDeNasc.Texto, out var data)
                                               ? data
                                               : (DateTime?)null;

                        EnumResultadoQuery retornoQuery = Repositorios.Cliente.Salvar(cliente);
                        DispararEventoSalvo(cliente);
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
            cancelarEdicao(cliente);
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

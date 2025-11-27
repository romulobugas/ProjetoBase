using ProjetoBase.CustomControl;
using ProjetoBase.CustomControl.Validacao;
using ProjetoBase.DataBase.Dominio.Funcionario;
using ProjetoBase.DataBase.Ferramentas;
using ProjetoBase.Enumeradores;
using System;
using System.Windows.Forms;

namespace ProjetoBase.Formularios
{
    public partial class FuncionarioCadastro : FormCC
    {
        Funcionario funcionario = null;

        public FuncionarioCadastro(Funcionario funcionario)
        {
            InitializeComponent();
            this.funcionario = funcionario;
            carregarFuncionario();
        }

        //Carrega dados de um Cargo se ja cadastrado
        public void carregarFuncionario()
        {
            if (funcionario != null)
            {
                txt_codigo.Texto = funcionario.Codigo;
                txt_nome.Texto = funcionario.Nome;
                btn_cadastrar.TipoBotao = TipoBotao.Salvar;
            }
        }

        private void PessoaNovo_Load(object sender, EventArgs e)
        {

        }

        //Cadastrar ou salvar cargo
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            RetornoValidacaoDados retorno = ValidacaoDadosObrigatorios.validarPanelObrigatorio(panel_funcionario);
            if (retorno.Valido)
            {
                funcionario = new Funcionario();
                funcionario.Nome = txt_nome.Texto;

                EnumResultadoQuery retornoQuery = Repositorios.Funcionario.Salvar(funcionario);
                DispararEventoSalvo(funcionario);
                mostrarMensagemResultado(retornoQuery);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            cancelarEdicao(funcionario);
        }

        private void btn_add_tipo_ato_Click(object sender, EventArgs e)
        {

        }

        private void txt_codigo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_nome_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

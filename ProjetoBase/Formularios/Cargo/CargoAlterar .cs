using ProjetoBase.CustomControl;
using ProjetoBase.CustomControl.Validacao;
using ProjetoBase.DataBase.Dominio.Funcionario;
using ProjetoBase.DataBase.Ferramentas;
using ProjetoBase.Enumeradores;
using System;

namespace ProjetoBase.Formularios
{
    public partial class CargoAlterar : FormCC
    {
        Cargo cargo = null;

        public CargoAlterar(Cargo cargo)
        {
            InitializeComponent();
            this.cargo = cargo;
            carregarCargo();
        }

        //Carrega dados de um Cliente se ja cadastrado
        public void carregarCargo()
        {
            if (cargo != null)
            {
                textboxLabel_Nome.Texto = cargo.Nome;
                textboxLabel_Codigo.Texto = cargo.Codigo;

                btn_alterar.TipoBotao = TipoBotao.Alterar;
            }
        }

        private void PessoaNovo_Load(object sender, EventArgs e)
        {

        }

        //Cargo Alterar      
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                RetornoValidacaoDados retorno = ValidacaoDadosObrigatorios.validarPanelObrigatorio(panel_cargo);
                if (retorno.Valido)
                {
                    Repositorios.Cargo.ProcurarPorID(cargo.Id);

                    if (cargo.Id != 0)
                    {
                        cargo.Nome = textboxLabel_Nome.Texto;

                        EnumResultadoQuery retornoQuery = Repositorios.Cargo.Salvar(cargo);
                        DispararEventoSalvo(cargo);
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
            cancelarEdicao(cargo);
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

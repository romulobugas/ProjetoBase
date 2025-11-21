using ProjetoBase.DataBase.Dominio.Funcionario;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoBase.Ferramentas
{
    public static class SessaoSistema
    {
        public static Funcionario funcionario = null;
        public static string ChaveLevontec = null;

        //public static List<EnumTipoBotaoAtalho> BotoesAtalho;


        public static Point posicaoNotificacaoChat;
        internal static bool emailAvisoHandlersEnviado = false;
        public static string modulo;

        public static Point PosicaoForm { get; internal set; }
        public static Size TamanhoForm { get; internal set; }
        public static int SavesSemCommit { get; internal set; }

        public static FormWindowState WindowStateForm = FormWindowState.Maximized;
 

 



    }


}

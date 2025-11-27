using ProjetoBase.Enumeradores;
using ProjetoBase.DataBase.Dominio.Funcionario;
using System;
using System.Linq;
using ProjetoBase.CustomControl;

namespace ProjetoBase.Formularios
{
    public partial class MenuInicial : MenuCC
    {
        private Usuario _usuarioLogado;

        public MenuInicial(Usuario usuario) : base(ConverterUsuarioParaNivel(usuario))  
        {
            _usuarioLogado = usuario;
        }

        private void MenuInicial_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Converte o Usuario do banco para o EnumNivelDeAcesso usado pelo menu.
        /// Ajuste o mapeamento conforme sua modelagem (PerfilDeAcesso / NivelDeAcesso).
        /// </summary>
        private static EnumNivelDeAcesso ConverterUsuarioParaNivel(Usuario usuario)
        {
            if (usuario == null)
                return EnumNivelDeAcesso.CRM; // fallback mínimo

            // 1) Administrador global (campo bool)
            if (usuario.Administrador)
                return EnumNivelDeAcesso.Administrador;

            // 2) Perfil de acesso definido no banco
            // PERFIL_DE_ACESSO (Id → nome → enum)
            if (usuario.PerfilDeAcesso != null)
            {
                switch (usuario.PerfilDeAcesso.Id)
                {
                    case 1:  // Administração
                        return EnumNivelDeAcesso.Administrador;

                    case 2:  // Recursos Humanos
                        return EnumNivelDeAcesso.RecursosHumanos;

                    case 3:  // Vendas (CRM)
                        return EnumNivelDeAcesso.CRM;
                }
            }

            // 3) Níveis adicionais na tabela NIVEL_DE_ACESSO (se usar essa também)
            if (usuario.NivelDeAcesso != null && usuario.NivelDeAcesso.Count > 0)
            {
                // presume que NivelDeAcesso.Id corresponde ao EnumNivelDeAcesso
                var nivel = usuario.NivelDeAcesso.First();
                return (EnumNivelDeAcesso)nivel.Id;
            }

            // 4) fallback
            return EnumNivelDeAcesso.CRM;
        }
    }
}

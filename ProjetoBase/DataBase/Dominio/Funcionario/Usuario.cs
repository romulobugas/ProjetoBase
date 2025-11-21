using System;
using System.Collections.Generic;

namespace ProjetoBase.DataBase.Dominio.Funcionario
{
    [Serializable]
    public class Usuario : Funcionario
    {
        public virtual int Id { get; set; }
        public virtual String Login { get; set; }
        public virtual String Senha { get; set; }
        public virtual Boolean Administrador { get; set; }
        public virtual PerfilDeAcesso PerfilDeAcesso { get; set; }
        public virtual ISet<NivelDeAcesso> NivelDeAcesso { get; set; }
        public virtual Boolean ResetarSenha { get; set; }
        public virtual Boolean ReceberAlertas { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        public virtual string IpHost { get; set; }

        public Usuario()
        {
            NivelDeAcesso = new HashSet<NivelDeAcesso>();
        }
    }
}

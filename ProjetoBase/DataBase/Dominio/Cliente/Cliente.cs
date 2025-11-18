using ProjetoBase.DataBase.Dominio.Interface;
using ProjetoBase.DataBase.Interface;
using System;

namespace ProjetoBase.DataBase.Dominio.Cliente
{
    [Serializable]
    public class Cliente : Entidade, DeletavelInterface
    {
        public virtual int Id { get; set; }
        public virtual String Nome { get; set; }

        public virtual string Codigo
        {
            get { return Id.ToString(); }
        }

        public virtual string Descricao
        {
            get { return Nome; }
        }
        public virtual Entidade Proprio
        {
            get { return this; }
        }
        public virtual bool deletavel()
        {
            return true;
        }

        public virtual string CpfCnpj { get; set; }
        public virtual string RgIe { get; set; }
        public virtual DateTime? DataNascFund { get; set; }
        public virtual string Endereço { get; set; }
        public virtual string Contato { get; set; }
        public virtual string Email { get; set; }
        public virtual string Outros { get; set; }
    }
}

using FluentNHibernate.Mapping;
using ProjetoBase.DataBase.Dominio.Cliente;

namespace ProjetoBase.DataBase.Mapeamento
{
    class ClienteMap : ClassMap<Cliente>
    {
        public ClienteMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Nome);
            Map(x => x.CpfCnpj).Unique().Not.Nullable();
            Map(x => x.RgIe);
            Map(x => x.DataNascFund);
            Map(x => x.Endereço);
            Map(x => x.Contato);
            Map(x => x.Email);
            Map(x => x.Outros);
            Table("CLIENTE");            
        }
    }
}

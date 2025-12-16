using FluentNHibernate.Mapping;
using ProjetoBase.API.Domain.Cliente;

namespace ProjetoBase.API.Mapping;

public class ClienteMap : ClassMap<Cliente>
{
    public ClienteMap()
    {
        Table("CLIENTE");

        Id(x => x.Id).GeneratedBy.Identity();
        Map(x => x.Nome);
        Map(x => x.CpfCnpj).Unique().Not.Nullable();
        Map(x => x.RgIe);
        Map(x => x.DataNascFund);
        Map(x => x.Endereco).Column("Endereço");
        Map(x => x.Contato);
        Map(x => x.Email);
        Map(x => x.Observacoes).Column("Outros");
    }
}

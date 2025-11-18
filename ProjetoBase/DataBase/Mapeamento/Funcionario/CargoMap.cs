using FluentNHibernate.Mapping;
using ProjetoBase.DataBase.Dominio.Funcionario;

namespace ProjetoBase.DataBase.Mapeamento
{
    class CargoMap : ClassMap<Cargo>
    {
        public CargoMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Nome).Length(10);
            Table("CARGO");            
        }
    }
}

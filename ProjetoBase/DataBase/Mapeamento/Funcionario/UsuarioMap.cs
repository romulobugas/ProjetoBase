using FluentNHibernate.Mapping;
using ProjetoBase.DataBase.Dominio.Funcionario;

namespace ProjetoBase.DataBase.Mapeamento
{            
    class UsuarioMap : ClassMap<Usuario>
    {
        public UsuarioMap()
        {            
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Login).Unique();
            Map(x => x.Senha);
            Map(x => x.Administrador);
            References(x => x.PerfilDeAcesso, "PERFIL_DE_ACESSO_ID").Cascade.None();
            HasManyToMany(x => x.NivelDeAcesso).ParentKeyColumn("USUARIO_ID").ChildKeyColumn("NIVEL_ACESSO_ID").Table("NIVEL_ACESSO_USUARIO").Cascade.None();
            Map(x => x.ResetarSenha);
            Map(x => x.ReceberAlertas);
            References(x => x.Funcionario, "FUNCIONARIO_ID").Cascade.None().Unique();

            Table("USUARIO");
        }
    }
}

using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Driver;
using ProjetoBase.API.Mapping;

namespace ProjetoBase.API.Startup;

public static class NhSessionFactoryBuilder
{
    public static ISessionFactory Build(IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Default");

        if (string.IsNullOrWhiteSpace(connectionString))
        {
            throw new InvalidOperationException("Connection string 'Default' must be configured for the API.");
        }

        return Fluently.Configure()
            .Database(MsSqlConfiguration.MsSql2012
                .ConnectionString(connectionString)
                .Driver<SqlClientDriver>())
            .Mappings(m => m.FluentMappings.AddFromAssemblyOf<ClienteMap>())
            .ExposeConfiguration(cfg => cfg.SetProperty("command_timeout", "300"))
            .BuildSessionFactory();
    }
}

using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Dialect;
using NHibernate.Mapping.ByCode;

namespace ProjetoNHibernateApi.Models.Infra.Data.Extensions;

public static class NHibernateExtensions
{
    public static IServiceCollection AddNHibernate(this IServiceCollection services, string connectionStrig)
    {
        var mapper = new ModelMapper();
        mapper.AddMappings(typeof(NHibernateExtensions).Assembly.ExportedTypes);
        HbmMapping entityMapping = mapper.CompileMappingForAllExplicitlyAddedEntities();

        var configuration = new Configuration();
        string rootDir = Directory.GetCurrentDirectory();
        string mapFile = $"{rootDir}\\Mappings\\Cliente.hbm.xml";
        configuration.AddFile(mapFile);

        configuration.DataBaseIntegration(c =>
        {
            c.Dialect<MsSql2012Dialect>();
            c.ConnectionString = connectionStrig;
            c.KeywordsAutoImport = Hbm2DDLKeyWords.AutoQuote;
            c.SchemaAction = SchemaAutoAction.Update;
            c.LogFormattedSql = true;
            c.LogSqlInConsole = true;
        });
        configuration.AddMapping(entityMapping);
        var sessionFactory = configuration.BuildSessionFactory();
        services.AddSingleton(sessionFactory);
        services.AddScoped(factory => sessionFactory.OpenSession());
        return services;
    }
}

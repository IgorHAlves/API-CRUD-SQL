using ProjetoNHibernateApi.Models.Infra.Data.Extensions;
using ProjetoNHibernateApi.Models.Infra.Data.Repositories;
using ProjetoNHibernateApi.Models.Services;

namespace ProjetoNHibernateApi.Models.IoC
{
    public static class ProjetoNHibernateApiconfig
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            string connStr = configuration.GetConnectionString("clienteDB");

            services.AddNHibernate(connStr);

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IClienteService, ClienteService>();
        }                      
    }
}

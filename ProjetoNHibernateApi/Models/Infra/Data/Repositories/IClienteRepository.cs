using ProjetoNHibernateApi.Models.Domain.Contracts;
using ProjetoNHibernateApi.Models.Domain.Entities;

namespace ProjetoNHibernateApi.Models.Infra.Data.Repositories
{
    public interface IClienteRepository : IGenericRepoService<Cliente, int>
    {
    }
}

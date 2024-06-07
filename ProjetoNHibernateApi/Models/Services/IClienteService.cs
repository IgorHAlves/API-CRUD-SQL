using ProjetoNHibernateApi.Models.Domain.Contracts;
using ProjetoNHibernateApi.Models.Domain.Entities;

namespace ProjetoNHibernateApi.Models.Services
{
    public interface IClienteService : IGenericRepoService<Cliente, int>
    {
    }
}

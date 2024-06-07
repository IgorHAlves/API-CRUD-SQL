using NHibernate;
using ProjetoNHibernateApi.Models.Domain.Entities;
using ISession = NHibernate.ISession;

namespace ProjetoNHibernateApi.Models.Infra.Data.Repositories;

public class ClienteRepository : IClienteRepository
{
    private readonly ISession _session;

    public ClienteRepository(ISession session)
    {

    _session = session;
    }
    public async Task Atualizar(Cliente cliente)
    {
        ITransaction transaction = null;
        try
        {
            transaction = _session.BeginTransaction();
            await _session.UpdateAsync(cliente);
            await transaction.CommitAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            await transaction?.RollbackAsync();
        }
        finally
        {
            transaction?.Dispose();
        }
    }

    public async Task Cadastrar(Cliente cliente)
    {
        ITransaction transaction = null;
        try
        {
            transaction = _session.BeginTransaction();
            await _session.SaveAsync(cliente);
            await transaction.CommitAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            await transaction?.RollbackAsync();
        }
        finally
        {
            transaction?.Dispose();
        }
    }

    public async Task Excluir(int id)
    {
        ITransaction transaction = null;
        try
        {
            transaction = _session.BeginTransaction();
            var item = await _session.GetAsync<Cliente>(id);
            await _session.DeleteAsync(item);
            await transaction.CommitAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            await transaction?.RollbackAsync();
        }
        finally
        {
            transaction?.Dispose();
        }
    }

    public List<Cliente> Listar()
    {
        var result = _session.Query<Cliente>().ToList();
        return result;
    }
 
    public Cliente PesquisaPorID(int id)
    {
        var result = _session.Get<Cliente>(id);
        return result;
    }

    //public Cliente PesquisaPorNome(string nome)
    //{
    //    var result = _session.Get<Cliente>(nome);
    //    return result;
    //}
}

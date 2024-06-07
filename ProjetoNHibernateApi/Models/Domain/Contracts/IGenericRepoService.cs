namespace ProjetoNHibernateApi.Models.Domain.Contracts
{
    public interface IGenericRepoService <T, Y>
    {
        Task Cadastrar(T entidade);
        Task Atualizar(T entidade);
        Task Excluir(Y id);
        T PesquisaPorID(Y id);
        //T PesquisaPorNome(string nome);
        List<T> Listar();
    }
}

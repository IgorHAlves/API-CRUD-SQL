using ProjetoNHibernateApi.Models.Domain.Contracts;
using ProjetoNHibernateApi.Models.Domain.Entities;
using ProjetoNHibernateApi.Models.Infra.Data.Repositories;

namespace ProjetoNHibernateApi.Models.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public async Task Atualizar(Cliente entidade)
        {
            await _clienteRepository.Atualizar(entidade);
        }

        public async Task Cadastrar(Cliente entidade)
        {
            await _clienteRepository.Cadastrar(entidade);
        }

        public async Task Excluir(int id)
        {
            await _clienteRepository.Excluir(id);
        }

        public List<Cliente> Listar()
        {
            var result = _clienteRepository.Listar();
            return result;
        }

        public Cliente PesquisaPorID(int id)
        {
            var result = _clienteRepository.PesquisaPorID(id);
            return result;
        }

        //public Cliente PesquisaPorNome(string nome)
        //{
        //    var result = _clienteRepository.PesquisaPorNome(nome);
        //    return result;
        //}

    }
}

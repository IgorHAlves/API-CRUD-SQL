using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoNHibernateApi.Models.Domain.Entities;
using ProjetoNHibernateApi.Models.Services;

namespace ProjetoNHibernateApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;
        
        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }
        [HttpPost]
        
        public async Task<IActionResult> Cadastrar(int? id, string nome, string datanascimento, string email, int divida)
        {
            Cliente cliente = new Cliente() {  Id = Convert.ToInt32(id), Nome = nome, DataNascimento = datanascimento, Email = email, Divida = divida};
            await _clienteService.Cadastrar(cliente);
            return Ok("Cadastro realizado com sucesso!");

        }

        [HttpPut]
        public async Task<IActionResult> Atualizar(int id, string nome, string datanascimento, string email, int divida)
        {
            Cliente cliente = new Cliente() { Id = id, Nome = nome, DataNascimento = datanascimento, Email = email, Divida = divida };
            await _clienteService.Atualizar(cliente);
            return Ok("Atualização realizada com sucesso");

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoverCliente(int id)
        {
            await _clienteService.Excluir(id);
            return Ok();

        }

        [HttpGet]
        public IActionResult Listar()
        {
            var clientes = _clienteService.Listar();
            return Ok(clientes);

        }

        [HttpGet("{id}")]

        public IActionResult PesquisarPorID(int id)
        {
            var cliente = _clienteService.PesquisaPorID(id);
            if (cliente == null)
                return NotFound();

            return Ok(cliente);

        }

        //[HttpGet("{nome}")]

        //public IActionResult PesquisaPorNome(string nome)
        //{
        //    var cliente = _clienteService.PesquisaPorNome(nome);
        //    if (cliente == null)
        //        return NotFound();

        //    return Ok(cliente);

        //}
    }
}

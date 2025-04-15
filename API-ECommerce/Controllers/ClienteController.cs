using API_ECommerce.Context;
using API_ECommerce.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_ECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private IClienteRepository _clienteRepository;
        // Injecao de Dependencia
        // Ao inves de EU instanciar a classe
        // Eu aviso que DEPENDO dela 
        // E a responsabilidade de criar vem pra classe que chama (C#)
        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        [HttpGet]
        public IActionResult ListarTodos()
        {
            return Ok(_clienteRepository.ListaTodos());
        }
    }
}

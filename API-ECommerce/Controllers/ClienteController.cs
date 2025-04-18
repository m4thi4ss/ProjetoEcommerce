using API_ECommerce.Context;
using API_ECommerce.Interfaces;
using API_ECommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_ECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private IClienteRepository _clienteRepository;

        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        [HttpGet]
        public IActionResult ListarCliente()
        {
            return Ok(_clienteRepository.ListaTodos());
        }

        [HttpPost]
        public IActionResult CadastrarCliente(Cliente cli)
        {
           
            _clienteRepository.Cadastrar(cli);

            return Created();

        }
        [HttpGet("{id}")] 
        public IActionResult ListarPorId(int id) 
        {
            Cliente cliente = _clienteRepository.BuscarPorId(id); 

            if (cliente == null) 
            {
                return NotFound(); 
            }

            return Ok(cliente);  
        }

        [HttpPut("{id}")]
        public IActionResult Editar(int id, Cliente cli)
        {
            try 
            {
                _clienteRepository.Atualizar(id, cli);

                return Ok(cli);
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                _clienteRepository.Deletar(id);

                
                return NoContent();
            }
            
            catch (Exception ex)
            {
                return NotFound("Produto nao encontrado!");
            }
        }
    }
}

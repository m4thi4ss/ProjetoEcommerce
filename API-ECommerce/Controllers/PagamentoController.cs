using API_ECommerce.Context;
using API_ECommerce.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_ECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentoController : ControllerBase
    {
        private IPagamentoRepository _pagamentoRepository;

        public PagamentoController(IPagamentoRepository pagamentoRepository)
        {
            _pagamentoRepository = pagamentoRepository;
        }

        //CRIANDO METODO
        // - Definir o verbo 
        [HttpGet]
        public IActionResult ListarTodos()
        {
            return Ok(_pagamentoRepository.ListaTodos());
        }
    }
}

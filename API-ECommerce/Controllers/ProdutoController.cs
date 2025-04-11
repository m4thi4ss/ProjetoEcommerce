using API_ECommerce.Context;
using API_ECommerce.Interfaces;
using API_ECommerce.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_ECommerce.Controllers
{
    [Route("api/[controller]")] //O ROUTE SERIA A ROTA, que seria a tabela e a informacao que voce quer vericar
    [ApiController]
    public class ProdutoController : ControllerBase
    {

        private readonly EcommerceContext _context;
        private IProdutoRepository _produtoRepository;
       
        public ProdutoController(EcommerceContext context)
        {
            _context = context;
            _produtoRepository = new ProdutoRepository(_context);
        }

        // GET 

        public IActionResult ListarProdutos()
        {
            return Ok(_produtoRepository.ListarTodos());
        }

        //Aqui seria um metodo de pedido e envio da informacao do controllador. Nesse codigo voce esta pedindo para o controllador listar os produtos e ele esta retornando a lista de produtos. 
    }
}

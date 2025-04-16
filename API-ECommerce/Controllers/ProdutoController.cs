using API_ECommerce.Context;
using API_ECommerce.Interfaces;
using API_ECommerce.Models;
using API_ECommerce.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_ECommerce.Controllers
{
    [Route("api/[controller]")]//O ROUTE SERIA A ROTA, que seria a tabela e a informacao que voce quer vericar
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        // GET 
        [HttpGet]
        public IActionResult ListarProdutos()
        {
            return Ok(_produtoRepository.ListarTodos());
        }

        //Aqui seria um metodo de pedido e envio da informacao do controllador. Nesse codigo voce esta pedindo para o controllador listar os produtos e ele esta retornando a lista de produtos. 

        //Cadastrar Produto


        [HttpPost]
        public IActionResult CadastrarProduto(Produto prod)
        {
            // - Coloco o produto no Banco de Dados 
            _produtoRepository.Cadastrar(prod);

            //2- salvo a alteracao (Padrao)
            //O cadastrar foi para o repository por que ele que esta responsavel 

            //3 - Retorno o resultado 
            //201 - Created
            return Created();


            // Buscar Produto por id
            // /api/produtos
            // /api/produtos/1
        }
        [HttpGet("{id}")] //Aqui ele esta informando que o id apareca no url
        public IActionResult ListarPorId(int id) //Criando um objeto.
        {
            Produto produto = _produtoRepository.BuscarPorId(id); //Aqui ele vai buscar o id 

            if (produto == null) //Aqui ele vai ve se achou ou nao
            {
                return NotFound(); //Se nao achou ele vai lancar o erro 404
            }

            return Ok(produto); //Se achar ele vai mostrar na tela. 
        }

        [HttpPut("{id}")]
        public IActionResult Editar(int id, Produto prod )//Aqui ele ta informando que ele tem que editar que seria o id, e no Produto prod esta criando um objeto para o novo que foi atualizado
        {
            try //Aqui e se foi 
            {
                _produtoRepository.Atualizar(id, prod);

                return Ok(prod);
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
                _produtoRepository.Deletar(id);

                // 204 - Deu certo!
                return NoContent();
            }
            //Caso de erro 
            catch (Exception ex)
            {
                return NotFound("Produto nao encontrado!");
            }
        }
    }
}

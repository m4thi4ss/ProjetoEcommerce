using API_ECommerce.Context;
using API_ECommerce.Interfaces;
using API_ECommerce.Models;

namespace API_ECommerce.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        //Metodos que acessam o Banco de Dados

        //Injetar o Context - Seria jogar uma classe dentro de outra. Como por exemplo Repositorio usara informcoes coluna tabelas do repository
        //Injecao de Dependecia 
        private readonly EcommerceContext _context;

        //ctor - Ele cria um metodo COnstrutor
        //Que seria, quando criar um ojeto o que eu precidso ter?
        //Ele e criado para informar o que e obrigado a ter, como por exemplo carro, obrigaria o criador a colocar marca e ano obrigatoriamente 
        public ProdutoRepository(EcommerceContext context)
        {
             _context = context;
            //Aqui ele vai usar o processo injetar, que serve para criar um objeto context.
        }

        public void Atualizar(int id, Produto produto)
        {
            throw new NotImplementedException();
        }

        public Produto BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Produto> ListarTodos()
        {
            return _context.Produtos.ToList();
        }
    }
}

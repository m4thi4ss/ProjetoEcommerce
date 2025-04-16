using API_ECommerce.Context;
using API_ECommerce.Interfaces;
using API_ECommerce.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

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
            Produto produtoEncontrado = _context.Produtos.Find(id);

            if (produtoEncontrado == null)
            {
                throw new Exception();
            }

            //O comando abaixo ele serve para verificar se as informacoes foram mudadas, se caso for mudada ele atualiza para informacao correta, ele seria usado como por exemplo: trocar e-mail.
            produtoEncontrado.Nome = produto.Nome;
            produtoEncontrado.Descricao = produto.Descricao;
            produtoEncontrado.Preco = produto.Preco;
            produtoEncontrado.Categoria = produto.Categoria;
            produtoEncontrado.Imagem = produto.Imagem;
            produtoEncontrado.EstoqueDisponivel = produto.EstoqueDisponivel;

            _context.SaveChanges();
        }   


        public Produto BuscarPorId(int id)
        {
            // ToList() - Pegar Varios
            //FistorDefault - Traz o primeiro que Encontrar, ou null

            //Expresao lambda
            // _context.Produto - Acesso a tabela produto do Contexto do Contexto
            //FirstOrDefault - Pegue o primeiro que encontrar 
            //p => p.IdProduto == id
            //Para cada produto P, me retorne aquele que tem o IdProduto igual ao id 

            return _context.Produtos.FirstOrDefault(p => p.IdProduto == id);
        }

        public void Cadastrar(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            //1 - Encontrar o que eu quero excluir (Ele primeiro procura para verificar se a informacao certa para excluir)
            // Find - Procura pela chave primaria 
            Produto produtoEncontrado = _context.Produtos.Find(id);

            if (produtoEncontrado == null)
            {
                throw new Exception();
            }
            //Caso eu encontre o produto, remove ele 
            _context.Produtos.Remove(produtoEncontrado);

            //Esse e o metodo para salvar no banco de dados.
            _context.SaveChanges();
        }


        public List<Produto> ListarTodos()
        {
            return _context.Produtos.ToList();
        }

       
    }
}

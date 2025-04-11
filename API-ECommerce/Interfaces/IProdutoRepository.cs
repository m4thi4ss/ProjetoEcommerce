using API_ECommerce.Models;

namespace API_ECommerce.Interfaces
{
    public interface IProdutoRepository
    {
        //Metodos de CRUD
        //R - Read (Leitura)
        // Retorno
        List<Produto> ListarTodos();

        //Recebe um indentificador, e retorna o produto correspondente 
        Produto BuscarPorId(int id);

        //C - Creat (Cadastro)
        void Cadastrar(Produto produto);

        //U - Update (Atualizacao)
        //Recebe um identificador para encotrar um identificador para encontrar o Produto, e recebe o Produto Novo para substituir o Antigo
        void Atualizar(int id, Produto produto);

        //D - Delete (Delecao)
        //Recebo o identificador de quem quero excluir
        void Deletar(int id);

    }
}

using API_ECommerce.Context;
using API_ECommerce.Interfaces;
using API_ECommerce.Models;

namespace API_ECommerce.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        //1 - Herdar da Interface
        //2 - Implementar a Interface
        //3 - Injetar o Contexto 
        private EcommerceContext _context;

        public ClienteRepository(EcommerceContext context)
        {
            _context = context; 
        }

        public void Atualizar(int id, Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Cliente BuscarPorEmailSenha(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public Cliente BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ListaTodos()
        {
            throw new NotImplementedException();
        }
    }
}

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
            Cliente clienteEncontrado = _context.Clientes.Find(id);

            if (clienteEncontrado == null)
            {
                throw new Exception();
            }
            clienteEncontrado.Email = cliente.Email;
            clienteEncontrado.Telefone = cliente.Telefone;
            clienteEncontrado.Endereco = cliente.Endereco;
            clienteEncontrado.NomeCompleto = cliente.NomeCompleto;
            clienteEncontrado.DataCasdatro = cliente.DataCasdatro;

            _context.SaveChanges();
        }

        public Cliente BuscarPorEmailSenha(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public Cliente BuscarPorId(int id)
        {
            return _context.Clientes.FirstOrDefault(p => p.IdCliente == id);
        }

        public void Cadastrar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            Cliente clienteEncontrado = _context.Clientes.Find(id);

            if (clienteEncontrado == null)
            {
                throw new Exception();
            }
            //Caso eu encontre o produto, remove ele 
            _context.Clientes.Remove(clienteEncontrado);

            //Esse e o metodo para salvar no banco de dados.
            _context.SaveChanges();
        }

        public List<Cliente> ListaTodos()
        {
            return _context.Clientes.ToList();
        }
    }
}

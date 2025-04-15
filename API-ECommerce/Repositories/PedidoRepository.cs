using API_ECommerce.Context;
using API_ECommerce.Interfaces;
using API_ECommerce.Models;

namespace API_ECommerce.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private EcommerceContext _context;

        public PedidoRepository(EcommerceContext context)
        {
            _context = context;
        }
        public void Atualizar(int id, Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public Pedido BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pedido> ListaTodos()
        {
            return _context.Pedidos.ToList();
        }
    }
}

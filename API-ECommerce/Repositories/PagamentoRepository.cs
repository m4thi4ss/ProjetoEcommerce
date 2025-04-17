using API_ECommerce.Context;
using API_ECommerce.Interfaces;
using API_ECommerce.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace API_ECommerce.Repositories
{
    public class PagamentoRepository : IPagamentoRepository
    {
        private EcommerceContext _context;

        public PagamentoRepository(EcommerceContext context)
        {
            _context = context;
        }
        public void Atualizar(int id, Pagamento pagamento)
        {
            Pagamento pagamentoEncontrado = _context.Pagamentos.Find(id);

            if (pagamentoEncontrado == null)
            {
                throw new Exception();
            }

            pagamento.Status = pagamentoEncontrado.Status;
            pagamento.Data = pagamentoEncontrado.Data;
            pagamento.FormaDePagamento = pagamentoEncontrado.FormaDePagamento;
            pagamento.IdPedido = pagamentoEncontrado.IdPedido;
            
            _context.SaveChanges();
        }

        public Pagamento BuscarPorId(int id)
        {
            return _context.Pagamentos.FirstOrDefault(p => p.IdPagamento == id);
        }

        public void Cadastrar(Pagamento pagamento)
        {
            _context.Pagamentos.Add(pagamento);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            Pagamento pagamento = _context.Pagamentos.Find(
        }

        public List<Pagamento> ListaTodos()
        {
            return _context.Pagamentos.ToList();
        }
    }
}

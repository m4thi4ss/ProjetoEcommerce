using API_ECommerce.Context;
using API_ECommerce.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API_ECommerce.Controllers
{
    public class PagamentoController : Controller
    {
        private readonly EcommerceContext _context;
        private IPagamentoRepository _pedidoRepository;

        public PagamentoController(EcommerceContext context, IPagamentoRepository pagamentoRepository)
        {
            _context = context;
            _pedidoRepository = pagamentoRepository;
        }
    }
}

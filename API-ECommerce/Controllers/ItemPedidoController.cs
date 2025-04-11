using API_ECommerce.Context;
using API_ECommerce.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API_ECommerce.Controllers
{
    public class ItemPedidoController : Controller
    {
        private readonly EcommerceContext _context;
        private IItemPedidoRepository _itemPedidoRepository;

        public ItemPedidoController(EcommerceContext context, IItemPedidoRepository itemPedidoRepository)
        {
            _context = context;
            _itemPedidoRepository = itemPedidoRepository;
        }
    }
}

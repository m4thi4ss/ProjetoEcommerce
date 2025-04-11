using API_ECommerce.Context;
using API_ECommerce.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API_ECommerce.Controllers
{
    public class ClienteController : ControllerBase
    {
        private readonly EcommerceContext _context;
        private IClienteRepository _clienteRepository;

        public ClienteController(EcommerceContext context, IClienteRepository clienteRepository)
        {
            _context = context;
            _clienteRepository = clienteRepository;
        }


    }
}

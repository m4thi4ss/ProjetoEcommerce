﻿using API_ECommerce.Context;
using API_ECommerce.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_ECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly EcommerceContext _context;
        private IPedidoRepository _pedidoRepository;

        public PedidoController(EcommerceContext context, IPedidoRepository pedidoRepository)
        {
            _context = context;
            _pedidoRepository = pedidoRepository;
        }
    }
}

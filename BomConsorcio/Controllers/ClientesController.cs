using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BomConsorcio.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClienteService _clienteService;

        public ClientesController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public ActionResult Index()
        {
            return View("Clientes", "_AjaxLayout", _clienteService.ObterTodos());
        }
    }
}
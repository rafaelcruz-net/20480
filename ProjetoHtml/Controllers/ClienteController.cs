using ProjetoHtml.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoHtml.Controllers
{
    public class ClienteController : Controller
    {
        //
        // GET: /Cliente/

        
        [HttpPost]
        public ActionResult Post(Cliente cliente)
        {
            //Faz algo//
            // Valida cliente//
            // Gravei o cliente//
            cliente.Id = Guid.NewGuid();
            return Json(cliente);
        }

    }
}

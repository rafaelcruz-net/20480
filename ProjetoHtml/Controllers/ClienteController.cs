using ProjetoHtml.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ProjetoHtml.Controllers
{
    public class ClienteController : Controller
    {
        private static List<Cliente> clienteRepositorio
            = new List<Cliente>();

        //
        // GET: /Cliente/

        
        [HttpPost]
        public ActionResult Post(Cliente cliente)
        {
            System.Threading.Thread.Sleep(3000);

            bool isNew = true;
            foreach (var item in clienteRepositorio)
            {
                if (item.Email == cliente.Email)
                {
                    isNew = false;
                    break;
                }
            }

            if (isNew)
            {
                cliente.Id = Guid.NewGuid();
                clienteRepositorio.Add(cliente);
                return Json(cliente);
            }

            

            Response.StatusCode = (int)HttpStatusCode.BadRequest;
            return Json(new
            {
                Error = "Cliente ja cadastrado na base"
            });

            
            
        }

    }
}

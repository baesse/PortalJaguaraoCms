using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PORTALJAGUARAO.Controllers
{
    public class PortalController : Controller
    {
        // GET: POrtal
        public ActionResult Principal()
        {
            return View();
        }


        public void Cadastro()
        {
            Response.Redirect(@"~\cadastrodefuncionario\cadastro");
        }
    }
}
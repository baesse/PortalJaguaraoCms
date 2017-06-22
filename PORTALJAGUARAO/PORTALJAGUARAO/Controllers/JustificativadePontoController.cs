using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PORTALJAGUARAO.Controllers
{
    public class JustificativadePontoController : Controller
    {
        // GET: JustificativadePonto
        public ActionResult Justificativa()
        {
            return View();
        }
        public ActionResult Cadastrar()
        {
            return View();
        }
    }
}
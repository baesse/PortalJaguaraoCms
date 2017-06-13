using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PORTALJAGUARAO.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public void Validar()
        {

          Response.Redirect(@"~\views\portal");

        }



        public Boolean ValidarLogin()
        {
            return true;

        }

        public ActionResult Acesso()
        {
            return View();
        }

        public void Logar(FormCollection Usuario)
        {
            string user = Usuario["usuario"];

            string senha = Usuario["senha"];

            // string result = Models.Usuario.Logar(user, senha);
            Response.Redirect(@"~\Portal\Principal");

        }
    }
}
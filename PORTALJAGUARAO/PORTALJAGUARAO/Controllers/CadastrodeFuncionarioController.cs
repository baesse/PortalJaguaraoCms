using PORTALJAGUARAO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PORTALJAGUARAO.Controllers
{
    public class CadastrodeFuncionarioController : Controller
    {
        // GET: CadastrodeFuncionario
        public ActionResult Cadastro(Funcionario NovoFuncionario)
        {
            string teste = NovoFuncionario.Nome;

            return View();
        }
    }
}
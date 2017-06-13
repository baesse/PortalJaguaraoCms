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
        public ActionResult Cadastro()
        {
              
            return View();

        }

        public ActionResult CadastrarNovoFuncionario(Funcionario NovoCadFuncionario)
        {
            if (NovoCadFuncionario != null)
            {
                NovoCadFuncionario.CadastrarFuncionario(NovoCadFuncionario);
            }
            return View();
        }


    }
}
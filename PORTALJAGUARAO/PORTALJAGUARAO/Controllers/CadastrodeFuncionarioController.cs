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
            NovoCadFuncionario.CadastrarFuncionario(NovoCadFuncionario);           
            return View(@"~\VIEWS\cadastrodefuncionario\cadastro");
        }

        public String CadastrodeConjuge(String Nome,String Cpf,String DataNascimento,String cpffuncionario)
        {
            string nome = Nome;
            return "ok";

        }


        public String CadastroFinanceiro(String Cpf,String Descricao,String Valor)
        {
            string desc = Descricao;
            return "";
        }

        public String IncluirFilho(String Cpf, String cpffilho, String nomefilho, String dtnascimento)
        {
            string desc = nomefilho;
            return "ok";
        }

        public String Buscar(String Cpf)
        {
          Funcionario novo = new Funcionario();
          string teste= novo.Buscar(Cpf);
            return teste;

        }


    }
}
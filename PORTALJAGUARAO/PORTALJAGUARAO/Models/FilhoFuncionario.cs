using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PORTALJAGUARAO.Models
{
    public class FilhoFuncionario
    {
        [Display (Name="Cpf")]
        public int cpf { get; set; }
        [Display(Name = "Nome")]
        public int Nome { get; set; }
        [Display(Name = "Nascimento")]
        public DateTime DatadeNascimento { get; set; }

    }
}
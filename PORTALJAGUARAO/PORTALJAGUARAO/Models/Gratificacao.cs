using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PORTALJAGUARAO.Models
{
    public class Gratificacao
    {
        [Display (Name="Descrição")]
        public String NomedaGratificacao { get; set; }
        [Display(Name = "Valor")]
        public Decimal valor { get; set; }
    }
}
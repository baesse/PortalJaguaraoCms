using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PORTALJAGUARAO.Models
{
    public class HoraExtra
    {
        [Display (Name ="Nome do colaborador")]
        public String NomeColaborador { get; set; }
        [Display(Name = "Data")]
        public DateTime DataHoraExtra { get; set; }
        [Display(Name = "1º Entrada")]
        public DateTime PrimeiraEntrada { get; set; }
        [Display(Name = "2º Entrada")]
        public DateTime SegundaEntrada { get; set; }
        [Display(Name = "1º Saída")]

        public DateTime primeirasaida { get; set; }
        [Display(Name = "2º Saída")]
        public DateTime SegundaSaida { get; set; }

        [Display (Name ="Total de minutos")]
        public String TotalDeMinutos { get; set; }
        [Display(Name = "Observação")]
        public String Observacao { get; set; }
        public String RegraToleranciaPonto { get; set; }
    }
}
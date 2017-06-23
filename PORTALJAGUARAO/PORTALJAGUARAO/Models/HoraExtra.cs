using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PORTALJAGUARAO.Models
{
    public class HoraExtra
    {
        public String NomeColaborador { get; set; }
        public DateTime DataHoraExtra { get; set; }
        public DateTime PrimeiraEntrada { get; set; }
        public DateTime SegundaEntrada { get; set; }
        public DateTime SegundaSaida { get; set; }
        public String TotalDeMinutos { get; set; }
        public String Observacao { get; set; }
        public String RegraToleranciaPonto { get; set; }
    }
}
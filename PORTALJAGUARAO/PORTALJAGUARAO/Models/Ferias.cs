using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PORTALJAGUARAO.Models
{
    public class Ferias
    {
        [Display(Name ="Nome colaborador")]
        public String NomeColaborador { get; set; }
        [Display(Name = "Setor")]
        public String Setor { get; set; }
        [Display(Name = "Substituição")]
        public String Substituicao { get; set; }
        [Display(Name = "Período aquisitivo")]
        public DateTime Periodoaquisitivo { get; set; }
        [Display(Name = "Data limite")]
        public DateTime DataLimite { get; set; }
        [Display(Name = "Data de admissão")]
        public DateTime Admissao { get; set; }
        [Display(Name = "1)Próximas férias")]
        public DateTime ProximasFerias1 { get; set; }
        [Display(Name = "Próximas férias")]
        public DateTime ProximasFerias1lim { get; set; }
        [Display(Name = "2)Próximas férias")]
        public DateTime ProximasFerias2 { get; set; }
        [Display(Name = "Próximas férias")]
        public DateTime ProximasFerias2lim { get; set; }
        [Display(Name = "3)Próximas férias")]
        public DateTime ProximasFerias3 { get; set; }
        [Display(Name = "Próximas férias")]
        public DateTime ProximasFerias3lim { get; set; }
        [Display(Name = "2)Próximas férias")]
        public List<String> NaoPodeConcidirFuncionario { get; set; }
        [Display(Name = "Próximas férias")]
        public String Observacao { get; set; }



    }
}
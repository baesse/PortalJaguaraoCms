using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PORTALJAGUARAO.Models
{
    public class ExamePeriodico
    {
        [Display(Name="Nome do colaborador")]
        public String NomeColaborador { get; set; }
        [Display(Name = "Data do nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Required(ErrorMessage = "Informe a data do nascimento.")]
        public DateTime Nascimento { get; set; }
        [Required(ErrorMessage = "Informe a data do nascimento.")]
        public String Idade { get; set; }
        [Display(Name = "Data de admissão")]
        [Required(ErrorMessage = "Informe a data do nascimento.")]
        public DateTime Admissao { get; set; }
        [Display(Name = "Data do Ultimo exame")]
        [Required(ErrorMessage = "Informe a data do nascimento.")]
        public DateTime UltimoExame { get; set; }
        [Display(Name = "Próximo exame")]
        [Required(ErrorMessage = "Informe a data do nascimento.")]
        public DateTime proximoExame { get; set; }
        [Display(Name = "Data da Solicitação")]
        [Required(ErrorMessage = "Informe a data do nascimento.")]
        public DateTime Solicitacao { get; set; }
        


        public void InserirNovoExamePeriodico(ExamePeriodico novoexame)
        {

        }
    }
}
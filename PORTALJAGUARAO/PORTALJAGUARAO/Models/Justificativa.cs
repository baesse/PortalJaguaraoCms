using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PORTALJAGUARAO.Models
{
    public class Justificativa
    {
        [Display (Name="Data")]
        public DateTime DataOcorrencia { get; set; }
        [Display (Name ="Nome do colaborador")]
        public String NomeColaborador { get; set; }
        [Display (Name ="Motivo")]
        public List<String> Motivo { get; set; }
        [Display(Name = "Descrição")]
        public String DescJustificativa {get;set;}
        [Display(Name = "Abonado ?")]
        public Boolean Abonado { get; set; }
        [Display(Name = "Caminho para o arquivo")]
        public String CaminhoArquivo { get; set; }

        public Justificativa()
        {
            Motivo = new List<string>();
            Motivo.Add("Pessoal");
            Motivo.Add("Problema Técnico no Ponto Eletrônico");
            Motivo.Add("Atestado Médico");
            Motivo.Add("Serviços Externos");
            Motivo.Add("Visita para Captação de Clientes");
            Motivo.Add("Reunião e Cursos");
       }





        //Buscar do banco a lista de justificativas
        public void AtualizarListaDeJustificaritavas()
        {

        }

        public void CadastrarJustificativa(Justificativa NovaJustificativa)
        {

        }



    }
}
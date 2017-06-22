using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PORTALJAGUARAO.Models
{
    public class Justificativa
    {
        public DateTime DataOcorrencia { get; set; }
        public String NomeColaborador { get; set; }
        public List<String> Motivo { get; set; }
        public String DescJustificativa {get;set;}
        public Boolean Abonado { get; set; }
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
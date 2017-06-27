using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PORTALJAGUARAO.Models
{
    public class TesteFormulario
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string telefone;

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
    }
}
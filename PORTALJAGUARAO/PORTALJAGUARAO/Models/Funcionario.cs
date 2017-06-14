using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PORTALJAGUARAO.Models
{
    public class Funcionario
    {
        [Required(ErrorMessage = "Cpf do cadastro deve ser informado!")]
        public String Cpf { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime DataDemissao  { get; set; }
        public Boolean Atividade { get; set; }
        public String Nome { get; set; }
        public String Sexo { get; set; }
        public DateTime DataAnivesario { get; set; }
        public String Idade { get; set; }
        public String Setor { get; set; }
        public String EstadoCivil { get; set; }
        public String Ci { get; set; }
        public String DataEmissaoci { get; set; }
        public String DataNascimento { get; set; }
        public String NomePai { get; set; }
        public String NomeMae { get; set; }
        public String Cargo { get; set; }
        public String NumeroPis { get; set; }
        public String Cep { get; set; }
        public String Ctps { get; set; }
        public String Serie { get; set; }
        public String TituloEleitor { get; set; }
        public String Endereco { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public String UF { get; set; }
        public String BancoPagamento { get; set; }
        public String Naturalidade { get; set; }
        public String Escolaridade { get; set; }
        public String Telefone { get; set; }
        public String Celular { get; set; }
        public String Substituto { get; set; }
        public Conjuge Conjuge { get; set; }


        public  Boolean CadastrarFuncionario(Funcionario NovoCadastro)
        {
            SqlConnection Conexao = Banco.GetConexao();
            SqlCommand Comando = Banco.GetComando(Conexao);
            Comando.CommandText = "Insert into CAD_FUNCIONARIO (NOME) VALUES (@NOME)";
            Comando.Parameters.AddWithValue("@NOME", NovoCadastro.Nome);
            string teste = "";
            Comando.ExecuteNonQuery();
            Conexao.Close();
                       

            return true;

        }

    }
}
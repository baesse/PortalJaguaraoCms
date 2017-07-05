using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PORTALJAGUARAO.Models
{
    public class Funcionario
    {
        [Required(ErrorMessage = "Cpf do cadastro deve ser informado!")]
        [Display(Name="Cpf")]
        public String Cpf { get; set; }
        public String teste { get; set; }
        [Display(Name = "Data de adminissão")]
        public DateTime DataAdmissao { get; set; }
        [Display(Name = "Data da demissão")]
        public DateTime DataDemissao  { get; set; }
        public Boolean Atividade { get; set; }
        [Required(ErrorMessage = "O nome deve ser informado")]
        public String Nome { get; set; }
        [Display(Name = "Sexo")]
        [Required(ErrorMessage = "O sexo deve ser informado")]
        public String Sexo { get; set; }
        [Display(Name = "Data do aniversário")]
        public DateTime DataAnivesario { get; set; }
        public String Idade { get; set; }
        [Required(ErrorMessage = "O setor deve ser informado")]
        public String Setor { get; set; }
        [Display(Name = "Estado civil")]
        public String EstadoCivil { get; set; }
        [Display(Name = "Carteira de indetidade")]
        public String Ci { get; set; }
        [Display(Name = "Emissão da carteira")]
        public String DataEmissaoci { get; set; }
        [Display(Name = "Data do Nascimento")]
        public String DataNascimento { get; set; }
        [Display(Name = "Nome do pai")]
        public String NomePai { get; set; }
        [Display(Name = "Nome da mãe")]
        public String NomeMae { get; set; }
        public String Cargo { get; set; }
        [Display(Name = "Numero do pis")]
        public String NumeroPis { get; set; }
        public String Cep { get; set; }
        public String Ctps { get; set; }
        public String Serie { get; set; }
        [Display(Name = "Titulo eleitoral")]
        public String TituloEleitor { get; set; }
        public String Endereco { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        [Display(Name = "Uf")]
        public String UF { get; set; }
        public String BancoPagamento { get; set; }
        public String Naturalidade { get; set; }
        public String Escolaridade { get; set; }
        public String Telefone { get; set; }
        public String Celular { get; set; }
        public String Substituto { get; set; }
        public Conjuge Conjuge { get; set; }
        [Display(Name = "Observação")]
        public String observacao { get; set; }
      
        public String senha { get; set; }
        public String resenha { get; set; }
        public FilhoFuncionario filho { get; set; }
        public Gratificacao gratificacao { get; set; }

        public Funcionario()
        {

            filho = new FilhoFuncionario();
            Conjuge = new Conjuge();
            gratificacao = new Gratificacao();

          
        }

        public  Boolean CadastrarFuncionario(Funcionario NovoCadastro)
        {
            SqlConnection Conexao = Banco.GetConexao();
            SqlCommand Comando = Banco.GetComando(Conexao);
            Comando.CommandText = "Insert into CAD_FUNCIONARIO (NOME) VALUES (@NOME)";
            Comando.Parameters.AddWithValue("@NOME", NovoCadastro.Nome);
           
            Comando.ExecuteNonQuery();
            Conexao.Close();
                       

            return true;

        }

    }
}
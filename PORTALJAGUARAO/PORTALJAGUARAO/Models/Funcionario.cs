using Newtonsoft.Json;
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
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Data de admissão")]
        [Required(ErrorMessage = "A data de admissão deve ser informada")]
        public String DataAdmissao { get; set; }
        [Display(Name = "Data da demissão")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public String DataDemissao  { get; set; }
        public Boolean Atividade { get; set; }
        [Required(ErrorMessage = "O nome deve ser informado")]
        public String Nome { get; set; }
        [Display(Name = "Sexo")]
        [Required(ErrorMessage = "O sexo deve ser informado")]
        public String Sexo { get; set; }
        [Display(Name = "Data do aniversário")]
        [Required(ErrorMessage = "A data de aniversario deve ser informada")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public String DataAnivesario { get; set; }
        public String Idade { get; set; }
        [Required(ErrorMessage = "O setor deve ser informado")]
        public String Setor { get; set; }
        [Display(Name = "Estado civil")]
        public String EstadoCivil { get; set; }
        [Display(Name = "Carteira de indetidade")]
        [Required(ErrorMessage = "O RG deve ser informado")]
        public String Ci { get; set; }
        [Display(Name = "Emissão da carteira")]
        [Required(ErrorMessage = "A data da emissão deve ser informada")]
        public String DataEmissaoci { get; set; }
        [Display(Name = "Data do Nascimento")]
        [Required(ErrorMessage = "A data de nascimento deve ser informada")]
        public String DataNascimento { get; set; }
        [Display(Name = "Nome do pai")]
        public String NomePai { get; set; }
        [Display(Name = "Nome da mãe")]
        public String NomeMae { get; set; }
        public String Cargo { get; set; }
        [Display(Name = "Numero do pis")]
        public String NumeroPis { get; set; }
        [Required(ErrorMessage = "O cep deve ser informado")]
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

            String cpf = NovoCadastro.Cpf;
            cpf = cpf.Replace(".", "");
            cpf = cpf.Replace("-", "");

            String cep = NovoCadastro.Cep.Replace(".", "");
            cep = cep.Replace("-", "");


            SqlConnection Conexao = Banco.GetConexao();
            SqlCommand Comando = Banco.GetComando(Conexao);
            Comando.CommandText = "INSERT INTO CAD_FUNCIONARIO (CPF,NUMERORG,NOME,SEXO,DATANASCIMENTO,ESTADOCIVIL,ENDERECO,CEP,NATURALIDADE,ESCOLARIDADE,ULTIMAATUALIZACAO,DATAADMISSAO,DATAEMISSAOCI,CARGO,NUMEROPIS,CTPS,SERIECTPS,TITULOELEITOR,TELEFONE,CELULAR,SENHA)" +
                "                                      VALUES(@CPF,@NUMERORG,@NOME,@SEXO,@DATANASCIMENTO,@ESTADOCIVIL,@ENDERECO,@CEP,@NATURALIDADE,@ESCOLARIDADE,@ULTIMAATUALIZACAO,@DATAADMISSAO,@DATAEMISSAOCI,@CARGO,@NUMEROPIS,@CTPS,@SERIECTPS,@TITULOELEITOR,@TELEFONE,@CELULAR,@SENHA)";
            Comando.Parameters.AddWithValue("@NOME", NovoCadastro.Nome);
            Comando.Parameters.AddWithValue("@CPF", cpf);
            Comando.Parameters.AddWithValue("@SEXO", NovoCadastro.Sexo);
            Comando.Parameters.AddWithValue("@NUMERORG", NovoCadastro.Ci);
            Comando.Parameters.AddWithValue("@DATANASCIMENTO", Convert.ToDateTime(NovoCadastro.DataNascimento));
            Comando.Parameters.AddWithValue("@ESTADOCIVIL", NovoCadastro.EstadoCivil);
            Comando.Parameters.AddWithValue("@ENDERECO", NovoCadastro.Endereco);
            Comando.Parameters.AddWithValue("@CEP", cep);
            Comando.Parameters.AddWithValue("@NATURALIDADE", NovoCadastro.Naturalidade);
            Comando.Parameters.AddWithValue("@ESCOLARIDADE", NovoCadastro.Escolaridade);
            Comando.Parameters.AddWithValue("@ULTIMAATUALIZACAO", DateTime.Now.Date );
            Comando.Parameters.AddWithValue("@DATAADMISSAO",Convert.ToDateTime( NovoCadastro.DataAdmissao));
           // Comando.Parameters.AddWithValue("@ANIVERSARIO", NovoCadastro.DataAnivesario);
            Comando.Parameters.AddWithValue("@DATAEMISSAOCI", Convert.ToDateTime(NovoCadastro.DataEmissaoci));
            Comando.Parameters.AddWithValue("@CARGO", NovoCadastro.Cargo);
            Comando.Parameters.AddWithValue("@NUMEROPIS", NovoCadastro.NumeroPis);
            Comando.Parameters.AddWithValue("@CTPS", NovoCadastro.Ctps);
            Comando.Parameters.AddWithValue("@SERIECTPS", NovoCadastro.Serie);
            Comando.Parameters.AddWithValue("@TITULOELEITOR", NovoCadastro.TituloEleitor);
            Comando.Parameters.AddWithValue("@TELEFONE", NovoCadastro.Telefone);
            Comando.Parameters.AddWithValue("@CELULAR", NovoCadastro.Celular);
            Comando.Parameters.AddWithValue("@SENHA", NovoCadastro.senha);          
            Comando.ExecuteNonQuery();
            Conexao.Close();
                       

            return true;

        }

        public String Buscar(String Funcionariocpf)
        {
            String cpf = Funcionariocpf;
            cpf = cpf.Replace(".", "");
            cpf = cpf.Replace("-", "");

            SqlConnection Conexao = Banco.GetConexao();
            SqlCommand Comando = Banco.GetComando(Conexao);
            Comando.CommandText = "SELECT NOME,cpf,SEXO,NUMERORG,DATANASCIMENTO,ESTADOCIVIL,ENDERECO,CEP,NATURALIDADE,ESCOLARIDADE,ULTIMAATUALIZACAO" +
                ",DATAADMISSAO,ANIVERSARIO,DATAEMISSAOCI,CARGO,NUMEROPIS,CTPS,SERIECTPS,TITULOELEITOR,TELEFONE,CELULAR  FROM CAD_FUNCIONARIO WHERE CPF=@CPF";
            Comando.Parameters.AddWithValue("@CPF", cpf);
            SqlDataReader READER = Comando.ExecuteReader();


            while (READER.Read())
            {
                Funcionario retornofuncionar = new Funcionario();
                retornofuncionar.Nome = READER.GetString(0);
                retornofuncionar.Cpf = READER.GetString(1);
                retornofuncionar.Sexo = READER.GetString(2);
                retornofuncionar.Ci = READER.GetString(3);
                retornofuncionar.DataNascimento = Convert.ToString((READER.GetDateTime(4).ToShortDateString()));
                retornofuncionar.EstadoCivil = READER.GetString(5);
                retornofuncionar.Endereco = READER.GetString(6);
                retornofuncionar.Cep = READER.GetString(7);
                retornofuncionar.Naturalidade = READER.GetString(8);
                retornofuncionar.Escolaridade = READER.GetString(9);
                retornofuncionar.DataAdmissao = Convert.ToString(READER.GetDateTime(10).ToShortDateString());
                //retornofuncionar.DataAnivesario = Convert.ToString(READER.GetDateTime(11));
                retornofuncionar.DataEmissaoci = Convert.ToString(READER.GetDateTime(13).ToShortDateString());
                retornofuncionar.Cargo = READER.GetString(14);
                retornofuncionar.NumeroPis = READER.GetString(15);
                retornofuncionar.Ctps = READER.GetString(16);
                retornofuncionar.Serie = READER.GetString(17);
                retornofuncionar.TituloEleitor = READER.GetString(18);
                retornofuncionar.Telefone = READER.GetString(19);
                retornofuncionar.Celular = READER.GetString(20);


                return JsonConvert.SerializeObject(retornofuncionar);

            }

            return null;





        }




    }
}
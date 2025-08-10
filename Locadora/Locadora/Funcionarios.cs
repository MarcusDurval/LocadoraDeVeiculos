using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Locadora
{
    public class Funcionarios
    {
        SqlCommand comandossql = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable DadosTabela = new DataTable();
        public void Salvar(string nome, string data, string telefone, DateTime contrato, string salario, string bairro, string logradouro, string estado, string cidade, string rg, string cpf, string genero)
        {
            try
            {

                using (SqlConnection conexao = new SqlConnection(Conexao.Con))
                {
                    conexao.Open();

                    sql.Append(" INSERT INTO Funcionario (Nome_Completo,Data_Nascimento,Telefone,Contrato,Salario,Bairro,Logradouro,Estado,Cidade,RG,CPF,Genero)");
                    sql.Append(" VALUES (@nome,@data,@telefone,@contrato,@salario,@bairro,@logradouro,@estado,@cidade,@rg,@cpf,@genero)");

                    comandossql.Parameters.AddWithValue("@nome", nome);
                    comandossql.Parameters.AddWithValue("@data", data);
                    comandossql.Parameters.AddWithValue("@telefone", telefone);
                    comandossql.Parameters.AddWithValue("@contrato", contrato);
                    comandossql.Parameters.AddWithValue("@salario", salario);
                    comandossql.Parameters.AddWithValue("@bairro", bairro);
                    comandossql.Parameters.AddWithValue("@logradouro", logradouro);
                    comandossql.Parameters.AddWithValue("@estado", estado);
                    comandossql.Parameters.AddWithValue("@cidade", cidade);
                    comandossql.Parameters.AddWithValue("@rg", rg);
                    comandossql.Parameters.AddWithValue("@cpf", cpf);
                    comandossql.Parameters.AddWithValue("@genero", genero);

                    comandossql.CommandText = sql.ToString();
                    comandossql.Connection = conexao;
                    comandossql.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro no método Cadastrar. Caso o problema persista, entre em contato com o Administrador do Sistema.",ex.Message);
            }
        }


        public DataTable Listar()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Conexao.Con))
                {
                    connection.Open();

                    sql.Append(" Select * From Funcionario");

                    comandossql.CommandText = sql.ToString();
                    comandossql.Connection = connection;
                    DadosTabela.Load(comandossql.ExecuteReader());


                    return DadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Listar. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void Alterar(int id, string nome, string data, string telefone, DateTime contrato, string salario, string bairro, string logradouro, string estado, string cidade, string rg, string cpf, string genero)
        {
            try
            {
                using (SqlConnection conectar = new SqlConnection(Conexao.Con))
                {
                    conectar.Open();
                    sql.Append("UPDATE Funcionario");
                    sql.Append(" SET Nome_Completo=@nome,Data_Nascimento=@data,Telefone=@telefone,Contrato=@contrato,");
                    sql.Append(" Salario=@salario,Bairro=@bairro,Logradouro=@logradouro,Estado=@estado,");
                    sql.Append(" Cidade=@cidade,RG=@rg,CPF=@cpf,Genero=@genero");
                    sql.Append(" WHERE (ID_Funcionario=@id)");

                    comandossql.Parameters.AddWithValue("@nome", nome);
                    comandossql.Parameters.AddWithValue("@data", data);
                    comandossql.Parameters.AddWithValue("@telefone", telefone);
                    comandossql.Parameters.AddWithValue("@contrato", contrato);
                    comandossql.Parameters.AddWithValue("@salario", salario);
                    comandossql.Parameters.AddWithValue("@bairro", bairro);
                    comandossql.Parameters.AddWithValue("@logradouro", logradouro);
                    comandossql.Parameters.AddWithValue("@estado", estado);
                    comandossql.Parameters.AddWithValue("@cidade", cidade);
                    comandossql.Parameters.AddWithValue("@rg", rg);
                    comandossql.Parameters.AddWithValue("@cpf", cpf);
                    comandossql.Parameters.AddWithValue("genero", genero);
                    comandossql.Parameters.AddWithValue("@id", id);

                    comandossql.CommandText = sql.ToString();
                    comandossql.Connection = conectar;
                    comandossql.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro no método Alterar. Caso o problema persista, entre em contato com o Administrador do Sistema.", ex.Message);
            }
        }
    }
}

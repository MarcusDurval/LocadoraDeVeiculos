using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora
{
    public class Veiculo
    {
        SqlCommand comandoSql = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dadosTabela = new DataTable();
        public void salvar(string marca,string cor,string ano,string fabricacao, string modelo,string transmissao,string combustivel,string carroceria,string placa,string chassi,string nome)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Conexao.Con))
                {
                    connection.Open();

                    sql.Append(" INSERT INTO Veiculo (Marca,Cor,Ano,Fabricação,Modelo,Transmissao,Combustivel,Carroceria,Placa,Chassi,Nome)");
                    sql.Append(" VALUES (@Marca,@Cor,@Ano,@fabricacao,@Modelo,@Transmissao,@Combustivel,@Carroceria,@Placa,@Chassi,@nome)");

                    comandoSql.Parameters.AddWithValue("@Marca", marca);
                    comandoSql.Parameters.AddWithValue("@Cor", cor);
                    comandoSql.Parameters.AddWithValue("@Ano", ano);
                    comandoSql.Parameters.AddWithValue("@fabricacao", fabricacao);
                    comandoSql.Parameters.AddWithValue("@Modelo", modelo);
                    comandoSql.Parameters.AddWithValue("@Transmissao", transmissao);
                    comandoSql.Parameters.AddWithValue("@Combustivel", combustivel);
                    comandoSql.Parameters.AddWithValue("@Carroceria", carroceria);
                    comandoSql.Parameters.AddWithValue("@Placa", placa);
                    comandoSql.Parameters.AddWithValue("@Chassi", chassi);
                    comandoSql.Parameters.AddWithValue("@nome", nome);

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = connection;
                    comandoSql.ExecuteNonQuery();
                }
            }
             catch(Exception )
             {
                throw new Exception("Ocorreu um erro no método Cadastrar. Caso o problema persista, entre em contato com o Administrador do Sistema.");
             }
        }

        public DataTable Listar()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Conexao.Con))
                {
                    connection.Open();

                    sql.Append(" Select * From Veiculo");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = connection;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                    
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Listar. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }
    }
}

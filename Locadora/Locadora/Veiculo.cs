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
             catch(Exception ex)
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

                    sql.Append("Select * From Veiculo");

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

        public void Alterar(int cod, string Marca, string Cor, string Ano, string Fabricacao, string Modelo, string Transmissao, string Combustivel, string Carroceria, string Placa, string Chassi, string Nome)
        {
            try
            {

                using (SqlConnection conectar = new SqlConnection(Conexao.Con))
                {
                    conectar.Open();

                    sql.Append("Update Veiculo");
                    sql.Append(" Set Marca=@Marca,Cor=@Cor,Ano=@Ano,Fabricação=@Fabricacao,Modelo=@Modelo,Transmissao=@Transmissao,Combustivel=@Combustivel,Carroceria=@Carroceria,Placa=@Placa,Chassi=@Chassi,Nome=@Nome");

                    sql.Append("Where (Cod_Veiculo = @cod)");

                    comandoSql.Parameters.AddWithValue("@Marca",Marca);
                    comandoSql.Parameters.AddWithValue("@Cor",Cor);
                    comandoSql.Parameters.AddWithValue("@Ano",Ano);
                    comandoSql.Parameters.AddWithValue("@Fabricacao",Fabricacao);
                    comandoSql.Parameters.AddWithValue("@Modelo",Modelo);
                    comandoSql.Parameters.AddWithValue("@Transmissao",Transmissao);
                    comandoSql.Parameters.AddWithValue("@Combustivel",Combustivel);
                    comandoSql.Parameters.AddWithValue("@Carroceria", Carroceria);
                    comandoSql.Parameters.AddWithValue("@Placa",Placa);
                    comandoSql.Parameters.AddWithValue("@Chassi",Chassi);
                    comandoSql.Parameters.AddWithValue("@Nome",Nome);
                    comandoSql.Parameters.AddWithValue("@cod",cod);

                    comandoSql.CommandText = comandoSql.ToString();
                    comandoSql.Connection = conectar;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro no método Listar. Caso o problema persista, entre em contato com o Administrador do Sistema.", ex.Message);
            }
           
        }

        public void Excluir(int idveiculo)
        {
            try
            {
                using (SqlConnection conectar = new SqlConnection(Conexao.Con))
                {
                    conectar.Open();
                    sql.Append("Delete From Veiculo");
                    sql.Append(" Where (Cod_Veiculo = @idveiculo)");

                    comandoSql.Parameters.AddWithValue("@idveiculo", idveiculo);

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conectar;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro no método Listar. Caso o problema persista, entre em contato com o Administrador do Sistema.",ex.Message);
            }
        }
    }
}

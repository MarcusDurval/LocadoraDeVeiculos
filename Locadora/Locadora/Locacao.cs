using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Locadora
{
    public class Locacao
    {
        SqlCommand comandosql = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dadostabela = new DataTable();
        public List<string> Visualizar()
        {
            try
            {
                List<string> visualizar = new List<string>();
                using (SqlConnection connection = new SqlConnection(Conexao.Con))
                {
                    connection.Open();

                    sql.Append("Select Veiculo.Nome From Veiculo");

                    comandosql.CommandText = sql.ToString();
                    comandosql.Connection = connection;
                    SqlDataReader reader = comandosql.ExecuteReader();

                    while (reader.Read())
                    {
                        visualizar.Add(reader["Nome"].ToString());
                    }

                    reader.Close();

                }
                return visualizar;
            }
            catch (Exception )
            {
                throw new Exception("Ocorreu um erro no método Visualizar. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable BusacarPorNome(string N)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Conexao.Con))
                {
                    con.Open();

                    sql.Append("Select * From Veiculo");
                    sql.Append(" Where Nome = @N");

                    comandosql.Parameters.Add(new SqlParameter("@N", N));

                    comandosql.CommandText = sql.ToString();
                    comandosql.Connection = con;
                    dadostabela.Load(comandosql.ExecuteReader());

                    return dadostabela;
                }
            }

            catch (Exception )
            {
                throw new Exception("Ocorreu um erro no método de Buscar. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }
    }
}

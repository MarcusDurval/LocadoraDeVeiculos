using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Login
{
    public class Logins
    {
        public string NomeUsuario { get; private set; }
        public bool Verificar { get; private set; }
        SqlCommand ComandoSql = new SqlCommand();
        StringBuilder Sql = new StringBuilder();
        public void VerificarLogin(string login, string senha)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.Con))
                {
                    conexao.Open();

                    Sql.Append("SELECT * FROM Login");
                    Sql.Append(" WHERE Email=@login AND Senha=@senha");

                    ComandoSql.Parameters.AddWithValue("@login", login);
                    ComandoSql.Parameters.AddWithValue("@senha", senha);

                    ComandoSql.CommandText = Sql.ToString();    
                    ComandoSql.Connection = conexao;
                    using (SqlDataReader Reader = ComandoSql.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            NomeUsuario = Reader["Email"].ToString();
                        }
                        Reader.Close();
                    }
                    Verificar = true;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Login não encontrado verifique seu Email",ex.Message);
                Verificar = true;
            }
        }

        public void Cadastrar(string login, string senha, string confsenha)
        {
            try
            {
                if (confsenha == senha)
                {
                    using (SqlConnection conexao = new SqlConnection(Conexao.Con))
                    {
                        conexao.Open();

                        Sql.Append("INSERT INTO Login");
                        Sql.Append(" VALUES(@Login, @Senha)");

                        ComandoSql.Parameters.AddWithValue("@Login",login);
                        ComandoSql.Parameters.AddWithValue("@Senha", senha);

                        ComandoSql.CommandText = Sql.ToString();
                        ComandoSql.Connection = conexao;
                        ComandoSql.ExecuteNonQuery();

                        Verificar = true;
                    } 
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Cadastrar, Por Favor Tente Novamente",ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Login
{
    public class LoginDaoComandos
    {
        public string NomeUsuario = null;
        public bool tem;
        public string mensagem = "";
        SqlCommand comandoSql = new SqlCommand();
        SqlConnection connection = new SqlConnection(Conexao.Con);
        StringBuilder sql = new StringBuilder();    
        SqlDataReader dr;
        public bool verificarLogin(string login, string senha)
        {
            sql.Append("Select * From Login");
            sql.Append(" Where Email = @login and Senha = @senha");
            comandoSql.Parameters.AddWithValue("@login", login);
            comandoSql.Parameters.AddWithValue("@senha", senha);

            try
            {
                connection.Open();
                comandoSql.Connection = connection;
                comandoSql.CommandText = sql.ToString();

                dr = comandoSql.ExecuteReader();

                if(dr.Read())
                {
                    tem = true;
                    NomeUsuario = dr["Email"].ToString();
                }
                else
                {
                    tem = false;
                }
                dr.Close(); 
            }
            catch (SqlException)
            {
                this.mensagem = "Erro no banco de dados";
            }
            return tem;
            
        }

        public string cadastrar(string login, string senha, string Confsenha)
        {
            tem = false;
            if(senha.Equals(Confsenha))
            {
                sql.Append("INSERT INTO Login");
                sql.Append(" VALUES (@Login, @Senha) ");
                comandoSql.Parameters.Add(new SqlParameter("@Login",login));
                comandoSql.Parameters.Add(new SqlParameter("@Senha", senha));

                try
                {
                    connection.Open();
                    comandoSql.Connection = connection;
                    comandoSql.CommandText = sql.ToString();
                    comandoSql.ExecuteNonQuery();
                    this.mensagem = "Cadastro com sucesso!";
                    tem = true;
                }
                catch (SqlException)
                {

                    this.mensagem = "Erro no Banco de Dados!";
                }
            }
            else
            {
                this.mensagem = "Senha não correspondem!";
            }
            return mensagem;
        }
    }
}

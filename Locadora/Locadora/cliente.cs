using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;


namespace Locadora
{
    public class Cliente
    {
        SqlCommand comandoSql = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dadosTabela = new DataTable();

        public void Salvar(string nome, string cpf, string rg, DateTime Cadastro, string Estado, string Cidade, string Bairro, string Logradouro, string Data_nascimento, string Telefone, string Genero, string Numero_cnh, string Categoria_cnh, string CEP)
        {
            try
            {

                using (SqlConnection Connection = new SqlConnection(Conexao.Con))
                {
                    Connection.Open();

                    sql.Append(" INSERT INTO Cliente (Nome_Completo,CPF,RG,Cadastro,Estado,Cidade,Bairro,Logradouro,Data_nascimento,Telefone,Genero,Numero_cnh,Categoria_cnh,CEP)");
                    sql.Append(" Values(@nome,@cpf,@rg,@Cadastro,@Estado,@Cidade,@Bairro,@Logradouro,@Data_nascimento,@Telefone,@Genero,@Numero_cnh,@Categoria_cnh,@CEP)");

                    comandoSql.Parameters.AddWithValue("@nome", nome);
                    comandoSql.Parameters.AddWithValue("@cpf", cpf);
                    comandoSql.Parameters.AddWithValue("@rg", rg);
                    comandoSql.Parameters.AddWithValue("@Cadastro", Cadastro);
                    comandoSql.Parameters.AddWithValue("@Estado", Estado);
                    comandoSql.Parameters.AddWithValue("@Cidade", Cidade);
                    comandoSql.Parameters.AddWithValue("@Bairro", Bairro);
                    comandoSql.Parameters.AddWithValue("@Logradouro", Logradouro);
                    comandoSql.Parameters.AddWithValue("@Data_nascimento", Data_nascimento);
                    comandoSql.Parameters.AddWithValue("@Telefone", Telefone);
                    comandoSql.Parameters.AddWithValue("@Genero", Genero);
                    comandoSql.Parameters.AddWithValue("@Numero_cnh", Numero_cnh);
                    comandoSql.Parameters.AddWithValue("@Categoria_cnh", Categoria_cnh);
                    comandoSql.Parameters.AddWithValue("@CEP", CEP);

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = Connection;
                    comandoSql.ExecuteNonQuery();
                }
            }

            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Cadastrar. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
            
           
        }
        public DataTable Listar()
        {
            try
            {

                using (SqlConnection con = new SqlConnection(Conexao.Con))
                {
                    con.Open();

                    sql.Append("Select * From Cliente");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = con;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {

                throw new Exception("Ocorreu um erro no método Listar. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
           
        } 

        public void Excluir(int idcliente)
        {
            using (SqlConnection conectar = new SqlConnection(Conexao.Con))
            {
                conectar.Open();

                sql.Append("Delete From Cliente");
                sql.Append(" Where (ID_Cliente = @idcliente)");

                comandoSql.Parameters.Add(new SqlParameter("idcliente", idcliente));

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                comandoSql.ExecuteNonQuery();
            }
        }

        public void Alterar(int idcliente,string nome, string cpf, string rg, DateTime Cadastro, string Estado, string Cidade, string Bairro, string Logradouro, string Data_nascimento, string Telefone, string Genero, string Numero_cnh, string Categoria_cnh, string CEP)
        {
            using (SqlConnection conectar = new SqlConnection(Conexao.Con))
            {
                conectar.Open();

                sql.Append("UPDATE Cliente");
                sql.Append(" SET Nome_Completo = @nome,CPF = @cpf,RG = @rg,Cadastro = @cadastro,Estado = @estado,Cidade = @cidade, ");
                sql.Append("Bairro = @Bairro,Logradouro = @Logradouro,Data_nascimento = @Data_nascimento,Telefone = @Telefone, ");
                sql.Append("Genero = @Genero,Numero_cnh = @Numero_cnh,Categoria_cnh = @Categoria_cnh,CEP = @CEP");

                sql.Append(" WHERE (ID_Cliente=@idcliente)");

                comandoSql.Parameters.AddWithValue("@nome", nome);
                comandoSql.Parameters.AddWithValue("@cpf", cpf);
                comandoSql.Parameters.AddWithValue("@rg", rg);
                comandoSql.Parameters.AddWithValue("@cadastro",Cadastro);
                comandoSql.Parameters.AddWithValue("@estado",Estado);
                comandoSql.Parameters.AddWithValue("@cidade",Cidade);
                comandoSql.Parameters.AddWithValue("@Bairro",Bairro);
                comandoSql.Parameters.AddWithValue("@Logradouro",Logradouro);
                comandoSql.Parameters.AddWithValue("@Data_nascimento",Data_nascimento);
                comandoSql.Parameters.AddWithValue("@Telefone", Telefone);
                comandoSql.Parameters.AddWithValue("@Genero",Genero);
                comandoSql.Parameters.AddWithValue("@Numero_cnh",Numero_cnh);
                comandoSql.Parameters.AddWithValue("@Categoria_cnh", Categoria_cnh);
                comandoSql.Parameters.AddWithValue("@CEP", CEP);
                comandoSql.Parameters.AddWithValue("@idcliente", idcliente);

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conectar;
                comandoSql.ExecuteNonQuery();
            }
        }
    }
}

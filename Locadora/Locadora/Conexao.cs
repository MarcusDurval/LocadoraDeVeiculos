using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora
{
    public class Conexao
    {
        private static string conectar = @"Data Source=Desktop-NND4R5B;Initial Catalog=Projeto_Locadora;Integrated Security=True;Encrypt=False";
      
        public static string Con
        {
            get { return conectar; }
        }
    }
}

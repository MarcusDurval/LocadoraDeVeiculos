using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Login
{
    public class Controle
    {
        public bool tem;
        public string mensagem = "";
        public string NomeUsuario = "";
        public bool acessar(string login, string senha)
        {
            LoginDaoComandos loginComandos = new LoginDaoComandos();
            tem = loginComandos.verificarLogin(login, senha);
            if(!loginComandos.mensagem.Equals(""))
            {
                this.mensagem = loginComandos.mensagem;
            }
            NomeUsuario = loginComandos.NomeUsuario;
            return tem;
        }

        public string Cadastrar(string email, string senha, string confsenha)
        {
            LoginDaoComandos logincomandos = new LoginDaoComandos();
            this.mensagem = logincomandos.cadastrar(email,senha,confsenha);
            if(logincomandos.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}

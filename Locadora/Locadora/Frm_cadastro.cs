using Locadora.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora
{
    public partial class Frm_cadastro : Form
    {
        Logins NovoLogin = new Logins();    
        public Frm_cadastro()
        {
            InitializeComponent();
        }

        private void tb_email_TextChanged(object sender, EventArgs e)
        {
            tb_email.TextAlign = HorizontalAlignment.Left;
        }

        private void tb_senha_TextChanged(object sender, EventArgs e)
        {
            tb_senha.TextAlign = HorizontalAlignment.Left;
        }

        private void tb_confsenha_TextChanged(object sender, EventArgs e)
        {
            tb_confsenha.TextAlign = HorizontalAlignment.Left;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            NovoLogin = new Logins();
            NovoLogin.Cadastrar(tb_email.Text, tb_senha.Text, tb_confsenha.Text);
            if(NovoLogin.Verificar == true)
            {
                MessageBox.Show("Cadastro Finalizado com Sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Algo deu erro, Verifique Seu Email ou Senha", "ERRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
           

        }
    }
}

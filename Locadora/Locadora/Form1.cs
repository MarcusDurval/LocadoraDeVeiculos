using Locadora.Login;

namespace Locadora
{
    public partial class Frm_locadora : Form
    {
        Logins NovoLogin = new Logins();
        public Frm_locadora()
        {
            InitializeComponent();
        }

        private void tb_email_TextChanged(object sender, EventArgs e)
        {
            tb_email.TextAlign = HorizontalAlignment.Left;
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            tb_password.TextAlign = HorizontalAlignment.Left;
        }

        private void lk_clique_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            NovoLogin = new Logins();
            NovoLogin.VerificarLogin(tb_email.Text, tb_password.Text);

            if (NovoLogin.Verificar == true)
            {
                SessaoUsuario.Nome = NovoLogin.NomeUsuario;
                Frm_principal frm_Principal = new Frm_principal();
                frm_Principal.Show();
                MessageBox.Show("Logado com sucesso", "Logado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                   MessageBox.Show("login não encontrado, verfique login e senha", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_cadastro cadastro = new Frm_cadastro();
            cadastro.ShowDialog();  
        }
    }
}

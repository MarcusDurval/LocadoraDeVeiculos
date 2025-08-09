using Locadora.Login;

namespace Locadora
{
    public partial class Frm_locadora : Form
    {
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
            Controle controle = new Controle();
            controle.acessar(tb_email.Text, tb_password.Text);
            if (controle.mensagem.Equals(""))
            {

                if (controle.tem)
                {
                    SessaoUsuario.Nome = controle.NomeUsuario;

                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm_principal bemvindo = new Frm_principal();
                    bemvindo.Show();
                }
                else
                {
                    MessageBox.Show("login não encontrado, verfique login e senha", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_cadastro cadastro = new Frm_cadastro();
            cadastro.ShowDialog();  
        }
    }
}

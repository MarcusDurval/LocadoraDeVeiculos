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
    public partial class Frm_principal : Form
    {
        public Frm_principal()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Frm_cliente frm_Clientes = new Frm_cliente();
            frm_Clientes.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Frm_veiculo frm_Veiculo = new Frm_veiculo();
            frm_Veiculo.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Frm_Funcionario frm_Funcionario = new Frm_Funcionario();
            frm_Funcionario.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Frm_Locação locação = new Frm_Locação();
            locação.ShowDialog();
        }

        private void lbl_usuario_Click(object sender, EventArgs e)
        {

        }

        private void Frm_principal_Load(object sender, EventArgs e)
        {
            lbl_usuario.Text = "Bem-vindo \n\r" + SessaoUsuario.Nome;

            if(SessaoUsuario.Nome == "Admin")
            {
                    btn_clientes.Enabled = true;
                    btn_funcionarios.Enabled = true;
                    btn_locadora.Enabled = true;
                    btn_veiculos.Enabled = true;
                
            }
        }
    }
}

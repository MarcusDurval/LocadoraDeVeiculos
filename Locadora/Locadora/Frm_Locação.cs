using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Locadora
{
    public partial class Frm_Locação : Form
    {
        public Frm_Locação()
        {
            InitializeComponent();
            CarregarVeiculosNoComboBox();
        }
        private void CarregarVeiculosNoComboBox()
        {
            Locacao NovaLocacao = new Locacao();

            List<string> visualizar = NovaLocacao.Visualizar();
            cmb_veiculo.Items.Clear();

            foreach (string l in visualizar)
            {
                cmb_veiculo.Items.Add(l);
            }

        }
        private void Frm_Locação_Load(object sender, EventArgs e)
        {
            lbl_name.Text = "Bem-vindo \r\n" + SessaoUsuario.Nome;
        }

        private void cmb_veiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomeSelecionado = cmb_veiculo.Text;
            MessageBox.Show("Veículo selecionado: " + nomeSelecionado);

            Locacao NovaLocacao = new Locacao();

            dtg_veiculo.DataSource = null;
            dtg_veiculo.DataSource = NovaLocacao.BusacarPorNome(nomeSelecionado);
        }

        private void dtp_time_ValueChanged(object sender, EventArgs e)
        {
           

        }
    }
}

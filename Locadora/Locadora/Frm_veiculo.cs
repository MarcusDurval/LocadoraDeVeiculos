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
    public partial class Frm_veiculo : Form
    {
        public Frm_veiculo()
        {
            InitializeComponent();
        }
        private void carregarLista()
        {
            Veiculo NewVeiculo = new Veiculo();
            dtg_veiculos.DataSource = null;
            dtg_veiculos.DataSource = NewVeiculo.Listar();
        }
        private void Apagar()
        {
            tb_nome.Clear();
            tb_marca.Clear();
            tb_combustivel.Clear();
            tb_fabricacao.Clear();
            tb_carroceria.Clear();
            tb_transmissao.Clear();
            tb_ano.Clear();
            tb_modelo.Clear();
            tb_chassi.Clear();
            tb_cor.Clear();
            tb_placa.Clear();
            tb_nome.Focus();
        }
        private void Frm_veiculo_Load(object sender, EventArgs e)
        {
            carregarLista();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Veiculo newVeiculos = new Veiculo();

            newVeiculos.salvar(
            tb_marca.Text, tb_cor.Text, tb_ano.Text, tb_fabricacao.Text,
            tb_modelo.Text, tb_transmissao.Text, tb_combustivel.Text, tb_carroceria.Text,
            tb_placa.Text, tb_chassi.Text, tb_nome.Text);

            carregarLista();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            Apagar();
        }

        private void dtg_veiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_veiculos.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                tb_registro.Text = dtg_veiculos.Rows[e.RowIndex].Cells["Cod_Veiculo"].Value.ToString();
                tb_marca.Text = dtg_veiculos.Rows[e.RowIndex].Cells["Marca"].Value.ToString();
                tb_cor.Text = dtg_veiculos.Rows[e.RowIndex].Cells["Cor"].Value.ToString();
                tb_ano.Text = dtg_veiculos.Rows[e.RowIndex].Cells["Ano"].Value.ToString();
            }
        }
    }
}

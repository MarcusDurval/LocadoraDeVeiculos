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
        private void ListarVeiculos()
        {
            Veiculo NewVeiculo = new Veiculo();
            dtg_veiculos.DataSource = null;
            dtg_veiculos.DataSource = NewVeiculo.Listar();
        }
        private void Limpar()
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
            try
            {
                ListarVeiculos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Veiculo NovoVeiculo = new Veiculo();
            try
            {
                if (tb_registro.Text == "0")
                {
                    NovoVeiculo.salvar(
                    tb_marca.Text, tb_cor.Text, tb_ano.Text, tb_fabricacao.Text,
                    tb_modelo.Text, tb_transmissao.Text, tb_combustivel.Text, tb_carroceria.Text,
                    tb_placa.Text, tb_chassi.Text, tb_nome.Text);

                }
                else
                {
                    NovoVeiculo.Alterar(Convert.ToInt32(tb_registro.Text), tb_marca.Text, tb_cor.Text, tb_ano.Text, tb_fabricacao.Text,
                    tb_modelo.Text, tb_transmissao.Text, tb_combustivel.Text, tb_carroceria.Text,
                    tb_placa.Text, tb_chassi.Text, tb_nome.Text);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ListarVeiculos();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void dtg_veiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_veiculos.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                tb_registro.Text = dtg_veiculos.Rows[e.RowIndex].Cells["Cod_Veiculo"].Value.ToString();
                tb_marca.Text = dtg_veiculos.Rows[e.RowIndex].Cells["Marca"].Value.ToString();
                tb_cor.Text = dtg_veiculos.Rows[e.RowIndex].Cells["Cor"].Value.ToString();
                tb_ano.Text = dtg_veiculos.Rows[e.RowIndex].Cells["Ano"].Value.ToString();
                tb_fabricacao.Text = dtg_veiculos.Rows[e.RowIndex].Cells["Fabricação"].Value.ToString();
                tb_modelo.Text = dtg_veiculos.Rows[e.RowIndex].Cells["Modelo"].Value.ToString();
                tb_transmissao.Text = dtg_veiculos.Rows[e.RowIndex].Cells["Transmissao"].Value.ToString();
                tb_combustivel.Text = dtg_veiculos.Rows[e.RowIndex].Cells["combustivel"].Value.ToString();
                tb_carroceria.Text = dtg_veiculos.Rows[e.RowIndex].Cells["Carroceria"].Value.ToString();
                tb_placa.Text = dtg_veiculos.Rows[e.RowIndex].Cells["Placa"].Value.ToString();
                tb_chassi.Text = dtg_veiculos.Rows[e.RowIndex].Cells["Chassi"].Value.ToString();
                tb_nome.Text = dtg_veiculos.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            }
            else if (dtg_veiculos.Columns[e.ColumnIndex].Name == "btn_excluir" && MessageBox.Show("Deseja Realmente excluir", "Deseja Excluir?",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                Cliente NovoCliente = new Cliente();

                NovoCliente.Excluir(Convert.ToInt32(dtg_veiculos.Rows[e.RowIndex].Cells["Cod_Veiculo"].Value));
                MessageBox.Show("Veiculo excluído com sucesso!","Sucesso",MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListarVeiculos();
                Limpar();
            }
        }
    }
}

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
    public partial class Frm_cliente : Form
    {
        public Frm_cliente()
        {
            InitializeComponent();
        }

        public void Limpar()
        {
            tb_registro.Text = "0";
            tb_nome.Clear();
            mkd_nascimento.Clear();
            tb_cnh.Clear();
            mkd_logradouro.Clear();
            dtp_cadastro.Value = DateTime.Now;
            tb_genero.Clear();
            mkd_categoria.Clear();
            msk_rg.Clear();
            mkd_cpf.Clear();
            mkd_telefone1.Clear();
            mkd_telefone2.Clear();
            mkd_cidade.Clear();
            tb_estado.Clear();
            tb_bairro.Clear();
            msk_cep.Clear();
        }

        public void ListarCliente()
        {
            var cliente = new Cliente();
            dtg_cliente.DataSource = null;
            dtg_cliente.DataSource = cliente.Lista();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Cliente NovoCliente = new Cliente();

            try
            {
                if (tb_registro.Text == "0")
                {
                    NovoCliente.Salvar(
                    tb_nome.Text, mkd_cpf.Text, msk_rg.Text, dtp_cadastro.Value.Date,
                    tb_estado.Text, mkd_cidade.Text, tb_bairro.Text, mkd_logradouro.Text,
                    mkd_nascimento.Text, mkd_telefone1.Text, tb_genero.Text, tb_cnh.Text,
                    mkd_categoria.Text, msk_cep.Text);

                }
                else
                {
                    NovoCliente.Alterar(Convert.ToInt32(tb_registro.Text), tb_nome.Text, mkd_cpf.Text, msk_rg.Text, dtp_cadastro.Value.Date,
                    tb_estado.Text, mkd_cidade.Text, tb_bairro.Text, mkd_logradouro.Text,
                    mkd_nascimento.Text, mkd_telefone1.Text, tb_genero.Text, tb_cnh.Text,
                    mkd_categoria.Text, msk_cep.Text);
                }

                if (MessageBox.Show("Concluido com sucesso!", "sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    ListarCliente();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void dtg_cliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_cliente.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                tb_registro.Text = dtg_cliente.Rows[e.RowIndex].Cells["ID_Cliente"].Value.ToString();
                tb_nome.Text = dtg_cliente.Rows[e.RowIndex].Cells["Nome_Completo"].Value.ToString();
                mkd_cpf.Text = dtg_cliente.Rows[e.RowIndex].Cells["CPF"].Value.ToString();
                msk_rg.Text = dtg_cliente.Rows[e.RowIndex].Cells["RG"].Value.ToString();
                dtp_cadastro.Value = Convert.ToDateTime(dtg_cliente.Rows[e.RowIndex].Cells["Cadastro"].Value.ToString());
                tb_estado.Text = dtg_cliente.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
                mkd_cidade.Text = dtg_cliente.Rows[e.RowIndex].Cells["Cidade"].Value.ToString();
                tb_bairro.Text = dtg_cliente.Rows[e.RowIndex].Cells["Bairro"].Value.ToString();
                mkd_logradouro.Text = dtg_cliente.Rows[e.RowIndex].Cells["Logradouro"].Value.ToString();
                mkd_nascimento.Text = dtg_cliente.Rows[e.RowIndex].Cells["Data_nascimento"].Value.ToString();
                mkd_telefone1.Text = dtg_cliente.Rows[e.RowIndex].Cells["Telefone"].Value.ToString();
                tb_genero.Text = dtg_cliente.Rows[e.RowIndex].Cells["Genero"].Value.ToString();
                tb_cnh.Text = dtg_cliente.Rows[e.RowIndex].Cells["Numero_cnh"].Value.ToString();
                mkd_categoria.Text = dtg_cliente.Rows[e.RowIndex].Cells["Categoria_cnh"].Value.ToString();
                msk_cep.Text = dtg_cliente.Rows[e.RowIndex].Cells["CEP"].Value.ToString();
            }
            else
            {
                if (dtg_cliente.Columns[e.ColumnIndex].Name == "btn_excluir" && MessageBox.Show("Deseja Realmente excluir", "Deseja Excluir?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Cliente NewCliente = new Cliente();

                    NewCliente.Excluir(Convert.ToInt32(dtg_cliente.Rows[e.RowIndex].Cells["ID_Cliente"].Value));
                    MessageBox.Show("Cliente excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarCliente();
                    Limpar();
                }
            }
        }

        private void Frm_clientes_Load(object sender, EventArgs e)
        {
            try
            {
                ListarCliente();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

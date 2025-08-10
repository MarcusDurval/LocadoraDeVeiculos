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
    public partial class Frm_Funcionario : Form
    {
        public Frm_Funcionario()
        {
            InitializeComponent();
        }

        private void CarregarDados()
        {
            Funcionarios NovoFuncionario = new Funcionarios();
            dtg_funcionario.DataSource = null;
            dtg_funcionario.DataSource = NovoFuncionario.Listar();

        }

        private void Limpar()
        {
            tb_registro.Text = "0";
            tb_nome.Clear();
            msk_nascimento.Clear();
            msk_telefone.Clear();
            tb_genero.Clear();
            msk_salario.Clear();
            msk_rg.Clear();
            msk_cpf.Clear();
            tb_estado.Clear();
            tb_cidade.Clear();
            tb_bairro.Clear();
            tb_rua.Clear();
            tb_nome.Focus();
        }

        private void lbl_cnh_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Funcionarios NovoFuncionario = new Funcionarios();

            if (tb_registro.Text == "0")
            {
                NovoFuncionario.Salvar(
                    tb_nome.Text, msk_nascimento.Text, msk_telefone.Text, dtp_contatro.Value.Date, msk_salario.Text,
                    tb_bairro.Text, tb_rua.Text, tb_estado.Text, tb_cidade.Text, msk_rg.Text, msk_cpf.Text,
                    tb_genero.Text);

            } else
            {
                NovoFuncionario.Alterar(Convert.ToInt32(tb_registro.Text),tb_nome.Text, msk_nascimento.Text, msk_telefone.Text, dtp_contatro.Value.Date, msk_salario.Text, tb_bairro.Text, tb_rua.Text, tb_estado.Text, tb_cidade.Text, msk_rg.Text, msk_cpf.Text, tb_genero.Text);
            }

            if (MessageBox.Show("Concluido com sucesso!", "sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                CarregarDados();
            }
        }

        private void Frm_Funcionario_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void dtg_funcionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_funcionario.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                tb_registro.Text = dtg_funcionario.Rows[e.RowIndex].Cells["ID_Funcionario"].Value.ToString();
                tb_nome.Text = dtg_funcionario.Rows[e.RowIndex].Cells["Nome_Completo"].Value.ToString();
                msk_nascimento.Text = dtg_funcionario.Rows[e.RowIndex].Cells["Data_Nascimento"].Value.ToString();
                msk_telefone.Text = dtg_funcionario.Rows[e.RowIndex].Cells["Telefone"].Value.ToString();
                dtp_contatro.Value = Convert.ToDateTime(dtg_funcionario.Rows[e.RowIndex].Cells["Contrato"].Value.ToString());
                msk_salario.Text = dtg_funcionario.Rows[e.RowIndex].Cells["Salario"].Value.ToString();
                tb_bairro.Text = dtg_funcionario.Rows[e.RowIndex].Cells["Bairro"].Value.ToString();
                tb_rua.Text = dtg_funcionario.Rows[e.RowIndex].Cells["Logradouro"].Value.ToString();
                tb_estado.Text = dtg_funcionario.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
                tb_cidade.Text = dtg_funcionario.Rows[e.RowIndex].Cells["Cidade"].Value.ToString();
                msk_rg.Text = dtg_funcionario.Rows[e.RowIndex].Cells["RG"].Value.ToString();
                msk_cpf.Text = dtg_funcionario.Rows[e.RowIndex].Cells["CPF"].Value.ToString();
                tb_genero.Text = dtg_funcionario.Rows[e.RowIndex].Cells["Genero"].Value.ToString();
            }
        }
    }
}

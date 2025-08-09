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

        private void Apagar()
        {
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

            NovoFuncionario.Salvar(tb_nome.Text, msk_nascimento.Text, msk_telefone.Text, dtp_contatro.Value.Date, msk_salario.Text, tb_bairro.Text, tb_rua.Text, tb_estado.Text, tb_cidade.Text, msk_rg.Text, msk_cpf.Text, tb_genero.Text);


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
            Apagar();
        }
    }
}

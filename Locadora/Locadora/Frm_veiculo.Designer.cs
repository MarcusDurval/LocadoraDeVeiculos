namespace Locadora
{
    partial class Frm_veiculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStrip1 = new ToolStrip();
            btn_novo = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btn_salvar = new ToolStripButton();
            lbl_combustível = new Label();
            tb_carroceria = new TextBox();
            lbl_endereco = new Label();
            lbl_carroceria = new Label();
            tb_marca = new TextBox();
            lbl_fabricacão = new Label();
            tb_placa = new TextBox();
            tb_modelo = new TextBox();
            lbl_placa = new Label();
            tb_cor = new TextBox();
            lbl_modelo = new Label();
            tb_registro = new TextBox();
            lbl_cor = new Label();
            lbl_ano = new Label();
            lbl_marca = new Label();
            lbl_registro = new Label();
            lbl_transmissão = new Label();
            lbl_chassi = new Label();
            tb_chassi = new TextBox();
            tb_fabricacao = new TextBox();
            tb_transmissao = new TextBox();
            tb_combustivel = new TextBox();
            tb_ano = new TextBox();
            dtg_veiculos = new DataGridView();
            btn_editar = new DataGridViewImageColumn();
            btn_excluir = new DataGridViewImageColumn();
            lbl_name = new Label();
            tb_nome = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_veiculos).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_novo, toolStripSeparator1, btn_salvar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(784, 58);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btn_novo
            // 
            btn_novo.AutoSize = false;
            btn_novo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_novo.Image = Properties.Resources.novo;
            btn_novo.ImageScaling = ToolStripItemImageScaling.None;
            btn_novo.ImageTransparentColor = Color.Magenta;
            btn_novo.Name = "btn_novo";
            btn_novo.Size = new Size(98, 55);
            btn_novo.Text = "Novo";
            btn_novo.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_novo.Click += btn_novo_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 58);
            // 
            // btn_salvar
            // 
            btn_salvar.AutoSize = false;
            btn_salvar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_salvar.Image = Properties.Resources.salvar;
            btn_salvar.ImageScaling = ToolStripItemImageScaling.None;
            btn_salvar.ImageTransparentColor = Color.Magenta;
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(98, 55);
            btn_salvar.Text = "Salvar";
            btn_salvar.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // lbl_combustível
            // 
            lbl_combustível.AutoSize = true;
            lbl_combustível.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_combustível.Location = new Point(20, 164);
            lbl_combustível.Name = "lbl_combustível";
            lbl_combustível.Size = new Size(111, 20);
            lbl_combustível.TabIndex = 12;
            lbl_combustível.Text = "Combustível:";
            // 
            // tb_carroceria
            // 
            tb_carroceria.Location = new Point(134, 239);
            tb_carroceria.Name = "tb_carroceria";
            tb_carroceria.Size = new Size(325, 23);
            tb_carroceria.TabIndex = 7;
            // 
            // lbl_endereco
            // 
            lbl_endereco.AutoSize = true;
            lbl_endereco.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_endereco.Location = new Point(79, 291);
            lbl_endereco.Name = "lbl_endereco";
            lbl_endereco.Size = new Size(0, 20);
            lbl_endereco.TabIndex = 15;
            // 
            // lbl_carroceria
            // 
            lbl_carroceria.AutoSize = true;
            lbl_carroceria.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_carroceria.Location = new Point(19, 242);
            lbl_carroceria.Name = "lbl_carroceria";
            lbl_carroceria.Size = new Size(97, 20);
            lbl_carroceria.TabIndex = 14;
            lbl_carroceria.Text = "Carroceria:";
            // 
            // tb_marca
            // 
            tb_marca.Location = new Point(134, 126);
            tb_marca.Name = "tb_marca";
            tb_marca.Size = new Size(325, 23);
            tb_marca.TabIndex = 4;
            // 
            // lbl_fabricacão
            // 
            lbl_fabricacão.AutoSize = true;
            lbl_fabricacão.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_fabricacão.Location = new Point(16, 202);
            lbl_fabricacão.Name = "lbl_fabricacão";
            lbl_fabricacão.Size = new Size(103, 20);
            lbl_fabricacão.TabIndex = 13;
            lbl_fabricacão.Text = "Fabricação:";
            // 
            // tb_placa
            // 
            tb_placa.Location = new Point(84, 81);
            tb_placa.Name = "tb_placa";
            tb_placa.Size = new Size(217, 23);
            tb_placa.TabIndex = 2;
            // 
            // tb_modelo
            // 
            tb_modelo.Location = new Point(84, 68);
            tb_modelo.Name = "tb_modelo";
            tb_modelo.Size = new Size(217, 23);
            tb_modelo.TabIndex = 1;
            // 
            // lbl_placa
            // 
            lbl_placa.AutoSize = true;
            lbl_placa.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_placa.Location = new Point(12, 83);
            lbl_placa.Name = "lbl_placa";
            lbl_placa.Size = new Size(58, 20);
            lbl_placa.TabIndex = 5;
            lbl_placa.Text = "Placa:";
            // 
            // tb_cor
            // 
            tb_cor.Location = new Point(84, 48);
            tb_cor.Name = "tb_cor";
            tb_cor.Size = new Size(217, 23);
            tb_cor.TabIndex = 1;
            // 
            // lbl_modelo
            // 
            lbl_modelo.AutoSize = true;
            lbl_modelo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_modelo.Location = new Point(6, 71);
            lbl_modelo.Name = "lbl_modelo";
            lbl_modelo.Size = new Size(72, 20);
            lbl_modelo.TabIndex = 3;
            lbl_modelo.Text = "Modelo:";
            // 
            // tb_registro
            // 
            tb_registro.Enabled = false;
            tb_registro.Location = new Point(134, 87);
            tb_registro.Name = "tb_registro";
            tb_registro.ReadOnly = true;
            tb_registro.Size = new Size(55, 23);
            tb_registro.TabIndex = 2;
            tb_registro.Text = "0";
            // 
            // lbl_cor
            // 
            lbl_cor.AutoSize = true;
            lbl_cor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cor.Location = new Point(13, 50);
            lbl_cor.Name = "lbl_cor";
            lbl_cor.Size = new Size(42, 20);
            lbl_cor.TabIndex = 4;
            lbl_cor.Text = "Cor:";
            // 
            // lbl_ano
            // 
            lbl_ano.AutoSize = true;
            lbl_ano.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ano.Location = new Point(6, 26);
            lbl_ano.Name = "lbl_ano";
            lbl_ano.Size = new Size(46, 20);
            lbl_ano.TabIndex = 2;
            lbl_ano.Text = "Ano:";
            // 
            // lbl_marca
            // 
            lbl_marca.AutoSize = true;
            lbl_marca.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_marca.Location = new Point(56, 129);
            lbl_marca.Name = "lbl_marca";
            lbl_marca.Size = new Size(63, 20);
            lbl_marca.TabIndex = 11;
            lbl_marca.Text = "Marca:";
            // 
            // lbl_registro
            // 
            lbl_registro.AutoSize = true;
            lbl_registro.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_registro.Location = new Point(34, 92);
            lbl_registro.Name = "lbl_registro";
            lbl_registro.Size = new Size(82, 20);
            lbl_registro.TabIndex = 10;
            lbl_registro.Text = "Registro:";
            // 
            // lbl_transmissão
            // 
            lbl_transmissão.AutoSize = true;
            lbl_transmissão.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_transmissão.Location = new Point(4, 284);
            lbl_transmissão.Name = "lbl_transmissão";
            lbl_transmissão.Size = new Size(115, 20);
            lbl_transmissão.TabIndex = 17;
            lbl_transmissão.Text = "Transmissão:";
            // 
            // lbl_chassi
            // 
            lbl_chassi.AutoSize = true;
            lbl_chassi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_chassi.Location = new Point(13, 16);
            lbl_chassi.Name = "lbl_chassi";
            lbl_chassi.Size = new Size(68, 20);
            lbl_chassi.TabIndex = 3;
            lbl_chassi.Text = "Chassi:";
            // 
            // tb_chassi
            // 
            tb_chassi.Location = new Point(84, 14);
            tb_chassi.Name = "tb_chassi";
            tb_chassi.Size = new Size(217, 23);
            tb_chassi.TabIndex = 0;
            // 
            // tb_fabricacao
            // 
            tb_fabricacao.Location = new Point(134, 200);
            tb_fabricacao.Name = "tb_fabricacao";
            tb_fabricacao.Size = new Size(325, 23);
            tb_fabricacao.TabIndex = 6;
            // 
            // tb_transmissao
            // 
            tb_transmissao.Location = new Point(134, 281);
            tb_transmissao.Name = "tb_transmissao";
            tb_transmissao.Size = new Size(325, 23);
            tb_transmissao.TabIndex = 8;
            // 
            // tb_combustivel
            // 
            tb_combustivel.Location = new Point(134, 161);
            tb_combustivel.Name = "tb_combustivel";
            tb_combustivel.Size = new Size(325, 23);
            tb_combustivel.TabIndex = 5;
            // 
            // tb_ano
            // 
            tb_ano.Location = new Point(84, 25);
            tb_ano.Name = "tb_ano";
            tb_ano.Size = new Size(217, 23);
            tb_ano.TabIndex = 0;
            // 
            // dtg_veiculos
            // 
            dtg_veiculos.AllowUserToAddRows = false;
            dtg_veiculos.AllowUserToDeleteRows = false;
            dtg_veiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_veiculos.Columns.AddRange(new DataGridViewColumn[] { btn_editar, btn_excluir });
            dtg_veiculos.Location = new Point(12, 333);
            dtg_veiculos.Name = "dtg_veiculos";
            dtg_veiculos.ReadOnly = true;
            dtg_veiculos.Size = new Size(757, 216);
            dtg_veiculos.TabIndex = 9;
            dtg_veiculos.CellContentClick += dtg_veiculos_CellContentClick;
            // 
            // btn_editar
            // 
            btn_editar.HeaderText = "";
            btn_editar.Image = Properties.Resources.editar;
            btn_editar.Name = "btn_editar";
            btn_editar.ReadOnly = true;
            // 
            // btn_excluir
            // 
            btn_excluir.HeaderText = "";
            btn_excluir.Image = Properties.Resources.excluir;
            btn_excluir.Name = "btn_excluir";
            btn_excluir.ReadOnly = true;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_name.Location = new Point(204, 88);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(60, 20);
            lbl_name.TabIndex = 16;
            lbl_name.Text = "Nome:";
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(274, 87);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(185, 23);
            tb_nome.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb_ano);
            groupBox1.Controls.Add(lbl_ano);
            groupBox1.Controls.Add(lbl_modelo);
            groupBox1.Controls.Add(tb_modelo);
            groupBox1.Location = new Point(465, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(307, 104);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tb_placa);
            groupBox2.Controls.Add(lbl_placa);
            groupBox2.Controls.Add(tb_cor);
            groupBox2.Controls.Add(lbl_cor);
            groupBox2.Controls.Add(lbl_chassi);
            groupBox2.Controls.Add(tb_chassi);
            groupBox2.Location = new Point(465, 190);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(307, 114);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            // 
            // Frm_veiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dtg_veiculos);
            Controls.Add(lbl_combustível);
            Controls.Add(tb_fabricacao);
            Controls.Add(tb_combustivel);
            Controls.Add(tb_transmissao);
            Controls.Add(tb_carroceria);
            Controls.Add(lbl_endereco);
            Controls.Add(lbl_transmissão);
            Controls.Add(lbl_carroceria);
            Controls.Add(tb_nome);
            Controls.Add(tb_marca);
            Controls.Add(lbl_fabricacão);
            Controls.Add(tb_registro);
            Controls.Add(lbl_name);
            Controls.Add(lbl_marca);
            Controls.Add(lbl_registro);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Frm_veiculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_veiculos";
            Load += Frm_veiculo_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_veiculos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btn_novo;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btn_salvar;
        private Label lbl_combustível;
        private ToolStripButton toolStripButton2;
        private MaskedTextBox mkd_categoria;
        private TextBox tb_carroceria;
        private Label lbl_endereco;
        private Label lbl_carroceria;
        private Label lbl_cnh;
        private TextBox tb_marca;
        private Label lbl_fabricacão;
        private TextBox tb_placa;
        private TextBox tb_modelo;
        private Label lbl_idade;
        private Label lbl_placa;
        private TextBox tb_cor;
        private Label lbl_modelo;
        private TextBox tb_registro;
        private Label lbl_cor;
        private Label lbl_ano;
        private Label lbl_marca;
        private Label lbl_nome;
        private Label lbl_registro;
        private Label lbl_transmissão;
        private Label lbl_chassi;
        private TextBox tb_chassi;
        private TextBox tb_fabricacao;
        private TextBox tb_transmissao;
        private TextBox tb_combustivel;
        private TextBox tb_ano;
        private DataGridView dtg_veiculos;
        private Label lbl_name;
        private TextBox tb_nome;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridViewImageColumn btn_editar;
        private DataGridViewImageColumn btn_excluir;
    }
}
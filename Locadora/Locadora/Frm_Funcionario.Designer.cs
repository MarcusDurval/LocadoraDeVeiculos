namespace Locadora
{
    partial class Frm_Funcionario
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
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton2 = new ToolStripButton();
            groupBox1 = new GroupBox();
            msk_cpf = new MaskedTextBox();
            msk_rg = new MaskedTextBox();
            lbl_rg = new Label();
            lbl_cpf = new Label();
            groupBox2 = new GroupBox();
            tb_bairro = new TextBox();
            tb_estado = new TextBox();
            lbl_bairro = new Label();
            lbl_estado = new Label();
            lbl_rua = new Label();
            lbl_cidade = new Label();
            tb_rua = new TextBox();
            tb_cidade = new TextBox();
            msk_salario = new MaskedTextBox();
            msk_nascimento = new MaskedTextBox();
            dtp_contatro = new DateTimePicker();
            lbl_salario = new Label();
            lbl_telefone = new Label();
            tb_nome = new TextBox();
            lbl_idade = new Label();
            tb_genero = new TextBox();
            tb_registro = new TextBox();
            lbl_genero = new Label();
            lbl_contrato = new Label();
            lbl_nome = new Label();
            lbl_registro = new Label();
            dtg_funcionario = new DataGridView();
            msk_telefone = new MaskedTextBox();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_funcionario).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripSeparator1, toolStripButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(902, 58);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.AutoSize = false;
            toolStripButton1.Image = Properties.Resources.novo;
            toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(98, 55);
            toolStripButton1.Text = "Novo";
            toolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 58);
            // 
            // toolStripButton2
            // 
            toolStripButton2.AutoSize = false;
            toolStripButton2.Image = Properties.Resources.salvar;
            toolStripButton2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(98, 55);
            toolStripButton2.Text = "Salvar";
            toolStripButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(msk_cpf);
            groupBox1.Controls.Add(msk_rg);
            groupBox1.Controls.Add(lbl_rg);
            groupBox1.Controls.Add(lbl_cpf);
            groupBox1.Location = new Point(635, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(261, 81);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Documentos";
            // 
            // msk_cpf
            // 
            msk_cpf.Location = new Point(97, 52);
            msk_cpf.Mask = "999,999,999-99";
            msk_cpf.Name = "msk_cpf";
            msk_cpf.Size = new Size(128, 23);
            msk_cpf.TabIndex = 1;
            // 
            // msk_rg
            // 
            msk_rg.Location = new Point(97, 13);
            msk_rg.Mask = "999,999,999-99";
            msk_rg.Name = "msk_rg";
            msk_rg.Size = new Size(128, 23);
            msk_rg.TabIndex = 0;
            // 
            // lbl_rg
            // 
            lbl_rg.AutoSize = true;
            lbl_rg.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_rg.Location = new Point(9, 13);
            lbl_rg.Name = "lbl_rg";
            lbl_rg.Size = new Size(38, 18);
            lbl_rg.TabIndex = 3;
            lbl_rg.Text = "RG:";
            // 
            // lbl_cpf
            // 
            lbl_cpf.AutoSize = true;
            lbl_cpf.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cpf.Location = new Point(9, 55);
            lbl_cpf.Name = "lbl_cpf";
            lbl_cpf.Size = new Size(46, 18);
            lbl_cpf.TabIndex = 2;
            lbl_cpf.Text = "CPF:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tb_bairro);
            groupBox2.Controls.Add(tb_estado);
            groupBox2.Controls.Add(lbl_bairro);
            groupBox2.Controls.Add(lbl_estado);
            groupBox2.Controls.Add(lbl_rua);
            groupBox2.Controls.Add(lbl_cidade);
            groupBox2.Controls.Add(tb_rua);
            groupBox2.Controls.Add(tb_cidade);
            groupBox2.Location = new Point(635, 216);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(261, 176);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Localização";
            // 
            // tb_bairro
            // 
            tb_bairro.Location = new Point(97, 102);
            tb_bairro.Name = "tb_bairro";
            tb_bairro.Size = new Size(128, 23);
            tb_bairro.TabIndex = 2;
            // 
            // tb_estado
            // 
            tb_estado.Location = new Point(97, 19);
            tb_estado.Name = "tb_estado";
            tb_estado.Size = new Size(128, 23);
            tb_estado.TabIndex = 0;
            // 
            // lbl_bairro
            // 
            lbl_bairro.AutoSize = true;
            lbl_bairro.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_bairro.Location = new Point(9, 102);
            lbl_bairro.Name = "lbl_bairro";
            lbl_bairro.Size = new Size(59, 18);
            lbl_bairro.TabIndex = 5;
            lbl_bairro.Text = "Bairro:";
            // 
            // lbl_estado
            // 
            lbl_estado.AutoSize = true;
            lbl_estado.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_estado.Location = new Point(9, 19);
            lbl_estado.Name = "lbl_estado";
            lbl_estado.Size = new Size(66, 18);
            lbl_estado.TabIndex = 6;
            lbl_estado.Text = "Estado:";
            // 
            // lbl_rua
            // 
            lbl_rua.AutoSize = true;
            lbl_rua.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_rua.Location = new Point(9, 144);
            lbl_rua.Name = "lbl_rua";
            lbl_rua.Size = new Size(43, 18);
            lbl_rua.TabIndex = 4;
            lbl_rua.Text = "Rua:";
            // 
            // lbl_cidade
            // 
            lbl_cidade.AutoSize = true;
            lbl_cidade.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cidade.Location = new Point(9, 61);
            lbl_cidade.Name = "lbl_cidade";
            lbl_cidade.Size = new Size(65, 18);
            lbl_cidade.TabIndex = 1;
            lbl_cidade.Text = "Cidade:";
            // 
            // tb_rua
            // 
            tb_rua.Location = new Point(97, 144);
            tb_rua.Name = "tb_rua";
            tb_rua.Size = new Size(128, 23);
            tb_rua.TabIndex = 3;
            // 
            // tb_cidade
            // 
            tb_cidade.Location = new Point(97, 61);
            tb_cidade.Name = "tb_cidade";
            tb_cidade.Size = new Size(128, 23);
            tb_cidade.TabIndex = 1;
            // 
            // msk_salario
            // 
            msk_salario.Location = new Point(503, 216);
            msk_salario.Name = "msk_salario";
            msk_salario.Size = new Size(108, 23);
            msk_salario.TabIndex = 8;
            // 
            // msk_nascimento
            // 
            msk_nascimento.Location = new Point(193, 183);
            msk_nascimento.Mask = "00/00/0000";
            msk_nascimento.Name = "msk_nascimento";
            msk_nascimento.Size = new Size(235, 23);
            msk_nascimento.TabIndex = 5;
            // 
            // dtp_contatro
            // 
            dtp_contatro.CustomFormat = "dd/MM/yyyy";
            dtp_contatro.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtp_contatro.Format = DateTimePickerFormat.Short;
            dtp_contatro.Location = new Point(503, 111);
            dtp_contatro.Name = "dtp_contatro";
            dtp_contatro.Size = new Size(108, 22);
            dtp_contatro.TabIndex = 9;
            dtp_contatro.Value = new DateTime(2024, 11, 28, 1, 6, 47, 0);
            // 
            // lbl_salario
            // 
            lbl_salario.AutoSize = true;
            lbl_salario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_salario.Location = new Point(436, 219);
            lbl_salario.Name = "lbl_salario";
            lbl_salario.Size = new Size(70, 20);
            lbl_salario.TabIndex = 16;
            lbl_salario.Text = "Salario:";
            // 
            // lbl_telefone
            // 
            lbl_telefone.AutoSize = true;
            lbl_telefone.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_telefone.Location = new Point(91, 222);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(84, 20);
            lbl_telefone.TabIndex = 15;
            lbl_telefone.Text = "Telefone:";
            lbl_telefone.Click += lbl_cnh_Click;
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(193, 147);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(418, 23);
            tb_nome.TabIndex = 4;
            // 
            // lbl_idade
            // 
            lbl_idade.AutoSize = true;
            lbl_idade.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_idade.Location = new Point(-2, 183);
            lbl_idade.Name = "lbl_idade";
            lbl_idade.Size = new Size(177, 20);
            lbl_idade.TabIndex = 14;
            lbl_idade.Text = "Data de Nascimento:";
            // 
            // tb_genero
            // 
            tb_genero.Location = new Point(503, 180);
            tb_genero.Name = "tb_genero";
            tb_genero.Size = new Size(108, 23);
            tb_genero.TabIndex = 7;
            // 
            // tb_registro
            // 
            tb_registro.Enabled = false;
            tb_registro.Location = new Point(193, 108);
            tb_registro.Name = "tb_registro";
            tb_registro.ReadOnly = true;
            tb_registro.Size = new Size(55, 23);
            tb_registro.TabIndex = 3;
            tb_registro.Text = "0";
            // 
            // lbl_genero
            // 
            lbl_genero.AutoSize = true;
            lbl_genero.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_genero.Location = new Point(432, 182);
            lbl_genero.Name = "lbl_genero";
            lbl_genero.Size = new Size(74, 20);
            lbl_genero.TabIndex = 17;
            lbl_genero.Text = "Genero:";
            // 
            // lbl_contrato
            // 
            lbl_contrato.AutoSize = true;
            lbl_contrato.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_contrato.Location = new Point(346, 113);
            lbl_contrato.Name = "lbl_contrato";
            lbl_contrato.Size = new Size(148, 20);
            lbl_contrato.TabIndex = 11;
            lbl_contrato.Text = "Data do Contrato";
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nome.Location = new Point(115, 150);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(60, 20);
            lbl_nome.TabIndex = 13;
            lbl_nome.Text = "Nome:";
            // 
            // lbl_registro
            // 
            lbl_registro.AutoSize = true;
            lbl_registro.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_registro.Location = new Point(93, 113);
            lbl_registro.Name = "lbl_registro";
            lbl_registro.Size = new Size(82, 20);
            lbl_registro.TabIndex = 12;
            lbl_registro.Text = "Registro:";
            // 
            // dtg_funcionario
            // 
            dtg_funcionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_funcionario.Location = new Point(12, 257);
            dtg_funcionario.Name = "dtg_funcionario";
            dtg_funcionario.Size = new Size(608, 285);
            dtg_funcionario.TabIndex = 0;
            // 
            // msk_telefone
            // 
            msk_telefone.Location = new Point(193, 223);
            msk_telefone.Mask = "(99) 0000-000000";
            msk_telefone.Name = "msk_telefone";
            msk_telefone.Size = new Size(235, 23);
            msk_telefone.TabIndex = 6;
            // 
            // Frm_Funcionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 554);
            Controls.Add(msk_telefone);
            Controls.Add(dtg_funcionario);
            Controls.Add(msk_salario);
            Controls.Add(msk_nascimento);
            Controls.Add(dtp_contatro);
            Controls.Add(lbl_salario);
            Controls.Add(lbl_telefone);
            Controls.Add(tb_nome);
            Controls.Add(lbl_idade);
            Controls.Add(tb_genero);
            Controls.Add(tb_registro);
            Controls.Add(lbl_genero);
            Controls.Add(lbl_contrato);
            Controls.Add(lbl_nome);
            Controls.Add(lbl_registro);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Frm_Funcionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Funcionario";
            Load += Frm_Funcionario_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_funcionario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton2;
        private GroupBox groupBox1;
        private Label lbl_rg;
        private Label lbl_cpf;
        private GroupBox groupBox2;
        private TextBox tb_bairro;
        private TextBox tb_estado;
        private Label lbl_bairro;
        private Label lbl_estado;
        private Label lbl_rua;
        private Label lbl_cidade;
        private TextBox tb_rua;
        private TextBox tb_cidade;
        private MaskedTextBox msk_salario;
        private MaskedTextBox msk_nascimento;
        private DateTimePicker dtp_contatro;
        private Label lbl_salario;
        private Label lbl_telefone;
        private TextBox tb_nome;
        private Label lbl_idade;
        private TextBox tb_genero;
        private TextBox tb_registro;
        private Label lbl_genero;
        private Label lbl_contrato;
        private Label lbl_nome;
        private Label lbl_registro;
        private DataGridView dtg_funcionario;
        private MaskedTextBox msk_telefone;
        private MaskedTextBox msk_cpf;
        private MaskedTextBox msk_rg;
    }
}
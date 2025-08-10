namespace Locadora
{
    partial class Frm_cliente
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
            lbl_registro = new Label();
            tb_registro = new TextBox();
            lbl_nome = new Label();
            tb_nome = new TextBox();
            lbl_idade = new Label();
            lbl_cnh = new Label();
            tb_cnh = new TextBox();
            lbl_endereco = new Label();
            gb_documentos = new GroupBox();
            msk_rg = new MaskedTextBox();
            msk_cep = new MaskedTextBox();
            label4 = new Label();
            mkd_cpf = new MaskedTextBox();
            lbl_cpf = new Label();
            lbl_rg = new Label();
            lbl_categoria = new Label();
            gb_contato = new GroupBox();
            mkd_telefone2 = new MaskedTextBox();
            mkd_telefone1 = new MaskedTextBox();
            lbl_telefone2 = new Label();
            lbl_telefone1 = new Label();
            dtp_cadastro = new DateTimePicker();
            lbl_cadastro = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            mkd_nascimento = new MaskedTextBox();
            mkd_categoria = new MaskedTextBox();
            lbl_genero = new Label();
            tb_genero = new TextBox();
            dtg_cliente = new DataGridView();
            btn_editar = new DataGridViewImageColumn();
            btn_excluir = new DataGridViewImageColumn();
            mkd_logradouro = new MaskedTextBox();
            label1 = new Label();
            tb_estado = new TextBox();
            label2 = new Label();
            mkd_cidade = new MaskedTextBox();
            label3 = new Label();
            tb_bairro = new TextBox();
            toolStrip1.SuspendLayout();
            gb_documentos.SuspendLayout();
            gb_contato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_cliente).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_novo, toolStripSeparator1, btn_salvar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(921, 58);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btn_novo
            // 
            btn_novo.AutoSize = false;
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
            btn_salvar.Image = Properties.Resources.salvar;
            btn_salvar.ImageScaling = ToolStripItemImageScaling.None;
            btn_salvar.ImageTransparentColor = Color.Magenta;
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(98, 55);
            btn_salvar.Text = "Salvar";
            btn_salvar.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // lbl_registro
            // 
            lbl_registro.AutoSize = true;
            lbl_registro.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_registro.Location = new Point(98, 106);
            lbl_registro.Name = "lbl_registro";
            lbl_registro.Size = new Size(82, 20);
            lbl_registro.TabIndex = 1;
            lbl_registro.Text = "Registro:";
            // 
            // tb_registro
            // 
            tb_registro.BorderStyle = BorderStyle.FixedSingle;
            tb_registro.Cursor = Cursors.IBeam;
            tb_registro.Location = new Point(198, 101);
            tb_registro.Name = "tb_registro";
            tb_registro.ReadOnly = true;
            tb_registro.Size = new Size(55, 23);
            tb_registro.TabIndex = 2;
            tb_registro.Text = "0";
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nome.Location = new Point(120, 143);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(60, 20);
            lbl_nome.TabIndex = 1;
            lbl_nome.Text = "Nome:";
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(198, 140);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(418, 23);
            tb_nome.TabIndex = 3;
            // 
            // lbl_idade
            // 
            lbl_idade.AutoSize = true;
            lbl_idade.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_idade.Location = new Point(3, 176);
            lbl_idade.Name = "lbl_idade";
            lbl_idade.Size = new Size(177, 20);
            lbl_idade.TabIndex = 1;
            lbl_idade.Text = "Data de Nascimento:";
            // 
            // lbl_cnh
            // 
            lbl_cnh.AutoSize = true;
            lbl_cnh.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cnh.Location = new Point(39, 215);
            lbl_cnh.Name = "lbl_cnh";
            lbl_cnh.Size = new Size(141, 20);
            lbl_cnh.TabIndex = 1;
            lbl_cnh.Text = "Registro da cnh:";
            // 
            // tb_cnh
            // 
            tb_cnh.Location = new Point(198, 212);
            tb_cnh.Name = "tb_cnh";
            tb_cnh.Size = new Size(235, 23);
            tb_cnh.TabIndex = 5;
            // 
            // lbl_endereco
            // 
            lbl_endereco.AutoSize = true;
            lbl_endereco.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_endereco.Location = new Point(74, 257);
            lbl_endereco.Name = "lbl_endereco";
            lbl_endereco.Size = new Size(106, 20);
            lbl_endereco.TabIndex = 1;
            lbl_endereco.Text = "Logradouro:";
            // 
            // gb_documentos
            // 
            gb_documentos.Controls.Add(msk_rg);
            gb_documentos.Controls.Add(msk_cep);
            gb_documentos.Controls.Add(label4);
            gb_documentos.Controls.Add(mkd_cpf);
            gb_documentos.Controls.Add(lbl_cpf);
            gb_documentos.Controls.Add(lbl_rg);
            gb_documentos.Location = new Point(648, 97);
            gb_documentos.Name = "gb_documentos";
            gb_documentos.Size = new Size(261, 118);
            gb_documentos.TabIndex = 4;
            gb_documentos.TabStop = false;
            gb_documentos.Text = "Documentos";
            // 
            // msk_rg
            // 
            msk_rg.Location = new Point(65, 19);
            msk_rg.Mask = "999,999,999-99";
            msk_rg.Name = "msk_rg";
            msk_rg.Size = new Size(128, 23);
            msk_rg.TabIndex = 0;
            // 
            // msk_cep
            // 
            msk_cep.Location = new Point(65, 84);
            msk_cep.Mask = "99999-999";
            msk_cep.Name = "msk_cep";
            msk_cep.Size = new Size(128, 23);
            msk_cep.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 84);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 1;
            label4.Text = "CEP:";
            // 
            // mkd_cpf
            // 
            mkd_cpf.Location = new Point(65, 52);
            mkd_cpf.Mask = "999,999,999-99";
            mkd_cpf.Name = "mkd_cpf";
            mkd_cpf.Size = new Size(128, 23);
            mkd_cpf.TabIndex = 1;
            // 
            // lbl_cpf
            // 
            lbl_cpf.AutoSize = true;
            lbl_cpf.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cpf.Location = new Point(6, 52);
            lbl_cpf.Name = "lbl_cpf";
            lbl_cpf.Size = new Size(48, 20);
            lbl_cpf.TabIndex = 1;
            lbl_cpf.Text = "CPF:";
            // 
            // lbl_rg
            // 
            lbl_rg.AutoSize = true;
            lbl_rg.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_rg.Location = new Point(6, 19);
            lbl_rg.Name = "lbl_rg";
            lbl_rg.Size = new Size(41, 20);
            lbl_rg.TabIndex = 1;
            lbl_rg.Text = "RG:";
            // 
            // lbl_categoria
            // 
            lbl_categoria.AutoSize = true;
            lbl_categoria.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_categoria.Location = new Point(438, 212);
            lbl_categoria.Name = "lbl_categoria";
            lbl_categoria.Size = new Size(92, 20);
            lbl_categoria.TabIndex = 1;
            lbl_categoria.Text = "Categoria:";
            // 
            // gb_contato
            // 
            gb_contato.Controls.Add(mkd_telefone2);
            gb_contato.Controls.Add(mkd_telefone1);
            gb_contato.Controls.Add(lbl_telefone2);
            gb_contato.Controls.Add(lbl_telefone1);
            gb_contato.Location = new Point(648, 235);
            gb_contato.Name = "gb_contato";
            gb_contato.Size = new Size(261, 81);
            gb_contato.TabIndex = 4;
            gb_contato.TabStop = false;
            gb_contato.Text = "Contato";
            // 
            // mkd_telefone2
            // 
            mkd_telefone2.Enabled = false;
            mkd_telefone2.Location = new Point(106, 49);
            mkd_telefone2.Mask = "(99) 0000-0000";
            mkd_telefone2.Name = "mkd_telefone2";
            mkd_telefone2.Size = new Size(128, 23);
            mkd_telefone2.TabIndex = 1;
            // 
            // mkd_telefone1
            // 
            mkd_telefone1.Location = new Point(106, 17);
            mkd_telefone1.Mask = "(99) 0000-000000";
            mkd_telefone1.Name = "mkd_telefone1";
            mkd_telefone1.Size = new Size(128, 23);
            mkd_telefone1.TabIndex = 0;
            // 
            // lbl_telefone2
            // 
            lbl_telefone2.AutoSize = true;
            lbl_telefone2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_telefone2.Location = new Point(6, 52);
            lbl_telefone2.Name = "lbl_telefone2";
            lbl_telefone2.Size = new Size(94, 20);
            lbl_telefone2.TabIndex = 1;
            lbl_telefone2.Text = "Telefone2:";
            // 
            // lbl_telefone1
            // 
            lbl_telefone1.AutoSize = true;
            lbl_telefone1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_telefone1.Location = new Point(6, 19);
            lbl_telefone1.Name = "lbl_telefone1";
            lbl_telefone1.Size = new Size(84, 20);
            lbl_telefone1.TabIndex = 1;
            lbl_telefone1.Text = "Telefone:";
            // 
            // dtp_cadastro
            // 
            dtp_cadastro.CustomFormat = "dd/MM/yyyy";
            dtp_cadastro.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtp_cadastro.Format = DateTimePickerFormat.Short;
            dtp_cadastro.Location = new Point(508, 104);
            dtp_cadastro.Name = "dtp_cadastro";
            dtp_cadastro.Size = new Size(108, 22);
            dtp_cadastro.TabIndex = 12;
            dtp_cadastro.Value = new DateTime(2024, 11, 28, 1, 6, 47, 0);
            // 
            // lbl_cadastro
            // 
            lbl_cadastro.AutoSize = true;
            lbl_cadastro.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cadastro.Location = new Point(351, 106);
            lbl_cadastro.Name = "lbl_cadastro";
            lbl_cadastro.Size = new Size(151, 20);
            lbl_cadastro.TabIndex = 1;
            lbl_cadastro.Text = "Data de Cadastro";
            // 
            // mkd_nascimento
            // 
            mkd_nascimento.Location = new Point(198, 176);
            mkd_nascimento.Mask = "00/00/0000";
            mkd_nascimento.Name = "mkd_nascimento";
            mkd_nascimento.Size = new Size(235, 23);
            mkd_nascimento.TabIndex = 4;
            // 
            // mkd_categoria
            // 
            mkd_categoria.Location = new Point(537, 209);
            mkd_categoria.Mask = "A/A";
            mkd_categoria.Name = "mkd_categoria";
            mkd_categoria.Size = new Size(79, 23);
            mkd_categoria.TabIndex = 10;
            // 
            // lbl_genero
            // 
            lbl_genero.AutoSize = true;
            lbl_genero.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_genero.Location = new Point(437, 175);
            lbl_genero.Name = "lbl_genero";
            lbl_genero.Size = new Size(74, 20);
            lbl_genero.TabIndex = 1;
            lbl_genero.Text = "Genero:";
            // 
            // tb_genero
            // 
            tb_genero.Location = new Point(508, 173);
            tb_genero.Name = "tb_genero";
            tb_genero.Size = new Size(108, 23);
            tb_genero.TabIndex = 11;
            // 
            // dtg_cliente
            // 
            dtg_cliente.AllowUserToAddRows = false;
            dtg_cliente.AllowUserToDeleteRows = false;
            dtg_cliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_cliente.Columns.AddRange(new DataGridViewColumn[] { btn_editar, btn_excluir });
            dtg_cliente.Location = new Point(12, 359);
            dtg_cliente.Name = "dtg_cliente";
            dtg_cliente.ReadOnly = true;
            dtg_cliente.Size = new Size(897, 261);
            dtg_cliente.TabIndex = 13;
            dtg_cliente.CellContentClick += dtg_cliente_CellContentClick;
            // 
            // btn_editar
            // 
            btn_editar.HeaderText = "";
            btn_editar.Image = Properties.Resources.editar;
            btn_editar.Name = "btn_editar";
            btn_editar.ReadOnly = true;
            btn_editar.Width = 30;
            // 
            // btn_excluir
            // 
            btn_excluir.HeaderText = "";
            btn_excluir.Image = Properties.Resources.excluir;
            btn_excluir.Name = "btn_excluir";
            btn_excluir.ReadOnly = true;
            btn_excluir.Width = 30;
            // 
            // mkd_logradouro
            // 
            mkd_logradouro.Location = new Point(198, 256);
            mkd_logradouro.Name = "mkd_logradouro";
            mkd_logradouro.Size = new Size(235, 23);
            mkd_logradouro.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(436, 254);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 1;
            label1.Text = "Estado:";
            // 
            // tb_estado
            // 
            tb_estado.Location = new Point(508, 252);
            tb_estado.Name = "tb_estado";
            tb_estado.Size = new Size(108, 23);
            tb_estado.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(110, 296);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Cidade:";
            // 
            // mkd_cidade
            // 
            mkd_cidade.Location = new Point(198, 293);
            mkd_cidade.Name = "mkd_cidade";
            mkd_cidade.Size = new Size(235, 23);
            mkd_cidade.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(436, 295);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 1;
            label3.Text = "Bairro:";
            // 
            // tb_bairro
            // 
            tb_bairro.Location = new Point(508, 293);
            tb_bairro.Name = "tb_bairro";
            tb_bairro.Size = new Size(108, 23);
            tb_bairro.TabIndex = 8;
            // 
            // Frm_cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 632);
            Controls.Add(mkd_cidade);
            Controls.Add(mkd_logradouro);
            Controls.Add(dtg_cliente);
            Controls.Add(mkd_categoria);
            Controls.Add(mkd_nascimento);
            Controls.Add(dtp_cadastro);
            Controls.Add(gb_contato);
            Controls.Add(gb_documentos);
            Controls.Add(label2);
            Controls.Add(tb_cnh);
            Controls.Add(lbl_endereco);
            Controls.Add(lbl_cnh);
            Controls.Add(tb_nome);
            Controls.Add(lbl_idade);
            Controls.Add(tb_bairro);
            Controls.Add(tb_estado);
            Controls.Add(label3);
            Controls.Add(tb_genero);
            Controls.Add(label1);
            Controls.Add(tb_registro);
            Controls.Add(lbl_genero);
            Controls.Add(lbl_categoria);
            Controls.Add(lbl_cadastro);
            Controls.Add(lbl_nome);
            Controls.Add(lbl_registro);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Frm_cliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_clientes";
            Load += Frm_clientes_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            gb_documentos.ResumeLayout(false);
            gb_documentos.PerformLayout();
            gb_contato.ResumeLayout(false);
            gb_contato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_cliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btn_novo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btn_salvar;
        private Label lbl_registro;
        private TextBox tb_registro;
        private Label lbl_nome;
        private TextBox tb_nome;
        private Label lbl_idade;
        private Label lbl_cnh;
        private TextBox tb_cnh;
        private Label lbl_endereco;
        private GroupBox gb_documentos;
        private Label lbl_categoria;
        private MaskedTextBox mkd_cpf;
        private Label lbl_cpf;
        private Label lbl_rg;
        private GroupBox gb_contato;
        private MaskedTextBox mkd_telefone2;
        private MaskedTextBox mkd_telefone1;
        private Label lbl_telefone2;
        private Label lbl_telefone1;
        private DateTimePicker dtp_cadastro;
        private Label lbl_cadastro;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MaskedTextBox mkd_nascimento;
        private MaskedTextBox mkd_categoria;
        private Label lbl_genero;
        private TextBox tb_genero;
        private DataGridView dtg_cliente;
        private MaskedTextBox mkd_logradouro;
        private Label label1;
        private TextBox tb_estado;
        private Label label2;
        private MaskedTextBox mkd_cidade;
        private Label label3;
        private TextBox tb_bairro;
        private MaskedTextBox msk_rg;
        private MaskedTextBox msk_cep;
        private Label label4;
        private DataGridViewImageColumn btn_editar;
        private DataGridViewImageColumn btn_excluir;
    }
}
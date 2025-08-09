namespace Locadora
{
    partial class Frm_principal
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
            pictureBox1 = new PictureBox();
            toolStrip1 = new ToolStrip();
            btn_locadora = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btn_funcionarios = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btn_clientes = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btn_veiculos = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripSeparator4 = new ToolStripSeparator();
            lbl_usuario = new ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ganho_de_capital_venda_veiculo;
            pictureBox1.Location = new Point(0, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 384);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_locadora, toolStripSeparator3, btn_funcionarios, toolStripSeparator1, btn_clientes, toolStripSeparator2, btn_veiculos, toolStripButton5, toolStripSeparator5, toolStripSeparator4, lbl_usuario });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(800, 58);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btn_locadora
            // 
            btn_locadora.AutoSize = false;
            btn_locadora.Image = Properties.Resources.orçamentos;
            btn_locadora.ImageScaling = ToolStripItemImageScaling.None;
            btn_locadora.ImageTransparentColor = Color.Magenta;
            btn_locadora.Name = "btn_locadora";
            btn_locadora.Size = new Size(98, 55);
            btn_locadora.Text = "Locação";
            btn_locadora.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_locadora.Click += toolStripButton2_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 58);
            // 
            // btn_funcionarios
            // 
            btn_funcionarios.AutoSize = false;
            btn_funcionarios.Enabled = false;
            btn_funcionarios.Image = Properties.Resources.funcionários;
            btn_funcionarios.ImageScaling = ToolStripItemImageScaling.None;
            btn_funcionarios.ImageTransparentColor = Color.Magenta;
            btn_funcionarios.Name = "btn_funcionarios";
            btn_funcionarios.Size = new Size(98, 55);
            btn_funcionarios.Text = "Funcionarios";
            btn_funcionarios.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_funcionarios.Click += toolStripButton3_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 58);
            // 
            // btn_clientes
            // 
            btn_clientes.AutoSize = false;
            btn_clientes.Enabled = false;
            btn_clientes.Image = Properties.Resources.clientes;
            btn_clientes.ImageScaling = ToolStripItemImageScaling.None;
            btn_clientes.ImageTransparentColor = Color.Magenta;
            btn_clientes.Name = "btn_clientes";
            btn_clientes.Size = new Size(98, 55);
            btn_clientes.Text = "Clientes";
            btn_clientes.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_clientes.Click += toolStripButton1_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 58);
            // 
            // btn_veiculos
            // 
            btn_veiculos.AutoSize = false;
            btn_veiculos.Enabled = false;
            btn_veiculos.Image = Properties.Resources.pequeno;
            btn_veiculos.ImageScaling = ToolStripItemImageScaling.None;
            btn_veiculos.ImageTransparentColor = Color.Magenta;
            btn_veiculos.Name = "btn_veiculos";
            btn_veiculos.Size = new Size(98, 55);
            btn_veiculos.Text = "Veiculos";
            btn_veiculos.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_veiculos.Click += toolStripButton4_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.Alignment = ToolStripItemAlignment.Right;
            toolStripButton5.AutoSize = false;
            toolStripButton5.Image = Properties.Resources.excluir;
            toolStripButton5.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(98, 55);
            toolStripButton5.Text = "Sair";
            toolStripButton5.TextAlign = ContentAlignment.BottomCenter;
            toolStripButton5.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton5.Click += toolStripButton5_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 58);
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 58);
            // 
            // lbl_usuario
            // 
            lbl_usuario.Alignment = ToolStripItemAlignment.Right;
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(0, 55);
            lbl_usuario.Click += lbl_usuario_Click;
            // 
            // Frm_principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Frm_principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_principal";
            Load += Frm_principal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private ToolStrip toolStrip1;
        private ToolStripButton btn_locadora;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btn_funcionarios;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btn_clientes;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btn_veiculos;
        private ToolStripButton toolStripButton5;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripLabel lbl_usuario;
    }
}
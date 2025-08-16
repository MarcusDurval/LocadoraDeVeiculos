namespace Locadora
{
    partial class Frm_cadastro
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
            gp_cadastra = new GroupBox();
            lbl_cadastro = new Label();
            tb_confsenha = new TextBox();
            tb_senha = new TextBox();
            tb_email = new TextBox();
            toolStrip2 = new ToolStrip();
            btn_entrar = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            pb_imagem = new PictureBox();
            gp_cadastra.SuspendLayout();
            toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_imagem).BeginInit();
            SuspendLayout();
            // 
            // gp_cadastra
            // 
            gp_cadastra.Controls.Add(lbl_cadastro);
            gp_cadastra.Controls.Add(tb_confsenha);
            gp_cadastra.Controls.Add(tb_senha);
            gp_cadastra.Controls.Add(tb_email);
            gp_cadastra.Location = new Point(464, 5);
            gp_cadastra.Name = "gp_cadastra";
            gp_cadastra.Size = new Size(334, 426);
            gp_cadastra.TabIndex = 0;
            gp_cadastra.TabStop = false;
            // 
            // lbl_cadastro
            // 
            lbl_cadastro.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cadastro.ForeColor = Color.Gray;
            lbl_cadastro.Location = new Point(100, 19);
            lbl_cadastro.Name = "lbl_cadastro";
            lbl_cadastro.Size = new Size(137, 25);
            lbl_cadastro.TabIndex = 1;
            lbl_cadastro.Text = "CADASTRE-SE";
            // 
            // tb_confsenha
            // 
            tb_confsenha.Location = new Point(40, 181);
            tb_confsenha.Name = "tb_confsenha";
            tb_confsenha.PasswordChar = '*';
            tb_confsenha.PlaceholderText = "Confirmar-Senha";
            tb_confsenha.Size = new Size(276, 23);
            tb_confsenha.TabIndex = 0;
            tb_confsenha.TextAlign = HorizontalAlignment.Center;
            tb_confsenha.TextChanged += tb_confsenha_TextChanged;
            // 
            // tb_senha
            // 
            tb_senha.Location = new Point(40, 138);
            tb_senha.Name = "tb_senha";
            tb_senha.PasswordChar = '*';
            tb_senha.PlaceholderText = "Senha";
            tb_senha.Size = new Size(276, 23);
            tb_senha.TabIndex = 0;
            tb_senha.TextAlign = HorizontalAlignment.Center;
            tb_senha.TextChanged += tb_senha_TextChanged;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(40, 96);
            tb_email.Name = "tb_email";
            tb_email.PlaceholderText = "E-mail";
            tb_email.Size = new Size(276, 23);
            tb_email.TabIndex = 0;
            tb_email.TextAlign = HorizontalAlignment.Center;
            tb_email.TextChanged += tb_email_TextChanged;
            // 
            // toolStrip2
            // 
            toolStrip2.AutoSize = false;
            toolStrip2.Dock = DockStyle.None;
            toolStrip2.Items.AddRange(new ToolStripItem[] { btn_entrar, toolStripSeparator3 });
            toolStrip2.Location = new Point(0, 427);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(800, 46);
            toolStrip2.TabIndex = 2;
            toolStrip2.Text = "toolStrip2";
            // 
            // btn_entrar
            // 
            btn_entrar.Alignment = ToolStripItemAlignment.Right;
            btn_entrar.AutoSize = false;
            btn_entrar.Image = Properties.Resources.entrar1;
            btn_entrar.ImageScaling = ToolStripItemImageScaling.None;
            btn_entrar.ImageTransparentColor = Color.Magenta;
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(98, 55);
            btn_entrar.Text = "Cadastrar:";
            btn_entrar.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_entrar.Click += btn_entrar_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 46);
            // 
            // pb_imagem
            // 
            pb_imagem.Image = Properties.Resources.ganho_de_capital_venda_veiculo;
            pb_imagem.Location = new Point(0, 12);
            pb_imagem.Name = "pb_imagem";
            pb_imagem.Size = new Size(460, 412);
            pb_imagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_imagem.TabIndex = 3;
            pb_imagem.TabStop = false;
            // 
            // Frm_cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 471);
            Controls.Add(pb_imagem);
            Controls.Add(toolStrip2);
            Controls.Add(gp_cadastra);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Frm_cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_cadastro";
            gp_cadastra.ResumeLayout(false);
            gp_cadastra.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_imagem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gp_cadastra;
        private TextBox tb_confsenha;
        private TextBox tb_senha;
        private TextBox tb_email;
        private Label lbl_cadastro;
        private ToolStrip toolStrip2;
        private ToolStripButton btn_entrar;
        private ToolStripSeparator toolStripSeparator3;
        private PictureBox pb_imagem;
    }
}
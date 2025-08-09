namespace Locadora
{
    partial class Frm_Locação
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
            lbl_title = new Label();
            cmb_veiculo = new ComboBox();
            dtp_time = new DateTimePicker();
            lbl_name = new Label();
            groupBox1 = new GroupBox();
            dtg_veiculo = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_veiculo).BeginInit();
            SuspendLayout();
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_title.Location = new Point(279, 62);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(204, 20);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "Escolha o seu veiculo:";
            // 
            // cmb_veiculo
            // 
            cmb_veiculo.FormattingEnabled = true;
            cmb_veiculo.Location = new Point(279, 85);
            cmb_veiculo.Name = "cmb_veiculo";
            cmb_veiculo.Size = new Size(204, 23);
            cmb_veiculo.TabIndex = 1;
            cmb_veiculo.SelectedIndexChanged += cmb_veiculo_SelectedIndexChanged;
            // 
            // dtp_time
            // 
            dtp_time.Format = DateTimePickerFormat.Time;
            dtp_time.Location = new Point(617, 12);
            dtp_time.Name = "dtp_time";
            dtp_time.Size = new Size(95, 23);
            dtp_time.TabIndex = 3;
            dtp_time.ValueChanged += dtp_time_ValueChanged;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_name.Location = new Point(630, 48);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(0, 15);
            lbl_name.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtg_veiculo);
            groupBox1.Location = new Point(12, 188);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(713, 263);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados veicular";
            // 
            // dtg_veiculo
            // 
            dtg_veiculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_veiculo.Location = new Point(6, 22);
            dtg_veiculo.Name = "dtg_veiculo";
            dtg_veiculo.Size = new Size(688, 235);
            dtg_veiculo.TabIndex = 0;
            // 
            // Frm_Locação
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(738, 457);
            Controls.Add(groupBox1);
            Controls.Add(lbl_name);
            Controls.Add(dtp_time);
            Controls.Add(cmb_veiculo);
            Controls.Add(lbl_title);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Frm_Locação";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Locação";
            Load += Frm_Locação_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_veiculo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_title;
        private ComboBox cmb_veiculo;
        private DateTimePicker dtp_time;
        private Label lbl_name;
        private GroupBox groupBox1;
        private DataGridView dtg_veiculo;
    }
}
namespace Hospital_Project
{
    partial class Secretary_Login_Panel
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
            this.btn_giris = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sifre_txt = new System.Windows.Forms.TextBox();
            this.sifre_label = new System.Windows.Forms.Label();
            this.tc_txt = new System.Windows.Forms.MaskedTextBox();
            this.no_label = new System.Windows.Forms.Label();
            this.btnhatirla = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(229, 194);
            this.btn_giris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(108, 23);
            this.btn_giris.TabIndex = 3;
            this.btn_giris.Text = "Giris Yap";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hospital_Project.Properties.Resources.sekreter_logo;
            this.pictureBox1.Location = new System.Drawing.Point(188, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // sifre_txt
            // 
            this.sifre_txt.Location = new System.Drawing.Point(229, 167);
            this.sifre_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sifre_txt.Name = "sifre_txt";
            this.sifre_txt.Size = new System.Drawing.Size(108, 22);
            this.sifre_txt.TabIndex = 2;
            // 
            // sifre_label
            // 
            this.sifre_label.AutoSize = true;
            this.sifre_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sifre_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.sifre_label.Location = new System.Drawing.Point(165, 166);
            this.sifre_label.Name = "sifre_label";
            this.sifre_label.Size = new System.Drawing.Size(58, 28);
            this.sifre_label.TabIndex = 15;
            this.sifre_label.Text = "Şifre:";
            // 
            // tc_txt
            // 
            this.tc_txt.Font = new System.Drawing.Font("Calibri Light", 10.8F);
            this.tc_txt.Location = new System.Drawing.Point(229, 137);
            this.tc_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tc_txt.Mask = "00000000000";
            this.tc_txt.Name = "tc_txt";
            this.tc_txt.Size = new System.Drawing.Size(108, 29);
            this.tc_txt.TabIndex = 1;
            // 
            // no_label
            // 
            this.no_label.AutoSize = true;
            this.no_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.no_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.no_label.Location = new System.Drawing.Point(117, 134);
            this.no_label.Name = "no_label";
            this.no_label.Size = new System.Drawing.Size(106, 28);
            this.no_label.TabIndex = 13;
            this.no_label.Text = "Kimlik No:";
            // 
            // btnhatirla
            // 
            this.btnhatirla.AutoSize = true;
            this.btnhatirla.Location = new System.Drawing.Point(387, 246);
            this.btnhatirla.Name = "btnhatirla";
            this.btnhatirla.Size = new System.Drawing.Size(98, 20);
            this.btnhatirla.TabIndex = 26;
            this.btnhatirla.Text = "Beni Hatırla";
            this.btnhatirla.UseVisualStyleBackColor = true;
            this.btnhatirla.CheckedChanged += new System.EventHandler(this.btnhatirla_CheckedChanged);
            // 
            // Sekreter_Giris_Paneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(488, 267);
            this.Controls.Add(this.btnhatirla);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sifre_txt);
            this.Controls.Add(this.sifre_label);
            this.Controls.Add(this.tc_txt);
            this.Controls.Add(this.no_label);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Sekreter_Giris_Paneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sekreter_Giris_Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sekreter_Giris_Paneli_FormClosing);
            this.Load += new System.EventHandler(this.Sekreter_Giris_Paneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_giris;
        private PictureBox pictureBox1;
        private TextBox sifre_txt;
        private Label sifre_label;
        private MaskedTextBox tc_txt;
        private Label no_label;
        private CheckBox btnhatirla;
    }
}
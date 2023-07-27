namespace Hospital_Project
{
    partial class Patient_Login_Panel
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
            this.no_label = new System.Windows.Forms.Label();
            this.tc_txt = new System.Windows.Forms.MaskedTextBox();
            this.sifre_label = new System.Windows.Forms.Label();
            this.sifre_txt = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kayitol_label = new System.Windows.Forms.LinkLabel();
            this.btnhatirla = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // no_label
            // 
            this.no_label.AutoSize = true;
            this.no_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.no_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.no_label.Location = new System.Drawing.Point(119, 118);
            this.no_label.Name = "no_label";
            this.no_label.Size = new System.Drawing.Size(106, 28);
            this.no_label.TabIndex = 0;
            this.no_label.Text = "Kimlik No:";
            // 
            // tc_txt
            // 
            this.tc_txt.Font = new System.Drawing.Font("Calibri Light", 10.8F);
            this.tc_txt.Location = new System.Drawing.Point(231, 118);
            this.tc_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tc_txt.Mask = "00000000000";
            this.tc_txt.Name = "tc_txt";
            this.tc_txt.Size = new System.Drawing.Size(108, 29);
            this.tc_txt.TabIndex = 1;
            // 
            // sifre_label
            // 
            this.sifre_label.AutoSize = true;
            this.sifre_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sifre_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.sifre_label.Location = new System.Drawing.Point(167, 148);
            this.sifre_label.Name = "sifre_label";
            this.sifre_label.Size = new System.Drawing.Size(58, 28);
            this.sifre_label.TabIndex = 2;
            this.sifre_label.Text = "Şifre:";
            // 
            // sifre_txt
            // 
            this.sifre_txt.Location = new System.Drawing.Point(231, 149);
            this.sifre_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sifre_txt.Name = "sifre_txt";
            this.sifre_txt.Size = new System.Drawing.Size(108, 22);
            this.sifre_txt.TabIndex = 3;
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(231, 175);
            this.btn_giris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(108, 23);
            this.btn_giris.TabIndex = 10;
            this.btn_giris.Text = "Giris Yap";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Üye değil misiniz?";
            // 
            // kayitol_label
            // 
            this.kayitol_label.AutoSize = true;
            this.kayitol_label.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayitol_label.LinkColor = System.Drawing.Color.Blue;
            this.kayitol_label.Location = new System.Drawing.Point(272, 241);
            this.kayitol_label.Name = "kayitol_label";
            this.kayitol_label.Size = new System.Drawing.Size(61, 17);
            this.kayitol_label.TabIndex = 12;
            this.kayitol_label.TabStop = true;
            this.kayitol_label.Text = "Kayit Ol!";
            this.kayitol_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.kayitol_label_LinkClicked_1);
            // 
            // btnhatirla
            // 
            this.btnhatirla.AutoSize = true;
            this.btnhatirla.Location = new System.Drawing.Point(386, 243);
            this.btnhatirla.Name = "btnhatirla";
            this.btnhatirla.Size = new System.Drawing.Size(98, 20);
            this.btnhatirla.TabIndex = 13;
            this.btnhatirla.Text = "Beni Hatırla";
            this.btnhatirla.UseVisualStyleBackColor = true;
            this.btnhatirla.CheckedChanged += new System.EventHandler(this.btnhatirla_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(187, 215);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(137, 16);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifrenizi mi unuttunuz ?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hospital_Project.Properties.Resources.kullanici_logo;
            this.pictureBox1.Location = new System.Drawing.Point(190, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Hasta_Giris_Paneli
            // 
            this.AcceptButton = this.btn_giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(488, 267);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnhatirla);
            this.Controls.Add(this.kayitol_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sifre_txt);
            this.Controls.Add(this.sifre_label);
            this.Controls.Add(this.tc_txt);
            this.Controls.Add(this.no_label);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Hasta_Giris_Paneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta_Giris_Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Hasta_Giris_Paneli_FormClosing_1);
            this.Load += new System.EventHandler(this.Hasta_Giris_Paneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label no_label;
        private MaskedTextBox tc_txt;
        private Label sifre_label;
        private TextBox sifre_txt;
        private PictureBox pictureBox1;
        private Button btn_giris;
        private Label label1;
        private LinkLabel kayitol_label;
        private CheckBox btnhatirla;
        private LinkLabel linkLabel1;
    }
}
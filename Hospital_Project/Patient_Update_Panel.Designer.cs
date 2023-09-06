namespace Hospital_Project
{
    partial class Patient_Update_Panel
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
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.sifre_txt = new System.Windows.Forms.TextBox();
            this.tel_txt = new System.Windows.Forms.MaskedTextBox();
            this.cinsiyet_txt = new System.Windows.Forms.ComboBox();
            this.tc_txt = new System.Windows.Forms.MaskedTextBox();
            this.soyad_txt = new System.Windows.Forms.TextBox();
            this.ad_txt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_geri
            // 
            this.btn_geri.Font = new System.Drawing.Font("Calibri Light", 7.8F);
            this.btn_geri.Location = new System.Drawing.Point(3, 354);
            this.btn_geri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(75, 23);
            this.btn_geri.TabIndex = 8;
            this.btn_geri.Text = "Return";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Font = new System.Drawing.Font("Calibri Light", 9F);
            this.btn_guncelle.Location = new System.Drawing.Point(191, 330);
            this.btn_guncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(125, 23);
            this.btn_guncelle.TabIndex = 7;
            this.btn_guncelle.Text = "Update";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // sifre_txt
            // 
            this.sifre_txt.Location = new System.Drawing.Point(191, 303);
            this.sifre_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sifre_txt.Name = "sifre_txt";
            this.sifre_txt.Size = new System.Drawing.Size(125, 22);
            this.sifre_txt.TabIndex = 6;
            // 
            // tel_txt
            // 
            this.tel_txt.Location = new System.Drawing.Point(191, 220);
            this.tel_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tel_txt.Mask = "(999) 000-0000";
            this.tel_txt.Name = "tel_txt";
            this.tel_txt.Size = new System.Drawing.Size(125, 22);
            this.tel_txt.TabIndex = 4;
            // 
            // cinsiyet_txt
            // 
            this.cinsiyet_txt.FormattingEnabled = true;
            this.cinsiyet_txt.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cinsiyet_txt.Location = new System.Drawing.Point(191, 253);
            this.cinsiyet_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cinsiyet_txt.Name = "cinsiyet_txt";
            this.cinsiyet_txt.Size = new System.Drawing.Size(125, 24);
            this.cinsiyet_txt.TabIndex = 5;
            // 
            // tc_txt
            // 
            this.tc_txt.Location = new System.Drawing.Point(191, 188);
            this.tc_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tc_txt.Mask = "00000000000";
            this.tc_txt.Name = "tc_txt";
            this.tc_txt.ReadOnly = true;
            this.tc_txt.Size = new System.Drawing.Size(125, 22);
            this.tc_txt.TabIndex = 3;
            // 
            // soyad_txt
            // 
            this.soyad_txt.Location = new System.Drawing.Point(191, 155);
            this.soyad_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soyad_txt.Name = "soyad_txt";
            this.soyad_txt.Size = new System.Drawing.Size(125, 22);
            this.soyad_txt.TabIndex = 2;
            // 
            // ad_txt
            // 
            this.ad_txt.Location = new System.Drawing.Point(191, 122);
            this.ad_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ad_txt.Name = "ad_txt";
            this.ad_txt.Size = new System.Drawing.Size(125, 22);
            this.ad_txt.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hospital_Project.Properties.Resources.kullanici_logo;
            this.pictureBox1.Location = new System.Drawing.Point(151, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(83, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 28);
            this.label6.TabIndex = 31;
            this.label6.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(67, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 28);
            this.label5.TabIndex = 30;
            this.label5.Text = "Patient Sex:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(40, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 28);
            this.label4.TabIndex = 29;
            this.label4.Text = "Patient Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(79, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 28);
            this.label3.TabIndex = 28;
            this.label3.Text = "Patient ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(18, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 28);
            this.label2.TabIndex = 27;
            this.label2.Text = "Patient Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(44, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 28);
            this.label1.TabIndex = 26;
            this.label1.Text = "Patient Name:";
            // 
            // Patient_Update_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(379, 381);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.sifre_txt);
            this.Controls.Add(this.tel_txt);
            this.Controls.Add(this.cinsiyet_txt);
            this.Controls.Add(this.tc_txt);
            this.Controls.Add(this.soyad_txt);
            this.Controls.Add(this.ad_txt);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Patient_Update_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Update Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Hasta_Güncelleme_Paneli_FormClosing);
            this.Load += new System.EventHandler(this.Hasta_Güncelleme_Paneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_geri;
        private Button btn_guncelle;
        private TextBox sifre_txt;
        private MaskedTextBox tel_txt;
        private ComboBox cinsiyet_txt;
        private MaskedTextBox tc_txt;
        private TextBox soyad_txt;
        private TextBox ad_txt;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
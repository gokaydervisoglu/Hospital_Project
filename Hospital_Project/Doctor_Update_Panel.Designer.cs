namespace Hospital_Project
{
    partial class Doctor_Update_Panel
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
            this.label6 = new System.Windows.Forms.Label();
            this.soyad_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ad_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.brans_txt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tc_txt = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_geri
            // 
            this.btn_geri.Font = new System.Drawing.Font("Calibri Light", 7.8F);
            this.btn_geri.Location = new System.Drawing.Point(12, 335);
            this.btn_geri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(75, 23);
            this.btn_geri.TabIndex = 54;
            this.btn_geri.Text = "Return";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Font = new System.Drawing.Font("Calibri Light", 9F);
            this.btn_guncelle.Location = new System.Drawing.Point(192, 291);
            this.btn_guncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(125, 23);
            this.btn_guncelle.TabIndex = 53;
            this.btn_guncelle.Text = "Update";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // sifre_txt
            // 
            this.sifre_txt.Location = new System.Drawing.Point(192, 265);
            this.sifre_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sifre_txt.Name = "sifre_txt";
            this.sifre_txt.Size = new System.Drawing.Size(125, 22);
            this.sifre_txt.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(84, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 28);
            this.label6.TabIndex = 51;
            this.label6.Text = "Password:";
            // 
            // soyad_txt
            // 
            this.soyad_txt.Location = new System.Drawing.Point(192, 155);
            this.soyad_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soyad_txt.Name = "soyad_txt";
            this.soyad_txt.Size = new System.Drawing.Size(125, 22);
            this.soyad_txt.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(21, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 28);
            this.label2.TabIndex = 43;
            this.label2.Text = "Doctor Surname:";
            // 
            // ad_txt
            // 
            this.ad_txt.Location = new System.Drawing.Point(192, 122);
            this.ad_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ad_txt.Name = "ad_txt";
            this.ad_txt.Size = new System.Drawing.Size(125, 22);
            this.ad_txt.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(46, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 28);
            this.label1.TabIndex = 41;
            this.label1.Text = "Doctor Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hospital_Project.Properties.Resources.doktor_logo;
            this.pictureBox1.Location = new System.Drawing.Point(128, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(36, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 28);
            this.label3.TabIndex = 55;
            this.label3.Text = "Doktor Branch:";
            // 
            // brans_txt
            // 
            this.brans_txt.FormattingEnabled = true;
            this.brans_txt.Location = new System.Drawing.Point(192, 226);
            this.brans_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brans_txt.Name = "brans_txt";
            this.brans_txt.Size = new System.Drawing.Size(125, 24);
            this.brans_txt.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(78, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 28);
            this.label5.TabIndex = 58;
            this.label5.Text = "Doctor TC:";
            // 
            // tc_txt
            // 
            this.tc_txt.Location = new System.Drawing.Point(192, 189);
            this.tc_txt.Mask = "00000000000";
            this.tc_txt.Name = "tc_txt";
            this.tc_txt.ReadOnly = true;
            this.tc_txt.Size = new System.Drawing.Size(125, 22);
            this.tc_txt.TabIndex = 59;
            // 
            // Doctor_Update_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 369);
            this.Controls.Add(this.tc_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.brans_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.sifre_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.soyad_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ad_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Doctor_Update_Panel";
            this.Text = "Doctor Update Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Doktor_Güncelleme_Paneli_FormClosing);
            this.Load += new System.EventHandler(this.Doktor_Güncelleme_Paneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_geri;
        private Button btn_guncelle;
        private TextBox sifre_txt;
        private Label label6;
        private TextBox soyad_txt;
        private Label label2;
        private TextBox ad_txt;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private ComboBox brans_txt;
        private Label label5;
        private MaskedTextBox tc_txt;
    }
}
namespace Hospital_Project
{
    partial class Doctor_Info_Panel
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sikayet_txt = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bilgiduzenle_label = new System.Windows.Forms.LinkLabel();
            this.tc_txt = new System.Windows.Forms.Label();
            this.soyad_txt = new System.Windows.Forms.Label();
            this.ad_txt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_duyurular = new System.Windows.Forms.Button();
            this.btn_iletisim = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_geri = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(367, 8);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(703, 371);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Detay";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(697, 352);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sikayet_txt);
            this.groupBox2.Location = new System.Drawing.Point(12, 141);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(349, 143);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Bilgilendirme";
            // 
            // sikayet_txt
            // 
            this.sikayet_txt.Location = new System.Drawing.Point(6, 21);
            this.sikayet_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sikayet_txt.Name = "sikayet_txt";
            this.sikayet_txt.ReadOnly = true;
            this.sikayet_txt.Size = new System.Drawing.Size(337, 111);
            this.sikayet_txt.TabIndex = 20;
            this.sikayet_txt.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bilgiduzenle_label);
            this.groupBox1.Controls.Add(this.tc_txt);
            this.groupBox1.Controls.Add(this.soyad_txt);
            this.groupBox1.Controls.Add(this.ad_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(349, 128);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bilgi";
            // 
            // bilgiduzenle_label
            // 
            this.bilgiduzenle_label.AutoSize = true;
            this.bilgiduzenle_label.LinkColor = System.Drawing.Color.DarkGreen;
            this.bilgiduzenle_label.Location = new System.Drawing.Point(109, 100);
            this.bilgiduzenle_label.Name = "bilgiduzenle_label";
            this.bilgiduzenle_label.Size = new System.Drawing.Size(113, 16);
            this.bilgiduzenle_label.TabIndex = 15;
            this.bilgiduzenle_label.TabStop = true;
            this.bilgiduzenle_label.Text = "Bilgilerini Düzenle";
            this.bilgiduzenle_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.bilgiduzenle_label_LinkClicked);
            // 
            // tc_txt
            // 
            this.tc_txt.AutoSize = true;
            this.tc_txt.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.tc_txt.Location = new System.Drawing.Point(213, 75);
            this.tc_txt.Name = "tc_txt";
            this.tc_txt.Size = new System.Drawing.Size(109, 21);
            this.tc_txt.TabIndex = 14;
            this.tc_txt.Text = "00000000000";
            // 
            // soyad_txt
            // 
            this.soyad_txt.AutoSize = true;
            this.soyad_txt.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.soyad_txt.Location = new System.Drawing.Point(244, 53);
            this.soyad_txt.Name = "soyad_txt";
            this.soyad_txt.Size = new System.Drawing.Size(38, 21);
            this.soyad_txt.TabIndex = 13;
            this.soyad_txt.Text = "Null";
            // 
            // ad_txt
            // 
            this.ad_txt.AutoSize = true;
            this.ad_txt.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.ad_txt.Location = new System.Drawing.Point(217, 28);
            this.ad_txt.Name = "ad_txt";
            this.ad_txt.Size = new System.Drawing.Size(38, 21);
            this.ad_txt.TabIndex = 12;
            this.ad_txt.Text = "Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(110, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(109, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Doktor Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(109, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Doktor Ad:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hospital_Project.Properties.Resources.doktor_logo;
            this.pictureBox1.Location = new System.Drawing.Point(6, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btn_duyurular
            // 
            this.btn_duyurular.Location = new System.Drawing.Point(6, 21);
            this.btn_duyurular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_duyurular.Name = "btn_duyurular";
            this.btn_duyurular.Size = new System.Drawing.Size(165, 26);
            this.btn_duyurular.TabIndex = 0;
            this.btn_duyurular.Text = "Duyurular";
            this.btn_duyurular.UseVisualStyleBackColor = true;
            this.btn_duyurular.Click += new System.EventHandler(this.btn_duyurular_Click);
            // 
            // btn_iletisim
            // 
            this.btn_iletisim.Enabled = false;
            this.btn_iletisim.Location = new System.Drawing.Point(177, 21);
            this.btn_iletisim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_iletisim.Name = "btn_iletisim";
            this.btn_iletisim.Size = new System.Drawing.Size(165, 26);
            this.btn_iletisim.TabIndex = 1;
            this.btn_iletisim.Text = "İletişim";
            this.btn_iletisim.UseVisualStyleBackColor = true;
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(177, 49);
            this.btn_cikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(165, 26);
            this.btn_cikis.TabIndex = 2;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_geri);
            this.groupBox5.Controls.Add(this.btn_cikis);
            this.groupBox5.Controls.Add(this.btn_iletisim);
            this.groupBox5.Controls.Add(this.btn_duyurular);
            this.groupBox5.Location = new System.Drawing.Point(18, 289);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(343, 90);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hizli Erişim";
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(6, 49);
            this.btn_geri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(165, 26);
            this.btn_geri.TabIndex = 3;
            this.btn_geri.Text = "Geri";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // Doktor_Bilgi_Paneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 391);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Doktor_Bilgi_Paneli";
            this.Text = "Doktor_Bilgi_Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Doktor_Bilgi_Paneli_FormClosing);
            this.Load += new System.EventHandler(this.Doktor_Bilgi_Paneli_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private RichTextBox sikayet_txt;
        private GroupBox groupBox1;
        private LinkLabel bilgiduzenle_label;
        private Label tc_txt;
        private Label soyad_txt;
        private Label ad_txt;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btn_duyurular;
        private Button btn_iletisim;
        private Button btn_cikis;
        private GroupBox groupBox5;
        private Button btn_geri;
        private DataGridView dataGridView1;
    }
}
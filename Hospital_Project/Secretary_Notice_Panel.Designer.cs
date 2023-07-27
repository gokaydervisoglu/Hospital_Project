namespace Hospital_Project
{
    partial class Secretary_Notice_Panel
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.doktor_duyuru_txt = new System.Windows.Forms.RadioButton();
            this.hasta_duyuru_txt = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tc_txt = new System.Windows.Forms.TextBox();
            this.sifre_txt = new System.Windows.Forms.TextBox();
            this.mail_txt = new System.Windows.Forms.TextBox();
            this.sifre_kurtar_btn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(304, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 346);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doktor Duyuruları";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 18);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(401, 325);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // doktor_duyuru_txt
            // 
            this.doktor_duyuru_txt.AutoSize = true;
            this.doktor_duyuru_txt.Location = new System.Drawing.Point(520, 364);
            this.doktor_duyuru_txt.Name = "doktor_duyuru_txt";
            this.doktor_duyuru_txt.Size = new System.Drawing.Size(131, 20);
            this.doktor_duyuru_txt.TabIndex = 2;
            this.doktor_duyuru_txt.TabStop = true;
            this.doktor_duyuru_txt.Text = "Doktor Duyuruları";
            this.doktor_duyuru_txt.UseVisualStyleBackColor = true;
            // 
            // hasta_duyuru_txt
            // 
            this.hasta_duyuru_txt.AutoSize = true;
            this.hasta_duyuru_txt.Location = new System.Drawing.Point(366, 364);
            this.hasta_duyuru_txt.Name = "hasta_duyuru_txt";
            this.hasta_duyuru_txt.Size = new System.Drawing.Size(127, 20);
            this.hasta_duyuru_txt.TabIndex = 3;
            this.hasta_duyuru_txt.TabStop = true;
            this.hasta_duyuru_txt.Text = "Hasta Duyuruları";
            this.hasta_duyuru_txt.UseVisualStyleBackColor = true;
            this.hasta_duyuru_txt.CheckedChanged += new System.EventHandler(this.hasta_duyuru_txt_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 183);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgiler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(280, 162);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sifre_kurtar_btn);
            this.groupBox3.Controls.Add(this.mail_txt);
            this.groupBox3.Controls.Add(this.sifre_txt);
            this.groupBox3.Controls.Add(this.tc_txt);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(15, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 157);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hızlı Erişim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta TC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta Sifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta Mail:";
            // 
            // tc_txt
            // 
            this.tc_txt.Location = new System.Drawing.Point(112, 27);
            this.tc_txt.Name = "tc_txt";
            this.tc_txt.Size = new System.Drawing.Size(165, 22);
            this.tc_txt.TabIndex = 3;
            // 
            // sifre_txt
            // 
            this.sifre_txt.Location = new System.Drawing.Point(112, 55);
            this.sifre_txt.Name = "sifre_txt";
            this.sifre_txt.Size = new System.Drawing.Size(165, 22);
            this.sifre_txt.TabIndex = 4;
            // 
            // mail_txt
            // 
            this.mail_txt.Location = new System.Drawing.Point(112, 78);
            this.mail_txt.Name = "mail_txt";
            this.mail_txt.Size = new System.Drawing.Size(165, 22);
            this.mail_txt.TabIndex = 5;
            // 
            // sifre_kurtar_btn
            // 
            this.sifre_kurtar_btn.Location = new System.Drawing.Point(75, 115);
            this.sifre_kurtar_btn.Name = "sifre_kurtar_btn";
            this.sifre_kurtar_btn.Size = new System.Drawing.Size(120, 23);
            this.sifre_kurtar_btn.TabIndex = 6;
            this.sifre_kurtar_btn.Text = "Sifre Kurtar";
            this.sifre_kurtar_btn.UseVisualStyleBackColor = true;
            this.sifre_kurtar_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sekreter_Duyuru_Paneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 388);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hasta_duyuru_txt);
            this.Controls.Add(this.doktor_duyuru_txt);
            this.Controls.Add(this.groupBox2);
            this.Name = "Sekreter_Duyuru_Paneli";
            this.Text = "Sekreter_Duyuru_Paneli";
            this.Load += new System.EventHandler(this.Sekreter_Duyuru_Paneli_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox2;
        private DataGridView dataGridView2;
        private RadioButton doktor_duyuru_txt;
        private RadioButton hasta_duyuru_txt;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox mail_txt;
        private TextBox sifre_txt;
        private TextBox tc_txt;
        private Button sifre_kurtar_btn;
    }
}
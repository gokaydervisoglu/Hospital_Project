﻿namespace Hospital_Project
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
            this.doctor_btn = new System.Windows.Forms.RadioButton();
            this.patient_btn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_helper = new System.Windows.Forms.Button();
            this.mail_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.tc_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.groupBox2.Text = "Doctor Info";
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
            // doctor_btn
            // 
            this.doctor_btn.AutoSize = true;
            this.doctor_btn.Location = new System.Drawing.Point(520, 364);
            this.doctor_btn.Name = "doctor_btn";
            this.doctor_btn.Size = new System.Drawing.Size(92, 20);
            this.doctor_btn.TabIndex = 2;
            this.doctor_btn.TabStop = true;
            this.doctor_btn.Text = "Doctor Info";
            this.doctor_btn.UseVisualStyleBackColor = true;
            // 
            // patient_btn
            // 
            this.patient_btn.AutoSize = true;
            this.patient_btn.Location = new System.Drawing.Point(366, 364);
            this.patient_btn.Name = "patient_btn";
            this.patient_btn.Size = new System.Drawing.Size(93, 20);
            this.patient_btn.TabIndex = 3;
            this.patient_btn.TabStop = true;
            this.patient_btn.Text = "Patient İnfo";
            this.patient_btn.UseVisualStyleBackColor = true;
            this.patient_btn.CheckedChanged += new System.EventHandler(this.hasta_duyuru_txt_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 183);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations";
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
            this.groupBox3.Controls.Add(this.btn_helper);
            this.groupBox3.Controls.Add(this.mail_txt);
            this.groupBox3.Controls.Add(this.password_txt);
            this.groupBox3.Controls.Add(this.tc_txt);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(15, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 157);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fast access";
            // 
            // btn_helper
            // 
            this.btn_helper.Location = new System.Drawing.Point(75, 115);
            this.btn_helper.Name = "btn_helper";
            this.btn_helper.Size = new System.Drawing.Size(120, 23);
            this.btn_helper.TabIndex = 6;
            this.btn_helper.Text = "Help Password";
            this.btn_helper.UseVisualStyleBackColor = true;
            this.btn_helper.Click += new System.EventHandler(this.button1_Click);
            // 
            // mail_txt
            // 
            this.mail_txt.Location = new System.Drawing.Point(112, 78);
            this.mail_txt.Name = "mail_txt";
            this.mail_txt.Size = new System.Drawing.Size(165, 22);
            this.mail_txt.TabIndex = 5;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(112, 55);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(165, 22);
            this.password_txt.TabIndex = 4;
            // 
            // tc_txt
            // 
            this.tc_txt.Location = new System.Drawing.Point(112, 27);
            this.tc_txt.Name = "tc_txt";
            this.tc_txt.Size = new System.Drawing.Size(165, 22);
            this.tc_txt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pt Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pt Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pt TC:";
            // 
            // Secretary_Notice_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 388);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.patient_btn);
            this.Controls.Add(this.doctor_btn);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Secretary_Notice_Panel";
            this.Text = "Secretary Notice Panel";
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
        private RadioButton doctor_btn;
        private RadioButton patient_btn;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox mail_txt;
        private TextBox password_txt;
        private TextBox tc_txt;
        private Button btn_helper;
    }
}
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
            this.appoint_info = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edit_btn = new System.Windows.Forms.LinkLabel();
            this.tc_txt = new System.Windows.Forms.Label();
            this.surname_txt = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Annoct = new System.Windows.Forms.Button();
            this.btn_com = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_rtn = new System.Windows.Forms.Button();
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
            this.groupBox3.Text = "Appointment Details";
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
            this.groupBox2.Controls.Add(this.appoint_info);
            this.groupBox2.Location = new System.Drawing.Point(12, 141);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(349, 143);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointment Info";
            // 
            // appoint_info
            // 
            this.appoint_info.Location = new System.Drawing.Point(6, 21);
            this.appoint_info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appoint_info.Name = "appoint_info";
            this.appoint_info.ReadOnly = true;
            this.appoint_info.Size = new System.Drawing.Size(337, 111);
            this.appoint_info.TabIndex = 20;
            this.appoint_info.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edit_btn);
            this.groupBox1.Controls.Add(this.tc_txt);
            this.groupBox1.Controls.Add(this.surname_txt);
            this.groupBox1.Controls.Add(this.name_txt);
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
            this.groupBox1.Text = "User Info";
            // 
            // edit_btn
            // 
            this.edit_btn.AutoSize = true;
            this.edit_btn.LinkColor = System.Drawing.Color.DarkGreen;
            this.edit_btn.Location = new System.Drawing.Point(232, 105);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(98, 16);
            this.edit_btn.TabIndex = 15;
            this.edit_btn.TabStop = true;
            this.edit_btn.Text = "Edit Information";
            this.edit_btn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.bilgiduzenle_label_LinkClicked);
            // 
            // tc_txt
            // 
            this.tc_txt.AutoSize = true;
            this.tc_txt.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.tc_txt.Location = new System.Drawing.Point(228, 75);
            this.tc_txt.Name = "tc_txt";
            this.tc_txt.Size = new System.Drawing.Size(109, 21);
            this.tc_txt.TabIndex = 14;
            this.tc_txt.Text = "00000000000";
            // 
            // surname_txt
            // 
            this.surname_txt.AutoSize = true;
            this.surname_txt.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.surname_txt.Location = new System.Drawing.Point(228, 46);
            this.surname_txt.Name = "surname_txt";
            this.surname_txt.Size = new System.Drawing.Size(38, 21);
            this.surname_txt.TabIndex = 13;
            this.surname_txt.Text = "Null";
            // 
            // name_txt
            // 
            this.name_txt.AutoSize = true;
            this.name_txt.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.name_txt.Location = new System.Drawing.Point(228, 17);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(38, 21);
            this.name_txt.TabIndex = 12;
            this.name_txt.Text = "Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(158, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "ID No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(108, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dr Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(132, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dr Name:";
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
            // btn_Annoct
            // 
            this.btn_Annoct.Location = new System.Drawing.Point(6, 21);
            this.btn_Annoct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Annoct.Name = "btn_Annoct";
            this.btn_Annoct.Size = new System.Drawing.Size(165, 26);
            this.btn_Annoct.TabIndex = 0;
            this.btn_Annoct.Text = "Announcements";
            this.btn_Annoct.UseVisualStyleBackColor = true;
            this.btn_Annoct.Click += new System.EventHandler(this.btn_duyurular_Click);
            // 
            // btn_com
            // 
            this.btn_com.Enabled = false;
            this.btn_com.Location = new System.Drawing.Point(177, 21);
            this.btn_com.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_com.Name = "btn_com";
            this.btn_com.Size = new System.Drawing.Size(165, 26);
            this.btn_com.TabIndex = 1;
            this.btn_com.Text = "Communication";
            this.btn_com.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(177, 49);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(165, 26);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_rtn);
            this.groupBox5.Controls.Add(this.btn_exit);
            this.groupBox5.Controls.Add(this.btn_com);
            this.groupBox5.Controls.Add(this.btn_Annoct);
            this.groupBox5.Location = new System.Drawing.Point(18, 289);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(343, 90);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Fast access";
            // 
            // btn_rtn
            // 
            this.btn_rtn.Location = new System.Drawing.Point(6, 49);
            this.btn_rtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_rtn.Name = "btn_rtn";
            this.btn_rtn.Size = new System.Drawing.Size(165, 26);
            this.btn_rtn.TabIndex = 3;
            this.btn_rtn.Text = "Return";
            this.btn_rtn.UseVisualStyleBackColor = true;
            this.btn_rtn.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // Doctor_Info_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 391);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Doctor_Info_Panel";
            this.Text = "Doctor Panel";
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
        private RichTextBox appoint_info;
        private GroupBox groupBox1;
        private LinkLabel edit_btn;
        private Label tc_txt;
        private Label surname_txt;
        private Label name_txt;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btn_Annoct;
        private Button btn_com;
        private Button btn_exit;
        private GroupBox groupBox5;
        private Button btn_rtn;
        private DataGridView dataGridView1;
    }
}
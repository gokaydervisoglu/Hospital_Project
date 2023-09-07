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
            this.btn_rtn = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.surname_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.branch_txt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tc_txt = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_rtn
            // 
            this.btn_rtn.Font = new System.Drawing.Font("Calibri Light", 7.8F);
            this.btn_rtn.Location = new System.Drawing.Point(12, 335);
            this.btn_rtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_rtn.Name = "btn_rtn";
            this.btn_rtn.Size = new System.Drawing.Size(75, 23);
            this.btn_rtn.TabIndex = 54;
            this.btn_rtn.Text = "Return";
            this.btn_rtn.UseVisualStyleBackColor = true;
            this.btn_rtn.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Calibri Light", 9F);
            this.btn_update.Location = new System.Drawing.Point(192, 291);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(125, 23);
            this.btn_update.TabIndex = 53;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(192, 265);
            this.password_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(125, 22);
            this.password_txt.TabIndex = 52;
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
            // surname_txt
            // 
            this.surname_txt.Location = new System.Drawing.Point(192, 155);
            this.surname_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.surname_txt.Name = "surname_txt";
            this.surname_txt.Size = new System.Drawing.Size(125, 22);
            this.surname_txt.TabIndex = 44;
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
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(192, 122);
            this.name_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(125, 22);
            this.name_txt.TabIndex = 42;
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
            // branch_txt
            // 
            this.branch_txt.FormattingEnabled = true;
            this.branch_txt.Location = new System.Drawing.Point(192, 226);
            this.branch_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.branch_txt.Name = "branch_txt";
            this.branch_txt.Size = new System.Drawing.Size(125, 24);
            this.branch_txt.TabIndex = 56;
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
            this.Controls.Add(this.branch_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_rtn);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.surname_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_txt);
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

        private Button btn_rtn;
        private Button btn_update;
        private TextBox password_txt;
        private Label label6;
        private TextBox surname_txt;
        private Label label2;
        private TextBox name_txt;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private ComboBox branch_txt;
        private Label label5;
        private MaskedTextBox tc_txt;
    }
}
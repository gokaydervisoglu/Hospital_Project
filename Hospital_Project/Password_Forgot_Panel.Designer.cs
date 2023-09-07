namespace Hospital_Project
{
    partial class Password_Forgot_Panel
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tc_txt = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_helper = new System.Windows.Forms.Button();
            this.phone_txt = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mail_txt = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_rtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hospital_Project.Properties.Resources.kullanici_logo;
            this.pictureBox1.Location = new System.Drawing.Point(132, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // tc_txt
            // 
            this.tc_txt.Location = new System.Drawing.Point(171, 130);
            this.tc_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tc_txt.Mask = "00000000000";
            this.tc_txt.Name = "tc_txt";
            this.tc_txt.Size = new System.Drawing.Size(164, 22);
            this.tc_txt.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(95, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 28);
            this.label3.TabIndex = 32;
            this.label3.Text = "ID No:";
            // 
            // btn_helper
            // 
            this.btn_helper.Location = new System.Drawing.Point(171, 221);
            this.btn_helper.Name = "btn_helper";
            this.btn_helper.Size = new System.Drawing.Size(164, 48);
            this.btn_helper.TabIndex = 33;
            this.btn_helper.Text = "Create Recovery Request";
            this.btn_helper.UseVisualStyleBackColor = true;
            this.btn_helper.Click += new System.EventHandler(this.btn_kurtar_Click);
            // 
            // phone_txt
            // 
            this.phone_txt.Location = new System.Drawing.Point(171, 162);
            this.phone_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phone_txt.Mask = "(999) 000-0000";
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(164, 22);
            this.phone_txt.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(89, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 28);
            this.label4.TabIndex = 35;
            this.label4.Text = "Phone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(92, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 28);
            this.label1.TabIndex = 36;
            this.label1.Text = "E-Mail:";
            // 
            // mail_txt
            // 
            this.mail_txt.Location = new System.Drawing.Point(171, 194);
            this.mail_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mail_txt.Name = "mail_txt";
            this.mail_txt.Size = new System.Drawing.Size(164, 22);
            this.mail_txt.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(94, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "(Please enter all information completely!)";
            // 
            // btn_rtn
            // 
            this.btn_rtn.Font = new System.Drawing.Font("Calibri Light", 7.8F);
            this.btn_rtn.Location = new System.Drawing.Point(2, 269);
            this.btn_rtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_rtn.Name = "btn_rtn";
            this.btn_rtn.Size = new System.Drawing.Size(75, 23);
            this.btn_rtn.TabIndex = 55;
            this.btn_rtn.Text = "Return";
            this.btn_rtn.UseVisualStyleBackColor = true;
            this.btn_rtn.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // Password_Forgot_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 293);
            this.Controls.Add(this.btn_rtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mail_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_helper);
            this.Controls.Add(this.tc_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Password_Forgot_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Help";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sifre_Unuttum_Paneli_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private MaskedTextBox tc_txt;
        private Label label3;
        private Button btn_helper;
        private MaskedTextBox phone_txt;
        private Label label4;
        private Label label1;
        private MaskedTextBox mail_txt;
        private Label label2;
        private Button btn_rtn;
    }
}
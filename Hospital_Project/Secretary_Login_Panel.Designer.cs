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
            this.btn_login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.sifre_label = new System.Windows.Forms.Label();
            this.tc_txt = new System.Windows.Forms.MaskedTextBox();
            this.no_label = new System.Windows.Forms.Label();
            this.btn_rm = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(229, 194);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(108, 23);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_giris_Click);
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
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(229, 167);
            this.password_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(108, 22);
            this.password_txt.TabIndex = 2;
            // 
            // sifre_label
            // 
            this.sifre_label.AutoSize = true;
            this.sifre_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sifre_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.sifre_label.Location = new System.Drawing.Point(123, 169);
            this.sifre_label.Name = "sifre_label";
            this.sifre_label.Size = new System.Drawing.Size(102, 28);
            this.sifre_label.TabIndex = 15;
            this.sifre_label.Text = "Password:";
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
            this.no_label.Location = new System.Drawing.Point(153, 138);
            this.no_label.Name = "no_label";
            this.no_label.Size = new System.Drawing.Size(70, 28);
            this.no_label.TabIndex = 13;
            this.no_label.Text = "ID No:";
            // 
            // btn_rm
            // 
            this.btn_rm.AutoSize = true;
            this.btn_rm.Location = new System.Drawing.Point(363, 240);
            this.btn_rm.Name = "btn_rm";
            this.btn_rm.Size = new System.Drawing.Size(119, 20);
            this.btn_rm.TabIndex = 26;
            this.btn_rm.Text = "Remember me";
            this.btn_rm.UseVisualStyleBackColor = true;
            this.btn_rm.CheckedChanged += new System.EventHandler(this.btnhatirla_CheckedChanged);
            // 
            // Secretary_Login_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(488, 267);
            this.Controls.Add(this.btn_rm);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.sifre_label);
            this.Controls.Add(this.tc_txt);
            this.Controls.Add(this.no_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Secretary_Login_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secretary Login Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sekreter_Giris_Paneli_FormClosing);
            this.Load += new System.EventHandler(this.Sekreter_Giris_Paneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_login;
        private PictureBox pictureBox1;
        private TextBox password_txt;
        private Label sifre_label;
        private MaskedTextBox tc_txt;
        private Label no_label;
        private CheckBox btn_rm;
    }
}
namespace Hospital_Project
{
    partial class Login_Panel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.doktor_label = new System.Windows.Forms.Label();
            this.sekreter_label = new System.Windows.Forms.Label();
            this.hasta_label = new System.Windows.Forms.Label();
            this.btn_patient = new System.Windows.Forms.Button();
            this.btn_secretary = new System.Windows.Forms.Button();
            this.btn_doctor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doktor_label
            // 
            this.doktor_label.AutoSize = true;
            this.doktor_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.doktor_label.Font = new System.Drawing.Font("Calibri Light", 13.8F);
            this.doktor_label.Location = new System.Drawing.Point(185, 305);
            this.doktor_label.Name = "doktor_label";
            this.doktor_label.Size = new System.Drawing.Size(131, 28);
            this.doktor_label.TabIndex = 11;
            this.doktor_label.Text = "Doctor Login";
            // 
            // sekreter_label
            // 
            this.sekreter_label.AutoSize = true;
            this.sekreter_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sekreter_label.Font = new System.Drawing.Font("Calibri Light", 13.8F);
            this.sekreter_label.Location = new System.Drawing.Point(173, 199);
            this.sekreter_label.Name = "sekreter_label";
            this.sekreter_label.Size = new System.Drawing.Size(154, 28);
            this.sekreter_label.TabIndex = 10;
            this.sekreter_label.Text = "Secretary Login";
            // 
            // hasta_label
            // 
            this.hasta_label.AutoSize = true;
            this.hasta_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.hasta_label.Font = new System.Drawing.Font("Calibri Light", 13.8F);
            this.hasta_label.Location = new System.Drawing.Point(184, 101);
            this.hasta_label.Name = "hasta_label";
            this.hasta_label.Size = new System.Drawing.Size(132, 28);
            this.hasta_label.TabIndex = 9;
            this.hasta_label.Text = "Patient Login";
            // 
            // btn_patient
            // 
            this.btn_patient.BackColor = System.Drawing.Color.Transparent;
            this.btn_patient.BackgroundImage = global::Hospital_Project.Properties.Resources.kullanici_logo;
            this.btn_patient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_patient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_patient.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_patient.Location = new System.Drawing.Point(193, 30);
            this.btn_patient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_patient.Name = "btn_patient";
            this.btn_patient.Padding = new System.Windows.Forms.Padding(20, 16, 20, 16);
            this.btn_patient.Size = new System.Drawing.Size(112, 92);
            this.btn_patient.TabIndex = 1;
            this.btn_patient.UseVisualStyleBackColor = false;
            this.btn_patient.Click += new System.EventHandler(this.btn_hasta_Click_1);
            // 
            // btn_secretary
            // 
            this.btn_secretary.BackgroundImage = global::Hospital_Project.Properties.Resources.sekreter_logo;
            this.btn_secretary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_secretary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_secretary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_secretary.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_secretary.Location = new System.Drawing.Point(192, 126);
            this.btn_secretary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_secretary.Name = "btn_secretary";
            this.btn_secretary.Padding = new System.Windows.Forms.Padding(20, 16, 20, 16);
            this.btn_secretary.Size = new System.Drawing.Size(112, 92);
            this.btn_secretary.TabIndex = 2;
            this.btn_secretary.UseVisualStyleBackColor = true;
            this.btn_secretary.Click += new System.EventHandler(this.btn_sekreter_Click_1);
            // 
            // btn_doctor
            // 
            this.btn_doctor.BackgroundImage = global::Hospital_Project.Properties.Resources.doktor_logo;
            this.btn_doctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_doctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_doctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doctor.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_doctor.Location = new System.Drawing.Point(193, 230);
            this.btn_doctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_doctor.Name = "btn_doctor";
            this.btn_doctor.Padding = new System.Windows.Forms.Padding(20, 16, 20, 16);
            this.btn_doctor.Size = new System.Drawing.Size(112, 92);
            this.btn_doctor.TabIndex = 3;
            this.btn_doctor.UseVisualStyleBackColor = true;
            this.btn_doctor.Click += new System.EventHandler(this.btn_doktor_Click);
            // 
            // Login_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 386);
            this.Controls.Add(this.doktor_label);
            this.Controls.Add(this.sekreter_label);
            this.Controls.Add(this.hasta_label);
            this.Controls.Add(this.btn_patient);
            this.Controls.Add(this.btn_secretary);
            this.Controls.Add(this.btn_doctor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Panel";
            this.Load += new System.EventHandler(this.Login_Panel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label doktor_label;
        private Label sekreter_label;
        private Label hasta_label;
        private Button btn_patient;
        private Button btn_secretary;
        private Button btn_doctor;
    }
}
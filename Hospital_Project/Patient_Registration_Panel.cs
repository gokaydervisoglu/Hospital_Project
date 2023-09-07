using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Hospital_Project
{
    public partial class Patient_Registration_Panel : Form
    {
        public Patient_Registration_Panel()
        {
            InitializeComponent();
        }

        Sql_Baglanti sql = new Sql_Baglanti();

        private void btn_kayit_Click_1(object sender, EventArgs e)
        {
            if (name_txt.Text == "" || surname_txt.Text == "" || tc_txt.Text == "" || phone_txt.Text == "" || sex_txt.Items == null || password_txt.Text == "")
            {
                MessageBox.Show("Please Enter All Information Completely");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaCinsiyet,HastaSifre) values (@p1,@p2,@p3,@p4,@p5,@p6)", sql.baglanti());

                cmd.Parameters.AddWithValue("@p1", name_txt.Text);
                cmd.Parameters.AddWithValue("@p2", surname_txt.Text);
                cmd.Parameters.AddWithValue("@p3", tc_txt.Text);
                cmd.Parameters.AddWithValue("@p4", phone_txt.Text);
                cmd.Parameters.AddWithValue("@p5", sex_txt.Text);
                cmd.Parameters.AddWithValue("@p6", password_txt.Text);

                cmd.ExecuteNonQuery();

                DialogResult result = MessageBox.Show("Registered!" + "Password =" + password_txt.Text, "Info", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    sql.baglanti().Close();
                    this.Close();
                    Application.OpenForms["Patient_Login_Panel"].Show();
                }

            }
        }

        private void btn_geri_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Patient_Login_Panel"].Show();
        }

        private void Hasta_Kayit_Paneli_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["Patient_Login_Panel"].Show();
        }
    }
}

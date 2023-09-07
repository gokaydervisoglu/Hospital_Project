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
    public partial class Patient_Update_Panel : Form
    {
        public string? tc;
        public Patient_Update_Panel()
        {
            InitializeComponent();
        }
        Sql_Baglanti sql = new Sql_Baglanti();

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (name_txt.Text == "" || surname_txt.Text == "" || phone_txt.Text == "" || sex_txt.Text == "" || password_txt.Text == "")
            {
                MessageBox.Show("Please enter complete information");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaCinsiyet=@p4,HastaSifre=@p5 where HastaTC=@p6", sql.baglanti());

                cmd.Parameters.AddWithValue("@p6", tc);
                cmd.Parameters.AddWithValue("@p1", name_txt.Text);
                cmd.Parameters.AddWithValue("@p2", surname_txt.Text);
                cmd.Parameters.AddWithValue("@p3", phone_txt.Text);
                cmd.Parameters.AddWithValue("@p4", sex_txt.Text);
                cmd.Parameters.AddWithValue("@p5", password_txt.Text);
                cmd.ExecuteNonQuery();

                sql.baglanti().Close();

                DialogResult res = MessageBox.Show("Your Information Has Been Updated", "Info", MessageBoxButtons.OK);

                if (DialogResult.OK == res)
                {
                    this.Close();
                    Application.OpenForms["Patient_Info_Panel"].Show();
                }

            }

        }

        private void Hasta_Güncelleme_Paneli_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Hastalar where HastaTC=@p1", sql.baglanti());

            cmd.Parameters.AddWithValue("@p1", tc);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                name_txt.Text = dr[1].ToString();
                surname_txt.Text = dr[2].ToString();
                tc_txt.Text = dr[3].ToString();
                phone_txt.Text = dr[4].ToString();
                password_txt.Text = dr[5].ToString();
                sex_txt.Text = dr[6].ToString();

                sql.baglanti().Close();
            }
        }

        private void Hasta_Güncelleme_Paneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["Patient_Info_Panel"].Show();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Patient_Info_Panel"].Show();
        }
    }
}

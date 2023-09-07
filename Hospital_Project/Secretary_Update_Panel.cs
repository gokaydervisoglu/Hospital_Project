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
using Hospital_Project;

namespace Hospital_Project
{
    public partial class Secretary_Update_Panel : Form
    {
        public string? tc;
        public Secretary_Update_Panel()
        {
            InitializeComponent();
        }

        Sql_Baglanti sql = new Sql_Baglanti();

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (name_txt.Text == "" || surname_txt.Text == "" || password_txt.Text == "")
            {
                MessageBox.Show("Please enter complete information");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Update Tbl_Sekreter set SekreterAd=@p1,SekreterSoyad=@p2,SekreterSifre=@p3 where SekreterTC=@p6", sql.baglanti());

                cmd.Parameters.AddWithValue("@p6", tc);
                cmd.Parameters.AddWithValue("@p1", name_txt.Text);
                cmd.Parameters.AddWithValue("@p2", surname_txt.Text);
                cmd.Parameters.AddWithValue("@p3", password_txt.Text);
                cmd.ExecuteNonQuery();

                sql.baglanti().Close();

                DialogResult res = MessageBox.Show("Your Information Has Been Updated", "Info", MessageBoxButtons.OK);

                if (DialogResult.OK == res)
                {
                    this.Close();
                    Application.OpenForms["Secretary_Information_Panel"].Show();
                }
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Secretary_Information_Panel"].Show();
        }

        private void Sekreter_Guncelleme_Paneli_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Sekreter where SekreterTC=@p1", sql.baglanti());

            cmd.Parameters.AddWithValue("@p1", tc);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                name_txt.Text = dr[1].ToString();
                surname_txt.Text = dr[2].ToString();
                password_txt.Text = dr[3].ToString();
                tc_txt.Text = dr[4].ToString();
           

                sql.baglanti().Close();
            }
        }

        private void Sekreter_Guncelleme_Paneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["Secretary_Information_Panel"].Show();
        }
    }
}

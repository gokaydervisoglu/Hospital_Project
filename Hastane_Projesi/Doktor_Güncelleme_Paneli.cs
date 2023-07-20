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

namespace Hastane_Projesi
{
    public partial class Doktor_Güncelleme_Paneli : Form
    {
        public string? tc;
        public Doktor_Güncelleme_Paneli()
        {
            InitializeComponent();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (ad_txt.Text == "" || soyad_txt.Text == "" || brans_txt.Text == "" || sifre_txt.Text == "")
            {
                MessageBox.Show("Lutfen bilgileri eksiksiz giriniz");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p6", sql.baglanti());

                cmd.Parameters.AddWithValue("@p6", tc);
                cmd.Parameters.AddWithValue("@p1", ad_txt.Text);
                cmd.Parameters.AddWithValue("@p2", soyad_txt.Text);
                cmd.Parameters.AddWithValue("@p3", brans_txt.Text);
                cmd.Parameters.AddWithValue("@p4", sifre_txt.Text);
                cmd.ExecuteNonQuery();

                sql.baglanti().Close();

                DialogResult res = MessageBox.Show("Bilgileriniz Guncellendi", "Bilgi", MessageBoxButtons.OK);

                if(DialogResult.OK == res)
                {
                    this.Close();
                    Application.OpenForms["Doktor_Bilgi_Paneli"].Show();
                }
            }
        }

        private void Doktor_Güncelleme_Paneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["Doktor_Bilgi_Paneli"].Show();
        }
        Sql_Baglanti sql = new Sql_Baglanti();

        private void Doktor_Güncelleme_Paneli_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Doktorlar where DoktorTC=@p1", sql.baglanti());

            cmd.Parameters.AddWithValue("@p1", tc);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ad_txt.Text = dr[1].ToString();
                soyad_txt.Text = dr[2].ToString();
                tc_txt.Text = dr[3].ToString();
                brans_txt.Text = dr[4].ToString();
                sifre_txt.Text = dr[5].ToString();

                sql.baglanti().Close();
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Doktor_Bilgi_Paneli"].Show();
        }
    }
}

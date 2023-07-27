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
            if (ad_txt.Text == "" || soyad_txt.Text == "" || tc_txt.Text == "" || tel_txt.Text == "" || cinsiyet_txt.Items == null || sifre_txt.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Bilgileri Eksiksiz Giriniz");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaCinsiyet,HastaSifre) values (@p1,@p2,@p3,@p4,@p5,@p6)", sql.baglanti());

                cmd.Parameters.AddWithValue("@p1", ad_txt.Text);
                cmd.Parameters.AddWithValue("@p2", soyad_txt.Text);
                cmd.Parameters.AddWithValue("@p3", tc_txt.Text);
                cmd.Parameters.AddWithValue("@p4", tel_txt.Text);
                cmd.Parameters.AddWithValue("@p5", cinsiyet_txt.Text);
                cmd.Parameters.AddWithValue("@p6", sifre_txt.Text);

                cmd.ExecuteNonQuery();

                DialogResult result = MessageBox.Show("Kayit Olundu!" + "Sifreniz =" + sifre_txt.Text, "Bilgi", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    sql.baglanti().Close();
                    this.Close();
                    Application.OpenForms["Hasta_Giris_Paneli"].Show();
                }

            }
        }

        private void btn_geri_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Hasta_Giris_Paneli"].Show();
        }

        private void Hasta_Kayit_Paneli_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["Hasta_Giris_Paneli"].Show();
        }
    }
}

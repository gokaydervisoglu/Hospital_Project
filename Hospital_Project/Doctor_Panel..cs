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
    public partial class Doktor_Paneli : Form
    {
        public Doktor_Paneli()
        {
            InitializeComponent();
        }

        Sql_Baglanti sql = new Sql_Baglanti();

        private void btn_ekle_Click(object sender, EventArgs e)
        {  
            if (ad_txt.Text == "" || soyad_txt.Text == "" || tc_txt.Text == "" || brans_txt.Text == "" || sifre_txt.Text == "")
            {
                MessageBox.Show("Lutfen bilgileri ekiksiz giriniz");
            }
            else {
                SqlCommand cmd = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorTC,DoktorBrans,DoktorSifre) values(@p1,@p2,@p3,@p4,@p5)", sql.baglanti());
                cmd.Parameters.AddWithValue("@p1", ad_txt.Text);
                cmd.Parameters.AddWithValue("@p2", soyad_txt.Text);
                cmd.Parameters.AddWithValue("@p3", tc_txt.Text);
                cmd.Parameters.AddWithValue("@p4", brans_txt.Text);
                cmd.Parameters.AddWithValue("@p5", sifre_txt.Text);
                cmd.ExecuteNonQuery();

                sql.baglanti().Close();
                MessageBox.Show("Başarılı Şekilde Eklendi");
            }
        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            if ( tc_txt.Text == "" )
            {
                MessageBox.Show("Lutfen Kimlik No bilgisini ekiksiz giriniz");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("delete from Tbl_Doktorlar where DoktorTC=@p1", sql.baglanti());
                cmd.Parameters.AddWithValue("@p1", tc_txt.Text);
           
                cmd.ExecuteNonQuery();

                sql.baglanti().Close();
                MessageBox.Show("Başarılı Şekilde Silindi");
            }
        }

        private void Doktor_Paneli_Load(object sender, EventArgs e)
        {
            //Randevu Brans Aktarma
            SqlCommand cmd4 = new SqlCommand("Select BransAd from Tbl_Brans", sql.baglanti());

            brans_txt.Items.Clear();

            SqlDataReader reader4 = cmd4.ExecuteReader();

            while (reader4.Read())
            {
                brans_txt.Items.Add(reader4[0].ToString());
                sql.baglanti().Close();
            }

            //Mevcut Doktorlar
            DataTable dt =  new DataTable();

            SqlDataAdapter sqldata = new SqlDataAdapter("Select * from Tbl_Doktorlar ", sql.baglanti());
            sqldata.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (ad_txt.Text == "" || soyad_txt.Text == ""  || brans_txt.Text == "" || sifre_txt.Text == "")
            {
                MessageBox.Show("Lutfen bilgileri ekiksiz giriniz");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("update Tbl_Doktorlar Set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@4,DoktorSifre=@p5 where DoktorTC=@p3", sql.baglanti());
                cmd.Parameters.AddWithValue("@p1", ad_txt.Text);
                cmd.Parameters.AddWithValue("@p2", soyad_txt.Text);
                cmd.Parameters.AddWithValue("@p3", tc_txt.Text);
                cmd.Parameters.AddWithValue("@p4", brans_txt.Text);
                cmd.Parameters.AddWithValue("@p5", sifre_txt.Text);
                cmd.ExecuteNonQuery();

                sql.baglanti().Close();
                MessageBox.Show("Başarılı Şekilde Guncellendi");
            }
        }
    }
}

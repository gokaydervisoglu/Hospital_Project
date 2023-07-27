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
using System.Data.Common;
using System.Windows.Input;

namespace Hospital_Project
{
    public partial class Secretary_Information_Panel : Form
    {
        private bool key = true;
        public string? tc;
        public Secretary_Information_Panel()
        {
            InitializeComponent();
        }

        private void bilgiduzenle_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Secretary_Update_Panel fr = new Secretary_Update_Panel();
            fr.tc = tc_txt.Text;
            fr.Show();
            this.Hide();
        }

        Sql_Baglanti sql = new Sql_Baglanti();
        private void Sekreter_Bilgi_Paneli_Load(object sender, EventArgs e)
        {
            //Ad ve Soyad Cekme
            SqlCommand cmd = new SqlCommand("Select SekreterAd,SekreterSoyad From Tbl_Sekreter where SekreterTC=@p1", sql.baglanti());

            cmd.Parameters.AddWithValue("@p1", tc);

            tc_txt.Text = tc;

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ad_txt.Text = reader[0].ToString();
                soyad_txt.Text = reader[1].ToString();
                sql.baglanti().Close();
            }

            //Branslar Cekme
            DataTable dt = new DataTable();
            SqlCommand cmd2 = new SqlCommand("Select BransAd from Tbl_Brans", sql.baglanti());


            SqlDataAdapter sqldata = new SqlDataAdapter(cmd2);
            sqldata.Fill(dt);

            dataGridView1.DataSource = dt;
            sql.baglanti().Close();

            //Doktorlar Cekme
            DataTable dt3 = new DataTable();
            SqlCommand cmd3 = new SqlCommand("Select (DoktorAd+' '+DoktorSoyad) as 'Doktorlar',DoktorBrans from Tbl_Doktorlar", sql.baglanti());


            SqlDataAdapter sqldata3 = new SqlDataAdapter(cmd3);
            sqldata3.Fill(dt3);

            dataGridView2.DataSource = dt3;
            sql.baglanti().Close();

            //Randevu Brans Aktarma
            SqlCommand cmd4 = new SqlCommand("Select BransAd from Tbl_Brans", sql.baglanti());

            brans_txt.Items.Clear();

            SqlDataReader reader4 = cmd4.ExecuteReader();

            while (reader4.Read())
            {
                brans_txt.Items.Add(reader4[0].ToString());
                sql.baglanti().Close();
            }

        }

        private void Sekreter_Bilgi_Paneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (key == true)
            {
                Application.OpenForms["Giris_Paneli"].Close();
            }
        }

        private void randevu_kaydet_btn_Click(object sender, EventArgs e)
        {

            if (tarih_txt.Text == "" || zaman_txt.Text == "" || brans_txt.Text == ""|| doktor_txt.Text == "")
            {
                MessageBox.Show("Lutfen bilgileri eksiksiz giriniz");
            }
            else 
            {
                //Randevu Olusturma
                SqlCommand cmd3 = new SqlCommand("insert into Tbl_Randevu (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@p1,@p2,@p3,@p4)", sql.baglanti());
                cmd3.Parameters.AddWithValue("@p1", tarih_txt.Text);
                cmd3.Parameters.AddWithValue("@p2", zaman_txt.Text);
                cmd3.Parameters.AddWithValue("@p3", brans_txt.Text);
                cmd3.Parameters.AddWithValue("@p4", doktor_txt.Text);
                cmd3.ExecuteNonQuery();

                sql.baglanti().Close();
                MessageBox.Show("Randevu Olusturuldu!");
            }


        }

        private void guncelle_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (guncelle_btn.Checked == true)
            {
                id_txt.Enabled = true;
                kimlikno_txt.Enabled = true;
            }
            else 
            {
                id_txt.Enabled = false;
                kimlikno_txt.Enabled = false;
            }
        }

        private void brans_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Doktor Cekme
            SqlCommand cmd3 = new SqlCommand("Select DoktorAd from Tbl_Doktorlar where DoktorBrans=@p1", sql.baglanti());

            cmd3.Parameters.AddWithValue("@p1", brans_txt.Text);

            doktor_txt.Items.Clear();

            SqlDataReader reader3 = cmd3.ExecuteReader();

            while (reader3.Read())
            {
                doktor_txt.Items.Add(reader3[0].ToString());
            }
        }

        private void btn_duyuru_Click(object sender, EventArgs e)
        {
            if (duyuru_txt.Text == "")
            {
                MessageBox.Show("Lutfen duyuruyu giriniz!");
            }
            else
            {
                //Duyuru Olusturma
                SqlCommand cmd = new SqlCommand("insert into Tbl_Duyuru (Duyuru) values (@p1)", sql.baglanti());

                cmd.Parameters.AddWithValue("@p1", duyuru_txt.Text);
                cmd.ExecuteNonQuery();
                duyuru_txt.Clear();
                MessageBox.Show("Duyuru Olusturuldu!");

            }
        }

        private void btn_doktorpnl_Click(object sender, EventArgs e)
        {
            Doktor_Paneli fr = new Doktor_Paneli();
            fr.Show();

        }

        private void btn_branspnl_Click(object sender, EventArgs e)
        {
            Branches_Panel br = new Branches_Panel();
            br.Show();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            key = false;
            this.Close();
            Application.OpenForms["Giris_Paneli"].Show();
        }

        private void btn_randevulst_Click(object sender, EventArgs e)
        {
            Appointment_List_Panel fr = new Appointment_List_Panel();
            fr.Show();
        }

        private void randevu_guncelle_btn_Click(object sender, EventArgs e)
        {
            if (id_txt.Text == "" )
            {
                MessageBox.Show("Lutfen ID bilgisini eksiksiz giriniz");
            }
            else
            {
                //Randevu Guncelleme
                SqlCommand cmd3 = new SqlCommand("update Tbl_Randevu Set RandevuTarih=@p1,RandevuSaat=@p2,RandevuBrans=@p3,RandevuDoktor=@p4,HastaTC=@p5 where RandevuID=@p7", sql.baglanti());
                cmd3.Parameters.AddWithValue("@p7", id_txt.Text);
                cmd3.Parameters.AddWithValue("@p1", tarih_txt.Text);
                cmd3.Parameters.AddWithValue("@p2", zaman_txt.Text);
                cmd3.Parameters.AddWithValue("@p3", brans_txt.Text);
                cmd3.Parameters.AddWithValue("@p4", doktor_txt.Text);
                cmd3.Parameters.AddWithValue("@p5", tc_txt.Text);

                string durum;

                if(durum_btn.Checked)
                {
                    durum = "True";
                }
                else
                {
                    durum = "False";
                }


                cmd3.Parameters.AddWithValue("@p6", durum);
                cmd3.ExecuteNonQuery();

                sql.baglanti().Close();
                MessageBox.Show("Randevu Guncellendi!");
            }
        }

        public void SetData(string id,string tarih,string saat,string brans,string doktor,string kimlik,bool durum)
        {
            id_txt.Text = id;
            tarih_txt.Text = tarih;
            zaman_txt.Text = saat;
            brans_txt.Text = brans;
            doktor_txt.Text = doktor;
            kimlikno_txt.Text = kimlik;
            durum_btn.Checked = durum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id_txt.Text == "")
            {
                MessageBox.Show("Lutfen ID bilgisini eksiksiz giriniz");
            }
            else
            {
                //Randevu Guncelleme
                SqlCommand cmd3 = new SqlCommand("delete from Tbl_Randevu where RandevuID=@p7", sql.baglanti());
                cmd3.Parameters.AddWithValue("@p7", id_txt.Text);
                cmd3.ExecuteNonQuery();

                sql.baglanti().Close();
                MessageBox.Show("Randevu Silindi!");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Secretary_Notice_Panel fr = new Secretary_Notice_Panel();
            fr.Show();
        }
    }
}

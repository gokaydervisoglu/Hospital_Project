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
            // Get Name and Surname
            SqlCommand cmd = new SqlCommand("Select SekreterAd,SekreterSoyad From Tbl_Sekreter where SekreterTC=@p1", sql.baglanti());

            cmd.Parameters.AddWithValue("@p1", tc);

            tc_txt.Text = tc;

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                name_txt.Text = reader[0].ToString();
                surname_txt.Text = reader[1].ToString();
                sql.baglanti().Close();
            }

            // Get Branches
            DataTable dt = new DataTable();
            SqlCommand cmd2 = new SqlCommand("Select BransAd from Tbl_Brans", sql.baglanti());


            SqlDataAdapter sqldata = new SqlDataAdapter(cmd2);
            sqldata.Fill(dt);

            dataGridView1.DataSource = dt;
            sql.baglanti().Close();

            // Get Doctors
            DataTable dt3 = new DataTable();
            SqlCommand cmd3 = new SqlCommand("Select (DoktorAd+' '+DoktorSoyad) as 'Doktorlar',DoktorBrans from Tbl_Doktorlar", sql.baglanti());


            SqlDataAdapter sqldata3 = new SqlDataAdapter(cmd3);
            sqldata3.Fill(dt3);

            dataGridView2.DataSource = dt3;
            sql.baglanti().Close();

            // Appointment Branch Transfer
            SqlCommand cmd4 = new SqlCommand("Select BransAd from Tbl_Brans", sql.baglanti());

            branch_txt.Items.Clear();

            SqlDataReader reader4 = cmd4.ExecuteReader();

            while (reader4.Read())
            {
                branch_txt.Items.Add(reader4[0].ToString());
                sql.baglanti().Close();
            }

        }

        private void Sekreter_Bilgi_Paneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (key == true)
            {
                Application.OpenForms["Login_Panel"].Close();
            }
        }

        private void randevu_kaydet_btn_Click(object sender, EventArgs e)
        {

            if (date_txt.Text == "" || time_txt.Text == "" || branch_txt.Text == ""|| doctor_txt.Text == "")
            {
                MessageBox.Show("Please enter complete information");
            }
            else 
            {
                //Randevu Olusturma
                SqlCommand cmd3 = new SqlCommand("insert into Tbl_Randevu (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@p1,@p2,@p3,@p4)", sql.baglanti());
                cmd3.Parameters.AddWithValue("@p1", date_txt.Text);
                cmd3.Parameters.AddWithValue("@p2", time_txt.Text);
                cmd3.Parameters.AddWithValue("@p3", branch_txt.Text);
                cmd3.Parameters.AddWithValue("@p4", doctor_txt.Text);
                cmd3.ExecuteNonQuery();

                sql.baglanti().Close();
                MessageBox.Show("Appointment Created!");
            }


        }

        private void guncelle_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_updatemode.Checked == true)
            {
                id_txt.Enabled = true;
                idno_txt.Enabled = true;
            }
            else 
            {
                id_txt.Enabled = false;
                idno_txt.Enabled = false;
            }
        }

        private void brans_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Doktor Cekme
            SqlCommand cmd3 = new SqlCommand("Select DoktorAd from Tbl_Doktorlar where DoktorBrans=@p1", sql.baglanti());

            cmd3.Parameters.AddWithValue("@p1", branch_txt.Text);

            doctor_txt.Items.Clear();

            SqlDataReader reader3 = cmd3.ExecuteReader();

            while (reader3.Read())
            {
                doctor_txt.Items.Add(reader3[0].ToString());
            }
        }

        private void btn_duyuru_Click(object sender, EventArgs e)
        {
            if (duyuru_txt.Text == "")
            {
                MessageBox.Show("Please enter the announcement!");
            }
            else
            {
                // Creating Announcements
                SqlCommand cmd = new SqlCommand("insert into Tbl_Duyuru (Duyuru) values (@p1)", sql.baglanti());

                cmd.Parameters.AddWithValue("@p1", duyuru_txt.Text);
                cmd.ExecuteNonQuery();
                duyuru_txt.Clear();
                MessageBox.Show("Announcement Created!");

            }
        }

        private void btn_doktorpnl_Click(object sender, EventArgs e)
        {
            doctor_panel fr = new doctor_panel();
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
            Application.OpenForms["Login_Panel"].Show();
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
                MessageBox.Show("Please enter the complete ID information.");
            }
            else
            {
                // Appointment Update
                SqlCommand cmd3 = new SqlCommand("update Tbl_Randevu Set RandevuTarih=@p1,RandevuSaat=@p2,RandevuBrans=@p3,RandevuDoktor=@p4,HastaTC=@p5 where RandevuID=@p7", sql.baglanti());
                cmd3.Parameters.AddWithValue("@p7", id_txt.Text);
                cmd3.Parameters.AddWithValue("@p1", date_txt.Text);
                cmd3.Parameters.AddWithValue("@p2", time_txt.Text);
                cmd3.Parameters.AddWithValue("@p3", branch_txt.Text);
                cmd3.Parameters.AddWithValue("@p4", doctor_txt.Text);
                cmd3.Parameters.AddWithValue("@p5", tc_txt.Text);

                string durum;

                if(status_btn.Checked)
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
                MessageBox.Show("Appointment Updated!");
            }
        }

        public void SetData(string id,string tarih,string saat,string brans,string doktor,string kimlik,bool durum)
        {
            id_txt.Text = id;
            date_txt.Text = tarih;
            time_txt.Text = saat;
            branch_txt.Text = brans;
            doctor_txt.Text = doktor;
            idno_txt.Text = kimlik;
            status_btn.Checked = durum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id_txt.Text == "")
            {
                MessageBox.Show("Please enter the complete ID information.");
            }
            else
            {
                //Randevu Guncelleme
                SqlCommand cmd3 = new SqlCommand("delete from Tbl_Randevu where RandevuID=@p7", sql.baglanti());
                cmd3.Parameters.AddWithValue("@p7", id_txt.Text);
                cmd3.ExecuteNonQuery();

                sql.baglanti().Close();
                MessageBox.Show("Appointment Deleted!");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Secretary_Notice_Panel fr = new Secretary_Notice_Panel();
            fr.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

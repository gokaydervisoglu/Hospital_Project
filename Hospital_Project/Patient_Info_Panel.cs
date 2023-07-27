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
    public partial class Patient_Info_Panel : Form
    {
        private bool key = true;
        public Patient_Info_Panel()
        {
            InitializeComponent();
        }

        private void Hasta_Bilgi_Paneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (key == true)
            {
                Application.OpenForms["Giris_Paneli"].Close();
            }
        
        }
        
        Sql_Baglanti sql = new Sql_Baglanti();

        public string? tc;
        private void Hasta_Bilgi_Paneli_Load(object sender, EventArgs e)
        {
            //Ad ve Soyad Cekme
            SqlCommand cmd = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTC=@p1", sql.baglanti());

            cmd.Parameters.AddWithValue("@p1", tc);

            tc_txt.Text = tc;

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ad_txt.Text = reader[0].ToString();
                soyad_txt.Text = reader[1].ToString();
                sql.baglanti().Close();
            }

            //Gecmis Randevu Paneli Cekme
            DataTable dt = new DataTable();

            SqlCommand cmd4 = new SqlCommand("Select * from Tbl_Randevu where HastaTC=@p1", sql.baglanti());

            cmd4.Parameters.AddWithValue("@p1", tc);

            SqlDataAdapter sqldata = new SqlDataAdapter(cmd4);
            sqldata.Fill(dt);

            dataGridView1.DataSource = dt;
            sql.baglanti().Close();

            //Brans Cekme
            SqlCommand cmd2 = new SqlCommand("Select BransAd from Tbl_Brans", sql.baglanti());

            brans_txt.Items.Clear();

            SqlDataReader reader2 = cmd2.ExecuteReader();

            while (reader2.Read())
            {
                brans_txt.Items.Add(reader2[0].ToString());
                sql.baglanti().Close();
            }


        }

        public string? id;

        private void btn_randevu_Click(object sender, EventArgs e)
        {
            if (brans_txt.SelectedIndex == -1 || doktorad_txt.SelectedIndex == -1 || id_txt.Text == "")
            {
                MessageBox.Show("Lutfen Randevu Seciniz");
            }
            else
            {
                SqlCommand cmd2 = new SqlCommand("Update Tbl_Randevu Set RandevuDurum=1,HastaTC=@p1 where RandevuID=@p2", sql.baglanti());
                cmd2.Parameters.AddWithValue("@p2", id_txt.Text);
                cmd2.Parameters.AddWithValue("@p1", tc_txt.Text);
                cmd2.ExecuteNonQuery();
                sql.baglanti().Close();

                DialogResult res = MessageBox.Show("Randevu Alindi", "Bilgi", MessageBoxButtons.OK);
                if (res == DialogResult.OK)
                {
                    //Sikayet Gonderme
                    SqlCommand cmd = new SqlCommand("insert into Tbl_Sikayet (Sikayet,HastaTC,RandevuID) values (@p1,@p2,@p3)", sql.baglanti());
                    cmd.Parameters.AddWithValue("@p1", sikayet_txt.Text);
                    cmd.Parameters.AddWithValue("@p2", tc_txt.Text);
                    cmd.Parameters.AddWithValue("@p3", id_txt.Text);
                    cmd.ExecuteNonQuery();
                    sql.baglanti().Close();

                    sikayet_txt.Clear();
                    brans_txt.Text = string.Empty;
                    doktorad_txt.Text = string.Empty;

                }
                else
                {
                    MessageBox.Show("Randevu Alinamadi!");
                }
            }

          
            
        }

        private void bilgiduzenle_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Patient_Update_Panel gnc = new Patient_Update_Panel();
            gnc.tc = tc;
            gnc.Show();
            this.Hide();
        }

        private void brans_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Doktor Cekme
            SqlCommand cmd3 = new SqlCommand("Select DoktorAd from Tbl_Doktorlar where DoktorBrans=@p1", sql.baglanti());

            cmd3.Parameters.AddWithValue("@p1", brans_txt.Text);

            doktorad_txt.Items.Clear();

            SqlDataReader reader3 = cmd3.ExecuteReader();

            while (reader3.Read())
            {
                doktorad_txt.Items.Add(reader3[0].ToString());
            }
        }

        private void doktorad_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Aktif Randevu Paneli Cekme
            DataTable dt = new DataTable();

            SqlCommand cmd4 = new SqlCommand("Select * from Tbl_Randevu where RandevuDoktor=@p1 and RandevuDurum=0", sql.baglanti());

            cmd4.Parameters.AddWithValue("@p1", doktorad_txt.Text);

            SqlDataAdapter sqldata = new SqlDataAdapter(cmd4);
            sqldata.Fill(dt);

            dataGridView2.DataSource = dt;
            sql.baglanti().Close();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            key = false;
            this.Close();
            Application.OpenForms["Hasta_Giris_Paneli"].Show();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Randevu Alma
            int selectedRow = dataGridView2.CurrentCell.RowIndex;
            id_txt.Text = dataGridView2.Rows[selectedRow].Cells[0].Value.ToString();
        }
    }
}

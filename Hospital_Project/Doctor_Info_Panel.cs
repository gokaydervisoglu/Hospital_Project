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
using Microsoft.Identity.Client;
using Hospital_Project;

namespace Hospital_Project
{
    public partial class Doctor_Info_Panel : Form
    {
        private bool key = true;
        public string? id;
        public Doctor_Info_Panel()
        {
            InitializeComponent();
        }

        private void bilgiduzenle_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Doctor_Update_Panel fr = new Doctor_Update_Panel();
            fr.tc = tc_txt.Text;
            fr.Show();
            this.Hide();
        }

        public string? tc;

        Sql_Baglanti sql = new Sql_Baglanti();

        private void Doktor_Bilgi_Paneli_Load(object sender, EventArgs e)
        {
            //Name and Surname
            SqlCommand cmd = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorTC=@p1", sql.baglanti());

            cmd.Parameters.AddWithValue("@p1", tc);

            tc_txt.Text = tc;

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                name_txt.Text = reader[0].ToString();
                surname_txt.Text = reader[1].ToString();
                sql.baglanti().Close();
            }

            //Appointment panel
            DataTable dt = new DataTable();
            SqlDataAdapter sqldata = new SqlDataAdapter("Select * from Tbl_Randevu where RandevuDoktor = '" + name_txt.Text + "'", sql.baglanti());

            sqldata.Fill(dt);
            dataGridView1.DataSource = dt;
            
            
            sql.baglanti().Close();
        }

        private void Doktor_Bilgi_Paneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (key == true)
            {
                Application.OpenForms["Login_Panel"].Close();
            }
        }

        private void btn_duyurular_Click(object sender, EventArgs e)
        {
            Doctor_Notice_Panel fr = new Doctor_Notice_Panel();
            fr.Show();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Login_Panel"].Close();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            key = false;
            this.Close();
            Application.OpenForms["Login_Panel"].Show();
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Appointment select
            int selectedRow = dataGridView1.CurrentCell.RowIndex;
            id = dataGridView1.Rows[selectedRow].Cells[0].Value.ToString();

            //Complaint select
      
            SqlCommand cmd2 = new SqlCommand("Select Sikayet from Tbl_Sikayet where RandevuID=@p1", sql.baglanti());
            cmd2.Parameters.AddWithValue("@p1", id);
            SqlDataReader reader = cmd2.ExecuteReader();

            while (reader.Read())
            {
                appoint_info.Text = reader[0].ToString();
            }

            sql.baglanti().Close();

            
        }
    }
}

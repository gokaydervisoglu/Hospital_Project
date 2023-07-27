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
using System.IO;
using System.Windows.Input;


namespace Hospital_Project
{
    public partial class Patient_Login_Panel : Form
    {

        public bool key;

        public Patient_Login_Panel()
        {
            InitializeComponent();
        }

        private void Hasta_Giris_Paneli_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["Giris_Paneli"].Show();
        }

        Sql_Baglanti sql = new Sql_Baglanti();

        private void btn_giris_Click_1(object sender, EventArgs e)
        {
            if(btnhatirla.Checked == true)
            {
                key = true;
                if (tc_txt.Text != "" && sifre_txt.Text != "")
                {
                    File.Delete("hasta.txt");
                    adminwr();
                }
                else
                {

                }
            }

            if(tc_txt.Text == "" || sifre_txt.Text == "")
            {
                MessageBox.Show("Lütfen kimlik no ve şifreyi giriniz");     
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1 and HastaSifre=@p2", sql.baglanti());

                cmd.Parameters.AddWithValue("@p1", tc_txt.Text);
                cmd.Parameters.AddWithValue("@p2", sifre_txt.Text);


                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Patient_Info_Panel fr = new Patient_Info_Panel();
                    fr.tc = tc_txt.Text;
                    fr.Show();
                    this.Hide();
                    sql.baglanti().Close();
                }
                else
                {
                    MessageBox.Show("Hatali Kullanici Adi ya da Sifre");
                }
            }
        }

        private void kayitol_label_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Patient_Registration_Panel fr = new Patient_Registration_Panel();
            this.Hide();
            fr.Show();
        }

        private void btnhatirla_CheckedChanged(object sender, EventArgs e)
        {
            if (btnhatirla.Checked == true)
            {
                key = true;
                if (tc_txt.Text != "" && sifre_txt.Text != "")
                {
                    adminwr();
                }
                else
                {

                }
            }
            else
            {
                key = false;
                File.Delete("hasta.txt");
                keywr();
            }
        }

        private void adminwr()
        {
            string tc, sifre;
            string path = "hasta.txt";
            string path2 = "key.txt";

            tc = tc_txt.Text;
            sifre = sifre_txt.Text;

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(tc);
                sw.WriteLine(sifre);
            }
            using (StreamWriter swr = new StreamWriter(path2))
            {
                swr.WriteLine(key.ToString());
            }
        }
        private void keywr()
        {
            string path = "key.txt";

            using (StreamWriter swr = new StreamWriter(path))
            {
                swr.WriteLine(key.ToString());
            }
        }
        private void adminrd()
        {
            string tc, sifre;
            string path = "hasta.txt";

            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    tc = sr.ReadLine();
                    sifre = sr.ReadLine();
                }
                tc_txt.Text = tc;
                sifre_txt.Text = sifre;
            }
        }
        private void keyrd()
        {
            string path2 = "key.txt";

            if (File.Exists(path2))
            {
                using (StreamReader sr = new StreamReader(path2))
                {
                    key = Convert.ToBoolean(sr.ReadLine());
                }
            }
        }

        private void Hasta_Giris_Paneli_Load(object sender, EventArgs e)
        {
            keyrd();

            if (key)
            {
                btnhatirla.Checked = true;
                adminrd();
            }
            else
            {
                tc_txt.Text = string.Empty;
                sifre_txt.Text = string.Empty;
                btnhatirla.Checked = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Password_Forgot_Panel fr = new Password_Forgot_Panel();
            this.Hide();
            fr.Show();
        }
    }
}

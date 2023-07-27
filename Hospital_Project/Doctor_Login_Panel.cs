using Hospital_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Hospital_Project
{
    public partial class Doctor_Login_Panel : Form
    {
        public bool key;
        public Doctor_Login_Panel()
        {
            InitializeComponent();
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
                File.Delete("doktor.txt");
                keywr();
            }
        }

        private void adminwr()
        {
            string tc, sifre;
            string path = "doktor.txt";
            string path2 = "key2.txt";

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
            string path = "key2.txt";

            using (StreamWriter swr = new StreamWriter(path))
            {
                swr.WriteLine(key.ToString());
            }
        }
        private void adminrd()
        {
            string tc, sifre;
            string path = "doktor.txt";

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
            string path2 = "key2.txt";

            if (File.Exists(path2))
            {
                using (StreamReader sr = new StreamReader(path2))
                {
                    key = Convert.ToBoolean(sr.ReadLine());
                }
            }
        }

        private void Doktor_Giris_Paneli_Load(object sender, EventArgs e)
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

        Sql_Baglanti sql = new Sql_Baglanti();

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (btnhatirla.Checked == true)
            {
                key = true;
                if (tc_txt.Text != "" && sifre_txt.Text != "")
                {
                    File.Delete("doktor.txt");
                    adminwr();
                }
                else
                {

                }
            }

            if (tc_txt.Text == "" || sifre_txt.Text == "")
            {
                MessageBox.Show("Lütfen kimlik no ve şifreyi giriniz");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@p1 and DoktorSifre=@p2", sql.baglanti());

                cmd.Parameters.AddWithValue("@p1", tc_txt.Text);
                cmd.Parameters.AddWithValue("@p2", sifre_txt.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Doctor_Info_Panel fr = new Doctor_Info_Panel();
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

        private void Doktor_Giris_Paneli_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["Giris_Paneli"].Show();
        }
    }
}

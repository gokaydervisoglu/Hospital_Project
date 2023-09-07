using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Data.SqlClient;

namespace Hospital_Project
{
    public partial class Secretary_Login_Panel : Form
    {
        private bool key;
        public Secretary_Login_Panel()
        {
            InitializeComponent();
        }
        Sql_Baglanti sql = new Sql_Baglanti();

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (btn_rm.Checked == true)
            {
                key = true;
                if (tc_txt.Text != "" && password_txt.Text != "")
                {
                    File.Delete("secretary.txt");
                    adminwr();
                }
                else
                {

                }
            }

            if (tc_txt.Text == "" || password_txt.Text == "")
            {
                MessageBox.Show("Please enter ID number and password");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Select * From Tbl_Sekreter where SekreterTC=@p1 and SekreterSifre=@p2", sql.baglanti());

                cmd.Parameters.AddWithValue("@p1", tc_txt.Text);
                cmd.Parameters.AddWithValue("@p2", password_txt.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Secretary_Information_Panel fr = new Secretary_Information_Panel();
                    fr.tc = tc_txt.Text;
                    fr.Show();
                    this.Hide();
                    sql.baglanti().Close();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
            }
        }

        private void Sekreter_Giris_Paneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["Login_Panel"].Show();
        }

        private void btnhatirla_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_rm.Checked == true)
            {
                key = true;
                if (tc_txt.Text != "" && password_txt.Text != "")
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
                File.Delete("secretary.txt");
                keywr();
            }
        }
        private void adminwr()
        {
            string tc, sifre;
            string path = "secretary.txt";
            string path2 = "key3.txt";

            tc = tc_txt.Text;
            sifre = password_txt.Text;

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
            string path = "key3.txt";

            using (StreamWriter swr = new StreamWriter(path))
            {
                swr.WriteLine(key.ToString());
            }
        }
        private void adminrd()
        {
            string tc, sifre;
            string path = "secretary.txt";

            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    tc = sr.ReadLine();
                    sifre = sr.ReadLine();
                }
                tc_txt.Text = tc;
                password_txt.Text = sifre;
            }
        }
        private void keyrd()
        {
            string path2 = "key3.txt";

            if (File.Exists(path2))
            {
                using (StreamReader sr = new StreamReader(path2))
                {
                    key = Convert.ToBoolean(sr.ReadLine());
                }
            }
        }

        private void Sekreter_Giris_Paneli_Load(object sender, EventArgs e)
        {
            keyrd();

            if (key)
            {
                btn_rm.Checked = true;
                adminrd();
            }
            else
            {
                tc_txt.Text = string.Empty;
                password_txt.Text = string.Empty;
                btn_rm.Checked = false;
            }
        }
    }
}

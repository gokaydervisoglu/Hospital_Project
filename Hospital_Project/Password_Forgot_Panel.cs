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
    public partial class Password_Forgot_Panel : Form
    {
        public Password_Forgot_Panel()
        {
            InitializeComponent();
        }

        Sql_Baglanti sql = new Sql_Baglanti();

        private void btn_kurtar_Click(object sender, EventArgs e)
        {
            if (tc_txt.Text == "" || mail_txt.Text == "" || phone_txt.Text == "")
            {
                MessageBox.Show("Please enter all the information completely!");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into Tbl_SifreUnuttum (HastaTC,HastaMail,HastaTel) values (@p1,@p2,@p3)", sql.baglanti());
                cmd.Parameters.AddWithValue("@p1", tc_txt.Text);
                cmd.Parameters.AddWithValue("@p2", mail_txt.Text);
                cmd.Parameters.AddWithValue("@p3", phone_txt.Text);
                cmd.ExecuteNonQuery();
                sql.baglanti().Close();
                DialogResult res = MessageBox.Show("Request Received!", "Info",MessageBoxButtons.OK);

                if (res == DialogResult.OK)
                {
                    this.Close();
                    Application.OpenForms["Patient_Login_Panel"].Show();
                }

            }
        }

        private void Sifre_Unuttum_Paneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["Patient_Login_Panel"].Show();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Patient_Login_Panel"].Show();
        }
    }
}

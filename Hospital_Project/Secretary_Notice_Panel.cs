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
using System.Net.Mail;

namespace Hospital_Project
{
    public partial class Secretary_Notice_Panel : Form
    {
        public string? id;
        private string? tc;
        private string? mail;
        private string? password;
        private string? name;
        public Secretary_Notice_Panel()
        {
            InitializeComponent();
        }

        Sql_Baglanti sql = new Sql_Baglanti();

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //Get an Appointment
            int selectedRow = dataGridView2.CurrentCell.RowIndex;
            id = dataGridView2.Rows[selectedRow].Cells[0].Value.ToString();

            if (tc != null)
            {
                // Patient Information Retrieval
                DataTable dt2 = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from Tbl_Hastalar where HastaTC=@p1", sql.baglanti());
                cmd.Parameters.AddWithValue("@p1", tc);

                SqlDataAdapter sqldata2 = new SqlDataAdapter(cmd);
                sqldata2.Fill(dt2);
                //cmd.ExecuteNonQuery();

                dataGridView1.DataSource = dt2;

                SqlDataReader rd2 = cmd.ExecuteReader();
                while (rd2.Read())
                {
                    name = rd2[1].ToString();
                    password = rd2[5].ToString();
                }

                sql.baglanti().Close();

                //Transfer to Panel

                tc_txt.Text = tc;
                password_txt.Text = password;
                mail_txt.Text = mail;
            }

        }

        private void Sekreter_Duyuru_Paneli_Load(object sender, EventArgs e)
        {
            patient_btn.Checked = true;
        }

        private void hasta_duyuru_txt_CheckedChanged(object sender, EventArgs e)
        {
            if(patient_btn.Checked ==  false)
            {
                doctor_btn.Checked = true;
                groupBox2.Text = "Doctor Info";
            }
            else
            {
                //Hasta Cekme
                doctor_btn.Checked = false;
                groupBox2.Text = "Patient İnfo";
                DataTable dt = new DataTable();

                SqlCommand cmd2 = new SqlCommand("Select * from Tbl_Hastalar", sql.baglanti());
                SqlDataAdapter sqldata = new SqlDataAdapter(cmd2);
                sqldata.Fill(dt);
                
                dataGridView2.DataSource = dt;

                SqlDataReader rd = cmd2.ExecuteReader();
                while (rd.Read())
                {
                    tc = rd[1].ToString();
                    mail = rd[2].ToString();
                }
                sql.baglanti().Close();



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tc_txt.Text == "" || password_txt.Text == "" || mail_txt.Text == "")
            {
                MessageBox.Show("Please enter the information of the person whose password you will reset!");
            }
            else
            {
                Random random = new Random();
                int randomNumber = random.Next(1000, 10000);

                if (tc != null)
                {
                    //password helper

                    SqlCommand cmd = new SqlCommand("Update Tbl_Hastalar Set HastaSifre=@p1 where HastaTC=@p2", sql.baglanti());
                    cmd.Parameters.AddWithValue("@p2", tc);
                    cmd.Parameters.AddWithValue("@p1", randomNumber.ToString());
                    cmd.ExecuteNonQuery();
                    sql.baglanti().Close();
                }
                //Mail Sending
                MailMessage mailMessage = new MailMessage();
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Credentials = new System.Net.NetworkCredential("gokay_d@outlook.com", "vuNkad-kysvaq-wubqo6");
                smtpClient.Port = 587;
                smtpClient.Host = "smtp-mail.outlook.com";
                smtpClient.EnableSsl = true;
                mailMessage.To.Add(mail_txt.Text);
                mailMessage.From = new MailAddress("gokay_d@outlook.com");
                mailMessage.Subject = "password reset";
                mailMessage.Body = ("Hello " + name + "your password has been reset ,your temporary password=" + randomNumber + ",You can change your password from the panel later, have a nice day.");
                smtpClient.Send(mailMessage);

                MessageBox.Show("Mail Gonderildi");

                //password Recovery Announcement Uninstall
                SqlCommand cmd2 = new SqlCommand("delete from Tbl_Hastalar where HastaTC=@p1", sql.baglanti());
                cmd2.Parameters.AddWithValue("@p1", tc);
                cmd2.ExecuteNonQuery();
                sql.baglanti().Close();
                dataGridView2.ClearSelection();
                dataGridView1.ClearSelection();

                tc_txt.Clear();
                password_txt.Clear();
                mail_txt.Clear();
            }

        }
    }
}

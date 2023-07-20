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

namespace Hastane_Projesi
{
    public partial class Brans_Paneli : Form
    {
        public Brans_Paneli()
        {
            InitializeComponent();
        }

        Sql_Baglanti sql =  new Sql_Baglanti();

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (bransad_txt.Text == "")
            {
                MessageBox.Show("Lutfen Brans Adi Giriniz");
            }
            else 
            {
                SqlCommand cmd = new SqlCommand("insert into Tbl_Brans (BransAd) values (@p1)", sql.baglanti());
                cmd.Parameters.AddWithValue("@p1", bransad_txt.Text);
                cmd.ExecuteNonQuery();
                sql.baglanti().Close();
                MessageBox.Show("Brans Atandi");
            }
        }

        private void Brans_Paneli_Load(object sender, EventArgs e)
        {
            //Mevcut Brans
            DataTable dt = new DataTable();

            SqlDataAdapter sqldata = new SqlDataAdapter("Select * from Tbl_Brans ", sql.baglanti());
            sqldata.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            if (bransid_txt.Text == "")
            {
                MessageBox.Show("Lutfen Brans ID Giriniz");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("delete from Tbl_Brans where BransID=@p1", sql.baglanti());
                cmd.Parameters.AddWithValue("@p1", bransad_txt.Text);
                cmd.ExecuteNonQuery();
                sql.baglanti().Close();
                MessageBox.Show("Brans Silindi");
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (bransid_txt.Text == "")
            {
                MessageBox.Show("Lutfen Brans ID Giriniz");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("update Tbl_Brans Set BransAd=@p1 where BransID=@p2", sql.baglanti());
                cmd.Parameters.AddWithValue("@p1", bransad_txt.Text);
                cmd.Parameters.AddWithValue("@p2", bransid_txt.Text);
                cmd.ExecuteNonQuery();
                sql.baglanti().Close();
                MessageBox.Show("Brans Guncellendi");
            }
        }
    }
}

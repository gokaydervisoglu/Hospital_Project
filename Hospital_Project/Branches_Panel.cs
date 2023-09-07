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
    public partial class Branches_Panel : Form
    {
        public Branches_Panel()
        {
            InitializeComponent();
        }

        Sql_Baglanti sql =  new Sql_Baglanti();

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (branchname_txt.Text == "")
            {
                MessageBox.Show("Please enter the branch name");
            }
            else 
            {
                SqlCommand cmd = new SqlCommand("insert into Tbl_Brans (BransAd) values (@p1)", sql.baglanti());
                cmd.Parameters.AddWithValue("@p1", branchname_txt.Text);
                cmd.ExecuteNonQuery();
                sql.baglanti().Close();
                MessageBox.Show("Branch Added");
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
            if (branchid_txt.Text == "")
            {
                MessageBox.Show("Please enter the branch id");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("delete from Tbl_Brans where BransID=@p1", sql.baglanti());
                cmd.Parameters.AddWithValue("@p1", branchname_txt.Text);
                cmd.ExecuteNonQuery();
                sql.baglanti().Close();
                MessageBox.Show("Branch deleted");
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (branchid_txt.Text == "")
            {
                MessageBox.Show("Please enter the branch id");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("update Tbl_Brans Set BransAd=@p1 where BransID=@p2", sql.baglanti());
                cmd.Parameters.AddWithValue("@p1", branchname_txt.Text);
                cmd.Parameters.AddWithValue("@p2", branchid_txt.Text);
                cmd.ExecuteNonQuery();
                sql.baglanti().Close();
                MessageBox.Show("Branch Updated");
            }
        }
    }
}

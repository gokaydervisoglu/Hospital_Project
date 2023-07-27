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
    public partial class Doctor_Notice_Panel : Form
    {
        public Doctor_Notice_Panel()
        {
            InitializeComponent();
        }

        Sql_Baglanti sql = new Sql_Baglanti();  

        private void Doktor_Duyuru_Paneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqldata = new SqlDataAdapter("Select * from Tbl_Duyuru",sql.baglanti());

            sqldata.Fill(dt);

            dataGridView1.DataSource = dt;
            sql.baglanti().Close();

        }
    }
}

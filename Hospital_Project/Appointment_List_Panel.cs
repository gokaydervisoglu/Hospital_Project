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
    public partial class Appointment_List_Panel : Form
    {
        public string? id;
        public string? date;
        public string? time;
        public string? branch;
        public string? doctor;
        public string? status;
        public string? tc;
        public bool bstatus;

     
        public Appointment_List_Panel()
        {
            InitializeComponent();
        }
        Sql_Baglanti sql = new Sql_Baglanti();
        private void Randevu_Listesi_Paneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqldata = new SqlDataAdapter("Select * from Tbl_Randevu",sql.baglanti());

            sqldata.Fill(dt);
            dataGridView1.DataSource = dt;
            sql.baglanti().Close();
        }
        

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Secretary_Information_Panel? fr = Application.OpenForms["Secretary_Notice_Panel"] as Secretary_Information_Panel;
            int selectedRow = dataGridView1.CurrentCell.RowIndex;
            id = dataGridView1.Rows[selectedRow].Cells[0].Value.ToString();

            if (fr == null)
            {
                MessageBox.Show("Critical Error");
            }
            else if(fr !=  null)
            {

                //Randevu Alma
                if (id != null)
                {
                    date = dataGridView1.Rows[selectedRow].Cells[1].Value.ToString();
                    time = dataGridView1.Rows[selectedRow].Cells[2].Value.ToString();
                    branch = dataGridView1.Rows[selectedRow].Cells[3].Value.ToString();
                    doctor = dataGridView1.Rows[selectedRow].Cells[4].Value.ToString();
                    status = dataGridView1.Rows[selectedRow].Cells[5].Value.ToString();

                    if(status == "True")
                    {
                        bstatus = true;
                    }
                    else
                    {
                        bstatus = false;
                    }

                    tc = dataGridView1.Rows[selectedRow].Cells[6].Value.ToString();

                    fr.SetData(id, date, time, branch, doctor, tc , bstatus);
                }
                else
                {
                    MessageBox.Show("Appointment dont select!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


    }
}

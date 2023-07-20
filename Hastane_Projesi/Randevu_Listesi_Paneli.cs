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
    public partial class Randevu_Listesi_Paneli : Form
    {
        public string? id;
        public string? tarih;
        public string? saat;
        public string? brans;
        public string? doktor;
        public string? durum;
        public string? tc;
        public bool bdurum;

     
        public Randevu_Listesi_Paneli()
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
            Sekreter_Bilgi_Paneli? fr = Application.OpenForms["Sekreter_Bilgi_Paneli"] as Sekreter_Bilgi_Paneli;
            int selectedRow = dataGridView1.CurrentCell.RowIndex;
            id = dataGridView1.Rows[selectedRow].Cells[0].Value.ToString();

            if (fr == null)
            {
                MessageBox.Show("Kiritik Hata!");
            }
            else if(fr !=  null)
            {

                //Randevu Alma
                if (id != null)
                {
                    tarih = dataGridView1.Rows[selectedRow].Cells[1].Value.ToString();
                    saat = dataGridView1.Rows[selectedRow].Cells[2].Value.ToString();
                    brans = dataGridView1.Rows[selectedRow].Cells[3].Value.ToString();
                    doktor = dataGridView1.Rows[selectedRow].Cells[4].Value.ToString();
                    durum = dataGridView1.Rows[selectedRow].Cells[5].Value.ToString();

                    if(durum == "True")
                    {
                        bdurum = true;
                    }
                    else
                    {
                        bdurum = false;
                    }

                    tc = dataGridView1.Rows[selectedRow].Cells[6].Value.ToString();

                    fr.SetData(id, tarih, saat, brans, doktor, tc , bdurum);
                    //MessageBox.Show("Randevu Secildi");
                }
                else
                {
                    MessageBox.Show("Randevu Secilemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


    }
}

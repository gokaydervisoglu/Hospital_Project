using doktorne_Projesi;

namespace Hastane_Projesi
{
    public partial class Giris_Paneli : Form
    {
        private Hasta_Giris_Paneli hstgiris;
        private Sekreter_Giris_Paneli sekretergiris;
        private Doktor_Giris_Paneli doktorgirispaneli;
        public Giris_Paneli()
        {
            InitializeComponent();
            hstgiris = new Hasta_Giris_Paneli();
            sekretergiris = new Sekreter_Giris_Paneli();
            doktorgirispaneli = new Doktor_Giris_Paneli();
        }

        private void btn_hasta_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            if (hstgiris != null)
            {
                hstgiris.Focus();
            }
            if (sekretergiris != null)
            {
                sekretergiris.Close();
            }
            if (doktorgirispaneli != null)
            {
                doktorgirispaneli.Close();
            }
            if (hstgiris == null || hstgiris.IsDisposed)
            {
                hstgiris = new Hasta_Giris_Paneli();
            }

            hstgiris.Show();
        }

        private void btn_sekreter_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            if (sekretergiris != null)
            {
                sekretergiris.Focus();
            }
            if (hstgiris != null)
            {
                hstgiris.Close();
            }
            if (doktorgirispaneli != null)
            {
                doktorgirispaneli.Close();
            }
            if (sekretergiris == null || sekretergiris.IsDisposed)
            {
                sekretergiris = new Sekreter_Giris_Paneli();
            }
            sekretergiris.Show();
        }

        private void btn_doktor_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (doktorgirispaneli != null)
            {
                doktorgirispaneli.Focus();
            }
            if (sekretergiris != null)
            {
                sekretergiris.Close();
            }
            if (hstgiris != null)
            {
                hstgiris.Close();
            }
            if (doktorgirispaneli == null || doktorgirispaneli.IsDisposed)
            {
                doktorgirispaneli = new Doktor_Giris_Paneli();
            }
            doktorgirispaneli.Show();
        }

        public void FormKapa()
        {
            this.Close();
        }
    }
}
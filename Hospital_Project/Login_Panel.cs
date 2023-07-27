using Hospital_Project;

namespace Hospital_Project
{
    public partial class Login_Panel : Form
    {
        private Patient_Login_Panel hstgiris;
        private Secretary_Login_Panel sekretergiris;
        private Doctor_Login_Panel doktorgirispaneli;
        public Login_Panel()
        {
            InitializeComponent();
            hstgiris = new Patient_Login_Panel();
            sekretergiris = new Secretary_Login_Panel();
            doktorgirispaneli = new Doctor_Login_Panel();
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
                hstgiris = new Patient_Login_Panel();
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
                sekretergiris = new Secretary_Login_Panel();
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
                doktorgirispaneli = new Doctor_Login_Panel();
            }
            doktorgirispaneli.Show();
        }

        public void FormKapa()
        {
            this.Close();
        }
    }
}
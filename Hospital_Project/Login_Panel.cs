using Hospital_Project;

namespace Hospital_Project
{
    public partial class Login_Panel : Form
    {
        private Patient_Login_Panel ptnlogin;
        private Secretary_Login_Panel scrlogin;
        private Doctor_Login_Panel drlogin;
        public Login_Panel()
        {
            InitializeComponent();
            ptnlogin = new Patient_Login_Panel();
            scrlogin = new Secretary_Login_Panel();
            drlogin = new Doctor_Login_Panel();
        }

        private void btn_hasta_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            if (ptnlogin != null)
            {
                ptnlogin.Focus();
            }
            if (scrlogin != null)
            {
                scrlogin.Close();
            }
            if (drlogin != null)
            {
                drlogin.Close();
            }
            if (ptnlogin == null || ptnlogin.IsDisposed)
            {
                ptnlogin = new Patient_Login_Panel();
            }

            ptnlogin.Show();
        }

        private void btn_sekreter_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            if (scrlogin != null)
            {
                scrlogin.Focus();
            }
            if (ptnlogin != null)
            {
                ptnlogin.Close();
            }
            if (drlogin != null)
            {
                drlogin.Close();
            }
            if (scrlogin == null || scrlogin.IsDisposed)
            {
                scrlogin = new Secretary_Login_Panel();
            }
            scrlogin.Show();
        }

        private void btn_doktor_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (drlogin != null)
            {
                drlogin.Focus();
            }
            if (scrlogin != null)
            {
                scrlogin.Close();
            }
            if (ptnlogin != null)
            {
                ptnlogin.Close();
            }
            if (drlogin == null || drlogin.IsDisposed)
            {
                drlogin = new Doctor_Login_Panel();
            }
            drlogin.Show();
        }

        public void FormKapa()
        {
            this.Close();
        }

        private void Login_Panel_Load(object sender, EventArgs e)
        {

        }
    }
}
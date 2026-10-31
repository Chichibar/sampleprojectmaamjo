using System;
using System.Windows.Forms;

namespace sample
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            btnLogin.Click += (s, e) => Login();
            btnExit.Click += (s, e) => Application.Exit();
            AcceptButton = btnLogin;
            CancelButton = btnExit;
        }

        private void Login()
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (username.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Enter your username and password.");
                return;
            }

            bool ok;
            try
            {
                ok = Database.ValidateUser(username, password);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not connect to the database.\n" + ex.Message);
                return;
            }

            if (!ok)
            {
                MessageBox.Show("Wrong username or password.");
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }

            Hide();
            using (var main = new MainForm())
            {
                main.ShowDialog();
            }
            txtPassword.Clear();
            Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
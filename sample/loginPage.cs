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

namespace sample
{
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
        }

        private void loginPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("[" + txtUsername.Text + "] [" + txtPassword.Text + "]");
            string connStr = @"Server=(localdb)\MSSQLLocalDB;Database=lab_equipment_db;Trusted_Connection=True;";
            string sql = @"SELECT COUNT(*) FROM users
                   WHERE username = @u AND password_hash = CONVERT(NVARCHAR(255), HASHBYTES('SHA2_256', CONVERT(VARCHAR(100), @p)), 2)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@u", lblUsername.Text);
                    cmd.Parameters.AddWithValue("@p", lblPassword.Text);
                    conn.Open();

                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        this.Hide();
                        Form1 dashboard = new Form1();
                        dashboard.ShowDialog();
                        this.Show();
                        txtPassword.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not connect to the database.\n" + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Windows.Forms;

namespace sample
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Database.Initialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not set up the database:\n" + ex.Message);
                return;
            }

            Application.Run(new LoginForm());
        }
    }
}
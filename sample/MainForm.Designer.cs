using System;
using System.Windows.Forms;

namespace sample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            btnDashboard.Click += (s, e) => Navigate(btnDashboard, () => new DashboardControl());
            btnEquipment.Click += (s, e) => Navigate(btnEquipment, () => new EquipmentControl());
            btnCategories.Click += (s, e) => Navigate(btnCategories, () => new CategoriesControl());
            btnLogout.Click += (s, e) => Application.Exit();

            Navigate(btnDashboard, () => new DashboardControl());
        }

        private void Navigate(Button active, Func<UserControl> create)
        {
            Button[] navButtons = { btnDashboard, btnEquipment, btnCategories };
            foreach (var b in navButtons)
            {
                b.BackColor = Theme.Navy;
                b.ForeColor = System.Drawing.Color.White;
            }
            active.BackColor = System.Drawing.Color.White;
            active.ForeColor = Theme.Navy;

            content.Controls.Clear();
            UserControl view = create();
            view.Dock = DockStyle.Fill;
            content.Controls.Add(view);
        }
    }
}
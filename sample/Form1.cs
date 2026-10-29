using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int row = tablelist.RowCount;
            tablelist.RowCount++;

            tablelist.Controls.Add(new Label { Text = idbox.Text }, 0, row);
            tablelist.Controls.Add(new Label { Text = namebox.Text }, 1, row);
            tablelist.Controls.Add(new Label { Text = qntybox.Text }, 2, row);
            tablelist.Controls.Add(new Label { Text = conbox.GetItemText(conbox.SelectedItem) }, 3, row);
            tablelist.Controls.Add(new Label { Text = rembox.Text }, 4, row);
        }

        private void conbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tablelist_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace sample
{
    public static class Theme
    {
        public static readonly Color Navy = Color.FromArgb(31, 61, 110);
        public static readonly Color Blue = Color.FromArgb(44, 88, 152);
        public static readonly Color Red = Color.FromArgb(178, 35, 24);
        public static readonly Color Light = Color.FromArgb(240, 240, 240);
        public static readonly Color Grey = Color.FromArgb(225, 225, 225);
        public static readonly Color HeaderGrey = Color.FromArgb(232, 232, 232);
        public static readonly Color SelectBlue = Color.FromArgb(204, 228, 247);
        public static readonly Font BodyFont = new Font("Segoe UI", 9.5F);
        public static readonly Font TitleFont = new Font("Segoe UI", 18F);

        public static Label MakeLabel(string text, int x, int y)
        {
            return new Label
            {
                Text = text,
                AutoSize = true,
                Location = new Point(x, y),
                ForeColor = Color.FromArgb(60, 60, 60)
            };
        }

        public static Label MakeTitle(string text, int x, int y)
        {
            return new Label
            {
                Text = text,
                AutoSize = true,
                Font = TitleFont,
                ForeColor = Blue,
                Location = new Point(x, y)
            };
        }

        public static Button MakeButton(string text, int x, int y, Color back, Color fore, int width = 90)
        {
            var b = new Button
            {
                Text = text,
                Location = new Point(x, y),
                Size = new Size(width, 32),
                FlatStyle = FlatStyle.Flat,
                BackColor = back,
                ForeColor = fore,
                Cursor = Cursors.Hand
            };
            b.FlatAppearance.BorderColor = Color.Gray;
            return b;
        }

        public static DataGridView MakeGrid(string[] columns, int x, int y, int width, int height)
        {
            var g = new DataGridView
            {
                Location = new Point(x, y),
                Size = new Size(width, height),
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                RowHeadersVisible = false,
                MultiSelect = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };
            StyleGrid(g);
            foreach (string c in columns)
                g.Columns.Add(c, c);
            return g;
        }

        // Light grey headers and a soft blue selected row, matching the PDF
        public static void StyleGrid(DataGridView g)
        {
            g.EnableHeadersVisualStyles = false;
            g.ColumnHeadersDefaultCellStyle.BackColor = HeaderGrey;
            g.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40);
            g.ColumnHeadersDefaultCellStyle.SelectionBackColor = HeaderGrey;
            g.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(40, 40, 40);
            g.DefaultCellStyle.SelectionBackColor = SelectBlue;
            g.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        // Runs a database action and shows any error instead of crashing
        public static void Safely(Action action)
        {
            try { action(); }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
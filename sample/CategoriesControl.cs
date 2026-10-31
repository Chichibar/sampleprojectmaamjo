using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace sample
{
    public partial class CategoriesControl : UserControl
    {
        private List<Category> cats = new List<Category>();

        public CategoriesControl()
        {
            InitializeComponent();

            Theme.StyleGrid(grid);

            btnAdd.Click += (s, e) => AddCategory();
            btnUpdate.Click += (s, e) => UpdateCategory();
            btnDelete.Click += (s, e) => DeleteCategory();
            btnClear.Click += (s, e) => { nameBox.Clear(); grid.ClearSelection(); };
            grid.CellClick += (s, e) =>
            {
                if (e.RowIndex >= 0)
                    nameBox.Text = grid.Rows[e.RowIndex].Cells[1].Value.ToString();
            };

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            Theme.Safely(() =>
            {
                cats = Database.GetCategories();
                grid.Rows.Clear();
                foreach (var c in cats)
                    grid.Rows.Add(c.Id, c.Name);
                grid.ClearSelection();
            });
        }

        private int SelectedIndex()
        {
            return grid.SelectedRows.Count == 0 ? -1 : grid.SelectedRows[0].Index;
        }

        private void AddCategory()
        {
            string name = nameBox.Text.Trim();
            if (name.Length == 0) return;

            if (cats.Any(c => string.Equals(c.Name, name, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("That category already exists.");
                return;
            }

            Theme.Safely(() => Database.AddCategory(name));
            nameBox.Clear();
            RefreshGrid();
        }

        private void UpdateCategory()
        {
            int idx = SelectedIndex();
            string name = nameBox.Text.Trim();
            if (idx < 0 || name.Length == 0) return;

            int id = cats[idx].Id;
            Theme.Safely(() => Database.RenameCategory(id, name));
            RefreshGrid();
        }

        private void DeleteCategory()
        {
            int idx = SelectedIndex();
            if (idx < 0) return;

            int id = cats[idx].Id;
            if (Database.CategoryInUse(id))
            {
                MessageBox.Show("This category is used by equipment, so it can't be deleted.");
                return;
            }

            if (MessageBox.Show("Delete this category?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            Theme.Safely(() => Database.DeleteCategory(id));
            nameBox.Clear();
            RefreshGrid();
        }
    }
}
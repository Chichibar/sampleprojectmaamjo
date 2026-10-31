using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace sample
{
    public partial class EquipmentControl : UserControl
    {
        private List<EquipmentItem> shown = new List<EquipmentItem>();

        public EquipmentControl()
        {
            InitializeComponent();

            searchBox.TextChanged += (s, e) => RefreshGrid();
            btnAdd.Click += (s, e) => AddItem();
            btnEdit.Click += (s, e) => EditItem();
            btnDelete.Click += (s, e) => DeleteItem();

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            Theme.Safely(() =>
            {
                shown = Database.GetEquipment(searchBox.Text.Trim());
                grid.Rows.Clear();
                foreach (var item in shown)
                    grid.Rows.Add(item.PropertyNo, item.Name, item.Brand, item.Category,
                                  item.Location, item.Status, item.DateAcquired);
            });
        }

        private EquipmentItem GetSelectedItem()
        {
            if (grid.SelectedRows.Count == 0) return null;
            int i = grid.SelectedRows[0].Index;
            return i < shown.Count ? shown[i] : null;
        }

        private void AddItem()
        {
            using (var dlg = new AddEquipmentForm())
            {
                if (dlg.ShowDialog(FindForm()) == DialogResult.OK)
                    RefreshGrid();
            }
        }

        private void EditItem()
        {
            EquipmentItem item = GetSelectedItem();
            if (item == null)
            {
                MessageBox.Show("Select an item first.");
                return;
            }

            using (var dlg = new EditEquipmentForm(item))
            {
                if (dlg.ShowDialog(FindForm()) == DialogResult.OK)
                    RefreshGrid();
            }
        }

        private void DeleteItem()
        {
            EquipmentItem item = GetSelectedItem();
            if (item == null)
            {
                MessageBox.Show("Select an item first.");
                return;
            }

            using (var dlg = new ConfirmDeleteForm(item.PropertyNo + ", " + item.Name))
            {
                if (dlg.ShowDialog(FindForm()) != DialogResult.Yes) return;
            }

            Theme.Safely(() => Database.DeleteEquipment(item.PropertyNo));
            RefreshGrid();
        }
    }
}
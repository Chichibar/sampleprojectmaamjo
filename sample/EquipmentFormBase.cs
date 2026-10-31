using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace sample
{
    public abstract class EquipmentFormBase : Form
    {
        private readonly EquipmentItem editingItem;

        protected TextBox txtPropertyNo, txtName, txtBrand, txtModel, txtSerial,
                          txtDate, txtLocation, txtRemarks;
        protected ComboBox cmbCategory, cmbStatus;

        protected EquipmentFormBase(string title, EquipmentItem item)
        {
            editingItem = item;

            Text = title;
            ClientSize = new Size(620, 470);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            BackColor = Theme.Light;
            Font = Theme.BodyFont;

            txtPropertyNo = AddTextBox("Property No.", 0, 0, 270, true);
            txtName = AddTextBox("Name", 1, 0, 270, false);
            txtBrand = AddTextBox("Brand", 0, 1, 270, false);
            txtModel = AddTextBox("Model", 1, 1, 270, false);
            txtSerial = AddTextBox("Serial No.", 0, 2, 270, false);
            txtDate = AddTextBox("Date acquired (yyyy-mm-dd)", 1, 2, 270, false);
            cmbCategory = AddCombo("Category", 0, 3,
                Database.GetCategories().Select(c => c.Name).ToArray());
            cmbStatus = AddCombo("Status", 1, 3, Database.Statuses);
            txtLocation = AddTextBox("Location", 0, 4, 570, false);
            txtRemarks = AddTextBox("Remarks", 0, 5, 570, false);

            var btnSave = Theme.MakeButton("Save", 400, 410, Theme.Blue, Color.White);
            var btnCancel = Theme.MakeButton("Cancel", 500, 410, Theme.Grey, Color.Black);
            btnSave.Click += (s, e) => Save();
            btnCancel.DialogResult = DialogResult.Cancel;
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            AcceptButton = btnSave;
            CancelButton = btnCancel;

            if (item != null)
                FillFromItem(item);
            else
            {
                txtPropertyNo.Text = "(auto)";
                cmbStatus.SelectedIndex = 0;
            }
        }

        private Point LabelPos(int col, int row)
        {
            return new Point(col == 0 ? 20 : 320, 20 + row * 62);
        }

        protected TextBox AddTextBox(string label, int col, int row, int width, bool readOnly)
        {
            Point p = LabelPos(col, row);
            Controls.Add(Theme.MakeLabel(label, p.X, p.Y));

            var tb = new TextBox
            {
                Location = new Point(p.X, p.Y + 20),
                Width = width,
                ReadOnly = readOnly,
                BackColor = readOnly ? Theme.Grey : Color.White
            };
            Controls.Add(tb);
            return tb;
        }

        protected ComboBox AddCombo(string label, int col, int row, string[] items)
        {
            Point p = LabelPos(col, row);
            Controls.Add(Theme.MakeLabel(label, p.X, p.Y));

            var cb = new ComboBox
            {
                Location = new Point(p.X, p.Y + 20),
                Width = 270,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cb.Items.AddRange(items);
            Controls.Add(cb);
            return cb;
        }

        private void FillFromItem(EquipmentItem item)
        {
            txtPropertyNo.Text = item.PropertyNo;
            txtName.Text = item.Name;
            txtBrand.Text = item.Brand;
            txtModel.Text = item.Model;
            txtSerial.Text = item.SerialNo;
            txtDate.Text = item.DateAcquired;
            cmbCategory.SelectedItem = item.Category;
            cmbStatus.SelectedItem = item.Status;
            txtLocation.Text = item.Location;
            txtRemarks.Text = item.Remarks;
        }

        private void Save()
        {
            string name = txtName.Text.Trim();
            if (name.Length == 0)
            {
                Warn("Name is required.");
                return;
            }
            if (cmbCategory.SelectedItem == null)
            {
                Warn("Select a category.");
                return;
            }

            DateTime acquired;
            if (!DateTime.TryParseExact(txtDate.Text.Trim(), "yyyy-MM-dd",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out acquired))
            {
                Warn("Date must be in yyyy-mm-dd format.");
                return;
            }

            EquipmentItem item = editingItem ?? new EquipmentItem();
            item.Name = name;
            item.Brand = txtBrand.Text.Trim();
            item.Model = txtModel.Text.Trim();
            item.SerialNo = txtSerial.Text.Trim();
            item.DateAcquired = acquired.ToString("yyyy-MM-dd");
            item.Category = cmbCategory.SelectedItem.ToString();
            item.Status = cmbStatus.SelectedItem.ToString();
            item.Location = txtLocation.Text.Trim();
            item.Remarks = txtRemarks.Text.Trim();

            try
            {
                if (editingItem == null)
                {
                    item.PropertyNo = Database.NextPropertyNo();
                    Database.InsertEquipment(item);
                }
                else
                {
                    Database.UpdateEquipment(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void Warn(string message)
        {
            MessageBox.Show(message, "Check the form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
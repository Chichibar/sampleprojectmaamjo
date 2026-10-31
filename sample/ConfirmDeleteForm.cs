using System.Drawing;
using System.Windows.Forms;

namespace sample
{
    public class ConfirmDeleteForm : Form
    {
        public ConfirmDeleteForm(string details)
        {
            Text = "Confirm Delete";
            ClientSize = new Size(460, 200);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            BackColor = Theme.Light;
            Font = Theme.BodyFont;

            Controls.Add(new Label
            {
                Text = "Are you sure you want to delete this equipment?",
                AutoSize = true,
                Location = new Point(20, 25),
                Font = new Font("Segoe UI", 11F)
            });
            Controls.Add(Theme.MakeLabel(details, 20, 65));

            var btnYes = Theme.MakeButton("Yes, delete", 210, 130, Theme.Red, Color.White, 120);
            var btnNo = Theme.MakeButton("No", 340, 130, Theme.Grey, Color.Black);
            btnYes.DialogResult = DialogResult.Yes;
            btnNo.DialogResult = DialogResult.No;

            Controls.Add(btnYes);
            Controls.Add(btnNo);
            AcceptButton = btnYes;
            CancelButton = btnNo;
        }
    }
}
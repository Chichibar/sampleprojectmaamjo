namespace sample
{
    partial class DashboardControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlWorking = new System.Windows.Forms.Panel();
            this.lblWorkingTitle = new System.Windows.Forms.Label();
            this.lblWorking = new System.Windows.Forms.Label();
            this.pnlDefective = new System.Windows.Forms.Panel();
            this.lblDefectiveTitle = new System.Windows.Forms.Label();
            this.lblDefective = new System.Windows.Forms.Label();
            this.pnlRepair = new System.Windows.Forms.Panel();
            this.lblRepairTitle = new System.Windows.Forms.Label();
            this.lblRepair = new System.Windows.Forms.Label();
            this.pnlTotal.SuspendLayout();
            this.pnlWorking.SuspendLayout();
            this.pnlDefective.SuspendLayout();
            this.pnlRepair.SuspendLayout();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(44, 88, 152);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(170, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dashboard";
            //
            // lblSub
            //
            this.lblSub.AutoSize = true;
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblSub.Location = new System.Drawing.Point(0, 50);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(155, 17);
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "Equipment by status";
            //
            // pnlTotal
            //
            this.pnlTotal.BackColor = System.Drawing.Color.White;
            this.pnlTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotal.Controls.Add(this.lblTotalTitle);
            this.pnlTotal.Controls.Add(this.lblTotal);
            this.pnlTotal.Location = new System.Drawing.Point(0, 90);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(210, 130);
            this.pnlTotal.TabIndex = 2;
            //
            // lblTotalTitle
            //
            this.lblTotalTitle.AutoSize = true;
            this.lblTotalTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTotalTitle.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblTotalTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTotalTitle.Name = "lblTotalTitle";
            this.lblTotalTitle.Size = new System.Drawing.Size(114, 17);
            this.lblTotalTitle.TabIndex = 0;
            this.lblTotalTitle.Text = "Total equipment";
            //
            // lblTotal
            //
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(44, 88, 152);
            this.lblTotal.Location = new System.Drawing.Point(12, 70);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(24, 30);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "0";
            //
            // pnlWorking
            //
            this.pnlWorking.BackColor = System.Drawing.Color.White;
            this.pnlWorking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWorking.Controls.Add(this.lblWorkingTitle);
            this.pnlWorking.Controls.Add(this.lblWorking);
            this.pnlWorking.Location = new System.Drawing.Point(230, 90);
            this.pnlWorking.Name = "pnlWorking";
            this.pnlWorking.Size = new System.Drawing.Size(210, 130);
            this.pnlWorking.TabIndex = 3;
            //
            // lblWorkingTitle
            //
            this.lblWorkingTitle.AutoSize = true;
            this.lblWorkingTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblWorkingTitle.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblWorkingTitle.Location = new System.Drawing.Point(12, 12);
            this.lblWorkingTitle.Name = "lblWorkingTitle";
            this.lblWorkingTitle.Size = new System.Drawing.Size(55, 17);
            this.lblWorkingTitle.TabIndex = 0;
            this.lblWorkingTitle.Text = "Working";
            //
            // lblWorking
            //
            this.lblWorking.AutoSize = true;
            this.lblWorking.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblWorking.ForeColor = System.Drawing.Color.FromArgb(44, 88, 152);
            this.lblWorking.Location = new System.Drawing.Point(12, 70);
            this.lblWorking.Name = "lblWorking";
            this.lblWorking.Size = new System.Drawing.Size(24, 30);
            this.lblWorking.TabIndex = 1;
            this.lblWorking.Text = "0";
            //
            // pnlDefective
            //
            this.pnlDefective.BackColor = System.Drawing.Color.White;
            this.pnlDefective.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDefective.Controls.Add(this.lblDefectiveTitle);
            this.pnlDefective.Controls.Add(this.lblDefective);
            this.pnlDefective.Location = new System.Drawing.Point(460, 90);
            this.pnlDefective.Name = "pnlDefective";
            this.pnlDefective.Size = new System.Drawing.Size(210, 130);
            this.pnlDefective.TabIndex = 4;
            //
            // lblDefectiveTitle
            //
            this.lblDefectiveTitle.AutoSize = true;
            this.lblDefectiveTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDefectiveTitle.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblDefectiveTitle.Location = new System.Drawing.Point(12, 12);
            this.lblDefectiveTitle.Name = "lblDefectiveTitle";
            this.lblDefectiveTitle.Size = new System.Drawing.Size(65, 17);
            this.lblDefectiveTitle.TabIndex = 0;
            this.lblDefectiveTitle.Text = "Defective";
            //
            // lblDefective
            //
            this.lblDefective.AutoSize = true;
            this.lblDefective.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblDefective.ForeColor = System.Drawing.Color.FromArgb(44, 88, 152);
            this.lblDefective.Location = new System.Drawing.Point(12, 70);
            this.lblDefective.Name = "lblDefective";
            this.lblDefective.Size = new System.Drawing.Size(24, 30);
            this.lblDefective.TabIndex = 1;
            this.lblDefective.Text = "0";
            //
            // pnlRepair
            //
            this.pnlRepair.BackColor = System.Drawing.Color.White;
            this.pnlRepair.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRepair.Controls.Add(this.lblRepairTitle);
            this.pnlRepair.Controls.Add(this.lblRepair);
            this.pnlRepair.Location = new System.Drawing.Point(690, 90);
            this.pnlRepair.Name = "pnlRepair";
            this.pnlRepair.Size = new System.Drawing.Size(210, 130);
            this.pnlRepair.TabIndex = 5;
            //
            // lblRepairTitle
            //
            this.lblRepairTitle.AutoSize = true;
            this.lblRepairTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRepairTitle.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblRepairTitle.Location = new System.Drawing.Point(12, 12);
            this.lblRepairTitle.Name = "lblRepairTitle";
            this.lblRepairTitle.Size = new System.Drawing.Size(83, 17);
            this.lblRepairTitle.TabIndex = 0;
            this.lblRepairTitle.Text = "Under repair";
            //
            // lblRepair
            //
            this.lblRepair.AutoSize = true;
            this.lblRepair.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblRepair.ForeColor = System.Drawing.Color.FromArgb(44, 88, 152);
            this.lblRepair.Location = new System.Drawing.Point(12, 70);
            this.lblRepair.Name = "lblRepair";
            this.lblRepair.Size = new System.Drawing.Size(24, 30);
            this.lblRepair.TabIndex = 1;
            this.lblRepair.Text = "0";
            //
            // DashboardControl
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.Controls.Add(this.pnlRepair);
            this.Controls.Add(this.pnlDefective);
            this.Controls.Add(this.pnlWorking);
            this.Controls.Add(this.pnlTotal);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblTitle);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(930, 500);
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.pnlWorking.ResumeLayout(false);
            this.pnlWorking.PerformLayout();
            this.pnlDefective.ResumeLayout(false);
            this.pnlDefective.PerformLayout();
            this.pnlRepair.ResumeLayout(false);
            this.pnlRepair.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel pnlWorking;
        private System.Windows.Forms.Label lblWorkingTitle;
        private System.Windows.Forms.Label lblWorking;
        private System.Windows.Forms.Panel pnlDefective;
        private System.Windows.Forms.Label lblDefectiveTitle;
        private System.Windows.Forms.Label lblDefective;
        private System.Windows.Forms.Panel pnlRepair;
        private System.Windows.Forms.Label lblRepairTitle;
        private System.Windows.Forms.Label lblRepair;
    }
}
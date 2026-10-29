namespace sample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idbox = new System.Windows.Forms.TextBox();
            this.namebox = new System.Windows.Forms.TextBox();
            this.qntybox = new System.Windows.Forms.TextBox();
            this.rembox = new System.Windows.Forms.TextBox();
            this.tablelist = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdt = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.conbox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tablelist.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "condition";
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(84, 61);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(100, 22);
            this.idbox.TabIndex = 5;
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(98, 96);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(100, 22);
            this.namebox.TabIndex = 6;
            // 
            // qntybox
            // 
            this.qntybox.Location = new System.Drawing.Point(112, 135);
            this.qntybox.Name = "qntybox";
            this.qntybox.Size = new System.Drawing.Size(100, 22);
            this.qntybox.TabIndex = 7;
            this.qntybox.TextChanged += new System.EventHandler(this.qntybox_TextChanged);
            // 
            // rembox
            // 
            this.rembox.Location = new System.Drawing.Point(120, 205);
            this.rembox.Name = "rembox";
            this.rembox.Size = new System.Drawing.Size(100, 22);
            this.rembox.TabIndex = 8;
            // 
            // tablelist
            // 
            this.tablelist.AutoSize = true;
            this.tablelist.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablelist.ColumnCount = 5;
            this.tablelist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tablelist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 323F));
            this.tablelist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tablelist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tablelist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 394F));
            this.tablelist.Controls.Add(this.label7, 0, 0);
            this.tablelist.Controls.Add(this.label8, 1, 0);
            this.tablelist.Controls.Add(this.label10, 3, 0);
            this.tablelist.Controls.Add(this.label11, 4, 0);
            this.tablelist.Controls.Add(this.label9, 2, 0);
            this.tablelist.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablelist.Location = new System.Drawing.Point(0, 0);
            this.tablelist.Name = "tablelist";
            this.tablelist.RowCount = 2;
            this.tablelist.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablelist.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablelist.Size = new System.Drawing.Size(991, 16);
            this.tablelist.TabIndex = 9;
            this.tablelist.Paint += new System.Windows.Forms.PaintEventHandler(this.tablelist_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "name";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(457, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "condition";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(600, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "remarks";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "quantity";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(123, 249);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 10;
            this.btnadd.Text = "add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(273, 249);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 11;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnupdt
            // 
            this.btnupdt.Location = new System.Drawing.Point(420, 249);
            this.btnupdt.Name = "btnupdt";
            this.btnupdt.Size = new System.Drawing.Size(75, 23);
            this.btnupdt.TabIndex = 12;
            this.btnupdt.Text = "update";
            this.btnupdt.UseVisualStyleBackColor = true;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(553, 249);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 13;
            this.btnclear.Text = "edit item";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "remarks";
            // 
            // conbox
            // 
            this.conbox.FormattingEnabled = true;
            this.conbox.Items.AddRange(new object[] {
            "defective",
            "for repair",
            "good condition"});
            this.conbox.Location = new System.Drawing.Point(123, 170);
            this.conbox.Name = "conbox";
            this.conbox.Size = new System.Drawing.Size(161, 24);
            this.conbox.TabIndex = 15;
            this.conbox.SelectedIndexChanged += new System.EventHandler(this.conbox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tablelist);
            this.panel1.Location = new System.Drawing.Point(62, 299);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 297);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1188, 631);
            this.Controls.Add(this.conbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnupdt);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.rembox);
            this.Controls.Add(this.qntybox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "inventory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tablelist.ResumeLayout(false);
            this.tablelist.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox qntybox;
        private System.Windows.Forms.TextBox rembox;
        private System.Windows.Forms.TableLayoutPanel tablelist;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdt;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox conbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
    }
}


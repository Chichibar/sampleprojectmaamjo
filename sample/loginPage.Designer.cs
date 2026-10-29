namespace sample
{
    partial class loginPage
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
            this.lblUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F);
            this.label1.Location = new System.Drawing.Point(48, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Page";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(306, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(631, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Computer Laboratory Equipment System";
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(367, 312);
            this.lblUsername.Multiline = true;
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(587, 29);
            this.lblUsername.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(367, 390);
            this.lblPassword.Multiline = true;
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(587, 29);
            this.lblPassword.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(437, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(711, 505);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUsername.Location = new System.Drawing.Point(248, 312);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(99, 29);
            this.txtUsername.TabIndex = 8;
            this.txtUsername.Text = "Username:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPassword.Location = new System.Drawing.Point(248, 390);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(99, 29);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.Text = " Password:";
            // 
            // loginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 696);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "loginPage";
            this.Text = "loginPage";
            this.Load += new System.EventHandler(this.loginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblUsername;
        private System.Windows.Forms.TextBox lblPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
    }
}
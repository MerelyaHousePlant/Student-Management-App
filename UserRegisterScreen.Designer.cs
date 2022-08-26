namespace User_Admin_Interface_take2
{
    partial class UserRegisterScreen
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
            this.name = new System.Windows.Forms.RichTextBox();
            this.username = new System.Windows.Forms.RichTextBox();
            this.year = new System.Windows.Forms.RichTextBox();
            this.mail = new System.Windows.Forms.RichTextBox();
            this.phone = new System.Windows.Forms.RichTextBox();
            this.password = new System.Windows.Forms.RichTextBox();
            this.usernameHeadUp = new System.Windows.Forms.Label();
            this.Nameheadup = new System.Windows.Forms.Label();
            this.yearHeadUp = new System.Windows.Forms.Label();
            this.mailHeadUp = new System.Windows.Forms.Label();
            this.passwordHeadUp = new System.Windows.Forms.Label();
            this.phoneHeadUp = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(151, 92);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(198, 22);
            this.name.TabIndex = 0;
            this.name.Text = "";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(151, 140);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(198, 22);
            this.username.TabIndex = 1;
            this.username.Text = "";
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(151, 192);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(198, 22);
            this.year.TabIndex = 2;
            this.year.Text = "";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(151, 241);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(198, 22);
            this.mail.TabIndex = 3;
            this.mail.Text = "";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(151, 283);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(198, 22);
            this.phone.TabIndex = 4;
            this.phone.Text = "";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(151, 328);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(198, 22);
            this.password.TabIndex = 5;
            this.password.Text = "";
            // 
            // usernameHeadUp
            // 
            this.usernameHeadUp.AutoSize = true;
            this.usernameHeadUp.Location = new System.Drawing.Point(10, 140);
            this.usernameHeadUp.Name = "usernameHeadUp";
            this.usernameHeadUp.Size = new System.Drawing.Size(109, 13);
            this.usernameHeadUp.TabIndex = 6;
            this.usernameHeadUp.Text = "Choose an Username";
            // 
            // Nameheadup
            // 
            this.Nameheadup.AutoSize = true;
            this.Nameheadup.Location = new System.Drawing.Point(12, 92);
            this.Nameheadup.Name = "Nameheadup";
            this.Nameheadup.Size = new System.Drawing.Size(88, 13);
            this.Nameheadup.TabIndex = 6;
            this.Nameheadup.Text = "Enter Your Name";
            // 
            // yearHeadUp
            // 
            this.yearHeadUp.AutoSize = true;
            this.yearHeadUp.Location = new System.Drawing.Point(-3, 192);
            this.yearHeadUp.Name = "yearHeadUp";
            this.yearHeadUp.Size = new System.Drawing.Size(148, 13);
            this.yearHeadUp.TabIndex = 7;
            this.yearHeadUp.Text = "Enter your current school year";
            // 
            // mailHeadUp
            // 
            this.mailHeadUp.AutoSize = true;
            this.mailHeadUp.Location = new System.Drawing.Point(31, 241);
            this.mailHeadUp.Name = "mailHeadUp";
            this.mailHeadUp.Size = new System.Drawing.Size(83, 13);
            this.mailHeadUp.TabIndex = 8;
            this.mailHeadUp.Text = "Enter your Email";
            // 
            // passwordHeadUp
            // 
            this.passwordHeadUp.AutoSize = true;
            this.passwordHeadUp.Location = new System.Drawing.Point(19, 328);
            this.passwordHeadUp.Name = "passwordHeadUp";
            this.passwordHeadUp.Size = new System.Drawing.Size(100, 13);
            this.passwordHeadUp.TabIndex = 9;
            this.passwordHeadUp.Text = "Choose a password";
            // 
            // phoneHeadUp
            // 
            this.phoneHeadUp.AutoSize = true;
            this.phoneHeadUp.Location = new System.Drawing.Point(10, 283);
            this.phoneHeadUp.Name = "phoneHeadUp";
            this.phoneHeadUp.Size = new System.Drawing.Size(126, 13);
            this.phoneHeadUp.TabIndex = 9;
            this.phoneHeadUp.Text = "Enter your phone number";
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(201, 380);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(75, 23);
            this.Register.TabIndex = 10;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // UserRegisterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.phoneHeadUp);
            this.Controls.Add(this.passwordHeadUp);
            this.Controls.Add(this.mailHeadUp);
            this.Controls.Add(this.yearHeadUp);
            this.Controls.Add(this.Nameheadup);
            this.Controls.Add(this.usernameHeadUp);
            this.Controls.Add(this.password);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.year);
            this.Controls.Add(this.username);
            this.Controls.Add(this.name);
            this.Name = "UserRegisterScreen";
            this.Text = "UserRegisterScreencs";
            this.Load += new System.EventHandler(this.UserRegisterScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox name;
        private System.Windows.Forms.RichTextBox username;
        private System.Windows.Forms.RichTextBox year;
        private System.Windows.Forms.RichTextBox mail;
        private System.Windows.Forms.RichTextBox phone;
        private System.Windows.Forms.RichTextBox password;
        private System.Windows.Forms.Label usernameHeadUp;
        private System.Windows.Forms.Label Nameheadup;
        private System.Windows.Forms.Label yearHeadUp;
        private System.Windows.Forms.Label mailHeadUp;
        private System.Windows.Forms.Label passwordHeadUp;
        private System.Windows.Forms.Label phoneHeadUp;
        private System.Windows.Forms.Button Register;
    }
}
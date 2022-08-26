namespace User_Admin_Interface_take2
{
    partial class UserConnectScreen
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
            this.UsernameEntry = new System.Windows.Forms.RichTextBox();
            this.PasswordEntry = new System.Windows.Forms.RichTextBox();
            this.LogInUserButton = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.noaccountinfo = new System.Windows.Forms.Label();
            this.userlogintitle = new System.Windows.Forms.Label();
            this.RegisterRedirect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameEntry
            // 
            this.UsernameEntry.Location = new System.Drawing.Point(205, 85);
            this.UsernameEntry.Name = "UsernameEntry";
            this.UsernameEntry.Size = new System.Drawing.Size(205, 39);
            this.UsernameEntry.TabIndex = 0;
            this.UsernameEntry.Text = "";
            // 
            // PasswordEntry
            // 
            this.PasswordEntry.Location = new System.Drawing.Point(205, 186);
            this.PasswordEntry.Name = "PasswordEntry";
            this.PasswordEntry.Size = new System.Drawing.Size(205, 39);
            this.PasswordEntry.TabIndex = 1;
            this.PasswordEntry.Text = "";
            // 
            // LogInUserButton
            // 
            this.LogInUserButton.Location = new System.Drawing.Point(258, 273);
            this.LogInUserButton.Name = "LogInUserButton";
            this.LogInUserButton.Size = new System.Drawing.Size(86, 23);
            this.LogInUserButton.TabIndex = 2;
            this.LogInUserButton.Text = "Log In";
            this.LogInUserButton.UseVisualStyleBackColor = true;
            this.LogInUserButton.Click += new System.EventHandler(this.LogInUserButton_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(105, 88);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(55, 13);
            this.Username.TabIndex = 3;
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(105, 189);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 4;
            this.Password.Text = "Password";
            // 
            // noaccountinfo
            // 
            this.noaccountinfo.AutoSize = true;
            this.noaccountinfo.Location = new System.Drawing.Point(578, 145);
            this.noaccountinfo.Name = "noaccountinfo";
            this.noaccountinfo.Size = new System.Drawing.Size(142, 13);
            this.noaccountinfo.TabIndex = 5;
            this.noaccountinfo.Text = "You don\'t have an account?";
            // 
            // userlogintitle
            // 
            this.userlogintitle.AutoSize = true;
            this.userlogintitle.Location = new System.Drawing.Point(275, 30);
            this.userlogintitle.Name = "userlogintitle";
            this.userlogintitle.Size = new System.Drawing.Size(52, 13);
            this.userlogintitle.TabIndex = 6;
            this.userlogintitle.Text = "Welcome";
            // 
            // RegisterRedirect
            // 
            this.RegisterRedirect.Location = new System.Drawing.Point(593, 179);
            this.RegisterRedirect.Name = "RegisterRedirect";
            this.RegisterRedirect.Size = new System.Drawing.Size(111, 23);
            this.RegisterRedirect.TabIndex = 7;
            this.RegisterRedirect.Text = "Create one here!";
            this.RegisterRedirect.UseVisualStyleBackColor = true;
            this.RegisterRedirect.Click += new System.EventHandler(this.RegisterRedirect_Click);
            // 
            // UserConnectScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegisterRedirect);
            this.Controls.Add(this.userlogintitle);
            this.Controls.Add(this.noaccountinfo);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.LogInUserButton);
            this.Controls.Add(this.PasswordEntry);
            this.Controls.Add(this.UsernameEntry);
            this.Name = "UserConnectScreen";
            this.Text = "UserConnectScreen";
            this.Load += new System.EventHandler(this.UserConnectScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox UsernameEntry;
        private System.Windows.Forms.RichTextBox PasswordEntry;
        private System.Windows.Forms.Button LogInUserButton;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label noaccountinfo;
        private System.Windows.Forms.Label userlogintitle;
        private System.Windows.Forms.Button RegisterRedirect;
    }
}
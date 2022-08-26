namespace User_Admin_Interface_take2
{
    partial class Home
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
            this.UserDirectButton = new System.Windows.Forms.Button();
            this.AdminDirectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserDirectButton
            // 
            this.UserDirectButton.Location = new System.Drawing.Point(183, 174);
            this.UserDirectButton.Name = "UserDirectButton";
            this.UserDirectButton.Size = new System.Drawing.Size(95, 23);
            this.UserDirectButton.TabIndex = 0;
            this.UserDirectButton.Text = "Log in as User";
            this.UserDirectButton.UseVisualStyleBackColor = true;
            this.UserDirectButton.Click += new System.EventHandler(this.UserDirectButton_Click);
            // 
            // AdminDirectButton
            // 
            this.AdminDirectButton.Location = new System.Drawing.Point(479, 174);
            this.AdminDirectButton.Name = "AdminDirectButton";
            this.AdminDirectButton.Size = new System.Drawing.Size(97, 23);
            this.AdminDirectButton.TabIndex = 1;
            this.AdminDirectButton.Text = "Log in as Admin";
            this.AdminDirectButton.UseVisualStyleBackColor = true;
            this.AdminDirectButton.Click += new System.EventHandler(this.AdminDirectButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdminDirectButton);
            this.Controls.Add(this.UserDirectButton);
            this.Name = "Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UserDirectButton;
        private System.Windows.Forms.Button AdminDirectButton;
    }
}


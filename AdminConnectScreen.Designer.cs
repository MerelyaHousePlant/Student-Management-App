﻿namespace User_Admin_Interface_take2
{
    partial class AdminConnectScreen
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
            this.adminUserEntry = new System.Windows.Forms.RichTextBox();
            this.AdminPasswordEntry = new System.Windows.Forms.RichTextBox();
            this.AdminLogIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adminUserEntry
            // 
            this.adminUserEntry.Location = new System.Drawing.Point(244, 182);
            this.adminUserEntry.Name = "adminUserEntry";
            this.adminUserEntry.Size = new System.Drawing.Size(244, 35);
            this.adminUserEntry.TabIndex = 0;
            this.adminUserEntry.Text = "";
            // 
            // AdminPasswordEntry
            // 
            this.AdminPasswordEntry.Location = new System.Drawing.Point(241, 255);
            this.AdminPasswordEntry.Name = "AdminPasswordEntry";
            this.AdminPasswordEntry.Size = new System.Drawing.Size(247, 30);
            this.AdminPasswordEntry.TabIndex = 1;
            this.AdminPasswordEntry.Text = "";
            // 
            // AdminLogIn
            // 
            this.AdminLogIn.Location = new System.Drawing.Point(309, 316);
            this.AdminLogIn.Name = "AdminLogIn";
            this.AdminLogIn.Size = new System.Drawing.Size(97, 23);
            this.AdminLogIn.TabIndex = 2;
            this.AdminLogIn.Text = "Log In as admin";
            this.AdminLogIn.UseVisualStyleBackColor = true;
            this.AdminLogIn.Click += new System.EventHandler(this.AdminLogIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter your username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter your password";
            // 
            // AdminConnectScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminLogIn);
            this.Controls.Add(this.AdminPasswordEntry);
            this.Controls.Add(this.adminUserEntry);
            this.Name = "AdminConnectScreen";
            this.Text = "AdminConnectScreen";
            this.Load += new System.EventHandler(this.AdminConnectScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox adminUserEntry;
        private System.Windows.Forms.RichTextBox AdminPasswordEntry;
        private System.Windows.Forms.Button AdminLogIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
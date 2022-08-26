namespace User_Admin_Interface_take2
{
    partial class CourseCreation
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
            this.courseRegister = new System.Windows.Forms.Button();
            this.mailHeadUp = new System.Windows.Forms.Label();
            this.yearHeadUp = new System.Windows.Forms.Label();
            this.Nameheadup = new System.Windows.Forms.Label();
            this.usernameHeadUp = new System.Windows.Forms.Label();
            this.courseCredits = new System.Windows.Forms.RichTextBox();
            this.courseNumberofWeeks = new System.Windows.Forms.RichTextBox();
            this.courseWeeklyHours = new System.Windows.Forms.RichTextBox();
            this.courseName = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // courseRegister
            // 
            this.courseRegister.Location = new System.Drawing.Point(126, 274);
            this.courseRegister.Name = "courseRegister";
            this.courseRegister.Size = new System.Drawing.Size(123, 23);
            this.courseRegister.TabIndex = 36;
            this.courseRegister.Text = "Create Course";
            this.courseRegister.UseVisualStyleBackColor = true;
            this.courseRegister.Click += new System.EventHandler(this.courseRegister_Click);
            // 
            // mailHeadUp
            // 
            this.mailHeadUp.AutoSize = true;
            this.mailHeadUp.Location = new System.Drawing.Point(27, 218);
            this.mailHeadUp.Name = "mailHeadUp";
            this.mailHeadUp.Size = new System.Drawing.Size(119, 13);
            this.mailHeadUp.TabIndex = 33;
            this.mailHeadUp.Text = "Enter Number of Credits";
            // 
            // yearHeadUp
            // 
            this.yearHeadUp.AutoSize = true;
            this.yearHeadUp.Location = new System.Drawing.Point(24, 169);
            this.yearHeadUp.Name = "yearHeadUp";
            this.yearHeadUp.Size = new System.Drawing.Size(121, 13);
            this.yearHeadUp.TabIndex = 32;
            this.yearHeadUp.Text = "Enter Number of Weeks";
            // 
            // Nameheadup
            // 
            this.Nameheadup.AutoSize = true;
            this.Nameheadup.Location = new System.Drawing.Point(30, 72);
            this.Nameheadup.Name = "Nameheadup";
            this.Nameheadup.Size = new System.Drawing.Size(99, 13);
            this.Nameheadup.TabIndex = 30;
            this.Nameheadup.Text = "Enter Course Name";
            // 
            // usernameHeadUp
            // 
            this.usernameHeadUp.AutoSize = true;
            this.usernameHeadUp.Location = new System.Drawing.Point(27, 120);
            this.usernameHeadUp.Name = "usernameHeadUp";
            this.usernameHeadUp.Size = new System.Drawing.Size(102, 13);
            this.usernameHeadUp.TabIndex = 31;
            this.usernameHeadUp.Text = "Enter Weekly Hours";
            // 
            // courseCredits
            // 
            this.courseCredits.Location = new System.Drawing.Point(160, 218);
            this.courseCredits.Name = "courseCredits";
            this.courseCredits.Size = new System.Drawing.Size(198, 22);
            this.courseCredits.TabIndex = 27;
            this.courseCredits.Text = "";
            // 
            // courseNumberofWeeks
            // 
            this.courseNumberofWeeks.Location = new System.Drawing.Point(160, 169);
            this.courseNumberofWeeks.Name = "courseNumberofWeeks";
            this.courseNumberofWeeks.Size = new System.Drawing.Size(198, 22);
            this.courseNumberofWeeks.TabIndex = 26;
            this.courseNumberofWeeks.Text = "";
            // 
            // courseWeeklyHours
            // 
            this.courseWeeklyHours.Location = new System.Drawing.Point(160, 117);
            this.courseWeeklyHours.Name = "courseWeeklyHours";
            this.courseWeeklyHours.Size = new System.Drawing.Size(198, 22);
            this.courseWeeklyHours.TabIndex = 25;
            this.courseWeeklyHours.Text = "";
            // 
            // courseName
            // 
            this.courseName.Location = new System.Drawing.Point(160, 69);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(198, 22);
            this.courseName.TabIndex = 24;
            this.courseName.Text = "";
            // 
            // CourseCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.courseRegister);
            this.Controls.Add(this.mailHeadUp);
            this.Controls.Add(this.yearHeadUp);
            this.Controls.Add(this.Nameheadup);
            this.Controls.Add(this.usernameHeadUp);
            this.Controls.Add(this.courseCredits);
            this.Controls.Add(this.courseNumberofWeeks);
            this.Controls.Add(this.courseWeeklyHours);
            this.Controls.Add(this.courseName);
            this.Name = "CourseCreation";
            this.Text = "CourseCreation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button courseRegister;
        private System.Windows.Forms.Label mailHeadUp;
        private System.Windows.Forms.Label yearHeadUp;
        private System.Windows.Forms.Label Nameheadup;
        private System.Windows.Forms.Label usernameHeadUp;
        private System.Windows.Forms.RichTextBox courseCredits;
        private System.Windows.Forms.RichTextBox courseNumberofWeeks;
        private System.Windows.Forms.RichTextBox courseWeeklyHours;
        private System.Windows.Forms.RichTextBox courseName;
    }
}
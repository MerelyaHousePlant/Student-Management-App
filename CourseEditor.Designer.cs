namespace User_Admin_Interface_take2
{
    partial class CourseEditor
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
            this.courseEdit = new System.Windows.Forms.Button();
            this.mailHeadUp = new System.Windows.Forms.Label();
            this.yearHeadUp = new System.Windows.Forms.Label();
            this.Nameheadup = new System.Windows.Forms.Label();
            this.usernameHeadUp = new System.Windows.Forms.Label();
            this.courseCredits = new System.Windows.Forms.RichTextBox();
            this.courseNumberofWeeks = new System.Windows.Forms.RichTextBox();
            this.courseWeeklyHours = new System.Windows.Forms.RichTextBox();
            this.courseName = new System.Windows.Forms.RichTextBox();
            this.idHeadup = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.courseID = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // courseEdit
            // 
            this.courseEdit.Location = new System.Drawing.Point(121, 324);
            this.courseEdit.Name = "courseEdit";
            this.courseEdit.Size = new System.Drawing.Size(123, 23);
            this.courseEdit.TabIndex = 45;
            this.courseEdit.Text = "Edit Course";
            this.courseEdit.UseVisualStyleBackColor = true;
            this.courseEdit.Click += new System.EventHandler(this.courseEdit_Click);
            // 
            // mailHeadUp
            // 
            this.mailHeadUp.AutoSize = true;
            this.mailHeadUp.Location = new System.Drawing.Point(22, 268);
            this.mailHeadUp.Name = "mailHeadUp";
            this.mailHeadUp.Size = new System.Drawing.Size(112, 13);
            this.mailHeadUp.TabIndex = 44;
            this.mailHeadUp.Text = "Edit Number of Credits";
            // 
            // yearHeadUp
            // 
            this.yearHeadUp.AutoSize = true;
            this.yearHeadUp.Location = new System.Drawing.Point(19, 219);
            this.yearHeadUp.Name = "yearHeadUp";
            this.yearHeadUp.Size = new System.Drawing.Size(114, 13);
            this.yearHeadUp.TabIndex = 43;
            this.yearHeadUp.Text = "Edit Number of Weeks";
            // 
            // Nameheadup
            // 
            this.Nameheadup.AutoSize = true;
            this.Nameheadup.Location = new System.Drawing.Point(25, 122);
            this.Nameheadup.Name = "Nameheadup";
            this.Nameheadup.Size = new System.Drawing.Size(92, 13);
            this.Nameheadup.TabIndex = 41;
            this.Nameheadup.Text = "Edit Course Name";
            // 
            // usernameHeadUp
            // 
            this.usernameHeadUp.AutoSize = true;
            this.usernameHeadUp.Location = new System.Drawing.Point(22, 170);
            this.usernameHeadUp.Name = "usernameHeadUp";
            this.usernameHeadUp.Size = new System.Drawing.Size(95, 13);
            this.usernameHeadUp.TabIndex = 42;
            this.usernameHeadUp.Text = "Edit Weekly Hours";
            // 
            // courseCredits
            // 
            this.courseCredits.Location = new System.Drawing.Point(155, 268);
            this.courseCredits.Name = "courseCredits";
            this.courseCredits.Size = new System.Drawing.Size(198, 22);
            this.courseCredits.TabIndex = 40;
            this.courseCredits.Text = "";
            // 
            // courseNumberofWeeks
            // 
            this.courseNumberofWeeks.Location = new System.Drawing.Point(155, 219);
            this.courseNumberofWeeks.Name = "courseNumberofWeeks";
            this.courseNumberofWeeks.Size = new System.Drawing.Size(198, 22);
            this.courseNumberofWeeks.TabIndex = 39;
            this.courseNumberofWeeks.Text = "";
            // 
            // courseWeeklyHours
            // 
            this.courseWeeklyHours.Location = new System.Drawing.Point(155, 167);
            this.courseWeeklyHours.Name = "courseWeeklyHours";
            this.courseWeeklyHours.Size = new System.Drawing.Size(198, 22);
            this.courseWeeklyHours.TabIndex = 38;
            this.courseWeeklyHours.Text = "";
            // 
            // courseName
            // 
            this.courseName.Location = new System.Drawing.Point(155, 119);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(198, 22);
            this.courseName.TabIndex = 37;
            this.courseName.Text = "";
            // 
            // idHeadup
            // 
            this.idHeadup.AutoSize = true;
            this.idHeadup.Location = new System.Drawing.Point(25, 82);
            this.idHeadup.Name = "idHeadup";
            this.idHeadup.Size = new System.Drawing.Size(204, 13);
            this.idHeadup.TabIndex = 46;
            this.idHeadup.Text = "Enter the id of the course you want to edit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "label2";
            // 
            // courseID
            // 
            this.courseID.Location = new System.Drawing.Point(251, 79);
            this.courseID.Name = "courseID";
            this.courseID.Size = new System.Drawing.Size(33, 23);
            this.courseID.TabIndex = 48;
            this.courseID.Text = "";
            // 
            // CourseEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.courseID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idHeadup);
            this.Controls.Add(this.courseEdit);
            this.Controls.Add(this.mailHeadUp);
            this.Controls.Add(this.yearHeadUp);
            this.Controls.Add(this.Nameheadup);
            this.Controls.Add(this.usernameHeadUp);
            this.Controls.Add(this.courseCredits);
            this.Controls.Add(this.courseNumberofWeeks);
            this.Controls.Add(this.courseWeeklyHours);
            this.Controls.Add(this.courseName);
            this.Name = "CourseEditor";
            this.Text = "CourseEditor";
            this.Load += new System.EventHandler(this.CourseEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button courseEdit;
        private System.Windows.Forms.Label mailHeadUp;
        private System.Windows.Forms.Label yearHeadUp;
        private System.Windows.Forms.Label Nameheadup;
        private System.Windows.Forms.Label usernameHeadUp;
        private System.Windows.Forms.RichTextBox courseCredits;
        private System.Windows.Forms.RichTextBox courseNumberofWeeks;
        private System.Windows.Forms.RichTextBox courseWeeklyHours;
        private System.Windows.Forms.RichTextBox courseName;
        private System.Windows.Forms.Label idHeadup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox courseID;
    }
}
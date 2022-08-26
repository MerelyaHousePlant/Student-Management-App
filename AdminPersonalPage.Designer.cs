namespace User_Admin_Interface_take2
{
    partial class AdminPersonalPage
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
            this.UserEntries = new System.Windows.Forms.DataGridView();
            this.courseEntries = new System.Windows.Forms.DataGridView();
            this.AddStudent = new System.Windows.Forms.Button();
            this.EditStudent = new System.Windows.Forms.Button();
            this.DeleteStudent = new System.Windows.Forms.Button();
            this.AddCourse = new System.Windows.Forms.Button();
            this.EditCourse = new System.Windows.Forms.Button();
            this.DeleteCourse = new System.Windows.Forms.Button();
            this.deleteStudPrompt = new System.Windows.Forms.RichTextBox();
            this.deleteCoursePrompt = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UserEntries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseEntries)).BeginInit();
            this.SuspendLayout();
            // 
            // UserEntries
            // 
            this.UserEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserEntries.Location = new System.Drawing.Point(59, 41);
            this.UserEntries.Name = "UserEntries";
            this.UserEntries.Size = new System.Drawing.Size(240, 150);
            this.UserEntries.TabIndex = 0;
            // 
            // courseEntries
            // 
            this.courseEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseEntries.Location = new System.Drawing.Point(502, 41);
            this.courseEntries.Name = "courseEntries";
            this.courseEntries.Size = new System.Drawing.Size(240, 150);
            this.courseEntries.TabIndex = 1;
            // 
            // AddStudent
            // 
            this.AddStudent.Location = new System.Drawing.Point(76, 233);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(75, 23);
            this.AddStudent.TabIndex = 2;
            this.AddStudent.Text = "Add Student";
            this.AddStudent.UseVisualStyleBackColor = true;
            this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // EditStudent
            // 
            this.EditStudent.Location = new System.Drawing.Point(196, 233);
            this.EditStudent.Name = "EditStudent";
            this.EditStudent.Size = new System.Drawing.Size(75, 23);
            this.EditStudent.TabIndex = 3;
            this.EditStudent.Text = "Edit Student";
            this.EditStudent.UseVisualStyleBackColor = true;
            this.EditStudent.Click += new System.EventHandler(this.EditStudent_Click);
            // 
            // DeleteStudent
            // 
            this.DeleteStudent.Location = new System.Drawing.Point(119, 358);
            this.DeleteStudent.Name = "DeleteStudent";
            this.DeleteStudent.Size = new System.Drawing.Size(89, 23);
            this.DeleteStudent.TabIndex = 4;
            this.DeleteStudent.Text = "Delete Student";
            this.DeleteStudent.UseVisualStyleBackColor = true;
            this.DeleteStudent.Click += new System.EventHandler(this.DeleteStudent_Click);
            // 
            // AddCourse
            // 
            this.AddCourse.Location = new System.Drawing.Point(537, 233);
            this.AddCourse.Name = "AddCourse";
            this.AddCourse.Size = new System.Drawing.Size(75, 23);
            this.AddCourse.TabIndex = 5;
            this.AddCourse.Text = "Add Course";
            this.AddCourse.UseVisualStyleBackColor = true;
            this.AddCourse.Click += new System.EventHandler(this.AddCourse_Click);
            // 
            // EditCourse
            // 
            this.EditCourse.Location = new System.Drawing.Point(650, 233);
            this.EditCourse.Name = "EditCourse";
            this.EditCourse.Size = new System.Drawing.Size(75, 23);
            this.EditCourse.TabIndex = 6;
            this.EditCourse.Text = "Edit Course";
            this.EditCourse.UseVisualStyleBackColor = true;
            this.EditCourse.Click += new System.EventHandler(this.EditCourse_Click);
            // 
            // DeleteCourse
            // 
            this.DeleteCourse.Location = new System.Drawing.Point(586, 358);
            this.DeleteCourse.Name = "DeleteCourse";
            this.DeleteCourse.Size = new System.Drawing.Size(82, 23);
            this.DeleteCourse.TabIndex = 7;
            this.DeleteCourse.Text = "Delete Course";
            this.DeleteCourse.UseVisualStyleBackColor = true;
            this.DeleteCourse.Click += new System.EventHandler(this.DeleteCourse_Click);
            // 
            // deleteStudPrompt
            // 
            this.deleteStudPrompt.Location = new System.Drawing.Point(92, 298);
            this.deleteStudPrompt.Name = "deleteStudPrompt";
            this.deleteStudPrompt.Size = new System.Drawing.Size(158, 30);
            this.deleteStudPrompt.TabIndex = 8;
            this.deleteStudPrompt.Text = "";
            // 
            // deleteCoursePrompt
            // 
            this.deleteCoursePrompt.Location = new System.Drawing.Point(547, 298);
            this.deleteCoursePrompt.Name = "deleteCoursePrompt";
            this.deleteCoursePrompt.Size = new System.Drawing.Size(162, 30);
            this.deleteCoursePrompt.TabIndex = 9;
            this.deleteCoursePrompt.Text = "";
            // 
            // AdminPersonalPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteCoursePrompt);
            this.Controls.Add(this.deleteStudPrompt);
            this.Controls.Add(this.DeleteCourse);
            this.Controls.Add(this.EditCourse);
            this.Controls.Add(this.AddCourse);
            this.Controls.Add(this.DeleteStudent);
            this.Controls.Add(this.EditStudent);
            this.Controls.Add(this.AddStudent);
            this.Controls.Add(this.courseEntries);
            this.Controls.Add(this.UserEntries);
            this.Name = "AdminPersonalPage";
            this.Text = "AdminPersonalPage";
            this.Load += new System.EventHandler(this.AdminPersonalPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserEntries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseEntries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UserEntries;
        private System.Windows.Forms.DataGridView courseEntries;
        private System.Windows.Forms.Button AddStudent;
        private System.Windows.Forms.Button EditStudent;
        private System.Windows.Forms.Button DeleteStudent;
        private System.Windows.Forms.Button AddCourse;
        private System.Windows.Forms.Button EditCourse;
        private System.Windows.Forms.Button DeleteCourse;
        private System.Windows.Forms.RichTextBox deleteStudPrompt;
        private System.Windows.Forms.RichTextBox deleteCoursePrompt;
    }
}
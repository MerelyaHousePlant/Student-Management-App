namespace User_Admin_Interface_take2
{
    partial class StudentCoursesScreen
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
            this.coursesOnDisplay = new System.Windows.Forms.DataGridView();
            this.HeadCourse = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enterCourse = new System.Windows.Forms.RichTextBox();
            this.newCourseButton = new System.Windows.Forms.Button();
            this.personalCoursesView = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coursesOnDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // coursesOnDisplay
            // 
            this.coursesOnDisplay.CausesValidation = false;
            this.coursesOnDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursesOnDisplay.Location = new System.Drawing.Point(225, 70);
            this.coursesOnDisplay.Name = "coursesOnDisplay";
            this.coursesOnDisplay.Size = new System.Drawing.Size(428, 150);
            this.coursesOnDisplay.TabIndex = 0;
            // 
            // HeadCourse
            // 
            this.HeadCourse.AutoSize = true;
            this.HeadCourse.Location = new System.Drawing.Point(393, 31);
            this.HeadCourse.Name = "HeadCourse";
            this.HeadCourse.Size = new System.Drawing.Size(64, 13);
            this.HeadCourse.TabIndex = 1;
            this.HeadCourse.Text = "Courses List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Would you like to join a new course?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type out one from the list";
            // 
            // enterCourse
            // 
            this.enterCourse.Location = new System.Drawing.Point(51, 151);
            this.enterCourse.Name = "enterCourse";
            this.enterCourse.Size = new System.Drawing.Size(100, 29);
            this.enterCourse.TabIndex = 4;
            this.enterCourse.Text = "";
            // 
            // newCourseButton
            // 
            this.newCourseButton.Location = new System.Drawing.Point(61, 197);
            this.newCourseButton.Name = "newCourseButton";
            this.newCourseButton.Size = new System.Drawing.Size(75, 23);
            this.newCourseButton.TabIndex = 5;
            this.newCourseButton.Text = "Add Course";
            this.newCourseButton.UseVisualStyleBackColor = true;
            this.newCourseButton.Click += new System.EventHandler(this.newCourseButton_Click);
            // 
            // personalCoursesView
            // 
            this.personalCoursesView.FormattingEnabled = true;
            this.personalCoursesView.Location = new System.Drawing.Point(165, 326);
            this.personalCoursesView.Name = "personalCoursesView";
            this.personalCoursesView.Size = new System.Drawing.Size(445, 95);
            this.personalCoursesView.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Here is a list of your courses";
            // 
            // StudentCoursesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.personalCoursesView);
            this.Controls.Add(this.newCourseButton);
            this.Controls.Add(this.enterCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeadCourse);
            this.Controls.Add(this.coursesOnDisplay);
            this.Name = "StudentCoursesScreen";
            this.Text = "StudentCoursesScreen";
            this.Load += new System.EventHandler(this.StudentCoursesScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coursesOnDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView coursesOnDisplay;
        private System.Windows.Forms.Label HeadCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox enterCourse;
        private System.Windows.Forms.Button newCourseButton;
        private System.Windows.Forms.ListBox personalCoursesView;
        private System.Windows.Forms.Label label3;
    }
}
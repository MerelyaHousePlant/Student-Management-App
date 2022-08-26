namespace User_Admin_Interface_take2
{
    partial class UserPersonalPage
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
            this.UserDataDisplay = new System.Windows.Forms.ListBox();
            this.headWelcome = new System.Windows.Forms.Label();
            this.headInfo = new System.Windows.Forms.Label();
            this.seeCourses = new System.Windows.Forms.Button();
            this.editProfile = new System.Windows.Forms.Button();
            this.headHereCourse = new System.Windows.Forms.Label();
            this.userCourseDisplay = new System.Windows.Forms.RichTextBox();
            this.summonCourses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserDataDisplay
            // 
            this.UserDataDisplay.FormattingEnabled = true;
            this.UserDataDisplay.Location = new System.Drawing.Point(209, 97);
            this.UserDataDisplay.Name = "UserDataDisplay";
            this.UserDataDisplay.Size = new System.Drawing.Size(367, 82);
            this.UserDataDisplay.TabIndex = 0;
            // 
            // headWelcome
            // 
            this.headWelcome.AutoSize = true;
            this.headWelcome.Location = new System.Drawing.Point(349, 22);
            this.headWelcome.Name = "headWelcome";
            this.headWelcome.Size = new System.Drawing.Size(52, 13);
            this.headWelcome.TabIndex = 1;
            this.headWelcome.Text = "Welcome";
            // 
            // headInfo
            // 
            this.headInfo.AutoSize = true;
            this.headInfo.Location = new System.Drawing.Point(319, 68);
            this.headInfo.Name = "headInfo";
            this.headInfo.Size = new System.Drawing.Size(111, 13);
            this.headInfo.TabIndex = 2;
            this.headInfo.Text = "Here\'s your profile info";
            // 
            // seeCourses
            // 
            this.seeCourses.Location = new System.Drawing.Point(209, 223);
            this.seeCourses.Name = "seeCourses";
            this.seeCourses.Size = new System.Drawing.Size(108, 23);
            this.seeCourses.TabIndex = 3;
            this.seeCourses.Text = "See Courses List";
            this.seeCourses.UseVisualStyleBackColor = true;
            this.seeCourses.Click += new System.EventHandler(this.seeCourses_Click);
            // 
            // editProfile
            // 
            this.editProfile.Location = new System.Drawing.Point(439, 223);
            this.editProfile.Name = "editProfile";
            this.editProfile.Size = new System.Drawing.Size(137, 23);
            this.editProfile.TabIndex = 4;
            this.editProfile.Text = "Edit your profile";
            this.editProfile.UseVisualStyleBackColor = true;
            this.editProfile.Click += new System.EventHandler(this.editProfile_Click);
            // 
            // headHereCourse
            // 
            this.headHereCourse.AutoSize = true;
            this.headHereCourse.Location = new System.Drawing.Point(307, 258);
            this.headHereCourse.Name = "headHereCourse";
            this.headHereCourse.Size = new System.Drawing.Size(147, 13);
            this.headHereCourse.TabIndex = 5;
            this.headHereCourse.Text = "Here are your current courses";
            // 
            // userCourseDisplay
            // 
            this.userCourseDisplay.Location = new System.Drawing.Point(209, 288);
            this.userCourseDisplay.Name = "userCourseDisplay";
            this.userCourseDisplay.Size = new System.Drawing.Size(367, 77);
            this.userCourseDisplay.TabIndex = 6;
            this.userCourseDisplay.Text = "";
            // 
            // summonCourses
            // 
            this.summonCourses.Location = new System.Drawing.Point(355, 385);
            this.summonCourses.Name = "summonCourses";
            this.summonCourses.Size = new System.Drawing.Size(75, 23);
            this.summonCourses.TabIndex = 7;
            this.summonCourses.Text = "Show Courses";
            this.summonCourses.UseVisualStyleBackColor = true;
            this.summonCourses.Click += new System.EventHandler(this.summonCourses_Click);
            // 
            // UserPersonalPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.summonCourses);
            this.Controls.Add(this.userCourseDisplay);
            this.Controls.Add(this.headHereCourse);
            this.Controls.Add(this.editProfile);
            this.Controls.Add(this.seeCourses);
            this.Controls.Add(this.headInfo);
            this.Controls.Add(this.headWelcome);
            this.Controls.Add(this.UserDataDisplay);
            this.Name = "UserPersonalPage";
            this.Text = "UserPersonalPage";
            this.Load += new System.EventHandler(this.UserPersonalPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UserDataDisplay;
        private System.Windows.Forms.Label headWelcome;
        private System.Windows.Forms.Label headInfo;
        private System.Windows.Forms.Button seeCourses;
        private System.Windows.Forms.Button editProfile;
        private System.Windows.Forms.Label headHereCourse;
        private System.Windows.Forms.RichTextBox userCourseDisplay;
        private System.Windows.Forms.Button summonCourses;
    }
}
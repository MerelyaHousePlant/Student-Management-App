using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User_Admin_Interface_take2.Models.db;
using User_Admin_Interface_take2.Resources;

namespace User_Admin_Interface_take2
{
    public partial class StudentCoursesScreen : Form
    {
        public ProfileManager see;
        public StudentCoursesScreen()
        {
            InitializeComponent();
            see = new ProfileManager();
            see.GetCoursesList(coursesOnDisplay);
            see.ShowStudentCourses(Authenticate.userProfile.StudentId, ref personalCoursesView);
        }

        private void StudentCoursesScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void newCourseButton_Click(object sender, EventArgs e)
        {
            see.SelectRow(coursesOnDisplay,Int32.Parse(enterCourse.Text));
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User_Admin_Interface_take2.Resources;

namespace User_Admin_Interface_take2
{
    public partial class AdminPersonalPage : Form
    {
        public ProfileManager studrep;
        public ProfileManager courserep;

        public AdminPersonalPage()
        {
            InitializeComponent();
            studrep = new ProfileManager();
            studrep.GetUserList(UserEntries);
            courserep = new ProfileManager();
            courserep.GetCoursesList(courseEntries);
        }

        private void AdminPersonalPage_Load(object sender, EventArgs e)
        {

        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            new StudentCreation().Show();
        }

        private void AddCourse_Click(object sender, EventArgs e)
        {
            new CourseCreation().Show();
        }

        private void DeleteStudent_Click(object sender, EventArgs e)
        {
            studrep.DeleteStudent(Int32.Parse(deleteStudPrompt.Text));

        }

        private void DeleteCourse_Click(object sender, EventArgs e)
        {
            courserep.DeleteCourse(Int32.Parse(deleteCoursePrompt.Text));
            
        }

        private void EditStudent_Click(object sender, EventArgs e)
        {
            new StudentEditor().Show();
        }

        private void EditCourse_Click(object sender, EventArgs e)
        {
            new CourseEditor().Show();
        }
    }
}

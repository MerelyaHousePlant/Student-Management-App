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
    public partial class UserPersonalPage : Form
    {   
        public ProfileManager userDisplayer;
        public UserPersonalPage()
        {
            InitializeComponent();
            userDisplayer = new ProfileManager();
            userDisplayer.GetUserProfileData(UserDataDisplay);
        }

        private void UserPersonalPage_Load(object sender, EventArgs e)
        {

        }

        private void editProfile_Click(object sender, EventArgs e)
        {
            new EditPersonalPage().Show();
        }

        private void seeCourses_Click(object sender, EventArgs e)
        {
            new StudentCoursesScreen().Show();
        }

        private void summonCourses_Click(object sender, EventArgs e)
        {
            //userDisplayer.ShowStudentCourses(Authenticate.userProfile.StudentId, personalCoursesView);
        }
    }
}

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
    public partial class CourseEditor : Form
    {
        public ProfileManager courseEditor;
        public CourseEditor()
        {
            InitializeComponent();
            courseEditor = new ProfileManager();
        }

        private void courseEdit_Click(object sender, EventArgs e)
        {
            courseEditor.EditCourse(Int32.Parse(courseID.Text), courseName.Text, Int32.Parse(courseWeeklyHours.Text), Int32.Parse(courseNumberofWeeks.Text), Int32.Parse(courseCredits.Text));
        }

        private void CourseEditor_Load(object sender, EventArgs e)
        {

        }
    }
}

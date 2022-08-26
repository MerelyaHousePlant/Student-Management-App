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
    public partial class CourseCreation : Form
    {
        public Authenticate courseFetcher;
        public CourseCreation()
        {
            InitializeComponent();
            courseFetcher = new Authenticate();
        }

        private void courseRegister_Click(object sender, EventArgs e)
        {
            courseFetcher.RegisterNewClass(courseName.Text, Int32.Parse(courseWeeklyHours.Text), Int32.Parse(courseNumberofWeeks.Text), Int32.Parse(courseCredits.Text));
        }
    }
}

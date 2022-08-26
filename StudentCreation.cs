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
    public partial class StudentCreation : Form
    {
        public Authenticate student_fetcher;
        public StudentCreation()
        {
            InitializeComponent();
            student_fetcher = new Authenticate();
        }

        private void studRegister_Click(object sender, EventArgs e)
        {
            student_fetcher.RegisterNewUser(studName.Text, studUsername.Text, Int32.Parse(studYear.Text), studMail.Text, studPhone.Text, studPassword.Text);
            new AdminPersonalPage().Show();
        }

        private void StudentCreation_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class EditPersonalPage : Form
    {
        public ProfileManager profileEditor;
        public EditPersonalPage()
        {
            InitializeComponent();
            profileEditor = new ProfileManager();
        }

        private void EditPersonalPage_Load(object sender, EventArgs e)
        {

        }

        private void studEdit_Click(object sender, EventArgs e)
        {
            profileEditor.EditStudent(Authenticate.userProfile.StudentId, studName.Text, studUsername.Text, Int32.Parse(studYear.Text), studMail.Text, studPhone.Text, studPassword.Text);
            new UserPersonalPage().Show();
        }
    }
}

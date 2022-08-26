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
    public partial class StudentEditor : Form
    {
        public ProfileManager studEditor;
        public StudentEditor()
        {
            InitializeComponent();
            studEditor = new ProfileManager();
        }

        private void studEdit_Click(object sender, EventArgs e)
        {
            studEditor.EditStudent(Int32.Parse(studID.Text), studName.Text, studUsername.Text, Int32.Parse(studYear.Text), studMail.Text, studPhone.Text, studPassword.Text);
        }

        private void StudentEditor_Load(object sender, EventArgs e)
        {
            new AdminPersonalPage().Show();
        }
    }
}

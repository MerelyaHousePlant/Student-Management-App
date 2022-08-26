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
    public partial class AdminConnectScreen : Form
    {
        public Authenticate admin;
        public AdminConnectScreen()
        {
            InitializeComponent();
            admin = new Authenticate();
        }

        private void AdminLogIn_Click(object sender, EventArgs e)
        {
            admin.AdminAuthenticate(adminUserEntry.Text, AdminPasswordEntry.Text);

        }

        private void AdminConnectScreen_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class UserConnectScreen : Form
    {
        public Authenticate user;
        public UserConnectScreen()
        {
            InitializeComponent();
            user = new Authenticate();
        }

        private void LogInUserButton_Click(object sender, EventArgs e)
        {
            user.UserAuthenticate(UsernameEntry.Text, PasswordEntry.Text);
        }

        private void RegisterRedirect_Click(object sender, EventArgs e)
        {
            new UserRegisterScreen().Show();
        }

        private void UserConnectScreen_Load(object sender, EventArgs e)
        {

        }
    }
}

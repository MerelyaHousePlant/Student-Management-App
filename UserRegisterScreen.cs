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
    public partial class UserRegisterScreen : Form
    {
        public Authenticate fetcher;
        public UserRegisterScreen()
        {
            InitializeComponent();
            fetcher = new Authenticate();
        }

        private void UserRegisterScreen_Load(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            fetcher.RegisterNewUser(name.Text, username.Text, Int32.Parse(year.Text), mail.Text, phone.Text, password.Text);
        }
    }
}

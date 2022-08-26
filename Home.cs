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

namespace User_Admin_Interface_take2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void UserDirectButton_Click(object sender, EventArgs e)
        {
            new UserConnectScreen().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AdminDirectButton_Click(object sender, EventArgs e)
        {
            new AdminConnectScreen().Show();
        }
    }
}

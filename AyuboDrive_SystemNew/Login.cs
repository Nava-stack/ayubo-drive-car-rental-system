using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive_SystemNew
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void closeBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ForgotLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact with the IT department.....!", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string Username = UserBox.Text;
            string Password = PassBox.Text;
            if (Username =="adrive" && Password =="008")
            {
                MessageBox.Show("Login to System Successfully...!", "LOGIN SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Management obj = new Management();
                this.Hide();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Invalid User name or Password ", "LOGIN FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void minBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoginCloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class WelcomeAyuboDrive : Form
    {
        public WelcomeAyuboDrive()
        {
            InitializeComponent();
        }

        private void wel_timer_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 943)
            {
                wel_timer.Stop();
                Login obj = new Login();
                this.Hide();
                obj.Show();
            }
        }
    }
}

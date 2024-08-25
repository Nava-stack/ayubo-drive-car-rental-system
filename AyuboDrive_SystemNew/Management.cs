using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive_SystemNew
{
    public partial class Management : Form
    {
        //SubMenu
        private void CustomizeDesign()
        {
            ServicesPanel.Visible = false;
            PaymentsPanel.Visible = false;
        }
        //Hide Submenu
        private void HideSubmenu()
        {
            if (ServicesPanel.Visible==true)
            {
                ServicesPanel.Visible = false;
            }
            else if (PaymentsPanel.Visible==true)
            {
                PaymentsPanel.Visible = false;
            }
        }
        //Show Submenu
        private void ShowSubmenu(Panel Submenu)
        {
            if (Submenu.Visible==false)
            {
                HideSubmenu();
                Submenu.Visible = true;
            }
            else
            {
                Submenu.Visible = false;
            }
        }
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //Constructer
        public Management()
        {
            InitializeComponent();
            CustomizeDesign();
            random = new Random();
            closeChildFormBtn.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ColourClass.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ColourClass.ColorList.Count);
            }
            tempIndex = index;
            string color = ColourClass.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Calibri", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ColourClass.ChangeColorBrightness(color, -0.3);
                    ColourClass.PrimaryColor = color;
                    ColourClass.SecondaryColor = ColourClass.ChangeColorBrightness(color, -0.3);
                    closeChildFormBtn.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            titleLabel.Text = childForm.Text;

        }

        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Customer(), sender);
        }

        private void DriverBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Driver(), sender);
        }

        private void PaymentsBtn_Click(object sender, EventArgs e)
        {
            ShowSubmenu(PaymentsPanel);
        }

        private void VehicleBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Vehicle(), sender);
        }

        private void HirePayBtn_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            OpenChildForm(new Forms.HirePayment(), sender);
        }

        private void RentPayBtn_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            OpenChildForm(new Forms.RentPayment(), sender);
        }

        private void PaymentsBtn_Click_1(object sender, EventArgs e)
        {
            ShowSubmenu(PaymentsPanel);
        }

        private void HireBtn_Click_1(object sender, EventArgs e)
        {
            HideSubmenu();
            OpenChildForm(new Forms.Hire(), sender);
        }

        private void RentBtn_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            OpenChildForm(new Forms.Rent(), sender);
        }
        private void ServicesBtn_Click(object sender, EventArgs e)
        {
            ShowSubmenu(ServicesPanel);
        }

        private void closeChildFormBtn_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            titleLabel.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            closeChildFormBtn.Visible = false;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maxBtn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) 
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Management_Load(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void PackBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Packages(), sender);
        }

        private void VehiTypeBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.VehicleType(), sender);
        }
    }
}

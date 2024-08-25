using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AyuboDrive_SystemNew.AppClass;

namespace AyuboDrive_SystemNew.Forms
{
    public partial class Driver : Form
    {
        DriverClass driverClass = new DriverClass();
        public Driver()
        {
            InitializeComponent();
        }

        private void Dri_SaveBtn_Click(object sender, EventArgs e)
        {
            driverClass.insert();
        }

        private void Dri_UpdateBtn_Click(object sender, EventArgs e)
        {
            driverClass.update();
        }

        private void Dri_DeleteBtn_Click(object sender, EventArgs e)
        {
            driverClass.delete();
        }

        private void Dri_ClearTextBtn_Click(object sender, EventArgs e)
        {

        }

        private void Driver_Load(object sender, EventArgs e)
        {
            driverClass.GridDriver = DriverGrid;
            driverClass.view();
        }

        private void DriverGrid_CellClick(object sender, DataGridViewCellEventArgs dataGrid)
        {

            int RowIndex = dataGrid.RowIndex;

            Dri_IdBox.Text = DriverGrid.Rows[RowIndex].Cells[0].Value.ToString();
            Dri_nameBox.Text = DriverGrid.Rows[RowIndex].Cells[1].Value.ToString();
            Dri_NICbox.Text = DriverGrid.Rows[RowIndex].Cells[2].Value.ToString();
            Dri_AgeBox.Text = DriverGrid.Rows[RowIndex].Cells[3].Value.ToString();
            Dri_AdBox.Text = DriverGrid.Rows[RowIndex].Cells[4].Value.ToString();
            Dri_mailBox.Text = DriverGrid.Rows[RowIndex].Cells[5].Value.ToString();
            Dri_teleBox.Text = DriverGrid.Rows[RowIndex].Cells[6].Value.ToString();
            DriBloodCombo.Text = DriverGrid.Rows[RowIndex].Cells[7].Value.ToString();
            WorkExpbox.Text = DriverGrid.Rows[RowIndex].Cells[8].Value.ToString();
            Dri_Drive_LicNoBox.Text = DriverGrid.Rows[RowIndex].Cells[9].Value.ToString();
            Dri_Lic_Expiry.Text = DriverGrid.Rows[RowIndex].Cells[10].Value.ToString();
            BankAccNoBox.Text = DriverGrid.Rows[RowIndex].Cells[11].Value.ToString();
            JoinDate.Text = DriverGrid.Rows[RowIndex].Cells[12].Value.ToString();
            Dri_SalaryPerDay.Text = DriverGrid.Rows[RowIndex].Cells[13].Value.ToString();

        }

        private void Dri_IdBox_TextChanged(object sender, EventArgs e)
        {
            driverClass.DriverID = int.Parse(Dri_IdBox.Text);
        }

        private void Dri_nameBox_TextChanged(object sender, EventArgs e)
        {
            driverClass.DriName = Dri_nameBox.Text;
        }

        private void Dri_NICbox_TextChanged(object sender, EventArgs e)
        {
            driverClass.NICno = Dri_NICbox.Text;
        }

        private void Dri_AgeBox_TextChanged(object sender, EventArgs e)
        {
            driverClass.Age = int.Parse(Dri_AgeBox.Text);
        }

        private void Dri_AdBox_TextChanged(object sender, EventArgs e)
        {
            driverClass.Address = Dri_AdBox.Text;
        }

        private void Dri_mailBox_TextChanged(object sender, EventArgs e)
        {
            driverClass.Email = Dri_mailBox.Text;
        }

        private void Dri_teleBox_TextChanged(object sender, EventArgs e)
        {
            driverClass.TeleNo = int.Parse(Dri_teleBox.Text);
        }

        private void DriBloodCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            driverClass.Blood = DriBloodCombo.Text;
        }

        private void WorkExpbox_TextChanged(object sender, EventArgs e)
        {
            driverClass.WorkExper = int.Parse(WorkExpbox.Text);
        }

        private void Dri_Drive_LicNoBox_TextChanged(object sender, EventArgs e)
        {
            driverClass.DriveLicNo = Dri_Drive_LicNoBox.Text;
        }

        private void Dri_Lic_Expiry_ValueChanged(object sender, EventArgs e)
        {
            driverClass.DriveLicExpiry = Dri_Lic_Expiry.Text;
        }

        private void BankAccNoBox_TextChanged(object sender, EventArgs e)
        {
            driverClass.AccountNo = BankAccNoBox.Text;
        }

        private void JoinDate_ValueChanged(object sender, EventArgs e)
        {
            driverClass.JoinedDate = JoinDate.Text;
        }

        private void Dri_SalaryPerDay_TextChanged(object sender, EventArgs e)
        {
            driverClass.SalaryPerDay = float.Parse(Dri_SalaryPerDay.Text);
        }
    }
}

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
    public partial class Hire : Form
    {
        HireClass hireClass = new HireClass();
        public Hire()
        {
            InitializeComponent();
        }

        private void Hire_DeleteBtn_Click(object sender, EventArgs e)
        {
            hireClass.delete();
        }

        private void Hire_UpdateBtn_Click(object sender, EventArgs e)
        {
            hireClass.update();
        }

        private void Hire_SaveBtn_Click(object sender, EventArgs e)
        {
            hireClass.insert();
        }

        private void Hire_ClearTextBtn_Click(object sender, EventArgs e)
        {

        }

        private void Hire_Load(object sender, EventArgs e)
        {
            hireClass.GridHire = HireGrid;
            hireClass.view();
            HireClass.loadTableDataAsFK("SELECT * FROM Customer", CustomerCombo, "C_Name", "CustomerID");
            HireClass.loadTableDataAsFK("SELECT * FROM Package", PackCombo, "P_Name", "P_ID");
            HireClass.loadTableDataAsFK("SELECT * FROM Driver", DriverCombo, "D_Name", "DriverID");
            HireClass.loadTableDataAsFK("SELECT * FROM Vehicle",VehicleCombo, "V_Name", "V_ID");
        }

        private void HireGrid_CellClick(object sender, DataGridViewCellEventArgs dataGrid)
        {
            int RowIndex = dataGrid.RowIndex;

            Hire_IdBox.Text = HireGrid.Rows[RowIndex].Cells[0].Value.ToString();
            CustomerCombo.Text = HireGrid.Rows[RowIndex].Cells[1].Value.ToString();
            PackCombo.Text = HireGrid.Rows[RowIndex].Cells[2].Value.ToString();
            DriverCombo.Text = HireGrid.Rows[RowIndex].Cells[3].Value.ToString();
            VehicleCombo.Text = HireGrid.Rows[RowIndex].Cells[4].Value.ToString();
            Hire_Ord_DateTime.Text = HireGrid.Rows[RowIndex].Cells[5].Value.ToString();
            HireStartKM.Text = HireGrid.Rows[RowIndex].Cells[6].Value.ToString();
            HireEndKM.Text = HireGrid.Rows[RowIndex].Cells[7].Value.ToString();
            ChargePerExKM.Text = HireGrid.Rows[RowIndex].Cells[8].Value.ToString();
            hiredPicker.Text = HireGrid.Rows[RowIndex].Cells[9].Value.ToString();
            returnPicker.Text = HireGrid.Rows[RowIndex].Cells[10].Value.ToString();
            ChargePerWaitHour.Text = HireGrid.Rows[RowIndex].Cells[10].Value.ToString();
            ChargePerOverNight.Text = HireGrid.Rows[RowIndex].Cells[10].Value.ToString();
        }

        private void Hire_IdBox_TextChanged(object sender, EventArgs e)
        {
            hireClass.HireID = int.Parse(Hire_IdBox.Text);
        }

        private void CustomerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            hireClass.Customer = CustomerCombo.SelectedValue.ToString();
        }

        private void PackCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            hireClass.Package = PackCombo.SelectedValue.ToString();
        }

        private void DriverCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            hireClass.Driver = DriverCombo.SelectedValue.ToString();
        }

        private void VehicleCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            hireClass.Vehicle = VehicleCombo.SelectedValue.ToString();
        }

        private void Hire_Ord_DateTime_ValueChanged(object sender, EventArgs e)
        {
            hireClass.OrdDateTime = DateTime.Parse(Hire_Ord_DateTime.Text);
        }

        private void HireStartKM_TextChanged(object sender, EventArgs e)
        {
            hireClass.StartKm = int.Parse(HireStartKM.Text);
        }

        private void HireEndKM_TextChanged(object sender, EventArgs e)
        {
            hireClass.EndKm = int.Parse(HireEndKM.Text);
        }

        private void ChargePerExKM_TextChanged(object sender, EventArgs e)
        {
            hireClass.ChargePerExKm = float.Parse(ChargePerExKM.Text);
        }

        private void hiredPicker_ValueChanged(object sender, EventArgs e)
        {
            hireClass.StartDateTime = DateTime.Parse(hiredPicker.Text);
        }

        private void returnPicker_ValueChanged(object sender, EventArgs e)
        {
            hireClass.EndDateTime = DateTime.Parse(returnPicker.Text);
        }

        private void ChargePerWaitHour_TextChanged(object sender, EventArgs e)
        {
            hireClass.WaitChargeHour = float.Parse(ChargePerWaitHour.Text);
        }

        private void ChargePerOverNight_TextChanged(object sender, EventArgs e)
        {
            hireClass.ChargePerNight = float.Parse(ChargePerOverNight.Text);
        }
    }
}

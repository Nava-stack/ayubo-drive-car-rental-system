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
    public partial class Rent : Form
    {
        RentClass rentClass = new RentClass();
        public Rent()
        {
            InitializeComponent();
        }
        private void R_SaveBtn_Click(object sender, EventArgs e)
        {
            rentClass.insert();
        }
        private void R_ClearTextBtn_Click(object sender, EventArgs e)
        {

        }
        private void R_UpdateBtn_Click(object sender, EventArgs e)
        {
            rentClass.update();
        }

        private void R_DeleteBtn_Click(object sender, EventArgs e)
        {
            rentClass.delete();
        }

        private void RentGrid_CellClick(object sender, DataGridViewCellEventArgs dataGrid)
        {
            int RowIndex = dataGrid.RowIndex;

            Rent_IdBox.Text = RentGrid.Rows[RowIndex].Cells[0].Value.ToString();
            R_CusCombo.Text = RentGrid.Rows[RowIndex].Cells[1].Value.ToString();
            Rent_OrdDateTime.Text = RentGrid.Rows[RowIndex].Cells[2].Value.ToString();
            if (RentGrid.Rows[RowIndex].Cells[3].Value.ToString() == "Yes")
            {
                RentDriverSttsYes.Checked = true;
            }
            else
            {
                RentDriverSttsNo.Checked = true;
            }
            R_DriCombo.Text = RentGrid.Rows[RowIndex].Cells[4].Value.ToString();
            R_VehiCombo.Text = RentGrid.Rows[RowIndex].Cells[5].Value.ToString();
            RentDate.Text = RentGrid.Rows[RowIndex].Cells[6].Value.ToString();
            ReturnDate.Text = RentGrid.Rows[RowIndex].Cells[7].Value.ToString();

        }

        private void Rent_Load(object sender, EventArgs e)
        {
            rentClass.GridRent = RentGrid;
            rentClass.view();
            RentClass.loadTableDataAsFK("SELECT * FROM Customer", R_CusCombo, "C_Name", "CustomerID");
            RentClass.loadTableDataAsFK("SELECT * FROM Driver", R_DriCombo, "D_Name", "DriverID");
            RentClass.loadTableDataAsFK("SELECT * FROM Vehicle", R_VehiCombo, "V_Name", "V_ID");
        }

        private void Rent_IdBox_TextChanged(object sender, EventArgs e)
        {
            rentClass.RentID = int.Parse(Rent_IdBox.Text);
        }

        private void R_CusCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            rentClass.Customer = R_CusCombo.SelectedValue.ToString();
        }

        private void Rent_OrdDateTime_ValueChanged(object sender, EventArgs e)
        {
            rentClass.OrdDateTime =DateTime.Parse(Rent_OrdDateTime.Text);
        }

        private void RentDriverSttsYes_CheckedChanged(object sender, EventArgs e)
        {
            rentClass.DriverStts = RentDriverSttsYes.Text;
        }

        private void RentDriverSttsNo_CheckedChanged(object sender, EventArgs e)
        {
            rentClass.DriverStts = RentDriverSttsNo.Text;
        }

        private void R_DriCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            rentClass.Driver = R_DriCombo.SelectedValue.ToString();
        }

        private void R_VehiCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            rentClass.Vehicle = R_VehiCombo.SelectedValue.ToString();
        }

        private void RentDate_ValueChanged(object sender, EventArgs e)
        {
            rentClass.startDate = DateTime.Parse(RentDate.Text);
        }

        private void ReturnDate_ValueChanged(object sender, EventArgs e)
        {
            rentClass.endDate = DateTime.Parse(ReturnDate.Text);
        }
    }
}

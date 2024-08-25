using AyuboDrive_SystemNew.AppClass;
using System;
using System.Windows.Forms;

namespace AyuboDrive_SystemNew.Forms
{
    public partial class Customer : Form
    {
        CustomerClass customerClass = new CustomerClass();
        public Customer()
        {
            InitializeComponent();
        }

        private void Cus_ClearTextBtn_Click(object sender, EventArgs e)
        {

        }

        private void Cus_SaveBtn_Click(object sender, EventArgs e)
        {
            customerClass.insert();
        }

        private void Cus_UpdateBtn_Click(object sender, EventArgs e)
        {
            customerClass.update();
        }

        private void Cus_DeleteBtn_Click(object sender, EventArgs e)
        {
            customerClass.delete();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            customerClass.GridCustomer = CustomerGrid;
            customerClass.view();
        }

        private void CustomerGrid_CellClick(object sender, DataGridViewCellEventArgs dataGrid)
        {
            int RowIndex = dataGrid.RowIndex;

            Cus_IdBox.Text = CustomerGrid.Rows[RowIndex].Cells[0].Value.ToString();
            Cus_nameBox.Text = CustomerGrid.Rows[RowIndex].Cells[1].Value.ToString();
            Cus_NICbox.Text = CustomerGrid.Rows[RowIndex].Cells[2].Value.ToString();

            if (CustomerGrid.Rows[RowIndex].Cells[3].Value.ToString() == "Male")
            {
                Cus_MaleBtn.Checked = true;
                Cus_FemaleBtn.Checked = false;
            }

            Cus_AgeBox.Text = CustomerGrid.Rows[RowIndex].Cells[4].Value.ToString();
            Occu_Box.Text = CustomerGrid.Rows[RowIndex].Cells[5].Value.ToString();
            Cus_AdBox.Text = CustomerGrid.Rows[RowIndex].Cells[6].Value.ToString();
            Cus_mailBox.Text = CustomerGrid.Rows[RowIndex].Cells[7].Value.ToString();
            Cus_teleBox.Text = CustomerGrid.Rows[RowIndex].Cells[8].Value.ToString();
            CusBloodCombo.Text = CustomerGrid.Rows[RowIndex].Cells[9].Value.ToString();
            Cus_Drive_LicNoBox.Text = CustomerGrid.Rows[RowIndex].Cells[10].Value.ToString();
            Cus_Lic_Expiry.Text = CustomerGrid.Rows[RowIndex].Cells[11].Value.ToString();
        }

        private void Cus_IdBox_TextChanged(object sender, EventArgs e)
        {
            customerClass.CustomerID = int.Parse(Cus_IdBox.Text);
        }

        private void Cus_nameBox_TextChanged(object sender, EventArgs e)
        {
            customerClass.CusName = Cus_nameBox.Text;
        }

        private void Cus_NICbox_TextChanged(object sender, EventArgs e)
        {
            customerClass.NICno = Cus_NICbox.Text;
        }

        private void Cus_AgeBox_TextChanged(object sender, EventArgs e)
        {
            customerClass.Age = int.Parse(Cus_AgeBox.Text);
        }

        private void Occu_Box_TextChanged(object sender, EventArgs e)
        {
            customerClass.Occupation = Occu_Box.Text;
        }

        private void Cus_AdBox_TextChanged(object sender, EventArgs e)
        {
            customerClass.Address = Cus_AdBox.Text;
        }

        private void Cus_mailBox_TextChanged(object sender, EventArgs e)
        {
            customerClass.Email = Cus_mailBox.Text;
        }

        private void Cus_teleBox_TextChanged(object sender, EventArgs e)
        {
            customerClass.TeleNo = int.Parse(Cus_teleBox.Text);
        }

        private void CusBloodCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            customerClass.Blood = CusBloodCombo.Text;
        }

        private void Cus_Drive_LicNoBox_TextChanged(object sender, EventArgs e)
        {
            customerClass.DriveLicNo = Cus_Drive_LicNoBox.Text;
        }

        private void Cus_Lic_Expiry_ValueChanged(object sender, EventArgs e)
        {
            customerClass.DriveLicExpiry = Cus_Lic_Expiry.Text;
        }

        private void Cus_MaleBtn_CheckedChanged(object sender, EventArgs e)
        {
            customerClass.Gender = Cus_MaleBtn.Text;
        }

        private void Cus_FemaleBtn_CheckedChanged(object sender, EventArgs e)
        {
            customerClass.Gender = Cus_FemaleBtn.Text;
        }

        private void LicCheckNoBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (LicCheckNoBtn.Checked == true)
            {
                Cus_Drive_LicNoBox.Enabled = false;
                Cus_Lic_Expiry.Enabled = false;
            }
        }

    }
}

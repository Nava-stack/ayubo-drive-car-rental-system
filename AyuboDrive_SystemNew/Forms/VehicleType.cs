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
    public partial class VehicleType : Form
    {
        VehicleTypeClass vehicleTypeClass = new VehicleTypeClass();
        public VehicleType()
        {
            InitializeComponent();
        }

        private void VehiTy_IdBox_TextChanged(object sender, EventArgs e)
        {
            vehicleTypeClass.VehTypeID = int.Parse(VehiTy_IdBox.Text);
        }

        private void VehiType_TextChanged(object sender, EventArgs e)
        {
            vehicleTypeClass.VehName = VehiType.Text;
        }

        private void MaxSeats_TextChanged(object sender, EventArgs e)
        {
            vehicleTypeClass.SeatNo = int.Parse(MaxSeats.Text);
        }

        private void V_DailyPay_TextChanged(object sender, EventArgs e)
        {
            vehicleTypeClass.day = float.Parse(V_DailyPay.Text);
        }

        private void V_WeeklyPay_TextChanged(object sender, EventArgs e)
        {
            vehicleTypeClass.week = float.Parse(V_WeeklyPay.Text);
        }

        private void V_MonthlyPay_TextChanged(object sender, EventArgs e)
        {
            vehicleTypeClass.month = float.Parse(V_MonthlyPay.Text);
        }

        private void VType_ClearTextBtn_Click(object sender, EventArgs e)
        {

        }

        private void VType_SaveBtn_Click(object sender, EventArgs e)
        {
            vehicleTypeClass.insert();
        }

        private void VType_UpdateBtn_Click(object sender, EventArgs e)
        {
            vehicleTypeClass.update();
        }

        private void VType_DeleteBtn_Click(object sender, EventArgs e)
        {
            vehicleTypeClass.delete();
        }

        private void VehicleType_Load(object sender, EventArgs e)
        {
            vehicleTypeClass.GridVehicleType = VehiTypeGrid;
            vehicleTypeClass.view();
        }
    }
}

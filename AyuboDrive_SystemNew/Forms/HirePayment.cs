using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AyuboDrive_SystemNew.CommonClass;

namespace AyuboDrive_SystemNew.Forms
{
    public partial class HirePayment : Form
    {
        public HirePayment()
        {
            InitializeComponent();
        }

        private void HirePayment_Load(object sender, EventArgs e)
        {
            MainClass.loadTableDataAsFK("SELECT * FROM Payment_Method",HirePayMCombo, "Pay_Method", "PayM_ID");
        }

        private void hireIDsearchBtn_Click(object sender, EventArgs e)
        {
            string searchHire = hireIDsearchBox.Text;
            string sql = "SELECT * FROM Hire H JOIN Customer C ON C.CustomerID = H.CustomerID_FK JOIN Package P ON P.P_ID = H.P_ID_FK JOIN Driver D ON D.DriverID = H.DriverID_FK JOIN Vehicle V ON V.V_ID = H.V_ID_FK JOIN Vehicle_Type VT ON VT.V_TypeID = V.V_TypeID_FK WHERE HireID = '" + searchHire + "'";

            DataTable dt = MainClass.getDataFromDB(sql);

            if (dt.Rows.Count > 0)
            {
                //Vehicle
                vehiIDBox.Text = dt.Rows[0]["V_ID"].ToString();
                vehiNameBox.Text = dt.Rows[0]["V_Name"].ToString();
                vehiNoBox.Text = dt.Rows[0]["V_No"].ToString();
                VehiColourBox.Text = dt.Rows[0]["V_Color"].ToString();

                //Vehicle type
                vehiTypeBox.Text = dt.Rows[0]["V_Type"].ToString();
               
                //Driver
                DriIDBox.Text = dt.Rows[0]["DriverID"].ToString();
                DriNameBox.Text = dt.Rows[0]["D_Name"].ToString();
                DriConBox.Text = dt.Rows[0]["D_Phone"].ToString();
                DriSalPerDayBox.Text = dt.Rows[0]["DriverCost"].ToString();

                //Customer
                CusIdBox.Text = dt.Rows[0]["CustomerID"].ToString();
                CusNameBox.Text = dt.Rows[0]["C_Name"].ToString();
                CusConBox.Text = dt.Rows[0]["C_Phone"].ToString();
                CusAdBox.Text = dt.Rows[0]["C_Address"].ToString();

                //Package
                PackIdBox.Text = dt.Rows[0]["P_ID"].ToString();
                packBox.Text = dt.Rows[0]["P_Name"].ToString();
                MaxHourBox.Text = dt.Rows[0]["Max_Hours"].ToString();
                MaxKmBox.Text = dt.Rows[0]["Max_km_limit"].ToString();
                PackCostBox.Text = dt.Rows[0]["Pack_Cost"].ToString();

                //Hire Details

                startHireDateTimeBox.Text = dt.Rows[0]["H_StartDateAndTime"].ToString();
                ReturnHireDateTimeBox.Text = dt.Rows[0]["H_EndDateAndTime"].ToString();

                StartReadBox.Text = dt.Rows[0]["Start_km_read"].ToString();
                EndReadBox.Text = dt.Rows[0]["End_km_read"].ToString();

                ///////////////////Hire Calculations
                
                double ParkingCharge = Convert.ToDouble(dt.Rows[0]["Parking_Charge"].ToString());
                double OverNightCharPerDay = Convert.ToDouble(dt.Rows[0]["ChargePerNight"].ToString());
                double waitCharPerHour = Convert.ToDouble(dt.Rows[0]["ChargePerWait_hour"].ToString());
                double PackageCharge = Convert.ToDouble(PackCostBox.Text);
                double MaxKm = Convert.ToDouble(MaxHourBox.Text);
                double MaxHours = Convert.ToDouble(MaxHourBox.Text);
                double ChargePerExKm= Convert.ToDouble(dt.Rows[0]["ChargePerEx_km"].ToString());

                // Hire Distance 

                double StartKmRead = Convert.ToDouble(StartReadBox.Text);
                double EndKmRead = Convert.ToDouble(EndReadBox.Text);
                double TotalKm = EndKmRead - StartKmRead;
                double ExtraKm = TotalKm - MaxKm;
                ExtraKmBox.Text = Convert.ToString(ExtraKm);
                TotalKmBox.Text = Convert.ToString(TotalKm);
                

                //Hire Date

                DateTime StartDate = Convert.ToDateTime(startHireDateTimeBox.Text);
                DateTime ReturnDate = Convert.ToDateTime(ReturnHireDateTimeBox.Text);
                             
                double DaysCount = (ReturnDate - StartDate).TotalDays;
                double HoursCount = (ReturnDate - StartDate).TotalHours;
                double ExtraHours = (HoursCount - MaxHours);
                
                TotalDaysHireBox.Text = Convert.ToString(DaysCount);
                TotalHoursBox.Text = Convert.ToString(HoursCount);
                ExtraHoursBox.Text = Convert.ToString(ExtraHours);

                //Hire Costs
                double TotalWaitingCharge = waitCharPerHour * ExtraHours;
                double TotalOvernightStayCharge = OverNightCharPerDay * DaysCount;
                double ExtraKmCharge = ExtraKm * ChargePerExKm;

                double LongExCharges = ExtraKmCharge + TotalOvernightStayCharge + ParkingCharge;
                double DayExCharges = ExtraKmCharge + ParkingCharge + TotalWaitingCharge;

                double TotalLongHireCharge = LongExCharges + PackageCharge;
                double TotalDayHireCharge = DayExCharges + PackageCharge;

                double HireAdvance = PackageCharge / 2;


                waitChargeBox.Text = Convert.ToString(TotalWaitingCharge);
                OvNightChargeBox.Text = Convert.ToString(TotalOvernightStayCharge);
                ExtraKMchargeBox.Text = Convert.ToString(ExtraKmCharge);
                H_AdBox.Text = Convert.ToString(HireAdvance);

                if (DaysCount > 0)
                {
                    TotHireCharBox.Text = Convert.ToString(TotalLongHireCharge);
                    HireType.Text = "LONG TOUR";
                }
                else
                {
                    TotHireCharBox.Text = Convert.ToString(TotalDayHireCharge);
                    HireType.Text = "DAY TOUR";
                }
            }
            else
            {
                MessageBox.Show("Please make sure the Hire has been placed", "Invalid Hire ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdPayChooseBtn_Click(object sender, EventArgs e)
        {
            double HireAdvancePay = Convert.ToDouble(H_AdBox.Text);
            HireAmountBox.Text = Convert.ToString(HireAdvancePay);

        }

        private void ReturnPayChooseBtn_Click(object sender, EventArgs e)
        {
            double TotalHire = Convert.ToDouble(TotHireCharBox.Text);
            double H_Advance = Convert.ToDouble(H_AdBox.Text);
            double H_DamCost = Convert.ToDouble(hireDamCostBox.Text);

            double ReturnPay = TotalHire + H_DamCost - H_Advance;

            HireAmountBox.Text = Convert.ToString(ReturnPay);
        }
    }
}

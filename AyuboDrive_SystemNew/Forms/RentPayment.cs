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
    public partial class RentPayment : Form
    {
        public RentPayment()
        {
            InitializeComponent();
        }

        private void RentPayment_Load(object sender, EventArgs e)
        {
            MainClass.loadTableDataAsFK("SELECT * FROM Payment_Method", PayMCombo, "Pay_Method", "PayM_ID");
        }

        private void rentIDsearchBtn_Click(object sender, EventArgs e)
        {
            string searchRent = rentIDsearchBox.Text;
            string sql = "SELECT * FROM Rent R JOIN Vehicle V ON R.V_ID_FK = V.V_ID JOIN Vehicle_Type VT ON V.V_TypeID_FK = VT.V_TypeID JOIN Driver D ON D.DriverID = R.RentID JOIN Customer C ON C.CustomerID = R.CustomerID_FK WHERE RentID = '" + searchRent + "'";

            DataTable dt = MainClass.getDataFromDB(sql);

            if (dt.Rows.Count > 0)
            {
                //Vehicle
                VehiIDBox.Text = dt.Rows[0]["V_ID"].ToString();
                VehiNoBox.Text = dt.Rows[0]["V_No"].ToString();
                VehiColorBox.Text = dt.Rows[0]["V_Color"].ToString();
                VehiBrandBox.Text = dt.Rows[0]["V_Brand"].ToString();

                //Vehicle type
                VehiTyIDBox.Text = dt.Rows[0]["V_TypeID"].ToString();
                VehiTypeBox.Text = dt.Rows[0]["V_Type"].ToString();
                MonthPayBox.Text = dt.Rows[0]["Month_Pay"].ToString();
                WeekPayBox.Text = dt.Rows[0]["Week_Pay"].ToString();
                DayPayBox.Text = dt.Rows[0]["Day_Pay"].ToString();

                //Driver
                DriIDBox.Text = dt.Rows[0]["DriverID"].ToString();
                DriNameBox.Text = dt.Rows[0]["D_Name"].ToString();
                DriMobBox.Text = dt.Rows[0]["D_Phone"].ToString();
                DriSalaryPerDayBox.Text = dt.Rows[0]["DriverCost"].ToString();

                //Customer
                CusIDBox.Text = dt.Rows[0]["CustomerID"].ToString();
                CusNameBox.Text = dt.Rows[0]["C_Name"].ToString();
                CusMobBox.Text = dt.Rows[0]["C_Phone"].ToString();
                CusAdBox.Text = dt.Rows[0]["C_Address"].ToString();

                //Rent
                rentIDLabel.Text = dt.Rows[0]["RentID"].ToString();


                //Rent payment calculations
                double monthPay = Convert.ToDouble(dt.Rows[0]["Month_Pay"].ToString());
                double weekPay = Convert.ToDouble(dt.Rows[0]["Week_Pay"].ToString());
                double dayPay = Convert.ToDouble(dt.Rows[0]["Day_Pay"].ToString());

                double DriverPerDay = Convert.ToDouble(dt.Rows[0]["DriverCost"].ToString());

                DateTime RentDate = Convert.ToDateTime(dt.Rows[0]["Rent_Date"].ToString());
                DateTime ReturnDate = Convert.ToDateTime(dt.Rows[0]["Return_Date"].ToString());

                double DaysCount = (ReturnDate - RentDate).TotalDays;
                RentDaysLabel.Text = DaysCount.ToString();

                if (DaysCount > 0)
                {
                    RentDaysLabel.Text = Convert.ToString(DaysCount);

                    double DaysCountTemp = DaysCount;
                    double D = 0,
                           W = 0,
                           M = 0;

                    if (DaysCountTemp >= 30)
                    {
                        M = DaysCountTemp / 30;
                        DaysCountTemp -= M * 30;
                    }
                    else if (DaysCountTemp >= 7)
                    {
                        W = DaysCountTemp / 7;
                        DaysCountTemp -= W * 7;
                    }
                    else 
                    D = DaysCountTemp;



                    double VehicleTermCharge = M * monthPay + W * weekPay + D * dayPay;
                    double DriverCharge = DaysCount * DriverPerDay;
                    double TotalRentPayment = VehicleTermCharge + DriverCharge;
                    double AdvancePayment = VehicleTermCharge / 3 + DriverCharge / 5;

                    TotVehicleChargeBox.Text = VehicleTermCharge.ToString();
                    TotDriverChargeBox.Text = DriverCharge.ToString();
                    AdAmountBox.Text = AdvancePayment.ToString();
                    TotRentAmountBox.Text = (TotalRentPayment).ToString();
                    BalanceRentBox.Text = (TotalRentPayment - AdvancePayment).ToString();
                 
                }
                else
                {
                    MessageBox.Show("Please make sure the Rent has been placed", "Invalid Rent ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Check the Rent Date details ", "Days count Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdPayChooseBtn_Click(object sender, EventArgs e)
        {
            double Advance =Convert.ToDouble(AdAmountBox.Text);
            PayAmountBox.Text = Advance.ToString();
        }

        private void ReturnPayChooseBtn_Click(object sender, EventArgs e)
        {
            double Damage = Convert.ToDouble(DamCostBox.Text);
            double BalanceRent = Convert.ToDouble(BalanceRentBox.Text);

            double TotalReturnPay = Damage + BalanceRent;
            PayAmountBox.Text = TotalReturnPay.ToString();
        }
    }
}

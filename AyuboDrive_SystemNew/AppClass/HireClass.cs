using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AyuboDrive_SystemNew.CommonClass;
using System.Windows.Forms;

namespace AyuboDrive_SystemNew.AppClass
{
    class HireClass: MainClass
    {
        public int HireID { get; set; }
        public string Customer { get; set; }
        public string Package { get; set; }
        public string Driver { get; set; }
        public string Vehicle { get; set; }
        public DateTime OrdDateTime { get; set; }
        public float StartKm { get; set; }
        public float EndKm { get; set; }
        public float ChargePerExKm { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public float WaitChargeHour { get; set; }
        public float  ChargePerNight{ get; set; }    

        public DataGridView GridHire { get; set; }


        public void view()
        {
            string HireDataSQL = "SELECT * FROM Hire";
            LoadDataInGridView(HireDataSQL, GridHire);
        }

        public void insert()
        {
            string insert = "INSERT INTO Hire VALUES ('" + Customer + "', '" + Driver + "', '" + Vehicle + "', '" + OrdDateTime + "', '" + StartKm + "', '" + EndKm + "', '" + ChargePerExKm + "', '" + StartDateTime + "', '" + EndDateTime + "', '" + WaitChargeHour + "', '" + ChargePerNight + "')";
            if (executeQuery(insert, FunctionType.insert))
            {
                view();
            }

        }

        public void update()
        {
            string update = "UPDATE Hire SET CustomerID_FK = '" + Customer + "' ,P_ID_FK = '" + Package + "',DriverID_FK = '" + Driver + "',V_ID_FK = '" + Vehicle + "',H_OrderDateAndTime = '" + OrdDateTime + "',Start_km_read = '" + StartKm + "',End_km_read = '" + EndKm + "',ChargePerEx_km = '" + ChargePerExKm + "',H_StartDateAndTime = '" + StartDateTime + "',H_EndDateAndTime = '" + EndDateTime + "',ChargePerWait_hour = '" + WaitChargeHour + "',ChargePerNight = '" + ChargePerNight + "' WHERE  HireID = '" + HireID + "'";
            if (executeQuery(update, FunctionType.update))
            {
                view();
            }
        }

        public void delete()
        {
            string Delete = "DELETE FROM Driver WHERE HireID = '" + HireID + "'";
            if (executeQuery(Delete, FunctionType.delete))
            {
                view();
            }

        }
    }
}

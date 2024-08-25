using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AyuboDrive_SystemNew.CommonClass;

namespace AyuboDrive_SystemNew.AppClass
{
    class RentClass : MainClass
    {
        public int RentID { get; set; }
        public string Customer { get; set; }
        public DateTime OrdDateTime { get; set; }
        public string Driver { get; set; }
        public string Vehicle { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string DriverStts { get; set; }


        public DataGridView GridRent { get; set; }

        public void view()
        {
            string RentDataSQL = "SELECT * FROM Rent";
            LoadDataInGridView(RentDataSQL, GridRent);
        }

        public void insert()
        {
            string insert = "INSERT INTO Rent VALUES ('" + Customer + "', '" + OrdDateTime + "','" + DriverStts + "', '" + Driver + "', '" + Vehicle + "', '" + startDate + "', '" + endDate + "')";
            if (executeQuery(insert, FunctionType.insert))
            {
                view();
            }

        }

        public void update()
        {
            string update = "UPDATE Rent SET CustomerID_FK = '" + Customer + "' ,R_OrderDateAndTime = '" + OrdDateTime + "',Driver_stts = '" + DriverStts + "',DriverID_FK = '" + Driver + "',Rent_Date = '" + startDate + "',Return_Date = '" + endDate + "' WHERE  RentID = '" + RentID + "'";

            if (executeQuery(update, FunctionType.update))
            {
                view();
            }
        }

        public void delete()
        {
            string Delete = "DELETE FROM Rent WHERE RentID = '" + RentID + "'";
            if (executeQuery(Delete, FunctionType.delete))
            {
                view();
            }

        }



    }
}

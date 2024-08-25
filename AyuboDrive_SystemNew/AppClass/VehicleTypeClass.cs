using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AyuboDrive_SystemNew.CommonClass;

namespace AyuboDrive_SystemNew.AppClass
{
    class VehicleTypeClass:MainClass
    {
        public int VehTypeID { get; set; }
        public string VehName { get; set; }
        public int SeatNo { get; set; }
        public float day { get; set; }
        public float week { get; set; }
        public float month { get; set; }
        public DataGridView GridVehicleType { get; set; }

        public void view()
        {
            string AllDataSql = "SELECT * FROM Vehicle_Type";
            LoadDataInGridView(AllDataSql, GridVehicleType);
        }

        public void insert()
        {
            string insert = "INSERT INTO Vehicle_type VALUES ('" + VehName + "', '"+SeatNo+"','" + day + "', '" + week + "', '" + month + "')";
            if (executeQuery(insert, FunctionType.insert))
            {
                view();
            }

        }

        public void update()
        {
            string update = "UPDATE Vehicle_Type SET Vehicle_Type_Name = '" + VehName + "' ,Max_SeatNo='"+SeatNo+"',Day_Amount = '" + day + "', Week_Amount = '" + week + "', Month_Amount = '" + month + "' WHERE  Vehicle_Type_ID = '" + VehTypeID + "'";
            if (executeQuery(update, FunctionType.update))
            {
                view();
            }
        }

        public void delete()
        {
            string Delete = "DELETE FROM Vehicle_Type WHERE Vehicle_Type_ID = '" + VehTypeID + "'";
            if (executeQuery(Delete, FunctionType.delete))
            {
                view();
            }

        }


       

    }
}

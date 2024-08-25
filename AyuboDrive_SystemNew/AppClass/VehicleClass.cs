using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AyuboDrive_SystemNew.CommonClass;
using System.Windows.Forms;
using AyuboDrive_SystemNew.Forms;

namespace AyuboDrive_SystemNew.AppClass
{
    class VehicleClass:MainClass
    {
        public int VehicleID { get; set; }
        public string VehiName { get; set; }
        public string VehiType { get; set; }
        public string VehiNo { get; set; }
        public string VehiBrand  { get; set; }
        public string Color { get; set; }
        public string InsNo { get; set; }
        public string InsExpiry { get; set; }
        public string VehiLicNo { get; set; }
        public string VehiLicExpiry { get; set; }
        public DataGridView GridVehicle { get; set; }


        public void view()
        {
            string VehiDataSQL = "SELECT * FROM Vehicle";
            LoadDataInGridView(VehiDataSQL, GridVehicle);
        }

        public void insert()
        {
            string insert = "INSERT INTO Vehicle VALUES ('" + VehiName + "', '" + VehiType + "', '" + VehiNo + "', '" + VehiBrand + "', '" + Color + "', '" + InsNo + "', '" + InsExpiry + "', '" + VehiLicNo + "', '" + VehiLicExpiry + "')";
            if (executeQuery(insert, FunctionType.insert))
            {
                view();
            }

        }

        public void update()
        {
            string update = "UPDATE Vehicle SET V_Name = '" + VehiName + "' ,V_TypeID_FK = '" + VehiType + "',V_No = '" + VehiNo + "',V_Brand = '" + VehiBrand + "',V_Color = '" + Color + "',InsuranceNo = '" + InsNo + "',Ins_Expiry = '" + InsExpiry + "',V_Lic_No = '" + VehiLicNo + "',V_Lic_Expiry = '" + VehiLicExpiry + "' WHERE  V_ID = '" + VehicleID + "'";
            if (executeQuery(update, FunctionType.update))
            {
                view();
            }
        }

        public void delete()
        {
            string Delete = "DELETE FROM Vehicle WHERE V_ID = '" + VehicleID + "'";
            if (executeQuery(Delete, FunctionType.delete))
            {
                view();
            }
        }
    }
}

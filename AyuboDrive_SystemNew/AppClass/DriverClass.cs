using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AyuboDrive_SystemNew.CommonClass;

namespace AyuboDrive_SystemNew.AppClass
{
    class DriverClass: MainClass
    {
        public int DriverID { get; set; }
        public string DriName { get; set; }
        public string NICno { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int TeleNo { get; set; }
        public string Blood { get; set; }
        public int WorkExper { get; set; }
        public string DriveLicNo { get; set; }
        public string DriveLicExpiry { get; set; }
        public string AccountNo { get; set; }
        public string JoinedDate { get; set; }
        public float SalaryPerDay { get; set; }

        public DataGridView GridDriver { get; set; }


        public void view()
        {
            string DriDataSQL = "SELECT * FROM Driver";
            LoadDataInGridView(DriDataSQL, GridDriver);
        }

        public void insert()
        {
            string insert = "INSERT INTO Driver VALUES ('" + DriName + "', '" + NICno + "', '" + Age + "', '" + Address + "', '" + Email + "', '" + TeleNo + "', '" + Blood + "', '" + WorkExper + "', '" + DriveLicNo + "', '" + DriveLicExpiry + "', '" + AccountNo + "','" + JoinedDate + "','" + SalaryPerDay + "')";
            if (executeQuery(insert, FunctionType.insert))
            {
                view();
            }

        }

        public void update()
        {
            string update = "UPDATE Driver SET D_Name = '" + DriName + "' ,D_ICno = '" + NICno + "',D_Age = '" + Age + "',D_Address = '" + Address + "',D_Mail = '" + Email + "',D_Phone = '" + TeleNo + "',D_Blood = '" + Blood + "',Work_Exp = '" + WorkExper + "',D_Lic_No = '" + DriveLicNo + "',D_Lic_Expiry = '" + DriveLicExpiry + "',Bank_AccNo = '" + AccountNo + "',Join_Date = '" + JoinedDate + "',DriverCost = '" + SalaryPerDay + "' WHERE  DriverID = '" + DriverID + "'";
            if (executeQuery(update, FunctionType.update))
            {
                view();
            }
        }

        public void delete()
        {
            string Delete = "DELETE FROM Driver WHERE DriverID = '" + DriverID + "'";
            if (executeQuery(Delete, FunctionType.delete))
            {
                view();
            }

        }
    }
}

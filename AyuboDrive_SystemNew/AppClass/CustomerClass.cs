using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AyuboDrive_SystemNew.CommonClass;

namespace AyuboDrive_SystemNew.AppClass
{
    class CustomerClass: MainClass
    {
        public int CustomerID { get; set; }
        public string CusName { get; set; }
        public string NICno { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Occupation { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int TeleNo { get; set; }
        public string Blood { get; set; }
        public string DriveLicNo { get; set; }
        public string DriveLicExpiry { get; set; }

        public DataGridView GridCustomer { get; set; }

        
        public void view()
        {
            string CusDataSQL = "SELECT * FROM Customer";
            LoadDataInGridView(CusDataSQL, GridCustomer);
        }

        public void insert()
        {
            string insert = "INSERT INTO Customer VALUES ('" + CusName + "', '" + NICno + "', '" + Gender + "', '" + Age + "', '" + Occupation + "', '" + Address + "', '" + Email + "', '" + TeleNo + "', '" + Blood + "', '" + DriveLicNo + "', '" + DriveLicExpiry + "')";
            if (executeQuery(insert, FunctionType.insert))
            {
                view();
            }

        }

        public void update()
        {
            string update = "UPDATE Customer SET C_Name = '" + CusName + "' ,C_ICno = '" + NICno + "', C_Gender = '" + Gender + "', C_Age = '" + Age + "',Occupation = '" + Occupation + "',C_Address = '" + Address + "',C_Mail = '" + Email + "',C_Phone = '" + TeleNo + "',C_Blood = '" + Blood + "',C_Lic_No = '" + DriveLicNo + "',C_Lic_Expiry = '" + DriveLicExpiry + "' WHERE  CustomerID = '" + CustomerID + "'";
            if (executeQuery(update, FunctionType.update))
            {
                view();
            }
        }

        public void delete()
        {
            string Delete = "DELETE FROM Customer WHERE CustomerID = '" + CustomerID + "'";
            if (executeQuery(Delete, FunctionType.delete))
            {
                view();
            }

        }
      
    }
}

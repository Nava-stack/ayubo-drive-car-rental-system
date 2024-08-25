using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AyuboDrive_SystemNew.CommonClass;
using System.Windows.Forms;

namespace AyuboDrive_SystemNew.AppClass
{
    class PackageClass:MainClass
    {
        public int PackID { get; set; }
        public string PackName { get; set; }
        public float MaxKmLimit { get; set; }
        public int MaxHours { get; set; }
        public float PackCost { get; set; }

        public DataGridView GridPack { get; set; }


        public void view()
        {
            string PackDataSQL = "SELECT * FROM Package";
            LoadDataInGridView(PackDataSQL, GridPack);
        }

        public void insert()
        {
            string insert = "INSERT INTO Package VALUES ('" + PackName + "', '" + MaxKmLimit + "', '" + MaxHours + "','" + PackCost + "')";
            if (executeQuery(insert, FunctionType.insert))
            {
                view();
            }

        }

        public void update()
        {
            string update = "UPDATE Package SET P_Name = '" + PackName + "' ,Max_km_limit = '" + MaxKmLimit + "', Max_Hours = '" + MaxHours + "', Pack_Cost = '" + PackCost + "' WHERE  P_ID = '" + PackID + "'";
            if (executeQuery(update, FunctionType.update))
            {
                view();
            }
        }

        public void delete()
        {
            string Delete = "DELETE FROM Package WHERE P_ID = '" + PackID + "'";
            if (executeQuery(Delete, FunctionType.delete))
            {
                view();
            }

        }
    }
}

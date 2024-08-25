using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace AyuboDrive_SystemNew.CommonClass
{
    enum FunctionType
    {
        insert,
        update,
        delete
    }
    class MainClass
    {
        static SqlConnection Con = new SqlConnection(@"Data Source=NAVA;Initial Catalog=Ayubo_Drive_System;Integrated Security=True");

        public static bool executeQuery(string _sql, FunctionType _FunctionType)
        {
            bool myRet = false;
            bool FunctionStatus = false;
            string myMessage = "";

            if (_FunctionType == FunctionType.update)
            {
                if (MessageBox.Show("Do you want to update?", "Update confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FunctionStatus = true;
                    myMessage = "Updated Succesfully";
                }
            }
            else if (_FunctionType == FunctionType.delete)
            {
                if (MessageBox.Show("Do you want to delete?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    FunctionStatus = true;
                    myMessage = "Deleted Successfully";
                }
            }
            else
            {
                FunctionStatus = true;
                myMessage = "Inserted Successfully";
            }

            if (FunctionStatus)
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(_sql, Con);
                    int effectedRowsCount = cmd.ExecuteNonQuery();

                    if (effectedRowsCount > 0)
                    {
                        MessageBox.Show(myMessage);
                        myRet = true;
                    }
                    else
                    {
                        MessageBox.Show("Contact with your IT Department");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }
            return myRet;
        }
        public static DataTable getDataFromDB(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static void loadTableDataAsFK(string sql, ComboBox combo, string nameColumnName, string idColumnName)
        {
            DataTable dt = getDataFromDB(sql);
            combo.DataSource = dt;
            combo.DisplayMember = nameColumnName;
            combo.ValueMember = idColumnName;
        }
        public static void LoadDataInGridView(string sql, DataGridView loadTable)
        {
            DataTable dt = getDataFromDB(sql);
            loadTable.DataSource = dt;
        }
    }
}

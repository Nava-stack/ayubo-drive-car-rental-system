using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AyuboDrive_SystemNew.AppClass;

namespace AyuboDrive_SystemNew.Forms
{
    public partial class Vehicle : Form
    {
        VehicleClass vehiClass = new VehicleClass();
        public Vehicle()
        {
            InitializeComponent();
        }
        private SqlConnection con = new SqlConnection(@"Data Source=NAVA;Initial Catalog=Ayubo_Drive_System;Integrated Security=True");
        private void VehicleGrid_CellClick(object sender, DataGridViewCellEventArgs dataGrid)
        {
            int RowIndex = dataGrid.RowIndex;

            Vehi_IdBox.Text = VehicleGrid.Rows[RowIndex].Cells[0].Value.ToString();
            Vehi_nameBox.Text = VehicleGrid.Rows[RowIndex].Cells[1].Value.ToString();
            VehiTypeCombo.Text = VehicleGrid.Rows[RowIndex].Cells[2].Value.ToString();
            VehiNoBox.Text = VehicleGrid.Rows[RowIndex].Cells[3].Value.ToString();
            V_BrandBox.Text = VehicleGrid.Rows[RowIndex].Cells[4].Value.ToString();
            V_ColorBox.Text = VehicleGrid.Rows[RowIndex].Cells[5].Value.ToString();
            Vehi_InsNo.Text = VehicleGrid.Rows[RowIndex].Cells[6].Value.ToString();
            Vehi_Ins_Expiry.Text = VehicleGrid.Rows[RowIndex].Cells[7].Value.ToString();
            Vehi_LicNoBox.Text = VehicleGrid.Rows[RowIndex].Cells[8].Value.ToString();
            Vehi_Lic_Expiry.Text = VehicleGrid.Rows[RowIndex].Cells[9].Value.ToString();

        }

        private void Vehi_ClearTextBtn_Click(object sender, EventArgs e)
        {
            Vehi_IdBox.Clear();
            Vehi_nameBox.Clear();

            VehiNoBox.Clear();
            V_BrandBox.Clear();
            V_ColorBox.Clear();
            Vehi_InsNo.Clear();

            Vehi_LicNoBox.Clear();

        }

        private void Vehi_SaveBtn_Click(object sender, EventArgs e)
        {
            vehiClass.insert();
        }

        private void Vehi_UpdateBtn_Click(object sender, EventArgs e)
        {
            vehiClass.update();
        }

        private void Vehi_DeleteBtn_Click(object sender, EventArgs e)
        {
            vehiClass.delete();
           
        }

        private void Vehicle_Load(object sender, EventArgs e)
        {
            vehiClass.GridVehicle = VehicleGrid;
            vehiClass.view();
            VehicleClass.loadTableDataAsFK("SELECT * FROM Vehicle_Type", VehiTypeCombo, "V_Type", "V_TypeID");

        }

        private void Vehi_TypeBtn_Click(object sender, EventArgs e)
        {

        }

        private void Vehi_SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string vehiNo = Vehi_searchNoBox.Text;

                string query_search = "select * from Vehicle where V_ID ='" + vehiNo+ "'";
                SqlCommand cmd = new SqlCommand(query_search, con);
                con.Open();
                SqlDataReader re = cmd.ExecuteReader();
                while (re.Read())
                {
                    Vehi_IdBox.Text = re[0].ToString();
                    Vehi_nameBox.Text = re[1].ToString();
                    VehiTypeCombo.Text = re[2].ToString();
                    VehiNoBox.Text = re[3].ToString();
                    V_BrandBox.Text  = re[4].ToString();
                    V_ColorBox.Text = re[5].ToString();
                    Vehi_InsNo.Text = re[6].ToString();
                    Vehi_Ins_Expiry.Text = re[7].ToString();
                    Vehi_LicNoBox.Text = re[8].ToString();
                    Vehi_Lic_Expiry.Text = re[9].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching : " + ex);
            } 
            finally
            {
                con.Close();
            }
        }
    }
}

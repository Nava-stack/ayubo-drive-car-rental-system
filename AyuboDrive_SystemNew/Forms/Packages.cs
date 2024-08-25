using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AyuboDrive_SystemNew.AppClass;

namespace AyuboDrive_SystemNew.Forms
{
    public partial class Packages : Form
    {
        PackageClass packageClass = new PackageClass();

        public Packages()
        {
            InitializeComponent();
        }

        private void Packages_Load(object sender, EventArgs e)
        {
            packageClass.GridPack = PackageGrid;
            packageClass.view();

        }

        private void Pack_ClearTextBtn_Click(object sender, EventArgs e)
        {

        }

        private void Pack_SaveBtn_Click(object sender, EventArgs e)
        {
            packageClass.insert();
        }

        private void Pack_UpdateBtn_Click(object sender, EventArgs e)
        {
            packageClass.update();
        }

        private void Pack_DeleteBtn_Click(object sender, EventArgs e)
        {
            packageClass.delete();
        }

        private void PackageGrid_CellClick(object sender, DataGridViewCellEventArgs dataGrid)
        {
            int RowIndex = dataGrid.RowIndex;

            Pack_IdBox.Text = PackageGrid.Rows[RowIndex].Cells[0].Value.ToString();
            PackageBox.Text = PackageGrid.Rows[RowIndex].Cells[1].Value.ToString();
            Pack_maxKM.Text = PackageGrid.Rows[RowIndex].Cells[2].Value.ToString();
            Pack_MaxHour.Text = PackageGrid.Rows[RowIndex].Cells[3].Value.ToString();
            Pack_cost.Text = PackageGrid.Rows[RowIndex].Cells[4].Value.ToString();
        }

        private void Pack_IdBox_TextChanged(object sender, EventArgs e)
        {
            packageClass.PackID = int.Parse(Pack_IdBox.Text);
        }

        private void PackageBox_TextChanged(object sender, EventArgs e)
        {
            packageClass.PackName = PackageBox.Text;
        }

        private void Pack_maxKM_TextChanged(object sender, EventArgs e)
        {
            packageClass.MaxKmLimit = int.Parse(Pack_maxKM.Text);
        }

        private void Pack_MaxHour_TextChanged(object sender, EventArgs e)
        {
            packageClass.MaxHours = int.Parse(Pack_MaxHour.Text);
        }

        private void Pack_cost_TextChanged(object sender, EventArgs e)
        {
            packageClass.PackCost = float.Parse(Pack_cost.Text);
        }
    }
}

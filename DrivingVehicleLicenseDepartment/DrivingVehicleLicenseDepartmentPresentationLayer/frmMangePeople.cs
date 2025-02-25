using BusinessLayerDrivingVehicleLicenseDepartment;
using DrivingVehicleLicenseDepartmentPresentationLayer.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingVehicleLicenseDepartmentPresentationLayer
{
    public partial class frmMangePeople : Form
    {

        private DataView dv;
        public frmMangePeople()
        {
            InitializeComponent();

        }

        private void frmMangePeople_Load(object sender , EventArgs e)
        {
            _fillGrid();
            comboBox1.Items.Add("noun");

            foreach ( DataColumn dataColumn in dv.Table.Columns )
                comboBox1.Items.Add((string) dataColumn.ColumnName);

            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender , EventArgs e)
        {
            txtFilteredValue.Visible = comboBox1.SelectedIndex != 0;
        }

        private void txtFilteredValue_TextChanged(object sender , EventArgs e)
        {
            dv.RowFilter = "";
            if ( comboBox1.SelectedIndex == 1 )
            {
                if ( txtFilteredValue.Text != string.Empty )
                    dv.RowFilter = (string) comboBox1.SelectedItem.ToString() + "=" + "\'" + txtFilteredValue.Text + "\'";
            }
            else
              if ( txtFilteredValue.Text != string.Empty )
                dv.RowFilter = string.Format("{0} like '%{1}%'" , comboBox1.SelectedItem.ToString() , txtFilteredValue.Text);

            _setRecordCount(dataGridView1.RowCount);
        }

        public void _fillGrid()
        {
            dv = new DataView(clsPerson.GetAllPerson());
            dataGridView1.DataSource = dv;
            _setRecordCount(dataGridView1.RowCount);
        }
        public void _setRecordCount(int recoredCount)
        {
            lblRecordCount.Text = $"Records = {recoredCount - 1}";
        }

        private void btnAddNewPerson_Click(object sender , EventArgs e)
        {
            frmAddUpdatePerson frmAddUpdatePerson = new frmAddUpdatePerson();

            frmAddUpdatePerson.ShowDialog();
        }

    

        private void toolStripAddNewPerson_Click(object sender , EventArgs e)
        {
            frmAddUpdatePerson frmAddUpdatePerson = new frmAddUpdatePerson();

            frmAddUpdatePerson.ShowDialog();
            _fillGrid();
        }

        private void toolStripShowdetails_Click(object sender , EventArgs e)
        {
            frmShowPersonInfo frmShowPersonInfo = new frmShowPersonInfo(dataGridView1.CurrentRow.Cells["NationalNo"].Value.ToString());

            frmShowPersonInfo.ShowDialog();
        }

        private void toolStripEditPerson_Click(object sender , EventArgs e)
        {
            frmAddUpdatePerson frmAddUpdatePerson = new frmAddUpdatePerson(dataGridView1.CurrentRow.Cells["NationalNo"].Value.ToString());

            frmAddUpdatePerson.ShowDialog();
            _fillGrid();
        }
    }
}

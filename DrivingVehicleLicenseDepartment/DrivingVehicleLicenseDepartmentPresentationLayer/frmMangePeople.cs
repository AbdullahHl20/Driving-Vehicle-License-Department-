using BusinessLayerDrivingVehicleLicenseDepartment;
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
            dv = new DataView(clsPerson.GetAllPerson());
            dataGridView1.DataSource = dv;
            SetRecordCount(dataGridView1.RowCount);
            comboBox1.Items.Add("noun");

            foreach (DataColumn dataColumn in  dv.Table.Columns)
              comboBox1.Items.Add((string)dataColumn.ColumnName);

            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender , EventArgs e)
        {
           txtFilteredValue.Visible = comboBox1.SelectedIndex != 0;
        }

        private void txtFilteredValue_TextChanged(object sender , EventArgs e)
        {
            dv.RowFilter = "";
            if (comboBox1.SelectedIndex == 1)
            {
                if (txtFilteredValue.Text != string.Empty)
                    dv.RowFilter = (string)comboBox1.SelectedItem.ToString() + "=" + "\'" + txtFilteredValue.Text + "\'";
            }
            else
              if (txtFilteredValue.Text != string.Empty)
                dv.RowFilter = string.Format("{0} like '%{1}%'", comboBox1.SelectedItem.ToString(), txtFilteredValue.Text); 

            SetRecordCount(dataGridView1.RowCount);
        }

        public void SetRecordCount(int recoredCount)
        {
            lblRecordCount.Text = $"Records = {recoredCount - 1 }" ;
        }
    }
}

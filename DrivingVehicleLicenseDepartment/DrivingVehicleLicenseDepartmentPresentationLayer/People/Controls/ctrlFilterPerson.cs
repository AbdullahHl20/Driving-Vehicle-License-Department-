using BusinessLayerDrivingVehicleLicenseDepartment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Skins.SolidColorHelper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DrivingVehicleLicenseDepartmentPresentationLayer.People.Controls
{
    public partial class ctrlFilterPerson : UserControl
    {

        private DataView _dataView;
        public ctrlFilterPerson()
        {
            InitializeComponent();
            _dataView = clsPerson.GetAllPerson().DefaultView;
            _fillComboBoxByFields();
        }

        private void _fillComboBoxByFields()
        {
            foreach ( DataColumn dataColumn in _dataView.Table.Columns )
                comboBox1.Items.Add((string) dataColumn.ColumnName);
        }

        private void btnAddNewPerson_Click(object sender , EventArgs e)
        {
            frmAddUpdatePerson frmAddUpdatePerson = new frmAddUpdatePerson();
            frmAddUpdatePerson.ShowDialog();
        }
        private void _fillDataFromRow()
        {
            DataRow dataRow = _dataView.Table.Rows[0];
            clsPerson clsPerson = new clsPerson();
            clsPerson.PersonId = (int) dataRow["PersonID"];
            clsPerson.NationalNo = (string)dataRow["NationalNo"];
            clsPerson.FirstName = (string) dataRow["FirstName"];
            clsPerson.SecondName = (string) dataRow["SecondName"];
            clsPerson.ThirdName = (string) dataRow["ThirdName"] ;
            clsPerson.LastName = (string) dataRow["LastName"] ;
            clsPerson.DateOfBirth = (DateTime)  dataRow["DateOfBirth"] ;
           // clsPerson.Gendor = (short) dataRow["Gendor"] ;
            clsPerson.Address = (string) dataRow["Address"] ;
            clsPerson.Phone = (string) dataRow["Phone"] ;
            clsPerson.Email = (string) dataRow["Email"] ;
            clsPerson.NationalityCountryID = (int) dataRow["NationalityCountryID"] ;
            clsPerson.ImagePath = (string) dataRow["ImagePath"];

            ctrlCardPerson1.loadPersondata(clsPerson);
        }

        private void btnSearchPerson_Click(object sender , EventArgs e)
        {
            _dataView.RowFilter = "";
            if ( comboBox1.SelectedIndex == 1 )
            {
                if ( txtFilteredValue.Text != string.Empty )
                    _dataView.RowFilter = (string) comboBox1.SelectedItem.ToString() + "=" + "\'" + txtFilteredValue.Text + "\'";
            }
            else
              if ( txtFilteredValue.Text != string.Empty )
                _dataView.RowFilter = string.Format("{0} like '%{1}%'" , comboBox1.SelectedItem.ToString() , txtFilteredValue.Text);

            _fillDataFromRow();
        }

        public int GetPersonId()
        {
            return ctrlCardPerson1.GetPersonid();
        }
    }
}

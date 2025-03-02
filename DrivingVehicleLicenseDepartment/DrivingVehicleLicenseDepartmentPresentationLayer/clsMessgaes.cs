using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingVehicleLicenseDepartmentPresentationLayer
{
    public class clsMessgaes
    {

        public static void ShowError(string introdction , string Caption = "Error")
        {
            MessageBox.Show(introdction , Caption , MessageBoxButtons.OK , MessageBoxIcon.Error);
        }
    }
}

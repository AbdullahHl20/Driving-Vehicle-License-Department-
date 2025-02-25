using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingVehicleLicenseDepartmentPresentationLayer.People
{
    public partial class frmShowPersonInfo : Form
    {
        public frmShowPersonInfo(string NationalNo)
        {
            InitializeComponent();
            ctrlCardPerson1.LoadPersonInfo(NationalNo);
        }
    }
}

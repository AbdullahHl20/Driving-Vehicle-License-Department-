using BusinessLayerDrivingVehicleLicenseDepartment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingVehicleLicenseDepartmentPresentationLayer.Login
{
    public partial class frmLogin : Form
    {

        private string _filePath = @"..\LastUserData.txt";
        private clsUser _User;
        public frmLogin()
        {
            InitializeComponent();

            if (File.Exists(_filePath))
                _readUserInfoInFile();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            _User = clsUser.FindByUserNameAndPassword(txtUserName.Text,txtPassword.Text);

            if (_User == null)
                return;

            if (ChbRemberMe.Checked && !File.Exists(_filePath))
                _writeUserInfoInFile();
            else
            {
                File.Delete(_filePath);
            }
            _showMainForm();
        }

        private void _showMainForm()
        {
            frmMain frmMain = new frmMain(this);

            this.Hide();
            frmMain.ShowDialog();
        }

        private void _writeUserInfoInFile()
        {
            // The text content you want to write to the file
            string content = txtUserName.Text + "\\" + txtPassword.Text;

            // Write to the file using StreamWriter
            try
            {
                using (StreamWriter writer = new StreamWriter(_filePath))
                {
                    writer.WriteLine(content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private void _readUserInfoInFile()
        {
            // Write to the file using StreamWriter
            try
            {
                using (StreamReader reader = new StreamReader(_filePath))
                {
                    string[] values = reader.ReadLine().Split('\\');
                    txtUserName.Text = values[0];
                    txtPassword.Text = values[1];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

    }

}

using SmartHomeLib;
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

namespace SmartHomeApp
{

    public partial class RegisterDevice : Form
    {
        public RegisterDevice()
        {
            InitializeComponent();
        }

        private void RegisterDevice_Load(object sender, EventArgs e)
        {
        }

        private void btnSelectDevice_Click(object sender, EventArgs e)
        {
            MainForm.Server.ConnectedHosts = MainForm.Server.GetNetworkInfo().ToList();
            ddlSelectDevice.DataSource = MainForm.Server.ConnectedHosts;
            ddlSelectDevice.DisplayMember = "IP";
            ddlSelectDevice.ValueMember = "MAC";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((tbDeviceName.Text == "") || (ddlSelectDevice.SelectedValue == null))
            {
                MessageBox.Show("Please fill in the field and select the device", "Error");
            }
            else
            {
                TextWriter txt = new StreamWriter(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\devices.txt", append: true);
                try
                {
                    int num = ddlSelectDevice.SelectedIndex;
                    txt.WriteLine(tbDeviceName.Text + "|" + ddlSelectDevice.SelectedValue.ToString());
                    txt.Close();
                    MessageBox.Show("Added device successfully!", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to add device! Exception: " + ex.ToString(), "Error");
                }
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void populateMacAddress(object sender, EventArgs e)
        {
            tbMacAddress.Text = ddlSelectDevice.SelectedValue.ToString();
        }
    }
}

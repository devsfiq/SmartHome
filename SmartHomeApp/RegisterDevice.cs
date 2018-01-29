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
        string[] lineOfContents;
        String selectpath; 
        public RegisterDevice()
        {
            InitializeComponent();
        }

        private void RegisterDevice_Load(object sender, EventArgs e)
        {
            lineOfContents = File.ReadAllLines("modules.txt");
            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split('|');
                ddlSelectDevice.Items.Add(tokens[0]);
            }
        }

        

        private void btnSelectDevice_Click(object sender, EventArgs e)
        {
            ddlSelectDevice.Items.Clear();
            string[] lineOfContents = File.ReadAllLines("modules.txt");
            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split('|');
                ddlSelectDevice.Items.Add(tokens[0]);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((tbDeviceName.Text == "") || (ddlSelectDevice.Text == "") || (lblMacAddress.Text == ""))
            {
                MessageBox.Show("Please fill in the field and select the device", "Error");
            }
            else
            {
                TextWriter txt = new StreamWriter(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\devices.txt", append: true);
                try
                {
                    int num = ddlSelectDevice.SelectedIndex;
                    txt.WriteLine(tbDeviceName.Text + "|" + lineOfContents[num]);
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

        private void popuMacAddress(object sender, EventArgs e)
        {

        }
    }
}

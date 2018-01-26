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
            string[] lineOfContents = File.ReadAllLines("modules.txt");
            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split('|');
                ddlSelectDevice.Items.Add(tokens[0]);
            }
        }

        

        private void btnSelectDevice_Click(object sender, EventArgs e)
        {
            string[] lineOfContents = File.ReadAllLines("modules.txt");
            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split('|');
                ddlSelectDevice.Items.Add(tokens[0]);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\devices.txt", append: true);
            try
            {
                txt.WriteLine(tbDeviceName.Text + "|" + ddlSelectDevice.Text + "|");
                txt.Close();
                MessageBox.Show("Added devices successfully!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to add device! Exception: " + ex.ToString(), "Error");
            }
        }
    }
}

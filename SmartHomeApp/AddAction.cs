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
    public partial class AddAction : Form
    {
        string[] lineOfContentForD;
        string[] lineOfContentForM;
        public AddAction()
        {
            InitializeComponent();
        }

        private void btnRefreshD_Click(object sender, EventArgs e)
        {
            cbDevice.Items.Clear();
            lineOfContentForD = File.ReadAllLines("devices.txt");
            foreach (var line in lineOfContentForD)
            {
                string[] tokens = line.Split('|');
                cbDevice.Items.Add(tokens[0]);
            }
        }

        private void AddAction_Load(object sender, EventArgs e)
        {
            lineOfContentForM = File.ReadAllLines("modules.txt");
            foreach (var line in lineOfContentForM)
            {
                string[] tokens = line.Split('|');
                cbModule.Items.Add(tokens[0]);
            }

            lineOfContentForD = File.ReadAllLines("devices.txt");
            foreach (var line in lineOfContentForD)
            {
                string[] tokens = line.Split('|');
                cbDevice.Items.Add(tokens[0]);
            }
        }

        private void btnRefreshM_Click(object sender, EventArgs e)
        {
            cbModule.Items.Clear();
            lineOfContentForM = File.ReadAllLines("modules.txt");
            foreach (var line in lineOfContentForM)
            {
                string[] tokens = line.Split('|');
                cbModule.Items.Add(tokens[0]);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if ((cbDevice.Text == "") || (cbModule.Text == "") || (cbAction.Text == ""))
            {
                MessageBox.Show("Please fill in the field ", "Error");
            }
            else
            {
                TextWriter txt = new StreamWriter(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\actions.txt", append: true);
                try
                {
                    int numM = cbModule.SelectedIndex;
                    int numD = cbDevice.SelectedIndex;
                    txt.WriteLine(lineOfContentForD[numD] + "|" + lineOfContentForM[numM] + "|" + cbAction.Text);
                    txt.Close();
                    MessageBox.Show("Added action successfully!", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to add action! Exception: " + ex.ToString(), "Error");
                }
            }
        }
    }
}

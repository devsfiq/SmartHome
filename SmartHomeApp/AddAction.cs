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
        public AddAction()
        {
            InitializeComponent();
        }

        private void btnRefreshD_Click(object sender, EventArgs e)
        {
            cbDevice.Items.Clear();
            string[] lineOfContents = File.ReadAllLines("modules.txt");
            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split('|');
                cbDevice.Items.Add(tokens[0]);
            }
        }

        private void AddAction_Load(object sender, EventArgs e)
        {
            string[] lineOfContentForM = File.ReadAllLines("modules.txt");
            foreach (var line in lineOfContentForM)
            {
                string[] tokens = line.Split('|');
                cbDevice.Items.Add(tokens[0]);
            }

            string[] lineOfContentForD = File.ReadAllLines("modules.txt");
            foreach (var line in lineOfContentForD)
            {
                string[] tokens = line.Split('|');
                cbModule.Items.Add(tokens[0]);
            }
        }

        private void btnRefreshM_Click(object sender, EventArgs e)
        {
            cbModule.Items.Clear();
            string[] lineOfContents = File.ReadAllLines("modules.txt");
            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split('|');
                cbModule.Items.Add(tokens[0]);
            }
        }
    }
}

using SmartHomeLib;
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

namespace SmartHomeApp
{
    public partial class MainForm : Form
    {
        public static SmartHomeServer Server;

        public MainForm()
        {
            InitializeComponent();

            Server = new SmartHomeServer(IPAddress.Any, 3000);
            Server.Start((command) =>
            {
                MessageBox.Show(command);
            });
        }

        private void addActionBTN_Click(object sender, EventArgs e)
        {
            new AddAction().Show();
        }

        private void manageModulesBTN_Click(object sender, EventArgs e)
        {
            new ManageModules().Show();
        }

        private void resgisterBtn_Click(object sender, EventArgs e)
        {
            new RegisterDevice().Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Server.Stop();
        }
    }
}

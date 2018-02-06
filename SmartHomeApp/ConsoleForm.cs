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
    public partial class ConsoleForm : Form
    {

        SmartHomeServer Server;

        public ConsoleForm()
        {
            InitializeComponent();
        }

        private void ConsoleForm_Load(object sender, EventArgs e)
        {
            Server = new SmartHomeServer(IPAddress.Any, 3000);
            Server.Start((command) =>
            {
                Invoke(new Action(() => {
                    tbConsole.AppendText(command);
                }));
            });
        }

        private void ConsoleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Server.Stop();
        }
    }
}

using SmartHomeLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
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
            Server.Start((connected, disconnected) =>
            {
                using (SQLiteConnection conn = new SQLiteConnection("data source=SmartHomeDB.db3"))
                {
                    conn.Open();

                    foreach(Host host in connected)
                    {
                        SQLiteCommand cmd = new SQLiteCommand(conn);
                        cmd.CommandText = "SELECT Modules.Path as Path, Modules.Args as Args FROM Devices INNER JOIN Actions ON Devices.DeviceName = Actions.DeviceName INNER JOIN Modules ON Actions.Command = Modules.Command WHERE Devices.MacAddress = @mac AND Action = @action";
                        cmd.Parameters.AddWithValue("@mac", host.MAC);
                        cmd.Parameters.AddWithValue("@action", "Enter");

                        var reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Read();
                            process(reader.GetString(reader.GetOrdinal("Path")), reader.GetString(reader.GetOrdinal("Args")));
                        }
                    }

                    foreach (Host host in disconnected)
                    {
                        SQLiteCommand cmd = new SQLiteCommand(conn);
                        cmd.CommandText = "SELECT Modules.Path as Path, Modules.Args as Args FROM Devices INNER JOIN Actions ON Devices.DeviceName = Actions.DeviceName INNER JOIN Modules ON Actions.Command = Modules.Command WHERE Devices.MacAddress = @mac AND Action = @action";
                        cmd.Parameters.AddWithValue("@mac", host.MAC);
                        cmd.Parameters.AddWithValue("@action", "Exit");
                        var reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();
                            process(reader.GetString(reader.GetOrdinal("Path")), reader.GetString(reader.GetOrdinal("Args")));
                        }
                    }
                }
            });
        }

        private void process(String command, String args)
        {
            Process.Start(command, args);
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

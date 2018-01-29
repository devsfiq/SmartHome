using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Xml.Linq;

namespace SmartHomeApp
{
    static class SmartHome
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            string createQuery = @"CREATE TABLE IF NOT EXISTS [Modules] ([Id] INTEGER PRIMARY KEY, [Command] NVARCHAR(256) UNIQUE NOT NULL, [Path] NVARCHAR(2048) NOT NULL, [Args] NVARCHAR(256) NULL)";

            SQLiteConnection.CreateFile("SmartHomeDB.db3");

            using (SQLiteConnection conn = new SQLiteConnection("data source=SmartHomeDB.db3"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    conn.Open();
                    cmd.CommandText = createQuery;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

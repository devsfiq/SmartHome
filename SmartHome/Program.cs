using SmartHomeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SmartHome
{
    class Program
    {
        static void Main(string[] args)
        {
            string ip = "127.0.0.1";
            int port = 3000;

            SmartHomeServer server = new SmartHomeServer(ip, port);
            server.Start(c =>
            {
                Console.WriteLine(c);
            });
        }
    }
}

using SmartHomeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartHomeServer server = new SmartHomeServer(IPAddress.Any, 3000);
            server.Start((command) =>
            {
                Console.WriteLine(command);
                Console.WriteLine();
            });
        }
    }
}

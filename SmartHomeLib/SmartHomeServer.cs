using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SmartHomeLib
{
    public class SmartHomeServer
    {
        public delegate void OnReceiveCommand(string command); // Callback Method

        public readonly string Ip;
        public readonly int Port;

        public List<Host> ConnectedHosts;

        private Thread listenerThread;
        private TcpListener Listener;
        private OnReceiveCommand onReceiveCommand;
        //private int count;

        public SmartHomeServer(string ip, int port)
        {
            Ip = ip;
            Port = port;
            ConnectedHosts = new List<Host>();
            Listener = new TcpListener(IPAddress.Parse(ip), port);
        }

        public SmartHomeServer(IPAddress ip, int port)
        {
            Ip = ip.ToString();
            Port = port;
            ConnectedHosts = new List<Host>();
            Listener = new TcpListener(ip, port);
        }

        public void Start(OnReceiveCommand onReceiveCommand)
        {
            try
            {
                this.onReceiveCommand = onReceiveCommand;
                //count = 0;

                listenerThread = new Thread(RunListenerThread);
                listenerThread.Start();
            } catch(Exception ex)
            {
                //[TODO] Handle Error (Port is busy)
            }
        }


        public void Stop()
        {
            Listener.Stop();
            listenerThread.Abort();
        }

        private void RunListenerThread()
        {

            Listener.Start();
            //ConnectedHosts = GetNetworkInfo().ToList();

            while (true)
            {
                Socket client = Listener.AcceptSocket();
                var childSocketThread = new Thread(() =>
                {
                    String request = "";

                byte[] data = new byte[102400];
                int size = 0;

                do
                {
                    size = client.Receive(data);
                    request += Encoding.ASCII.GetString(data, 0, size);
                } while (client.Available > 0);

                //onReceiveCommand(request);
                ThreadPool.QueueUserWorkItem(delegate
                    {
                        onReceiveCommand(request);
                    }, request);

                    client.Close();
                });
                childSocketThread.Start();
            }
        }

        public IEnumerable<Host> GetNetworkInfo()
        {
            List<Host> hosts = new List<Host>();
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://192.168.43.100/arduino/scan");

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    var xml = XDocument.Load(stream);
                    var tmp = xml.Descendants("host");

                    foreach (var node in tmp)
                    {
                        hosts.Add(new Host()
                        {
                            IP = node.Descendants("ip").FirstOrDefault().Value,
                            MAC = node.Descendants("mac").FirstOrDefault().Value
                        });
                    }
                }
            } catch (Exception ex)
            {
                //[TODO] Handle     
            }
            return hosts;
        }
    }
}

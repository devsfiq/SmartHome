using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
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
        public delegate void OnReceiveCommand(List<Host> newlyConnected, List<Host> newlyDisconnected); // Callback Method

        public readonly string Ip;
        public readonly int Port;

        public BindingList<Host> ConnectedHosts;

        private Thread listenerThread;
        private TcpListener Listener;

        public OnReceiveCommand onReceiveCommand;

        public SmartHomeServer(string ip, int port)
        {
            Ip = ip;
            Port = port;
            ConnectedHosts = new BindingList<Host>();
            Listener = new TcpListener(IPAddress.Parse(ip), port);
        }

        public SmartHomeServer(IPAddress ip, int port)
        {
            Ip = ip.ToString();
            Port = port;
            ConnectedHosts = new BindingList<Host>();
            Listener = new TcpListener(ip, port);
        }

        public void Start(OnReceiveCommand onReceiveCommand)
        {
            this.onReceiveCommand = onReceiveCommand;
            listenerThread = new Thread(RunListenerThread);
            listenerThread.Start();
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
                //var childSocketThread = new Thread(() =>
                //{
                    String request = "";

                    byte[] data = new byte[102400];
                    int size = 0;

                    do
                    {
                        size = client.Receive(data);
                        request += Encoding.ASCII.GetString(data, 0, size);
                    } while (client.Available > 0);

                    //onReceiveCommand(request);
                    List<Host> updatedNetworkInfo = new List<Host>();
                    //ConnectedHosts.Clear();

                    var xml = XDocument.Parse(request.Trim());
                    var tmp = xml.Descendants("host");

                    foreach (var node in tmp)
                    {
                        updatedNetworkInfo.Add(new Host()
                        {
                            IP = node.Descendants("ip").FirstOrDefault().Value,
                            MAC = node.Descendants("mac").FirstOrDefault().Value
                        });
                    }

                    var newlyConnectedHosts = updatedNetworkInfo.Except(ConnectedHosts, new HostComparer()).ToList();
                    var newlyDisconnectedHosts = ConnectedHosts.Except(updatedNetworkInfo, new HostComparer()).ToList();
                    //var query = newlyConnectedHosts.Except(newlyDisconnectedHosts).Union(newlyDisconnectedHosts.Except(newlyConnectedHosts)).ToList();

                    ConnectedHosts.Clear();
                    foreach (Host host in updatedNetworkInfo)
                        ConnectedHosts.Add(host);

                    onReceiveCommand(newlyConnectedHosts, newlyDisconnectedHosts);

                    client.Close();
                //});
                //childSocketThread.Start();
            }
        }

        [Obsolete]
        public IEnumerable<Host> GetNetworkInfo()
        {
            List<Host> hosts = new List<Host>();
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://192.168.1.2/arduino/scan");

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SmartHomeLib
{
    public class SmartHomeServer
    {
        public delegate void OnReceiveCommand(string command); // Callback Method

        public readonly string Ip;
        public readonly int Port;

        private Thread listenerThread;
        private TcpListener Listener;
        private OnReceiveCommand onReceiveCommand;
        private int count;

        public SmartHomeServer(string ip, int port)
        {
            Ip = ip;
            Port = port;
            Listener = new TcpListener(IPAddress.Parse(ip), port);
        }

        public void Start(OnReceiveCommand onReceiveCommand)
        {
            this.onReceiveCommand = onReceiveCommand;
            count = 0;

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
            Socket client = Listener.AcceptSocket();
            var childSocketThread = new Thread(() =>
            {
                ++count;
                String request = "";

                byte[] data = new byte[256];
                int size = client.Receive(data);

                for (int i = 0; i < size; i++)
                {
                    Char c = Convert.ToChar(data[i]);
                    request += c;
                    if (c == '\n') break;
                }

                string startStr = "/";
                string endStr = "HTTP";

                int start = request.IndexOf(startStr) + startStr.Length;
                int end = request.IndexOf(endStr) - (endStr.Length + 1);

                request = request.Substring(start, end).Trim();
                client.Close();

                if (count == 10)
                {
                    ThreadPool.QueueUserWorkItem(delegate
                    {
                        onReceiveCommand(request);
                    }, request);
                    count = 0;
                }
            });

            while (true)
            {
                client = Listener.AcceptSocket();
                childSocketThread.Start();
            }
        }
    }
}

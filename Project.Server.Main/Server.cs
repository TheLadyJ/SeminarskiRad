using Project.Server.Main.ClientsSession;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project.Server.Main
{
    public class Server
    {
        private Socket socket;

        public Server()
        {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

      

        public bool Start()
        {
            try
            {
                IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
                socket.Bind(endpoint);
                socket.Listen(5);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
                return false;
            }
        }


        public void Stop()
        {
            if(socket != null)
            {
                socket.Close();
                List<ClientHandler> clients = ClientsSessionData.Instance.Clients;
                foreach (ClientHandler handler in clients.ToList())
                {
                    handler.CloseSocket();
                }
            }
        }


        public void HandleClients()
        {
            try
            {
                while (true)
                {
                    Socket klijentskiSocket = socket.Accept();
                    ClientHandler client = new ClientHandler(klijentskiSocket);
                    ClientsSessionData.Instance.AddClientHAndler(client);

                    Thread nitKlijenta = new Thread(client.HandleRequests);
                    nitKlijenta.IsBackground = false;
                    nitKlijenta.Start();
                }
            }
            catch (SocketException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
        }
    }
}

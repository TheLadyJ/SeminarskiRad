using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Main.ClientsSession
{
    public class ClientsSessionData
    {
        private ClientsSessionData() { }
        private static ClientsSessionData instance;
        public static ClientsSessionData Instance
        {
            get
            {
                if (instance == null) instance = new ClientsSessionData();
                return instance;
            }
        }

        public List<ClientHandler> Clients { get; private set; } = new List<ClientHandler>();

        public void AddClientHAndler(ClientHandler client)
        {
            Clients.Add(client);
        }

        public void RemoveClientHAndler(ClientHandler client)
        {
            Clients.Remove(client);
        }

        public void ClearClientHandlerList()
        {
            Clients.Clear();
        }
    }
}

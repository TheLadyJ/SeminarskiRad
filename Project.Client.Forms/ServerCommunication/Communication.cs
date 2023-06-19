using Project.Client.Forms.Exceptions;
using Project.Common.Communication;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Project.Client.Forms.ServerCommunication
{
    public class Communication
    {
        private Socket socket;
        private CommunicationHelper helper;
        private static Communication instance;

        private Communication()
        {
        }
        public static Communication Instance
        {
            get
            {
                if (instance == null) instance = new Communication();
                return instance;
            }
        }

        public Response SendRequestGetResponse(Operation op, object i = null)
        {
            SendRequest(op, i);
            return GetResponse();
        }

        private Response GetResponse()
        {
            Response response = helper.Receive<Response>();
            if (response.IsSuccessful)
            {
                return response;
            }
            else
            {
                throw new SystemOperationException(response.Message);
            }
        }

        private void SendRequest(Operation operation, object requestObject = null)
        {
            try
            {
                Request r = new Request
                {
                    Operation = operation,
                    RequestObject = requestObject
                };
                helper.Send(r);
            }
            catch (NullReferenceException ex)
            {
                throw new NullReferenceException(ex.Message);
            }
            catch (IOException ex)
            {
                throw new ServerCommunicationException(ex.Message);
            }
        }

        public void Connect()
        {
            if (socket == null || !socket.Connected)
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect("127.0.0.1", 9999);
                helper = new CommunicationHelper(socket);
            }
        }
        public void Close()
        {
            if (socket == null) return;
            SendRequest(Operation.Kraj);
            GetResponse();

            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
            socket = null;
        }

    }
}

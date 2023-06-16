using Project.Common.Communication;
using Project.Common.Domain;
using Project.Server.ApplicationLogic;
using Project.Server.Main.ClientsSession;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Main
{
    public class ClientHandler
    {

        private Socket socket;
        private CommunicationHelper helper;
        private Radnik Radnik;
        public EventHandler OdjavljenRadnik;
        public EventHandler PrijavljenRadnik;
        public ClientHandler(Socket socket)
        {
            this.socket = socket;
            helper = new CommunicationHelper(socket);
        }

        private bool kraj = false;

        private object lockObject = new object();

        public void CloseSocket()
        {
            lock (lockObject)
            {
                if (socket != null)
                {
                    kraj = true;
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                    socket = null;
                    OdjavljenRadnik?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public void HandleRequests()
        {
            try
            {
                while (!kraj)
                {
                    Request request = helper.Receive<Request>();
                    Response response = CreateResponse(request);
                    helper.Send(response);
                }
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
            finally
            {
                CloseSocket();
            }
        }

        private Response CreateResponse(Request request)
        {
            Response response = new Response();
            try
            {
                switch (request.Operation)
                {
                    case Operation.PrijaviRadnika:
                        PrijaviRadnika(response, request);
                        break;
					case Operation.KreirajKlijenta:
						KreirajKlijenta(response, request);
						break;
					case Operation.Kraj:
                        kraj = true;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
                response.IsSuccessful = false;
                response.Message = ex.Message;
            }
            return response;
        }

		private void KreirajKlijenta(Response response, Request request)
		{
			response.Result = Controller.Instance.PrijaviRadnika((Radnik)request.RequestObject);
			if (response.Result == null)
			{
				response.IsSuccessful = false;
				response.Message = "Uneti podaci nisu validni!";
			}
			else if (VecPrijavljen((Radnik)response.Result))
			{
				response.Message = "Radnik je vec prijavljen!";
				response.Result = null;
			}
			else
			{
				response.Message = "Uspešno ste se prijavili!";
				Radnik = (Radnik)response.Result;
				PrijavljenRadnik?.Invoke(this, EventArgs.Empty);
			}
		}

		private void PrijaviRadnika(Response response, Request request)
        {
            response.Result = Controller.Instance.PrijaviRadnika((Radnik)request.RequestObject);
            if (response.Result == null)
            {
                response.IsSuccessful = false;
                response.Message = "Uneti podaci nisu validni!";
            }
            else if (VecPrijavljen((Radnik)response.Result))
            {
                response.Message = "Radnik je vec prijavljen!";
                response.Result = null;
            }
            else
            {
                response.Message = "Uspešno ste se prijavili!";
                Radnik = (Radnik)response.Result;
                PrijavljenRadnik?.Invoke(this, EventArgs.Empty);
            }
        }

        private bool VecPrijavljen(Radnik radnik)
        {
            return ClientsSessionData.Instance.Clients.Any(handler=>handler.Radnik==radnik);
        }
    }
}

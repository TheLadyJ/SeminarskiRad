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
					case Operation.VratiSveKlijente:
						VratiSveKlijente(response);
						break;
					case Operation.PretraziKlijenta:
						PretraziKlijenta(response,request);
						break;
                    case Operation.ObrisiKlijenta:
						ObrisiKlijenta(response,request);
						break;
                    case Operation.UnesiSto:
						UnesiSto(response,request);
						break;
					case Operation.VratiProizvodjace:
						VratiProizvodjace(response);
						break;
					case Operation.VratiSveStolove:
						VratiSveStolove(response);
						break;
					case Operation.PretraziSto:
						PretraziSto(response, request);
						break;
					case Operation.ObrisiSto:
						ObrisiSto(response, request);
						break;
					case Operation.VratiSvaMesta:
						VratiSvaMesta(response);
						break;
					case Operation.VratiSveTipoveProslave:
						VratiSveTipoveProslave(response);
						break;
					case Operation.VratiSveKeteringFirme:
						VratiSveKeteringFirme(response);
						break;
					case Operation.VratiMenijeFirme:
						VratiMenijeFirme(response, request);
						break;
					case Operation.ProveraCuvanjaRezervacije:
						ProveraCuvanjaRezervacije(response, request);
						break;
					case Operation.KreirajRezervaciju:
						KreirajRezervaciju(response, request);
						break;
					case Operation.VratiSveRezervacije:
						VratiSveRezervacije(response);
						break;
					case Operation.PretraziRezervaciju:
						PretraziRezervaciju(response, request);
						break;
					case Operation.VratiStoloveRezervacije:
						VratiStoloveRezervacije(response, request);
						break;
					case Operation.IzmeniRezervaciju:
						IzmeniRezervaciju(response, request);
						break;
					case Operation.ObrisiRezervaciju:
						ObrisiRezervaciju(response, request);
						break;
					case Operation.ProveriBrisanjeKlijenta:
						ProveriBrisanjeKlijenta(response, request);
						break;
					case Operation.ProveriBrisanjeStola:
						ProveriBrisanjeStola(response, request);
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

		




		#region Rezervacija i RezervisanSto


		private void ProveraCuvanjaRezervacije(Response response, Request request)
		{
			try
			{
				bool moguce = Controller.Instance.ProveraCuvanjaRezervacije((Rezervacija)request.RequestObject);
				response.Result = moguce;
				if(!moguce)
				{
					response.Message = "Nije moguće sačuvati rezervaciju. Već postoji rezervacija sa unetim mestom čije se vreme poklapa sa Vašim.";
				}
			}
			catch (Exception)
			{
				response.IsSuccessful = false;
				response.Message = "Došlo je do greške prilikom provere mogućnosti čuvanja rezervacije.";
			}
		}


		private void KreirajRezervaciju(Response response, Request request)
		{
			try
			{
				Controller.Instance.KreirajRezervaciju((Rezervacija)request.RequestObject);
				response.Message = "Sistem je zapamtio rezervaciju.";
			}
			catch (Exception)
			{
				response.IsSuccessful = false;
				response.Message = "Sistem ne može da zapamti podatke o rezervaciji.";
			}
		}

		private void VratiSveRezervacije(Response response)
		{
			try
			{
				List<Rezervacija> rezervacije = Controller.Instance.VratiSveRezervacije();
				response.Result = rezervacije;
			}
			catch (Exception)
			{
				response.IsSuccessful = false;
				response.Message = "Došlo je do greške prilikom učitavanja svih rezervacija.";
			}
		}

		private void PretraziRezervaciju(Response response, Request request)
		{
			try
			{
				List<Rezervacija> nadjeneRezervacije = Controller.Instance.PretraziRezervaciju((string)request.RequestObject);
				response.Result = nadjeneRezervacije;
				if (nadjeneRezervacije != null && nadjeneRezervacije.Count != 0)
				{
					response.Message = "Sistem je našao rezervacije po zadatoj vrednosti.";
				}
				else
				{
					response.IsSuccessful = false;
					response.Message = "Sistem ne može da nađe rezervaciju po zadatoj vrednosti.";
				}
			}
			catch (Exception)
			{
				response.IsSuccessful = false;
				response.Message = "Došlo je do greške prilikom pretrage rezervacije.";
			}
		}

		private void VratiStoloveRezervacije(Response response, Request request)
		{
			try
			{
				List<RezervisanSto> rezervisaniStolovi = Controller.Instance.VratiStoloveRezervacije((Rezervacija)request.RequestObject);
				response.Result = rezervisaniStolovi;
			}
			catch (Exception)
			{
				response.IsSuccessful = false;
				response.Message = "Došlo je do greške prilikom učitavanja rezervisanih stolova.";
			}
		}

		private void IzmeniRezervaciju(Response response, Request request)
		{
			try
			{
				Controller.Instance.IzmeniRezervaciju((Rezervacija)request.RequestObject);
				response.Message = "Sistem je zapamtio rezervaciju.";
			}
			catch (Exception)
			{
				response.IsSuccessful = false;
				response.Message = "Sistem ne može da zapamti rezervaciju.";
			}
		}


		private void ObrisiRezervaciju(Response response, Request request)
		{
			try
			{
				Controller.Instance.ObrisiRezervaciju((Rezervacija)request.RequestObject);
				response.Message = "Sistem je obrisao rezervaciju.";
			}
			catch (Exception)
			{
				response.IsSuccessful = false;
				response.Message = "Sistem ne može da obriše rezervaciju.";
			}
		}



		#endregion

		#region KeteringFirma i KeteringMeni
		private void VratiMenijeFirme(Response response, Request request)
		{
			try
			{
				List<KeteringMeni> meniji = Controller.Instance.VratiMenijeFirme((KeteringFirma)request.RequestObject);
				response.Result = meniji;
			}
			catch (Exception)
			{
				response.IsSuccessful = false;
				response.Message = "Došlo je do greške prilikom učitavanja menija odabrane firme.";
			}
		}

		private void VratiSveKeteringFirme(Response response)
		{
			try
			{
				List<KeteringFirma> firme = Controller.Instance.VratiSveKeteringFirme();
				response.Result = firme;
			}
			catch (Exception)
			{
				response.IsSuccessful = false;
				response.Message = "Došlo je do greške prilikom učitavanja svih ketering firmi.";
			}
		}


		#endregion

		#region Mesto i TipProslave

		private void VratiSvaMesta(Response response)
		{
			try
			{
				List<Mesto> mesta = Controller.Instance.VratiSvaMesta();
				response.Result = mesta;
			}
			catch (Exception)
			{
				response.IsSuccessful = false;
				response.Message = "Došlo je do greške prilikom učitavanja svih mesta.";
			}
		}

		private void VratiSveTipoveProslave(Response response)
		{
			try
			{
				List<TipProslave> tipoviProslave = Controller.Instance.VratiSveTipoveProslave();
				response.Result = tipoviProslave;
			}
			catch (Exception)
			{
				response.IsSuccessful = false;
				response.Message = "Došlo je do greške prilikom učitavanja svih tipova proslava.";
			}
		}

		#endregion

		#region Sto i proizvodjac

		private void ProveriBrisanjeStola(Response response, Request request)
		{
			try
			{
				bool moguce = Controller.Instance.ProveriBrisanjeStola((Sto)request.RequestObject);
				response.Result = moguce;
				if (!moguce)
				{
					response.Message = "Nije moguće obrisati sto jer još uvek postoji neka rezervacija koja ga koristi.";
				}
			}
			catch (Exception)
			{
				response.IsSuccessful = false;
				response.Message = "Došlo je do greške prilikom provere mogućnosti brisanja stola.";
			}
		}
		private void ObrisiSto(Response response, Request request)
		{
			try
			{
				Controller.Instance.ObrisiSto((Sto)request.RequestObject);
				response.Message = "Sistem je obrisao sto.";

			}
			catch (Exception)
			{
				response.IsSuccessful = false;
				response.Message = "Sistem ne može da obriše odabrani sto.";
			}
		}

		private void PretraziSto(Response response, Request request)
		{
			try
			{
				List<Sto> nadjeniStolovi = Controller.Instance.PretraziSto((string)request.RequestObject);
				response.Result = nadjeniStolovi;
				if (nadjeniStolovi != null && nadjeniStolovi.Count != 0)
				{
					response.Message = "Sistem je našao stolove po zadatoj vrednosti.";
				}
				else
				{
					response.Message = "Sistem ne može da nađe stolove po zadatoj vrednosti.";
					response.IsSuccessful = false;
				}
			}
			catch (Exception)
			{
				response.IsSuccessful = false;
				response.Message = "Došlo je do greške prilikom pretrage stolova.";
			}
		}

		private void VratiSveStolove(Response response)
		{
			try
			{
				List<Sto> stolovi = Controller.Instance.VratiSveStolove();
				response.Result = stolovi;
			}
			catch (Exception)
			{
				response.IsSuccessful = false;
				response.Message = "Došlo je do greške prilikom učitavanja svih stolova.";
			}
		}


		private void VratiProizvodjace(Response response)
		{
			try
			{
				List<Proizvodjac> proizvodjaci = Controller.Instance.VratiProizvodjace();
				response.Result = proizvodjaci;
			}
			catch (Exception)
			{
				response.IsSuccessful = false;
				response.Message = "Došlo je do greške prilikom učitavanja proizvodjaca.";
			}
		}

		private void UnesiSto(Response response, Request request)
		{
			try
			{
				Controller.Instance.UnesiSto((Sto)request.RequestObject);
				response.Message = "Sistem je zapamtio sto.";
			}
			catch (Exception)
			{
				response.IsSuccessful = false;
				response.Message = "Sistem ne može da zapamti sto.";
			}
		}

		#endregion

		#region Klijent

		private void ProveriBrisanjeKlijenta(Response response, Request request)
		{
			try
			{
				bool moguce = Controller.Instance.ProveriBrisanjeKlijenta((Klijent)request.RequestObject);
				response.Result = moguce;
				if (!moguce)
				{
					response.Message = "Nije moguće obrisati klijenta jer još uvek postoji neka rezervacija za njega.";
				}
			}
			catch (Exception)
			{
				response.IsSuccessful = false;
				response.Message = "Došlo je do greške prilikom provere mogućnosti brisanja klijenta.";
			}
		}
		private void ObrisiKlijenta(Response response, Request request)
		{
			try
			{
				Controller.Instance.ObrisiKlijenta((Klijent)request.RequestObject);
				response.Message = "Sistem je obrisao klijenta.";
				
			}
			catch (Exception)
			{
				response.IsSuccessful = false;
				response.Message = "Sistem ne može da obriše klijenta.";
			}
		}

		private void PretraziKlijenta(Response response, Request request)
		{
			try
			{
				List<Klijent> nadjeniKlijenti = Controller.Instance.PretraziKlijenta((string)request.RequestObject);
				response.Result = nadjeniKlijenti;
                if(nadjeniKlijenti!=null && nadjeniKlijenti.Count!=0)
                {
				    response.Message = "Sistem je našao klijente po zadatoj vrednosti.";
                }
                else
                {
					response.IsSuccessful = false;
					response.Message = "Sistem ne može da nađe klijenta po zadatoj vrednosti.";
				}
			}
			catch (Exception)
			{
				response.IsSuccessful = false;
				response.Message = "Došlo je do greške prilikom pretrage klijenata.";
			}
		}

		private void VratiSveKlijente(Response response)
		{
			try
			{
				List<Klijent> sviKlijenti = Controller.Instance.VratiSveKlijente();
                response.Result = sviKlijenti;
			}
			catch (Exception)
			{
				response.IsSuccessful = false;
				response.Message = "Došlo je do greške prilikom učitavanja svih klijenata.";
			}
		}

		private void KreirajKlijenta(Response response, Request request)
		{
            try
            {
                Controller.Instance.KreirajKlijenta((Klijent)request.RequestObject);
				response.Message = "Sistem je zapamtio klijenta.";
			}
			catch (Exception)
            {
				response.IsSuccessful = false;
				response.Message = "Sistem ne može da zapamti klijenta.";
			}
		}

		#endregion

		#region Radnik
		private void PrijaviRadnika(Response response, Request request)
        {
            try
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
            catch (Exception)
            {
				response.IsSuccessful = false;
				response.Message = "Došlo je do greške prilikom prijavljivanja.";
			}
            
        }

        private bool VecPrijavljen(Radnik radnik)
        {
            return ClientsSessionData.Instance.Clients.Any(handler=>handler.Radnik.RadnikID == radnik.RadnikID);
        }

		#endregion
	}
}

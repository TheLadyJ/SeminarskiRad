using Microsoft.SqlServer.Server;
using Project.Common.Domain;
using Project.Server.SystemOperations;
using Project.Server.SystemOperations.KeteringFirmaSO;
using Project.Server.SystemOperations.KeteringMeniSO;
using Project.Server.SystemOperations.KlijentSO;
using Project.Server.SystemOperations.MestoSO;
using Project.Server.SystemOperations.RadnikSO;
using Project.Server.SystemOperations.RezervacijaSO;
using Project.Server.SystemOperations.RezervisanStoSO;
using Project.Server.SystemOperations.StoSO;
using Project.Server.SystemOperations.TipProslaveSO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.ApplicationLogic
{
    public class Controller
    {

        private static Controller instance;
        private Controller()
        {
        }

        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            }
        }

        public Radnik PrijaviRadnika(Radnik radnik)
        {
            try
            {
                SystemOperationBase so = new PrijaviRadnikaSO(radnik);
                so.ExecuteTemplate();
                return (Radnik)so.Result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void KreirajKlijenta(Klijent klijent)
        {
			try
			{
				SystemOperationBase so = new KreirajKlijentaSO(klijent);
				so.ExecuteTemplate();
			}
			catch (Exception)
			{
				throw;
			}
		}

		public List<Klijent> VratiSveKlijente()
		{
			try
			{
				SystemOperationBase so = new VratiSveKlijenteSO();
				so.ExecuteTemplate();
                return (List<Klijent>)so.Result;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public List<Klijent> PretraziKlijenta(string kriterijum)
		{
			try
			{
				SystemOperationBase so = new PretraziKlijentaSO(kriterijum);
				so.ExecuteTemplate();
				return (List<Klijent>)so.Result;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public void ObrisiKlijenta(Klijent klijent)
		{
			try
			{
				SystemOperationBase so = new ObrisiKlijentaSO(klijent);
				so.ExecuteTemplate();
			}
			catch (Exception)
			{
				throw;
			}
		}

		public void UnesiSto(Sto sto)
		{
			try
			{
				SystemOperationBase so = new UnesiStoSO(sto);
				so.ExecuteTemplate();
			}
			catch (Exception)
			{
				throw;
			}
		}

		public List<Proizvodjac> VratiProizvodjace()
		{
			try
			{
				SystemOperationBase so = new VratiProizvodjaceSO();
				so.ExecuteTemplate();
				return (List<Proizvodjac>)so.Result;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public List<Sto> VratiSveStolove()
		{
			try
			{
				SystemOperationBase so = new VratiSveStoloveSO();
				so.ExecuteTemplate();
				return (List<Sto>)so.Result;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public List<Sto> PretraziSto(string kriterijum)
		{
			try
			{
				SystemOperationBase so = new PretraziStoSO(kriterijum);
				so.ExecuteTemplate();
				return (List<Sto>)so.Result;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public void ObrisiSto(Sto sto)
		{
			try
			{
				SystemOperationBase so = new ObrisiStoSO(sto);
				so.ExecuteTemplate();
			}
			catch (Exception)
			{
				throw;
			}
		}

		public List<Mesto> VratiSvaMesta()
		{
			try
			{
				SystemOperationBase so = new VratiSvaMestaSO();
				so.ExecuteTemplate();
				return (List<Mesto>)so.Result;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public List<TipProslave> VratiSveTipoveProslave()
		{
			try
			{
				SystemOperationBase so = new VratiSveTipoveProslaveSO();
				so.ExecuteTemplate();
				return (List<TipProslave>)so.Result;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public List<KeteringFirma> VratiSveKeteringFirme()
		{
			try
			{
				SystemOperationBase so = new VratiSveKeteringFirmeSO();
				so.ExecuteTemplate();
				return (List<KeteringFirma>)so.Result;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public List<KeteringMeni> VratiMenijeFirme(KeteringFirma firma)
		{
			try
			{
				SystemOperationBase so = new VratiMenijeFirmeSO(firma);
				so.ExecuteTemplate();
				return (List<KeteringMeni>)so.Result;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public void KreirajRezervaciju(Rezervacija rezervacija)
		{
			try
			{
				SystemOperationBase so = new KreirajRezervacijuSO(rezervacija);
				so.ExecuteTemplate();				
			}
			catch (Exception)
			{
				throw;
			}
		}

		public List<Rezervacija> VratiSveRezervacije()
		{
			try
			{
				SystemOperationBase so = new VratiSveRezervacijeSO();
				so.ExecuteTemplate();
				return (List<Rezervacija>)so.Result;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public List<Rezervacija> PretraziRezervaciju(string kriterijum)
		{
			try
			{
				SystemOperationBase so = new PretraziRezervacijuSO(kriterijum);
				so.ExecuteTemplate();
				return (List<Rezervacija>)so.Result;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public List<RezervisanSto> VratiStoloveRezervacije(Rezervacija rezervacija)
		{
			try
			{
				SystemOperationBase so = new VratiStoloveRezervacijeSO(rezervacija);
				so.ExecuteTemplate();
				return (List<RezervisanSto>)so.Result;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public void IzmeniRezervaciju(Rezervacija rezervacija)
		{
			try
			{
				SystemOperationBase so = new IzmeniRezervacijuSO(rezervacija);
				so.ExecuteTemplate();
			}
			catch (Exception)
			{
				throw;
			}
		}

		public void ObrisiRezervaciju(Rezervacija rezervacija)
		{
			try
			{
				SystemOperationBase so = new ObrisiRezervacijuSO(rezervacija);
				so.ExecuteTemplate();
			}
			catch (Exception)
			{
				throw;
			}
		}

		public bool ProveraCuvanjaRezervacije(Rezervacija rezervacija)
		{
			try
			{
				SystemOperationBase so = new ProveraCuvanjaRezervacijeSO(rezervacija);
				so.ExecuteTemplate();
				return (bool)so.Result;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public bool ProveriBrisanjeKlijenta(Klijent klijent)
		{
			try
			{
				SystemOperationBase so = new ProveriBrisanjeKlijentaSO(klijent);
				so.ExecuteTemplate();
				return (bool)so.Result;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public bool ProveriBrisanjeStola(Sto sto)
		{
			try
			{
				SystemOperationBase so = new ProveriBrisanjeStolaSO(sto);
				so.ExecuteTemplate();
				return (bool)so.Result;
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}

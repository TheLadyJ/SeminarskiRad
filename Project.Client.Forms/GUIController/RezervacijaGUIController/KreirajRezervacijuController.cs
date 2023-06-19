using Project.Client.Forms.Exceptions;
using Project.Client.Forms.ServerCommunication;
using Project.Client.Forms.Session;
using Project.Client.Forms.UserControls.UCRezervacija;
using Project.Common.Communication;
using Project.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Client.Forms.GUIController.RezervacijaGUIController
{
	public class KreirajRezervacijuController
	{
		private Rezervacija rezervacija;
		private UCKreirajNovuRezervaciju uCKreirajNovuRezervaciju;

		public KreirajRezervacijuController(UCKreirajNovuRezervaciju uCKreirajNovuRezervaciju)
		{
			this.uCKreirajNovuRezervaciju = uCKreirajNovuRezervaciju;
		}

		internal void KreirajRezervaciju()
		{
			if (ValidanUnosRezervacije())
			{
				UnesiPodatkeORezervaciji();

				if(MoguceCuvanjeRezervacije())
					SacuvajRezervaciju();
			}
		}

		private bool MoguceCuvanjeRezervacije()
		{
			try
			{
				Response response = Communication.Instance.SendRequestGetResponse(Operation.ProveraCuvanjaRezervacije, rezervacija);
				if ((bool)response.Result)
				{
					return true;
				}
				else
				{
					MessageBox.Show(response.Message);
					return false;
				}
			}
			catch (SystemOperationException e)
			{
				MessageBox.Show(e.Message);
				return false;
			}
		}

		private void SacuvajRezervaciju()
		{
			try
			{
				Response response = Communication.Instance.SendRequestGetResponse(Operation.KreirajRezervaciju, rezervacija);
				MessageBox.Show(response.Message);
			}
			catch (SystemOperationException e)
			{
				MessageBox.Show(e.Message);
			}
		}

		private bool ValidanUnosRezervacije()
		{
			bool valid = true;
			string message ="";

			if (uCKreirajNovuRezervaciju.UcRadSaRezervacijom.CbKlijent.SelectedItem == null)
			{
				message += "Rezervacija mora da sadrži klijenta na koga se ona odnosi.\n";
				valid = false;
			}

			if (uCKreirajNovuRezervaciju.UcRadSaRezervacijom.CbMesto.SelectedItem == null)
			{
				message += "Rezervacija mora da sadrži mesto.\n";
				valid = false;
			}

			if (uCKreirajNovuRezervaciju.UcRadSaRezervacijom.CbTipProslave.SelectedItem == null)
			{
				message += "Rezervacija mora da sadrži tip proslave.\n";
				valid = false;
			}

			if (uCKreirajNovuRezervaciju.UcRadSaRezervacijom.RezervisaniStolovi.Count == 0)
			{
				message += "Rezervacija mora da sadrži barem jedan sto u listi rezervisanih stolova.\n";
				valid = false;
			}

			if (String.IsNullOrEmpty(uCKreirajNovuRezervaciju.UcRadSaRezervacijom.LblKeteringMeniVrednost.Text))
			{
				message += "Rezervacija mora da sadrži ketering meni.\n";
				valid = false;
			}

			if(uCKreirajNovuRezervaciju.UcRadSaRezervacijom.DtpDatum.Value == null)
			{
				message += "Rezervacija mora da sadrži datum.\n";
				valid = false;
			}

			bool vremeOdFormat = TimeSpan.TryParseExact(uCKreirajNovuRezervaciju.UcRadSaRezervacijom.TxtVremeOd.Text, "hh\\:mm", null, System.Globalization.TimeSpanStyles.None, out TimeSpan vremeOd);
			bool vremeDoFormat = TimeSpan.TryParseExact(uCKreirajNovuRezervaciju.UcRadSaRezervacijom.TxtVremeDo.Text, "hh\\:mm", null, System.Globalization.TimeSpanStyles.None, out TimeSpan vremeDo);
			if (!vremeOdFormat)
			{
				message += "Vreme od nije u validnom formatu.\n";
				valid = false;
			}
			if (!vremeDoFormat)
			{
				message += "Vreme do nije u validnom formatu.\n";
				valid = false;
			}

			if((vremeOdFormat && vremeDoFormat) && vremeOd >= vremeDo)
			{
				message += "Vreme do mora biti posle vremena od.\n";
				valid = false;
			}

			if (!Double.TryParse(uCKreirajNovuRezervaciju.UcRadSaRezervacijom.LblUkupnaCenaVrednost.Text, out double res))
			{
				message += "Greška prilikom konvertovanja ukupne cene u numeričku vrednost.\n";
				valid = false;
			}

			if (!valid) MessageBox.Show(message);
			return valid;
		}

		private void UnesiPodatkeORezervaciji()
		{
			DateTime DatumVremeOd = uCKreirajNovuRezervaciju.UcRadSaRezervacijom.DtpDatum.Value.Date;
			DatumVremeOd = DatumVremeOd.Add(TimeSpan.ParseExact(uCKreirajNovuRezervaciju.UcRadSaRezervacijom.TxtVremeOd.Text, "hh\\:mm", null));

			DateTime DatumVremeDo = uCKreirajNovuRezervaciju.UcRadSaRezervacijom.DtpDatum.Value.Date;
			DatumVremeDo=DatumVremeDo.Add(TimeSpan.ParseExact(uCKreirajNovuRezervaciju.UcRadSaRezervacijom.TxtVremeDo.Text, "hh\\:mm", null));
			
			rezervacija = new Rezervacija
			{
				Radnik = SessionData.Instance.Radnik,
				Klijent = (Klijent)uCKreirajNovuRezervaciju.UcRadSaRezervacijom.CbKlijent.SelectedItem,
				TipProslave = (TipProslave)uCKreirajNovuRezervaciju.UcRadSaRezervacijom.CbTipProslave.SelectedItem,
				DatumVremeOd = DatumVremeOd,
				DatumVremeDo = DatumVremeDo,
				UkupnaCena = Double.Parse(uCKreirajNovuRezervaciju.UcRadSaRezervacijom.LblUkupnaCenaVrednost.Text),
				Mesto = (Mesto)uCKreirajNovuRezervaciju.UcRadSaRezervacijom.CbMesto.SelectedItem,
				KeteringMeni = uCKreirajNovuRezervaciju.UcRadSaRezervacijom.IzabraniMeni,
				RezervisaniStolovi = uCKreirajNovuRezervaciju.UcRadSaRezervacijom.RezervisaniStolovi
			};
		}

		

	}
}

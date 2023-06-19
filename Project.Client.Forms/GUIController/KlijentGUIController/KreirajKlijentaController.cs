using Project.Client.Forms.Exceptions;
using Project.Client.Forms.ServerCommunication;
using Project.Client.Forms.UserControls.UCKlijent;
using Project.Common.Communication;
using Project.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project.Client.Forms.GUIController.KlijentGUIController
{
	public class KreirajKlijentaController
	{
		private UCKreirajNovogKlijenta uCKreirajNovogKlijenta;
		private Klijent Klijent;

		public KreirajKlijentaController(UCKreirajNovogKlijenta uCKreirajNovogKlijenta)
		{
			this.uCKreirajNovogKlijenta = uCKreirajNovogKlijenta;
		}

		public void KreirajKlijenta()
		{
			if (!ValidanUnos())
				return;

			UcitajPodatkeKlijenta();

			try
			{
				Response response = Communication.Instance.SendRequestGetResponse(Operation.KreirajKlijenta, Klijent);
				MessageBox.Show(response.Message);
			}
			catch (SystemOperationException e)
			{
				MessageBox.Show(e.Message);
			}
		}

		private bool ValidanUnos()
		{
			bool valid = true;
			string message = "";

			bool nijeUnetoIme = String.IsNullOrEmpty(uCKreirajNovogKlijenta.TxtIme.Text);
			bool nijeUnetoPrezime = String.IsNullOrEmpty(uCKreirajNovogKlijenta.TxtPrezime.Text);
			bool nijeUnetTelefon = String.IsNullOrEmpty(uCKreirajNovogKlijenta.TxtTelefon.Text);
			bool nijeUnetEmail = String.IsNullOrEmpty(uCKreirajNovogKlijenta.TxtEmail.Text);

			if(nijeUnetoIme || nijeUnetoPrezime || nijeUnetTelefon || nijeUnetEmail)
			{
				message += "Sva polja moraju biti popunjena!";
				valid = false;
			}

			if (!uCKreirajNovogKlijenta.TxtIme.Text.All(Char.IsLetter)){
				message += "Ime može da sadrži samo slova.";
				valid = false;
			}

			if (!uCKreirajNovogKlijenta.TxtPrezime.Text.All(Char.IsLetter))
			{
				message += "Prezime može da sadrži samo slova.";
				valid = false;
			}

			bool validanEmail = Regex.IsMatch(uCKreirajNovogKlijenta.TxtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
			if (!validanEmail)
			{
				message += "Email nije u validnom formatu.";
				valid = false;
			}

			if (!valid) MessageBox.Show(message);

			return valid;
		}

		private void UcitajPodatkeKlijenta()
		{
			Klijent = new Klijent
			{
				Ime = uCKreirajNovogKlijenta.TxtIme.Text,
				Prezime = uCKreirajNovogKlijenta.TxtPrezime.Text,
				Telefon = uCKreirajNovogKlijenta.TxtTelefon.Text,
				Email = uCKreirajNovogKlijenta.TxtEmail.Text,
			};

		}
	}
}

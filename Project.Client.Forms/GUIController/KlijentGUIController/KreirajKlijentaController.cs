using Project.Client.Forms.Exceptions;
using Project.Client.Forms.ServerCommunication;
using Project.Client.Forms.UserControls.UCKlijent;
using Project.Common.Communication;
using Project.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
			Klijent = new Klijent
			{
				Ime = uCKreirajNovogKlijenta.TxtIme.Text,
				Prezime = uCKreirajNovogKlijenta.TxtPrezime.Text,
				Telefon = uCKreirajNovogKlijenta.TxtTelefon.Text,
				Email = uCKreirajNovogKlijenta.TxtEmail.Text,
			};

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
	}
}

using Project.Client.Forms.Dialogs;
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
	public class PretraziRezervacijuZaBrisanjeController
	{
		private UCPretraziRezervacijuZaBrisanje uCPretraziRezervacijuZaBrisanje;
		private Rezervacija rezervacijaZaBrisanje = new Rezervacija();


		public PretraziRezervacijuZaBrisanjeController(UCPretraziRezervacijuZaBrisanje uCPretraziRezervacijuZaBrisanje)
		{
			this.uCPretraziRezervacijuZaBrisanje = uCPretraziRezervacijuZaBrisanje;
		}

		internal void ObrisiRezervaciju()
		{
			if (uCPretraziRezervacijuZaBrisanje.UcPretragaRezervacija.DgvRezervacije.SelectedRows.Count == 0)
			{
				MessageBox.Show("Morate izabrati neku rezervaciju za brisanje.");
				return;
			}
			if (uCPretraziRezervacijuZaBrisanje.UcPretragaRezervacija.DgvRezervacije.SelectedRows.Count > 1)
			{
				MessageBox.Show("Možete izabrati samo jednu rezervaciju za brisanje.");
				return;
			}

			rezervacijaZaBrisanje = (Rezervacija)uCPretraziRezervacijuZaBrisanje.UcPretragaRezervacija.DgvRezervacije.SelectedRows[0].DataBoundItem;
			if (rezervacijaZaBrisanje.Radnik.RadnikID != SessionData.Instance.Radnik.RadnikID)
			{
				MessageBox.Show("Rezervaciju nije moguće obrisati jer je niste vi kreirali.");
				return;
			}
			UcitajStoloveRezervacije();
			ObrisiOdabranuRezervaciju();
			uCPretraziRezervacijuZaBrisanje.UcPretragaRezervacija.PretragaRezervacijaController.UcitajSveRezervacije();
		}
		private void UcitajStoloveRezervacije()
		{
			try
			{
				Response response = Communication.Instance.SendRequestGetResponse(Operation.VratiStoloveRezervacije, rezervacijaZaBrisanje);
				rezervacijaZaBrisanje.RezervisaniStolovi = (List<RezervisanSto>)response.Result;
			}
			catch (SystemOperationException e)
			{
				MessageBox.Show(e.Message);
			}
		}

		private void ObrisiOdabranuRezervaciju()
		{
			try
			{
				Response response = Communication.Instance.SendRequestGetResponse(Operation.ObrisiRezervaciju, rezervacijaZaBrisanje);
				MessageBox.Show(response.Message);
			}
			catch (SystemOperationException e)
			{
				MessageBox.Show(e.Message);
			}
		}

	}

}

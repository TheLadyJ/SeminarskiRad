using Project.Client.Forms.Dialogs;
using Project.Client.Forms.Session;
using Project.Client.Forms.UserControls.UCRezervacija;
using Project.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Client.Forms.GUIController.RezervacijaGUIController
{
	public class PretraziRezervacijuZaIzmenuController
	{
		private UCPretraziRezervacijuZaIzmenu uCPretraziRezervacijuZaIzmenu;

		public PretraziRezervacijuZaIzmenuController(UCPretraziRezervacijuZaIzmenu uCPretraziRezervacijuZaIzmenu)
		{
			this.uCPretraziRezervacijuZaIzmenu = uCPretraziRezervacijuZaIzmenu;
		}

		internal void IzmeniRezervaciju()
		{
			if(uCPretraziRezervacijuZaIzmenu.UcPretragaRezervacija.DgvRezervacije.SelectedRows.Count == 0)
			{
				MessageBox.Show("Morate izabrati neku rezervaciju za izmenu.");
				return;
			}
			if (uCPretraziRezervacijuZaIzmenu.UcPretragaRezervacija.DgvRezervacije.SelectedRows.Count > 1)
			{
				MessageBox.Show("Možete izabrati samo jednu rezervaciju za izmenu.");
				return;
			}

			SessionData.Instance.Rezervacija = (Rezervacija)uCPretraziRezervacijuZaIzmenu.UcPretragaRezervacija.DgvRezervacije.SelectedRows[0].DataBoundItem;
			FrmIzmeniRezervaciju frmIzmeniRezervaciju = new FrmIzmeniRezervaciju();
			frmIzmeniRezervaciju.ShowDialog();
			SessionData.Instance.Rezervacija = new Rezervacija();

			uCPretraziRezervacijuZaIzmenu.UcPretragaRezervacija.PretragaRezervacijaController.UcitajSveRezervacije();
		}
	}
}

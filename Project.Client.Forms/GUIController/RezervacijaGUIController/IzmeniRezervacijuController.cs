using Project.Client.Forms.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Client.Forms.GUIController.RezervacijaGUIController
{
	public class IzmeniRezervacijuController
	{
		private FrmIzmeniRezervaciju frmIzmeniRezervaciju;

		public IzmeniRezervacijuController(FrmIzmeniRezervaciju frmIzmeniRezervaciju)
		{
			this.frmIzmeniRezervaciju = frmIzmeniRezervaciju;			
		}

		internal void UcitajRezervaciju()
		{
			frmIzmeniRezervaciju.UcIzmeniRezervaciju.UcRadSaRezervacijom.LblRadnikVrednost.Text = frmIzmeniRezervaciju.Rezervacija.Radnik.ToString();
		}
	}
}

using Project.Client.Forms.Exceptions;
using Project.Client.Forms.ServerCommunication;
using Project.Client.Forms.UserControls.UCSto;
using Project.Common.Communication;
using Project.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Client.Forms.GUIController.StoGUIController
{
	public class UnseiNoviStoController
	{

		private Sto sto;
		private UCUnesiNoviSto uCUnesiNoviSto;

		public UnseiNoviStoController(UCUnesiNoviSto uCUnesiNoviSto)
		{
			this.uCUnesiNoviSto = uCUnesiNoviSto;
		}

		internal void UcitajProizvodjace()
		{
			try
			{
				Response response = Communication.Instance.SendRequestGetResponse(Operation.VratiProizvodjace);
				uCUnesiNoviSto.CbProizvodjac.DataSource = (List<Proizvodjac>)response.Result;
			}
			catch (SystemOperationException e)
			{
				MessageBox.Show(e.Message);
			}
		}

		internal void UnesiNoviSto()
		{
			if (ValidanUnos())
			{
				KreirajSto();

				try
				{
					Response response = Communication.Instance.SendRequestGetResponse(Operation.UnesiSto, sto);
					MessageBox.Show(response.Message);

				}
				catch (SystemOperationException e)
				{
					MessageBox.Show(e.Message);
				}
			}
		}

		private bool ValidanUnos()
		{
			bool valid = true;
			string message = "";

			bool validKapacitet = Int32.TryParse(uCUnesiNoviSto.TxtKapacitet.Text, out int kapacitet);
			
			if(!validKapacitet)
			{ 
				message += "Kapacitet nije u validnom formatu.\n";
				valid = false;
			}
			else if (kapacitet < 0)
			{
				message += "Kapacitet mora biti nenegativan celi broj.\n";
				valid = false;
			}

			bool validCenaStola = Double.TryParse(uCUnesiNoviSto.TxtCenaStola.Text, out double cenaStola);

			if (!validCenaStola)
			{
				message += "Cena sto;la nije u validnom formatu.\n";
				valid = false;
			}
			else if (cenaStola < 0)
			{
				message += "Cena sto;la mora biti nenegativan broj.\n";
				valid = false;
			}

			if (uCUnesiNoviSto.CbProizvodjac.SelectedItem == null)
			{
				message += "Morate izabrati nekog proizvođača.\n";
				valid = false;
			}

			if (!valid) MessageBox.Show(message);

			return valid;
		}
	
		private void KreirajSto()
		{
			sto = new Sto
			{
				Proizvodjac = (Proizvodjac)uCUnesiNoviSto.CbProizvodjac.SelectedItem,
				Kapacitet = Int32.Parse(uCUnesiNoviSto.TxtKapacitet.Text),
				CenaStola = Double.Parse(uCUnesiNoviSto.TxtCenaStola.Text)
			};
		}

		
	}
}

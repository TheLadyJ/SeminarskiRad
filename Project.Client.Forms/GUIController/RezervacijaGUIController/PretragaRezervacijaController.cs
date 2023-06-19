using Project.Client.Forms.Exceptions;
using Project.Client.Forms.ServerCommunication;
using Project.Client.Forms.UserControls.UCKlijent;
using Project.Client.Forms.UserControls.UCRezervacija;
using Project.Common.Communication;
using Project.Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Client.Forms.GUIController.RezervacijaGUIController
{
	public class PretragaRezervacijaController
	{
		private UCPretragaRezervacija uCPretragaRezervacija;

		public PretragaRezervacijaController(UCPretragaRezervacija uCPretragaRezervacija)
		{
			this.uCPretragaRezervacija = uCPretragaRezervacija;
		}

		#region Ucitavanje DgvRezervacije
		private void SakrijKolone(DataGridView dgv)
		{
			dgv.Columns["RezervacijaID"].Visible = false;
			dgv.Columns["Id"].Visible = false;
			dgv.Columns["TableName"].Visible = false;
			dgv.Columns["InsertValues"].Visible = false;
			dgv.Columns["IdCondition"].Visible = false;
			dgv.Columns["UpdateValues"].Visible = false;
			dgv.Columns["SearchCondition"].Visible = false;
			dgv.Columns["Join"].Visible = false;
		}

		private void UcitajDgvRezervacije(List<Rezervacija> rezervacije = null)
		{
			DataGridView dgv = uCPretragaRezervacija.DgvRezervacije;
			if (rezervacije == null)
				dgv.DataSource = new BindingList<Rezervacija>(new List<Rezervacija>());

			else dgv.DataSource = new BindingList<Rezervacija>(rezervacije);

			SakrijKolone(dgv);
		}

		#endregion

		internal void UcitajSveRezervacije()
		{
			try
			{
				Response response = Communication.Instance.SendRequestGetResponse(Operation.VratiSveRezervacije);
				List<Rezervacija> rezervacije = (List<Rezervacija>)response.Result;
				UcitajDgvRezervacije(rezervacije);

			}
			catch (SystemOperationException e)
			{
				MessageBox.Show(e.Message);
				UcitajDgvRezervacije();
			}
		}

		internal void PretraziRezervaciju()
		{
			try
			{
				string kriterijum = uCPretragaRezervacija.TxtKriterijum.Text;
				Response response = Communication.Instance.SendRequestGetResponse(Operation.PretraziRezervaciju, kriterijum);
				MessageBox.Show(response.Message);
				List<Rezervacija> nadjeneRezervacije = (List<Rezervacija>)response.Result;
				UcitajDgvRezervacije(nadjeneRezervacije);
			}
			catch (SystemOperationException e)
			{
				MessageBox.Show(e.Message);
				UcitajDgvRezervacije();
			}
		}
	}
}

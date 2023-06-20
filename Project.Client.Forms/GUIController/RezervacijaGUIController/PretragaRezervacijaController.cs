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
			dgv.Columns["InsertUpdateDeleteCondition"].Visible = false;
			dgv.Columns["TableName"].Visible = false;
			dgv.Columns["InsertValues"].Visible = false;
			dgv.Columns["IdCondition"].Visible = false;
			dgv.Columns["UpdateValues"].Visible = false;
			dgv.Columns["SearchCondition"].Visible = false;
			dgv.Columns["Join"].Visible = false;
		}

		private void UrediRedosledKolona(DataGridView dgv)
		{
			dgv.Columns["Radnik"].DisplayIndex = 0;
			dgv.Columns["Klijent"].DisplayIndex = 1;
			dgv.Columns["Mesto"].DisplayIndex = 2;
			dgv.Columns["DatumVremeOd"].DisplayIndex = 3;
			dgv.Columns["DatumVremeDo"].DisplayIndex = 4;
			dgv.Columns["TipProslave"].DisplayIndex = 5;
			dgv.Columns["KeteringMeni"].DisplayIndex = 6;
			dgv.Columns["UkupnaCena"].DisplayIndex = 7;
		}
		
		private void UrediNaslovKolona(DataGridView dgv)
		{
			dgv.Columns["TipProslave"].HeaderText = "Tip proslave";
			dgv.Columns["KeteringMeni"].HeaderText = "Ketering meni";
			dgv.Columns["UkupnaCena"].HeaderText = "Ukupna cena";
			dgv.Columns["DatumVremeOd"].HeaderText = "Datum i vreme od";
			dgv.Columns["DatumVremeDo"].HeaderText = "Datum i vreme do";
		}

		private void UrediKoloneDgv(DataGridView dgv)
		{
			SakrijKolone(dgv);
			UrediRedosledKolona(dgv);
			UrediNaslovKolona(dgv);
		}

		private void UcitajDgvRezervacije(List<Rezervacija> rezervacije = null)
		{
			DataGridView dgv = uCPretragaRezervacija.DgvRezervacije;
			if (rezervacije == null)
				dgv.DataSource = new BindingList<Rezervacija>(new List<Rezervacija>());

			else dgv.DataSource = new BindingList<Rezervacija>(rezervacije);

			UrediKoloneDgv(dgv);
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

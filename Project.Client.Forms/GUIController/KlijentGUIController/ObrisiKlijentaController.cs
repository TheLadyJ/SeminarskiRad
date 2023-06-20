using Project.Client.Forms.Exceptions;
using Project.Client.Forms.ServerCommunication;
using Project.Client.Forms.UserControls.UCKlijent;
using Project.Common.Communication;
using Project.Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Client.Forms.GUIController.KlijentGUIController
{
	internal class ObrisiKlijentaController
	{
		private UCObrisiKlijenta uCObrisiKlijenta;
		private Klijent klijent = new Klijent();

		public ObrisiKlijentaController(UCObrisiKlijenta uCObrisiKlijenta)
		{
			this.uCObrisiKlijenta = uCObrisiKlijenta;
		}

		private void SakrijKolone()
		{
			uCObrisiKlijenta.DgvKlijenti.Columns["KlijentID"].Visible = false;
			uCObrisiKlijenta.DgvKlijenti.Columns["Id"].Visible = false;
			uCObrisiKlijenta.DgvKlijenti.Columns["InsertUpdateDeleteCondition"].Visible = false;
			uCObrisiKlijenta.DgvKlijenti.Columns["TableName"].Visible = false;
			uCObrisiKlijenta.DgvKlijenti.Columns["InsertValues"].Visible = false;
			uCObrisiKlijenta.DgvKlijenti.Columns["IdCondition"].Visible = false;
			uCObrisiKlijenta.DgvKlijenti.Columns["UpdateValues"].Visible = false;
			uCObrisiKlijenta.DgvKlijenti.Columns["SearchCondition"].Visible = false;
			uCObrisiKlijenta.DgvKlijenti.Columns["Join"].Visible = false;
		}

		private void UcitajDgvKlijenti(List<Klijent> klijenti = null)
		{
			if (klijenti == null)
				uCObrisiKlijenta.DgvKlijenti.DataSource = new BindingList<Klijent>(new List<Klijent>());

			else uCObrisiKlijenta.DgvKlijenti.DataSource = new BindingList<Klijent>(klijenti);
			
			SakrijKolone();
		}

		internal void UcitajSveKlijente()
		{
			try
			{
				Response response = Communication.Instance.SendRequestGetResponse(Operation.VratiSveKlijente);
				List<Klijent> sviKlijenti = (List <Klijent>)response.Result;
				UcitajDgvKlijenti(sviKlijenti);

			}
			catch (SystemOperationException e)
			{
				MessageBox.Show(e.Message);
				UcitajDgvKlijenti();
			}
		}
		internal void PretraziKlijenta()
		{
			try
			{
				string kriterijum = uCObrisiKlijenta.TxtKriterijum.Text;
				Response response = Communication.Instance.SendRequestGetResponse(Operation.PretraziKlijenta, kriterijum);
				MessageBox.Show(response.Message);
				List<Klijent> nadjeniKlijenti = (List<Klijent>)response.Result;
				UcitajDgvKlijenti(nadjeniKlijenti);
			}
			catch (SystemOperationException e)
			{
				MessageBox.Show(e.Message);
				UcitajDgvKlijenti();
			}
		}

		internal void ObrisiKlijenta()
		{
			if (uCObrisiKlijenta.DgvKlijenti.SelectedRows.Count == 0)
			{
				MessageBox.Show("Morate izabrati nekog klijenta za brisanje.");
			}
			else if (uCObrisiKlijenta.DgvKlijenti.SelectedRows.Count > 1)
			{
				MessageBox.Show("Možete izabrati samo jednog klijenta za brisanje.");
			}
			else
			{
				Klijent klijentZaBrisanje = (Klijent)uCObrisiKlijenta.DgvKlijenti.SelectedRows[0].DataBoundItem;
				if (MoguceBrisanjeKlijenta(klijentZaBrisanje))
					ObrisiOdabranogKlijenta(klijentZaBrisanje);
			}
		}

		private bool MoguceBrisanjeKlijenta(Klijent klijentZaBrisanje)
		{
			try
			{
				Response response = Communication.Instance.SendRequestGetResponse(Operation.ProveriBrisanjeKlijenta, klijentZaBrisanje);
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

		private void ObrisiOdabranogKlijenta(Klijent klijentZaBrisanje)
		{
			try
			{
				Response response = Communication.Instance.SendRequestGetResponse(Operation.ObrisiKlijenta, klijentZaBrisanje);
				MessageBox.Show(response.Message);
			}
			catch (SystemOperationException e)
			{
				MessageBox.Show(e.Message);
			}
			UcitajSveKlijente();

		}

	}
}

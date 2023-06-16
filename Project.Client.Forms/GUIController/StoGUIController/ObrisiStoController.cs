using Project.Client.Forms.Exceptions;
using Project.Client.Forms.ServerCommunication;
using Project.Client.Forms.UserControls.UCKlijent;
using Project.Client.Forms.UserControls.UCSto;
using Project.Common.Communication;
using Project.Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Client.Forms.GUIController.StoGUIController
{
	public class ObrisiStoController
	{
		private UCObrisiSto uCObrisiSto;

		public ObrisiStoController(UCObrisiSto uCObrisiSto)
		{
			this.uCObrisiSto = uCObrisiSto;
		}

		private void SakrijKolone()
		{
			uCObrisiSto.DgvStolovi.Columns["RbStola"].Visible = false;
			uCObrisiSto.DgvStolovi.Columns["CenaStola"].Visible = false;
			uCObrisiSto.DgvStolovi.Columns["TableName"].Visible = false;
			uCObrisiSto.DgvStolovi.Columns["InsertValues"].Visible = false;
			uCObrisiSto.DgvStolovi.Columns["IdCondition"].Visible = false;
			uCObrisiSto.DgvStolovi.Columns["UpdateValues"].Visible = false;
			uCObrisiSto.DgvStolovi.Columns["SearchCondition"].Visible = false;
			uCObrisiSto.DgvStolovi.Columns["Join"].Visible = false;
		}

		private void UcitajDgvStolovi(List<Sto> stolovi = null)
		{
			if (stolovi == null)
				uCObrisiSto.DgvStolovi.DataSource = new BindingList<Sto>(new List<Sto>());

			else uCObrisiSto.DgvStolovi.DataSource = new BindingList<Sto>(stolovi);

			SakrijKolone();
		}

		internal void UcitajSveStolove()
		{
			try
			{
				Response response = Communication.Instance.SendRequestGetResponse(Operation.VratiSveStolove);
				List<Sto> sviStolovi = (List<Sto>)response.Result;
				UcitajDgvStolovi(sviStolovi);

			}
			catch (SystemOperationException e)
			{
				MessageBox.Show(e.Message);
				UcitajDgvStolovi();
			}
		}

		internal void PretraziSto()
		{
			try
			{
				string kriterijum = uCObrisiSto.TxtKriterijum.Text;
				Response response = Communication.Instance.SendRequestGetResponse(Operation.PretraziSto, kriterijum);
				MessageBox.Show(response.Message);
				List<Sto> nadjeniStolovi = (List<Sto>)response.Result;
				UcitajDgvStolovi(nadjeniStolovi);
			}
			catch (SystemOperationException e)
			{
				MessageBox.Show(e.Message);
				UcitajDgvStolovi();
			}
		}

		internal void ObrisiSto()
		{
			if (uCObrisiSto.DgvStolovi.SelectedRows.Count == 0)
			{
				MessageBox.Show("Morate izabrati neki sto za brisanje.");
			}
			else if (uCObrisiSto.DgvStolovi.SelectedRows.Count > 1)
			{
				MessageBox.Show("Možete izabrati samo jedan sto za brisanje.");
			}
			else
			{
				Sto StoZaBrisanje = (Sto)uCObrisiSto.DgvStolovi.SelectedRows[0].DataBoundItem;
				ObrisiOdabraniSto(StoZaBrisanje);
			}
		}

		private void ObrisiOdabraniSto(Sto StoZaBrisanje)
		{
			try
			{
				Response response = Communication.Instance.SendRequestGetResponse(Operation.ObrisiSto, StoZaBrisanje);
				MessageBox.Show(response.Message);
			}
			catch (SystemOperationException e)
			{
				MessageBox.Show(e.Message);
			}
			UcitajSveStolove();
		}
	}
}

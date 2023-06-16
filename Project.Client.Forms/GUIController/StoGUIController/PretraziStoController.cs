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
	public class PretraziStoController
	{
		private UCPretraziSto uCPretraziSto;

		public PretraziStoController(UCPretraziSto uCPretraziSto)
		{
			this.uCPretraziSto = uCPretraziSto;
		}

		private void SakrijKolone()
		{
			uCPretraziSto.DgvStolovi.Columns["StoID"].Visible = false;
			uCPretraziSto.DgvStolovi.Columns["CenaStola"].Visible = false;
			uCPretraziSto.DgvStolovi.Columns["TableName"].Visible = false;
			uCPretraziSto.DgvStolovi.Columns["InsertValues"].Visible = false;
			uCPretraziSto.DgvStolovi.Columns["IdCondition"].Visible = false;
			uCPretraziSto.DgvStolovi.Columns["UpdateValues"].Visible = false;
			uCPretraziSto.DgvStolovi.Columns["SearchCondition"].Visible = false;
			uCPretraziSto.DgvStolovi.Columns["Join"].Visible = false;
		}

		private void UcitajDgvStolovi(List<Sto> stolovi = null)
		{
			if (stolovi == null)
				uCPretraziSto.DgvStolovi.DataSource = new BindingList<Sto>(new List<Sto>());

			else uCPretraziSto.DgvStolovi.DataSource = new BindingList<Sto>(stolovi);

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
				string kriterijum = uCPretraziSto.TxtKriterijum.Text;
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


		internal void PrikaziDetalje()
		{
			if (uCPretraziSto.DgvStolovi.SelectedRows.Count == 0)
			{
				MessageBox.Show("Morate izabrati neki sto za prikaz njegovih detalja.");
			}
			else if (uCPretraziSto.DgvStolovi.SelectedRows.Count > 1)
			{
				MessageBox.Show("Možete izabrati samo jedan sto za prikaz njegovih detalja.");
			}
			else
			{
				Sto StoZaPrikaz = (Sto)uCPretraziSto.DgvStolovi.SelectedRows[0].DataBoundItem;
				PrikaziOdabraniSto(StoZaPrikaz);
			}
		}

		private void PrikaziOdabraniSto(Sto stoZaPrikaz)
		{
			try
			{
				uCPretraziSto.LblCenaStolaPrikaziVrednost.Text = stoZaPrikaz.CenaStola.ToString();
				uCPretraziSto.LblKapacitetPrikaziVrednost.Text = stoZaPrikaz.Kapacitet.ToString();
				uCPretraziSto.LblProizvodjacPrikaziVrednost.Text = stoZaPrikaz.Proizvodjac.ToString();

				MessageBox.Show("Sistem je učitao sto.");
			}
			catch (Exception)
			{
				MessageBox.Show("Sistem ne može da učita podatke o stolu.");
			}
		}
	}
}

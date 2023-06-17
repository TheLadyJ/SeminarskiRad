using Project.Client.Forms.Dialogs;
using Project.Client.Forms.Exceptions;
using Project.Client.Forms.ServerCommunication;
using Project.Client.Forms.UserControls.UCKlijent;
using Project.Client.Forms.UserControls.UCRezervacija;
using Project.Common.Communication;
using Project.Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Client.Forms.GUIController.RezervacijaGUIController
{
	public class RadSaRezervacijomController
	{
		private UCRadSaRezervacijom uCRadSaRezervacijom;
		private List<RezervisanSto> rezervisaniStolovi = new List<RezervisanSto>();

		public RadSaRezervacijomController(UCRadSaRezervacijom uCRadSaRezervacijom)
		{
			this.uCRadSaRezervacijom = uCRadSaRezervacijom;
		}

		#region Ucitavanje ComboBox Polja
		internal void UcitajSvaComboBoxPolja()
		{
			UcitajStolove();
			UcitajKlijetne();
			UcitajMesta();
			UcitajTipoveProslave();
		}

		private void UcitajListuComboBoxa(Operation op, ComboBox comboBox) 
		{
			try
			{
				Response response = Communication.Instance.SendRequestGetResponse(op);
				comboBox.DataSource = response.Result;
			}
			catch (SystemOperationException e)
			{
				MessageBox.Show(e.Message);
			}
		}

		private void UcitajStolove()
		{
			UcitajListuComboBoxa(Operation.VratiSveStolove, uCRadSaRezervacijom.CbStolovi);
		}

		internal void UcitajKlijetne()
		{
			UcitajListuComboBoxa(Operation.VratiSveKlijente, uCRadSaRezervacijom.CbKlijent);
		}

		private void UcitajMesta()
		{
			UcitajListuComboBoxa(Operation.VratiSvaMesta, uCRadSaRezervacijom.CbMesto);
		}

		private void UcitajTipoveProslave()
		{
			UcitajListuComboBoxa(Operation.VratiSveTipoveProslave, uCRadSaRezervacijom.CbTipProslave);
		}

		#endregion

		#region Ucitavanje DgvStolovi
		private void SakrijKolone(DataGridView dgv)
		{
			dgv.Columns["Rezervacija"].Visible = false;
			dgv.Columns["TableName"].Visible = false;
			dgv.Columns["InsertValues"].Visible = false;
			dgv.Columns["IdCondition"].Visible = false;
			dgv.Columns["UpdateValues"].Visible = false;
			dgv.Columns["SearchCondition"].Visible = false;
			dgv.Columns["Join"].Visible = false;
		}

		private void UcitajDgvStolovi(List<RezervisanSto> rezStolovi = null)
		{
			DataGridView dgv = uCRadSaRezervacijom.DgvStolovi;
			if (rezStolovi == null)
				dgv.DataSource = new BindingList<RezervisanSto>(new List<RezervisanSto>());

			else dgv.DataSource = new BindingList<RezervisanSto>(rezStolovi);

			SakrijKolone(dgv);
		}

		#endregion

		internal void DodajSto()
		{
			if(uCRadSaRezervacijom.CbStolovi.SelectedItem == null)
			{
				MessageBox.Show("Morate izabrati neki sto za dodavanje u listu.");
				return;
			}
			rezervisaniStolovi.Add(new RezervisanSto
			{
				Sto = (Sto)uCRadSaRezervacijom.CbStolovi.SelectedItem,
				RbStola = rezervisaniStolovi.Count+1
			});
			UcitajDgvStolovi(rezervisaniStolovi);
		}

		internal void ObrisiStolove()
		{
			if (uCRadSaRezervacijom.DgvStolovi.SelectedRows.Count == 0)
			{
				MessageBox.Show("Morate izabrati barem jedan sto za brisanje.");
				return;
			}

			IzbrisiOdabraneStolove();

			AzurirajRedneBrojeve();

			UcitajDgvStolovi(rezervisaniStolovi);
		}

		private void IzbrisiOdabraneStolove()
		{
			for (int i = uCRadSaRezervacijom.DgvStolovi.SelectedRows.Count - 1; i >= 0; i--)
			{
				RezervisanSto rezStoZaBrisanje = (RezervisanSto)uCRadSaRezervacijom.DgvStolovi.SelectedRows[i].DataBoundItem;
				rezervisaniStolovi.Remove(rezStoZaBrisanje);
			}
		}

		private void AzurirajRedneBrojeve()
		{
			for (int i = 1; i <= rezervisaniStolovi.Count; i++)
			{
				rezervisaniStolovi[i - 1].RbStola = i;
			}
		}

		internal void IzaberiKeteringMeni()
		{
			FrmIzaberiKeteringMeni frmIzaberiKeteringMeni = new FrmIzaberiKeteringMeni();
			frmIzaberiKeteringMeni.ShowDialog();
		}

	}
}

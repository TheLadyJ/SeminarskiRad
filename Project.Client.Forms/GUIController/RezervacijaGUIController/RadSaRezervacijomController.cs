using Project.Client.Forms.Dialogs;
using Project.Client.Forms.Exceptions;
using Project.Client.Forms.ServerCommunication;
using Project.Client.Forms.Session;
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
		private UCRadSaRezervacijom uCRadSaRezervacijom = new UCRadSaRezervacijom();

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
			dgv.Columns["RbStola"].Visible = false;
			dgv.Columns["Id"].Visible = false;
			dgv.Columns["TableName"].Visible = false;
			dgv.Columns["InsertValues"].Visible = false;
			dgv.Columns["IdCondition"].Visible = false;
			dgv.Columns["UpdateValues"].Visible = false;
			dgv.Columns["SearchCondition"].Visible = false;
			dgv.Columns["Join"].Visible = false;
		}

		private void UcitajDgvStolovi(List<Sto> stoloviRezervacije = null)
		{
			DataGridView dgv = uCRadSaRezervacijom.DgvStolovi;
			if (stoloviRezervacije == null)
				dgv.DataSource = new BindingList<Sto>(new List<Sto>());

			else dgv.DataSource = new BindingList<Sto>(stoloviRezervacije);

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
			uCRadSaRezervacijom.StoloviRezervacije.Add((Sto)uCRadSaRezervacijom.CbStolovi.SelectedItem);
			UcitajDgvStolovi(uCRadSaRezervacijom.StoloviRezervacije);
		}

		internal void ObrisiStolove()
		{
			if (uCRadSaRezervacijom.DgvStolovi.SelectedRows.Count == 0)
			{
				MessageBox.Show("Morate izabrati barem jedan sto za brisanje.");
				return;
			}

			IzbrisiOdabraneStolove();

			UcitajDgvStolovi(uCRadSaRezervacijom.StoloviRezervacije);
		}

		private void IzbrisiOdabraneStolove()
		{
			for (int i = uCRadSaRezervacijom.DgvStolovi.SelectedRows.Count - 1; i >= 0; i--)
			{
				Sto stoZaBrisanje = (Sto)uCRadSaRezervacijom.DgvStolovi.SelectedRows[i].DataBoundItem;
				uCRadSaRezervacijom.StoloviRezervacije.Remove(stoZaBrisanje);
			}
		}

		internal void IzaberiKeteringMeni()
		{
			FrmIzaberiKeteringMeni frmIzaberiKeteringMeni = new FrmIzaberiKeteringMeni();
			frmIzaberiKeteringMeni.ShowDialog();
			if (frmIzaberiKeteringMeni.DialogResult == DialogResult.OK)
			{
				uCRadSaRezervacijom.IzabraniMeni = frmIzaberiKeteringMeni.IzabraniMeni;
				uCRadSaRezervacijom.LblKeteringMeniVrednost.Text = uCRadSaRezervacijom.IzabraniMeni.ToString();
			}
		}

		internal void AzurirajUkupnuCenu()
		{
			if (String.IsNullOrEmpty(uCRadSaRezervacijom.LblKeteringMeniVrednost.Text) || uCRadSaRezervacijom.StoloviRezervacije == null || uCRadSaRezervacijom.StoloviRezervacije.Count == 0)
			{
				uCRadSaRezervacijom.LblUkupnaCenaVrednost.Text = "";
				return;
			}

			uCRadSaRezervacijom.LblUkupnaCenaVrednost.Text = IzracunajUkupnuCenu().ToString();
		}

		private double IzracunajUkupnuCenu()
		{
			double cenaSvihStolova = 0;
			int brojSvihLjudi = 0;

			uCRadSaRezervacijom.StoloviRezervacije.ForEach(sto =>
			{
				cenaSvihStolova += sto.CenaStola;
				brojSvihLjudi += sto.Kapacitet;
			});

			return cenaSvihStolova + uCRadSaRezervacijom.IzabraniMeni.CenaHranePoOsobi * brojSvihLjudi;
		}

		internal void UcitajImeRadnika()
		{
			uCRadSaRezervacijom.LblRadnikVrednost.Text = SessionData.Instance.Radnik.ToString();
		}
	}
}

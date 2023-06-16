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
	public class PretraziKlijentaController
	{
		private UCPretraziKlijetnta uCPretraziKlijetnta;
		private Klijent klijent = new Klijent();

		public PretraziKlijentaController(UCPretraziKlijetnta uCPretraziKlijetnta)
		{
			this.uCPretraziKlijetnta = uCPretraziKlijetnta;
			DodajCheckBoxITextBoxHandlers();
		}

		private void SakrijKolone()
		{
			uCPretraziKlijetnta.DgvKlijenti.Columns["KlijentID"].Visible = false;
			uCPretraziKlijetnta.DgvKlijenti.Columns["Email"].Visible = false;
			uCPretraziKlijetnta.DgvKlijenti.Columns["Telefon"].Visible = false;
			uCPretraziKlijetnta.DgvKlijenti.Columns["TableName"].Visible = false;
			uCPretraziKlijetnta.DgvKlijenti.Columns["InsertValues"].Visible = false;
			uCPretraziKlijetnta.DgvKlijenti.Columns["IdCondition"].Visible = false;
			uCPretraziKlijetnta.DgvKlijenti.Columns["UpdateValues"].Visible = false;
			uCPretraziKlijetnta.DgvKlijenti.Columns["SearchCondition"].Visible = false;
			uCPretraziKlijetnta.DgvKlijenti.Columns["Join"].Visible = false;
		}

		private void UcitajDgvKlijenti(List<Klijent> klijenti = null)
		{
			if (klijenti == null)
				uCPretraziKlijetnta.DgvKlijenti.DataSource = new BindingList<Klijent>(new List<Klijent>());

			else uCPretraziKlijetnta.DgvKlijenti.DataSource = new BindingList<Klijent>(klijenti);

			SakrijKolone();
		}

		internal void UcitajSveKlijente()
		{
			try
			{
				Response response = Communication.Instance.SendRequestGetResponse(Operation.VratiSveKlijente);
				List<Klijent> sviKlijenti = (List<Klijent>)response.Result;
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
				Response response = Communication.Instance.SendRequestGetResponse(Operation.PretraziKlijenta, klijent);
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

		
		internal void PrikaziDetaljno()
		{
			if(uCPretraziKlijetnta.DgvKlijenti.SelectedRows.Count == 0)
			{
				MessageBox.Show("Morate izabrati nekog klijenta za prikaz njegovih detalja.");
			}
			else if(uCPretraziKlijetnta.DgvKlijenti.SelectedRows.Count > 1)
			{
				MessageBox.Show("Možete izabrati samo jednog klijenta za prikaz njegovih detalja.");
			}
			else
			{
				Klijent klijentZaPrikaz = (Klijent)uCPretraziKlijetnta.DgvKlijenti.SelectedRows[0].DataBoundItem;
				PrikaziOdabranogKlijenta(klijentZaPrikaz);
			}
		}

		private void PrikaziOdabranogKlijenta(Klijent klijentZaPrikaz)
		{
			try
			{
				uCPretraziKlijetnta.LblImePrikaziVrednost.Text = klijentZaPrikaz.Ime;
				uCPretraziKlijetnta.LblPrezimePrikaziVrednost.Text = klijentZaPrikaz.Prezime;
				uCPretraziKlijetnta.LblEmailPrikaziVrednost.Text = klijentZaPrikaz.Email;
				uCPretraziKlijetnta.LblTelefonPrikaziVrednost.Text = klijentZaPrikaz.Telefon;

				MessageBox.Show("Sistem je učitao podatke o klijentu.");
			}
			catch (Exception)
			{
				MessageBox.Show("Sistem ne može da učita podatke o klijentu.");
			}
		}

		private void DodajCheckBoxITextBoxHandlers()
		{
			uCPretraziKlijetnta.ChbIme.CheckedChanged += HandleImeCheckedChanged;
			uCPretraziKlijetnta.ChbPrezime.CheckedChanged += HandlePrezimeCheckedChanged;
			uCPretraziKlijetnta.ChbEmail.CheckedChanged += HandleEmailCheckedChanged;
			uCPretraziKlijetnta.ChbTelefon.CheckedChanged += HandleTelefonCheckedChanged;

			uCPretraziKlijetnta.TxtIme.TextChanged += HandleImeCheckedChanged;
			uCPretraziKlijetnta.TxtPrezime.TextChanged += HandlePrezimeCheckedChanged;
			uCPretraziKlijetnta.TxtEmail.TextChanged += HandleEmailCheckedChanged;
			uCPretraziKlijetnta.TxtTelefon.TextChanged += HandleTelefonCheckedChanged;
		}

		internal void HandleImeCheckedChanged(object sender, EventArgs e)
		{
			if (uCPretraziKlijetnta.ChbIme.Checked)
			{
				klijent.Ime = uCPretraziKlijetnta.TxtIme.Text;
			}
			else
			{
				klijent.Ime = null;
			}
		}

		internal void HandlePrezimeCheckedChanged(object sender, EventArgs e)
		{
			if (uCPretraziKlijetnta.ChbPrezime.Checked)
			{
				klijent.Prezime = uCPretraziKlijetnta.TxtPrezime.Text;
			}
			else
			{
				klijent.Prezime = null;
			}
		}

		internal void HandleEmailCheckedChanged(object sender, EventArgs e)
		{
			if (uCPretraziKlijetnta.ChbEmail.Checked)
			{
				klijent.Email = uCPretraziKlijetnta.TxtEmail.Text;
			}
			else
			{
				klijent.Email = null;
			}
		}

		internal void HandleTelefonCheckedChanged(object sender, EventArgs e)
		{
			if (uCPretraziKlijetnta.ChbTelefon.Checked)
			{
				klijent.Telefon = uCPretraziKlijetnta.TxtTelefon.Text;
			}
			else
			{
				klijent.Telefon = null;
			}
		}
	}
}

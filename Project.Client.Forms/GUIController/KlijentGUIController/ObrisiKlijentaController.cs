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
		private List<Klijent> nadjeniKlijenti = new List<Klijent>();

		public ObrisiKlijentaController(UCObrisiKlijenta uCObrisiKlijenta)
		{
			this.uCObrisiKlijenta = uCObrisiKlijenta;
			DodajCheckBoxITextBoxHandlers();
		}

		private void DodajCheckBoxITextBoxHandlers()
		{
			uCObrisiKlijenta.ChbIme.CheckedChanged += HandleImeCheckedChanged;
			uCObrisiKlijenta.ChbPrezime.CheckedChanged += HandlePrezimeCheckedChanged;
			uCObrisiKlijenta.ChbEmail.CheckedChanged += HandleEmailCheckedChanged;
			uCObrisiKlijenta.ChbTelefon.CheckedChanged += HandleTelefonCheckedChanged;

			uCObrisiKlijenta.TxtIme.TextChanged += HandleImeCheckedChanged;
			uCObrisiKlijenta.TxtPrezime.TextChanged += HandlePrezimeCheckedChanged;
			uCObrisiKlijenta.TxtEmail.TextChanged += HandleEmailCheckedChanged;
			uCObrisiKlijenta.TxtTelefon.TextChanged += HandleTelefonCheckedChanged;
		}

		private void SakrijKolone()
		{
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
				Response response = Communication.Instance.SendRequestGetResponse(Operation.PretraziKlijenta, klijent);
				MessageBox.Show(response.Message);
				nadjeniKlijenti = (List<Klijent>)response.Result;
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
			throw new NotImplementedException();
		}

		internal void HandleImeCheckedChanged(object sender, EventArgs e)
		{
			if (uCObrisiKlijenta.ChbIme.Checked)
			{
				klijent.Ime = uCObrisiKlijenta.TxtIme.Text;
			}
			else
			{
				klijent.Ime = null;
			}
		}

		internal void HandlePrezimeCheckedChanged(object sender, EventArgs e)
		{
			if (uCObrisiKlijenta.ChbPrezime.Checked)
			{
				klijent.Prezime = uCObrisiKlijenta.TxtPrezime.Text;
			}
			else
			{
				klijent.Prezime = null;
			}
		}

		internal void HandleEmailCheckedChanged(object sender, EventArgs e)
		{
			if (uCObrisiKlijenta.ChbEmail.Checked)
			{
				klijent.Email = uCObrisiKlijenta.TxtEmail.Text;
			}
			else
			{
				klijent.Email = null;
			}
		}

		internal void HandleTelefonCheckedChanged(object sender, EventArgs e)
		{
			if (uCObrisiKlijenta.ChbTelefon.Checked)
			{
				klijent.Telefon = uCObrisiKlijenta.TxtTelefon.Text;
			}
			else
			{
				klijent.Telefon = null;
			}
		}


	}
}

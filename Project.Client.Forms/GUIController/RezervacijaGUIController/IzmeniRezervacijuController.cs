using Project.Client.Forms.Dialogs;
using Project.Client.Forms.Exceptions;
using Project.Client.Forms.ServerCommunication;
using Project.Client.Forms.Session;
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
	public class IzmeniRezervacijuController
	{
		private FrmIzmeniRezervaciju frmIzmeniRezervaciju;

		public IzmeniRezervacijuController(FrmIzmeniRezervaciju frmIzmeniRezervaciju)
		{
			this.frmIzmeniRezervaciju = frmIzmeniRezervaciju;
		}

		#region Ucitavanje DgvStolovi
		private void SakrijKolone(DataGridView dgv)
		{
			dgv.Columns["Rezervacija"].Visible = false;
			dgv.Columns["Id"].Visible = false;
			dgv.Columns["TableName"].Visible = false;
			dgv.Columns["InsertUpdateCondition"].Visible = false;
			dgv.Columns["InsertValues"].Visible = false;
			dgv.Columns["IdCondition"].Visible = false;
			dgv.Columns["UpdateValues"].Visible = false;
			dgv.Columns["SearchCondition"].Visible = false;
			dgv.Columns["Join"].Visible = false;
		}

		private void UcitajDgvStolovi(List<RezervisanSto> rezStolovi = null)
		{
			DataGridView dgv = frmIzmeniRezervaciju.UcRadSaRezervacijom.DgvStolovi;
			if (rezStolovi == null)
				dgv.DataSource = new BindingList<RezervisanSto>(new List<RezervisanSto>());

			else dgv.DataSource = new BindingList<RezervisanSto>(rezStolovi);

			SakrijKolone(dgv);
		}

		#endregion

		private void UcitajStoloveRezervacije()
		{
			try
			{
				Response response = Communication.Instance.SendRequestGetResponse(Operation.VratiStoloveRezervacije, SessionData.Instance.Rezervacija);
				List<RezervisanSto> rezStolovi = (List<RezervisanSto>)response.Result;
				SessionData.Instance.Rezervacija.RezervisaniStolovi = rezStolovi.ToList();
			
				frmIzmeniRezervaciju.UcRadSaRezervacijom.RezervisaniStolovi = rezStolovi;
				UcitajDgvStolovi(rezStolovi);
			}
			catch (SystemOperationException e)
			{
				UcitajDgvStolovi();
				MessageBox.Show(e.Message);
			}
		}

		internal void UcitajRezervaciju()
		{
			try
			{
				UcitajStoloveRezervacije();
				UCRadSaRezervacijom radSaRezervacijom = frmIzmeniRezervaciju.UcRadSaRezervacijom;
				radSaRezervacijom.LblRadnikVrednost.Text = SessionData.Instance.Rezervacija.Radnik.ToString();
				radSaRezervacijom.CbKlijent.SelectedItem = SessionData.Instance.Rezervacija.Klijent;
				radSaRezervacijom.CbMesto.SelectedItem = SessionData.Instance.Rezervacija.Mesto;
				radSaRezervacijom.CbTipProslave.SelectedItem = SessionData.Instance.Rezervacija.TipProslave;
				radSaRezervacijom.DtpDatum.Value = SessionData.Instance.Rezervacija.DatumVremeOd.Date;
				radSaRezervacijom.TxtVremeOd.Text = SessionData.Instance.Rezervacija.DatumVremeOd.ToString("hh\\:mm");
				radSaRezervacijom.TxtVremeDo.Text = SessionData.Instance.Rezervacija.DatumVremeDo.ToString("hh\\:mm");
				radSaRezervacijom.IzabraniMeni = SessionData.Instance.Rezervacija.KeteringMeni;
				radSaRezervacijom.LblKeteringMeniVrednost.Text = SessionData.Instance.Rezervacija.KeteringMeni.ToString();
				radSaRezervacijom.LblUkupnaCenaVrednost.Text = SessionData.Instance.Rezervacija.UkupnaCena.ToString();
				MessageBox.Show("Odabrana rezervacija je prikazana.");
			}
			catch (Exception)
			{
				MessageBox.Show("Sistem ne može da učita podatke o rezervaciji.");
				frmIzmeniRezervaciju.DialogResult = DialogResult.Abort;
			}
		}

		private bool ValidanUnosRezervacije()
		{
			UCRadSaRezervacijom radSaRezervacijom = frmIzmeniRezervaciju.UcRadSaRezervacijom;

			bool valid = true;
			string message = "";

			if (radSaRezervacijom.CbKlijent.SelectedItem == null)
			{
				message += "Rezervacija mora da sadrži klijenta na koga se ona odnosi.\n";
				valid = false;
			}

			if (radSaRezervacijom.CbMesto.SelectedItem == null)
			{
				message += "Rezervacija mora da sadrži mesto.\n";
				valid = false;
			}

			if (radSaRezervacijom.CbTipProslave.SelectedItem == null)
			{
				message += "Rezervacija mora da sadrži tip proslave.\n";
				valid = false;
			}

			if (radSaRezervacijom.RezervisaniStolovi.Count == 0)
			{
				message += "Rezervacija mora da sadrži barem jedan sto u listi rezervisanih stolova.\n";
				valid = false;
			}

			if (String.IsNullOrEmpty(radSaRezervacijom.LblKeteringMeniVrednost.Text))
			{
				message += "Rezervacija mora da sadrži ketering meni.\n";
				valid = false;
			}


			if (radSaRezervacijom.DtpDatum.Value == null)
			{
				message += "Rezervacija mora da sadrži datum.\n";
				valid = false;
			}

			bool vremeOdFormat = TimeSpan.TryParseExact(radSaRezervacijom.TxtVremeOd.Text, "hh\\:mm", null, System.Globalization.TimeSpanStyles.None, out TimeSpan vremeOd);
			bool vremeDoFormat = TimeSpan.TryParseExact(radSaRezervacijom.TxtVremeDo.Text, "hh\\:mm", null, System.Globalization.TimeSpanStyles.None, out TimeSpan vremeDo);
			if (!vremeOdFormat)
			{
				message += "Vreme od nije u validnom formatu.\n";
				valid = false;
			}
			if (!vremeDoFormat)
			{
				message += "Vreme do nije u validnom formatu.\n";
				valid = false;
			}

			if ((vremeOdFormat && vremeDoFormat) && vremeOd >= vremeDo)
			{
				message += "Vreme do mora biti polse vremena od.\n";
				valid = false;
			}


			if (!Double.TryParse(radSaRezervacijom.LblUkupnaCenaVrednost.Text, out double res))
			{
				message += "Greška prilikom konvertovanja ukupne cene u numeričku vrednost.\n";
				valid = false;
			}

			if (!valid) MessageBox.Show(message);
			return valid;
		}

		private void UnesiPodatkeORezervaciji()
		{
			UCRadSaRezervacijom radSaRezervacijom = frmIzmeniRezervaciju.UcRadSaRezervacijom;
			
			DateTime DatumVremeOd = radSaRezervacijom.DtpDatum.Value.Date;
			DatumVremeOd=DatumVremeOd.Add(TimeSpan.ParseExact(radSaRezervacijom.TxtVremeOd.Text, "hh\\:mm", null));

			DateTime DatumVremeDo = radSaRezervacijom.DtpDatum.Value.Date;
			DatumVremeDo=DatumVremeDo.Add(TimeSpan.ParseExact(radSaRezervacijom.TxtVremeDo.Text, "hh\\:mm", null));

			SessionData.Instance.Rezervacija.Radnik = SessionData.Instance.Radnik;
			SessionData.Instance.Rezervacija.Klijent = (Klijent)radSaRezervacijom.CbKlijent.SelectedItem;
			SessionData.Instance.Rezervacija.TipProslave = (TipProslave)radSaRezervacijom.CbTipProslave.SelectedItem;
			SessionData.Instance.Rezervacija.DatumVremeOd = DatumVremeOd;
			SessionData.Instance.Rezervacija.DatumVremeDo = DatumVremeDo;
			SessionData.Instance.Rezervacija.UkupnaCena = Double.Parse(radSaRezervacijom.LblUkupnaCenaVrednost.Text);
			SessionData.Instance.Rezervacija.Mesto = (Mesto)radSaRezervacijom.CbMesto.SelectedItem;
			SessionData.Instance.Rezervacija.KeteringMeni = radSaRezervacijom.IzabraniMeni;
			SessionData.Instance.Rezervacija.NoviRezervisaniStolovi = radSaRezervacijom.RezervisaniStolovi;
		}

		internal void IzmeniRezervaciju()
		{

			if (ValidanUnosRezervacije())
			{
				UnesiPodatkeORezervaciji();

				if (MoguceCuvanjeRezervacije())
					SacuvajRezervaciju();
				
			}
		}

		private bool MoguceCuvanjeRezervacije()
		{
			try
			{
				Response response = Communication.Instance.SendRequestGetResponse(Operation.ProveraCuvanjaRezervacije, SessionData.Instance.Rezervacija);
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


		private void SacuvajRezervaciju()
		{
			try
			{
				Response response = Communication.Instance.SendRequestGetResponse(Operation.IzmeniRezervaciju, SessionData.Instance.Rezervacija);
				MessageBox.Show(response.Message);
			}
			catch (SystemOperationException e)
			{
				MessageBox.Show(e.Message);
			}
		}

	}
}

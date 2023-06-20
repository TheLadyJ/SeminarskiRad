using Project.Client.Forms.Dialogs;
using Project.Client.Forms.Exceptions;
using Project.Client.Forms.ServerCommunication;
using Project.Client.Forms.UserControls.UCSto;
using Project.Common.Communication;
using Project.Common.Domain;
using Project.Server.ApplicationLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Client.Forms.GUIController.KeteringMeniGUIController
{
	public class IzabreiKeteringMeniController
	{
		private FrmIzaberiKeteringMeni frmIzaberiKeteringMeni;

		public IzabreiKeteringMeniController(FrmIzaberiKeteringMeni frmIzaberiKeteringMeni)
		{
			this.frmIzaberiKeteringMeni = frmIzaberiKeteringMeni;
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

		internal void UcitajListuKeteringFirmi()
		{
			UcitajListuComboBoxa(Operation.VratiSveKeteringFirme, frmIzaberiKeteringMeni.CbKeteringFirme);
		}

		internal void PrikaziMenijeFirme()
		{
			if (frmIzaberiKeteringMeni.CbKeteringFirme.SelectedItem == null)
			{
				MessageBox.Show("Morate izabrati barem jednu ketering firmu čije menije želite da vidite.");
				return;
			}

			KeteringFirma firma = (KeteringFirma)frmIzaberiKeteringMeni.CbKeteringFirme.SelectedItem;

			try
			{
				Response response = Communication.Instance.SendRequestGetResponse(Operation.VratiMenijeFirme, firma);
				List<KeteringMeni> meniji = (List<KeteringMeni>)response.Result;
				UcitajDgvMeni(meniji);
			}
			catch (SystemOperationException e)
			{
				MessageBox.Show(e.Message);
				UcitajDgvMeni();
			}
		}

		private void SakrijKolone(DataGridView dgv)
		{
			dgv.Columns["KeteringMeniID"].Visible = false;
			dgv.Columns["KeteringFirma"].Visible = false;
			dgv.Columns["Id"].Visible = false;
			dgv.Columns["InsertUpdateDeleteCondition"].Visible = false;
			dgv.Columns["TableName"].Visible = false;
			dgv.Columns["InsertValues"].Visible = false;
			dgv.Columns["IdCondition"].Visible = false;
			dgv.Columns["UpdateValues"].Visible = false;
			dgv.Columns["SearchCondition"].Visible = false;
			dgv.Columns["Join"].Visible = false;
		}

		private void PreimenujKolone(DataGridView dgv)
		{
			dgv.Columns["GlavnoJelo"].HeaderText = "Glavno jelo";
			dgv.Columns["GlavnoJelo"].Width = 150;
			dgv.Columns["CenaHranePoOsobi"].HeaderText = "Cena hrane po osobi";
			dgv.Columns["CenaHranePoOsobi"].Width = 200;

			dgv.Columns["Predjelo"].Width = 150;
			dgv.Columns["Dezert"].Width = 150;
		}

		private void UcitajDgvMeni(List<KeteringMeni> meniji = null)
		{
			DataGridView dgv = frmIzaberiKeteringMeni.DgvMeni;

			if (meniji == null)
				dgv.DataSource = new BindingList<KeteringMeni>(new List<KeteringMeni>());

			else dgv.DataSource = new BindingList<KeteringMeni>(meniji);


			SakrijKolone(dgv);
			PreimenujKolone(dgv);
		}

		internal void IzvrsiOdabirMenija()
		{
			if (frmIzaberiKeteringMeni.DgvMeni.SelectedRows.Count == 0)
			{
				MessageBox.Show("Morate izabrati neki meni sa liste.");
				return;
			}
			if (frmIzaberiKeteringMeni.DgvMeni.SelectedRows.Count > 1)
			{
				MessageBox.Show("Možete izabrati samo jedan meni sa liste.");
				return;
			}

			frmIzaberiKeteringMeni.IzabraniMeni = (KeteringMeni)frmIzaberiKeteringMeni.DgvMeni.SelectedRows[0].DataBoundItem;
			frmIzaberiKeteringMeni.DialogResult = DialogResult.OK;
		}
	}
}

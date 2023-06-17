using Project.Client.Forms.Dialogs;
using Project.Client.Forms.GUIController.RezervacijaGUIController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Client.Forms.UserControls.UCRezervacija
{
    public partial class UCRadSaRezervacijom : UserControl
    {
		RadSaRezervacijomController radSaRezervacijomController;
		public UCRadSaRezervacijom()
        {
            InitializeComponent();
			radSaRezervacijomController = new RadSaRezervacijomController(this);

		}

		private void btnIzaberiKeteringMeni_Click(object sender, EventArgs e)
		{
			radSaRezervacijomController.IzaberiKeteringMeni();
		}

		private void btnDodajSto_Click(object sender, EventArgs e)
		{
			radSaRezervacijomController.DodajSto();
		}

		private void btnObrisiStolove_Click(object sender, EventArgs e)
		{
			radSaRezervacijomController.ObrisiStolove();
		}

		private void UCRadSaRezervacijom_Load(object sender, EventArgs e)
		{
			radSaRezervacijomController.UcitajSvaComboBoxPolja();
		}
	}
}

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
	public partial class UCPretragaRezervacija : UserControl
	{
        public PretragaRezervacijaController PretragaRezervacijaController { get; set; }
		public UCPretragaRezervacija()
		{
			InitializeComponent();
			PretragaRezervacijaController = new PretragaRezervacijaController(this);
		}

		private void btnIzaberiKeteringMeni_Click(object sender, EventArgs e)
		{
			FrmIzaberiKeteringMeni frmIzaberiKeteringMeni = new FrmIzaberiKeteringMeni();
			frmIzaberiKeteringMeni.ShowDialog();
		}

		private void btnPretrazi_Click(object sender, EventArgs e)
		{
			PretragaRezervacijaController.PretraziRezervaciju();
		}

		private void UCPretragaRezervacija_Load(object sender, EventArgs e)
		{
			PretragaRezervacijaController.UcitajSveRezervacije();
		}

	}
}

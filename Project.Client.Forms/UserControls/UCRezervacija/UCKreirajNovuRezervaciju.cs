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
	public partial class UCKreirajNovuRezervaciju : UserControl
	{
		private KreirajRezervacijuController kreirajRezervacijuController;
		public UCKreirajNovuRezervaciju()
		{
			InitializeComponent();
			kreirajRezervacijuController = new KreirajRezervacijuController(this);
		}

		private void UCKreirajNovuRezervaciju_Load(object sender, EventArgs e)
		{
			kreirajRezervacijuController.UcitajStoloveIKlijente();
		}

		private void btnKreirajNovuRezervaciju_Click(object sender, EventArgs e)
		{
			kreirajRezervacijuController.KreirajRezervaciju();
		}
	}
}

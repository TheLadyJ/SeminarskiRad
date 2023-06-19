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
	public partial class UCPretraziRezervacijuZaBrisanje : UserControl
	{
		private PretraziRezervacijuZaBrisanjeController pretraziRezervacijuZaBrisanjeController;

		public UCPretraziRezervacijuZaBrisanje()
		{
			InitializeComponent();
			pretraziRezervacijuZaBrisanjeController = new PretraziRezervacijuZaBrisanjeController(this);
		}

		private void btnObrisiRezervaciju_Click(object sender, EventArgs e)
		{
			pretraziRezervacijuZaBrisanjeController.ObrisiRezervaciju();
		}

	}
}

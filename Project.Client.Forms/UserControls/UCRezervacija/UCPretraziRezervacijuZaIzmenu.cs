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
	public partial class UCPretraziRezervacijuZaIzmenu : UserControl
	{
		private PretraziRezervacijuZaIzmenuController pretraziRezervacijuZaIzmenuController;
		public UCPretraziRezervacijuZaIzmenu()
		{
			InitializeComponent();
			pretraziRezervacijuZaIzmenuController = new PretraziRezervacijuZaIzmenuController(this);
		}

		private void btnIzmeniRezervaciju_Click(object sender, EventArgs e)
		{
			pretraziRezervacijuZaIzmenuController.IzmeniRezervaciju();
		}
	}
}

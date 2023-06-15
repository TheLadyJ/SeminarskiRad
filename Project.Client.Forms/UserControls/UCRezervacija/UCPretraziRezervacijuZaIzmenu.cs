using Project.Client.Forms.Dialogs;
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
		public UCPretraziRezervacijuZaIzmenu()
		{
			InitializeComponent();
		}

		private void btnIzmeniRezervaciju_Click(object sender, EventArgs e)
		{
			FrmIzmeniRezervaciju frmIzmeniRezervaciju = new FrmIzmeniRezervaciju();
			frmIzmeniRezervaciju.ShowDialog();
		}
	}
}

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

namespace Project.Client.Forms.Dialogs
{
	public partial class FrmIzmeniRezervaciju : Form
	{
		public FrmIzmeniRezervaciju()
		{
			InitializeComponent();
		}

		private void FrmIzmeniRezervaciju_Load(object sender, EventArgs e)
		{
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
		}
	}
}

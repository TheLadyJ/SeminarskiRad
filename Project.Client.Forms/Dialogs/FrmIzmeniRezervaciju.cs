using Project.Client.Forms.GUIController.RezervacijaGUIController;
using Project.Client.Forms.Session;
using Project.Common.Domain;
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
        
		private IzmeniRezervacijuController izmeniRezervacijuController;
		public FrmIzmeniRezervaciju()
		{
			InitializeComponent();
			izmeniRezervacijuController = new IzmeniRezervacijuController(this);
		}

		private void FrmIzmeniRezervaciju_Load(object sender, EventArgs e)
		{
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			izmeniRezervacijuController.UcitajRezervaciju();
		}

		public void btnIzmeniRezervaciju_Click(object sender, EventArgs e)
		{
			izmeniRezervacijuController.IzmeniRezervaciju();
		}
	}
}

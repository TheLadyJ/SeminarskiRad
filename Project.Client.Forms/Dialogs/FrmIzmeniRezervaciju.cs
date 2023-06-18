using Project.Client.Forms.GUIController.RezervacijaGUIController;
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
        public Rezervacija Rezervacija { get; set; }
        
		private IzmeniRezervacijuController izmeniRezervacijuController;
		public FrmIzmeniRezervaciju(Rezervacija rezervacija)
		{
			InitializeComponent();
			Rezervacija = rezervacija;
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

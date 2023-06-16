using Project.Client.Forms.GUIController.KlijentGUIController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Client.Forms.UserControls.UCKlijent
{
    public partial class UCObrisiKlijenta : UserControl
    {
		private ObrisiKlijentaController brisanjeKlijentaController;
        public UCObrisiKlijenta()
        {
            InitializeComponent();
			brisanjeKlijentaController = new ObrisiKlijentaController(this);
		}

		private void btnPretraziKlijenta_Click(object sender, EventArgs e)
		{
			brisanjeKlijentaController.PretraziKlijenta();
		}

		private void btnObrisiKlijenta_Click(object sender, EventArgs e)
		{
			brisanjeKlijentaController.ObrisiKlijenta();
		}

		private void UCObrisiKlijenta_Load(object sender, EventArgs e)
		{
			brisanjeKlijentaController.UcitajSveKlijente();
		}
	}
}

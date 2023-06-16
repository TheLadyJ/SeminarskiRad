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
    public partial class UCKreirajNovogKlijenta : UserControl
    {
        private KreirajKlijentaController kreirajKlijentaController;
        public UCKreirajNovogKlijenta()
        {
            InitializeComponent();
            kreirajKlijentaController = new KreirajKlijentaController(this);
		}

		private void btnKreirajKlijenta_Click(object sender, EventArgs e)
		{
            kreirajKlijentaController.KreirajKlijenta();
		}
	}
}

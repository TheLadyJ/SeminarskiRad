using Project.Client.Forms.GUIController.StoGUIController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Client.Forms.UserControls.UCSto
{
    public partial class UCPretraziSto : UserControl
    {
        private PretraziStoController pretraziStoController;
        public UCPretraziSto()
        {
            InitializeComponent();
			pretraziStoController = new PretraziStoController(this);
		}

		private void btnPretraziSto_Click(object sender, EventArgs e)
		{
			pretraziStoController.PretraziSto();
		}

		private void btnPrikaziDetalje_Click(object sender, EventArgs e)
		{
			pretraziStoController.PrikaziDetalje();

		}

		private void UCPretraziSto_Load(object sender, EventArgs e)
		{
			pretraziStoController.UcitajSveStolove();
		}
	}
}

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
    public partial class UCObrisiSto : UserControl
    {
        ObrisiStoController obrisiStoController;
		public UCObrisiSto()
        {
            InitializeComponent();
			obrisiStoController = new ObrisiStoController(this);
		}

		private void btnPretraziSto_Click(object sender, EventArgs e)
		{
			obrisiStoController.PretraziSto();
		}

		private void btnObrisiSto_Click(object sender, EventArgs e)
		{
			obrisiStoController.ObrisiSto();

		}

		private void UCObrisiSto_Load(object sender, EventArgs e)
		{
			obrisiStoController.UcitajSveStolove();

		}
	}
}

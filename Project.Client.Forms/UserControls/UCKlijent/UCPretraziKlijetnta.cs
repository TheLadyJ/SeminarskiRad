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
    public partial class UCPretraziKlijetnta : UserControl
    {
        private PretraziKlijentaController pretraziKlijentaController;
        public UCPretraziKlijetnta()
        {
            InitializeComponent();
			pretraziKlijentaController = new PretraziKlijentaController(this);

		}

		private void btnPretraziKlijenta_Click(object sender, EventArgs e)
		{

		}

		private void btnPrikaziDetaljno_Click(object sender, EventArgs e)
		{

		}
	}
}

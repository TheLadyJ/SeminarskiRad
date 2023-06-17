using Project.Client.Forms.GUIController.KeteringMeniGUIController;
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
	public partial class FrmIzaberiKeteringMeni : Form
	{
        public KeteringMeni IzabraniMeni { get; set; }
		private IzabreiKeteringMeniController IzabreiKeteringMeniController;
        public FrmIzaberiKeteringMeni()
		{
			InitializeComponent();
			IzabreiKeteringMeniController = new IzabreiKeteringMeniController(this);
		}

		private void FrmIzaberiKeteringMeni_Load(object sender, EventArgs e)
		{
			IzabreiKeteringMeniController.UcitajListuKeteringFirmi();
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
		}

		private void btnPrikazi_Click(object sender, EventArgs e)
		{
			IzabreiKeteringMeniController.PrikaziMenijeFirme();
		}

		private void btnOdabir_Click(object sender, EventArgs e)
		{
			IzabreiKeteringMeniController.IzvrsiOdabirMenija();
		}
	}
}

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
    public partial class UCUnesiNoviSto : UserControl
    {
        private UnseiNoviStoController unseiNoviStoController; 

        public UCUnesiNoviSto()
        {
            InitializeComponent();
			unseiNoviStoController=new UnseiNoviStoController(this);

		}

		private void btnUnesiNoviSto_Click(object sender, EventArgs e)
		{
			unseiNoviStoController.UnesiNoviSto();
		}

		private void UCUnesiNoviSto_Load(object sender, EventArgs e)
		{
			unseiNoviStoController.UcitajProizvodjace();
		}
	}
}

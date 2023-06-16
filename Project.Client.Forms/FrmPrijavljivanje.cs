using Project.Client.Forms.GUIController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Client.Forms
{
    public partial class FrmPrijavljivanje : Form
    {
        private PrijaviRadnikaController prijaviRadnikaController;
        public FrmPrijavljivanje()
        {
            InitializeComponent();
            prijaviRadnikaController = new PrijaviRadnikaController(this);

        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            prijaviRadnikaController.PrijaviRadnika();
        }

        private void FrmPrijavljivanje_FormClosed(object sender, FormClosedEventArgs e)
        {
            //prijaviRadnikaController.ZatvoriKonekciju();
        }

        private void FrmPrijavljivanje_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}

﻿using Project.Client.Forms.GUIController;
using Project.Client.Forms.GUIController.RadnikGUIController;
using Project.Client.Forms.ServerCommunication;
using Project.Client.Forms.Session;
using Project.Client.Forms.UserControls.UCKlijent;
using Project.Client.Forms.UserControls.UCRezervacija;
using Project.Client.Forms.UserControls.UCSto;
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
    public partial class FrmRadnikovaGlavna : Form
    {
        private RadnikovaGlavnaController radnikovaGlavnaController;
		public FrmRadnikovaGlavna()
        {
            InitializeComponent();
            radnikovaGlavnaController = new RadnikovaGlavnaController();
		}

        private void FrmRadnikovaGlavna_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            lblPrijavljeniRadnik.Text += SessionData.Instance.Radnik.ToString();
        }

        private void ChangePanel(UserControl userControl)
        {
			pnlMain.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(userControl);
        }


        private void kreirajNovogKlijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCKreirajNovogKlijenta());
        }

        private void pretraziKlijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCPretraziKlijetnta());

        }

        private void obrisiKlijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCObrisiKlijenta());

        }
        private void unesiNoviStoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCUnesiNoviSto());
        }

        private void pretraziStoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCPretraziSto());

        }

        private void obrisiStoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCObrisiSto());

        }

		private void kreirajNovuRezervacijuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ChangePanel(new UCKreirajNovuRezervaciju());

		}

		private void izmeniRezervacijuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ChangePanel(new UCPretraziRezervacijuZaIzmenu());
		}

		private void obrisiRezervacijuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ChangePanel(new UCPretraziRezervacijuZaBrisanje());
		}

		private void FrmRadnikovaGlavna_FormClosed(object sender, FormClosedEventArgs e)
		{
            radnikovaGlavnaController.ZatvoriKonekciju();
		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Server.Main
{
    public partial class FrmServer : Form
    {
        private Server server;
        public FrmServer()
        {
            InitializeComponent();
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			btnPokreniServer.Enabled = true;
            btnZaustaviServer.Enabled = false;
        }

        private void btnPokreniServer_Click(object sender, EventArgs e)
        {
            server = new Server();
            if (server.Start())
            {
                btnPokreniServer.Enabled = false;
                btnZaustaviServer.Enabled = true;

                lblStatusServeraVrednost.Text = "Pokrenut";
				lblStatusServeraVrednost.ForeColor = btnPokreniServer.ForeColor;

                try
                {
                    
                     Thread nit = new Thread(server.HandleClients);
                     nit.IsBackground = true;
                     nit.Start(); 
                    
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(">>>" + ex.Message);
                    MessageBox.Show("Došlo je do greške prilikom obrade klijenata!");

                }
            }
            else
            {
                MessageBox.Show("Došlo je do greške prilikom pokretanja servera!");
            }
        }

        private void btnZaustaviServer_Click(object sender, EventArgs e)
        {
            server?.Stop();
            server = null;
            btnPokreniServer.Enabled = true;
            btnZaustaviServer.Enabled = false;

			lblStatusServeraVrednost.Text = "Zaustavljen";
			lblStatusServeraVrednost.ForeColor = btnZaustaviServer.ForeColor;

		}
        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

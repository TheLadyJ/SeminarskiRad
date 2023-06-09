using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

                txtStatusServera.Text = "Pokrenut";
                txtStatusServera.ForeColor = btnPokreniServer.ForeColor;

                Thread nit = new Thread(server.HandleClients);
                nit.IsBackground = true;
                nit.Start();
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

            txtStatusServera.Text = "Zaustavljen";
            txtStatusServera.ForeColor = btnZaustaviServer.ForeColor;

        }
        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

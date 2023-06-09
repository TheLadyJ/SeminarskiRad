using Project.Client.Forms.Exceptions;
using Project.Client.Forms.ServerCommunication;
using Project.Client.Forms.Session;
using Project.Common.Communication;
using Project.Common.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project.Client.Forms.GUIController
{

    public class PrijaviRadnikaController
    {
        public Radnik Radnik { get; set; }

        public PrijaviRadnikaController() 
        {
            try
            {
                Communication.Instance.Connect();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Greška prilikom povezivanja sa serverom");
            }
        }

        public void PrijaviRadnika(FrmPrijavljivanje frmPrijavljivanje)
        {
            string korisnickoIme = frmPrijavljivanje.TxtKorisnikoIme.Text;
            string lozinka = frmPrijavljivanje.TxtLozinka.Text;

            bool popunjeno = true;
            if (string.IsNullOrEmpty(korisnickoIme))
            { 
                popunjeno = false;
                frmPrijavljivanje.TxtKorisnikoIme.BackColor = Color.Violet;
            }
            if (string.IsNullOrEmpty(lozinka))
            {
                popunjeno = false;
                frmPrijavljivanje.TxtLozinka.BackColor = Color.Violet;
            }
            if (!popunjeno) return;

            try
            {
                Radnik radnik = new Radnik
                {
                    KorisnickoIme = korisnickoIme,
                    Lozinka = lozinka
                };


                Response response = Communication.Instance.SendRequestGetResponse(Operation.PrijaviRadnika, radnik);

                SessionData.Instance.Radnik = (Radnik)response.Result;
                MessageBox.Show(response.Message);
                frmPrijavljivanje.DialogResult = DialogResult.OK;
                
            }
            catch (SystemOperationException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Greska pri radu sa serverom!");
            }

        }

        internal void ZatvoriKonekciju(FrmPrijavljivanje frmPrijavljivanje)
        {
            Communication.Instance.Close();
        }
    }
}

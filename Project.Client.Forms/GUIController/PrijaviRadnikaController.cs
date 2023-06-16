using Project.Client.Forms.Exceptions;
using Project.Client.Forms.ServerCommunication;
using Project.Client.Forms.Session;
using Project.Common.Communication;
using Project.Common.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
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

        private FrmPrijavljivanje frmPrijavljivanje;


		public PrijaviRadnikaController(FrmPrijavljivanje frmPrijavljivanje) 
        {
            this.frmPrijavljivanje = frmPrijavljivanje;
            try
            {
                Communication.Instance.Connect();
            }
            catch(SocketException ex)
            {
				MessageBox.Show("Greška prilikom povezivanja sa serverom");
				frmPrijavljivanje.DialogResult = DialogResult.Abort;
			}
        }

        public void PrijaviRadnika()
        {
            string korisnickoIme = frmPrijavljivanje.TxtKorisnikoIme.Text;
            string lozinka = frmPrijavljivanje.TxtLozinka.Text;

            bool popunjeno = true;
            if (string.IsNullOrEmpty(korisnickoIme))
            { 
                popunjeno = false;
                frmPrijavljivanje.TxtKorisnikoIme.BackColor = Color.Violet;
            }
            else
            {
                frmPrijavljivanje.TxtKorisnikoIme.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(lozinka))
            {
                popunjeno = false;
                frmPrijavljivanje.TxtLozinka.BackColor = Color.Violet;
            }
            else
            {
                frmPrijavljivanje.TxtLozinka.BackColor = Color.White;
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
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Trenutno nije moguće obaviti prijavljivanje.");
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Greska pri radu sa serverom!");
            }

        }

        //internal void ZatvoriKonekciju()
        //{
        //    Communication.Instance.Close();
        //}
    }
}

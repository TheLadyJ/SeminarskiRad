using Project.Client.Forms.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Client.Forms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                try
                {
                    FrmPrijavljivanje frmPrijavljivanje = new FrmPrijavljivanje();
                    frmPrijavljivanje.ShowDialog();
                    DialogResult result = frmPrijavljivanje.DialogResult;
                    frmPrijavljivanje.Dispose();

                    if (result == DialogResult.OK)
                    {
                        Application.Run(new FrmRadnikovaGlavna());
                    }
                    if (result == DialogResult.Cancel)
                    {
                        break;
                    }
                }
                catch (ServerCommunicationException)
                {
                    MessageBox.Show("Greska pri radu sa serverom!");
                }
            }
        }
    }
}

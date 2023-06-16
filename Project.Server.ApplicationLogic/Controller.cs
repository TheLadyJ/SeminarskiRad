using Project.Common.Domain;
using Project.Server.SystemOperations;
using Project.Server.SystemOperations.KlijentSO;
using Project.Server.SystemOperations.RadnikSO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.ApplicationLogic
{
    public class Controller
    {

        private static Controller instance;
        private Controller()
        {
        }

        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            }
        }

        public Radnik PrijaviRadnika(Radnik radnik)
        {
            try
            {
                SystemOperationBase so = new PrijaviRadnikaSO(radnik);
                so.ExecuteTemplate();
                return (Radnik)so.Result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void KreirajKlijenta(Klijent klijent)
        {
			try
			{
				SystemOperationBase so = new KreirajKlijentaSO(klijent);
				so.ExecuteTemplate();
			}
			catch (Exception)
			{
				throw;
			}
		}
    }
}

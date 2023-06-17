using Project.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.SystemOperations.RezervacijaSO
{
	public class KreirajRezervacijuSO : SystemOperationBase
	{
		private Rezervacija rezervacija;

		public KreirajRezervacijuSO(Rezervacija rezervacija)
		{
			this.rezervacija = rezervacija;
		}

		protected override void Execute()
		{
			repository.Insert(rezervacija);
		}
	}
}

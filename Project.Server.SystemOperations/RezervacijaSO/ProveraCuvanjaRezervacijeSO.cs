using Project.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.SystemOperations.RezervacijaSO
{
	public class ProveraCuvanjaRezervacijeSO : SystemOperationBase
	{
		private Rezervacija rezervacija;

		public ProveraCuvanjaRezervacijeSO(Rezervacija rezervacija)
		{
			this.rezervacija = rezervacija;
		}

		protected override void Execute()
		{
			List<Rezervacija> rezervacije = repository.CheckInsertUpdate(rezervacija).OfType<Rezervacija>().ToList();
			Result = (rezervacije == null || rezervacije.Count == 0);
		}
	}
}

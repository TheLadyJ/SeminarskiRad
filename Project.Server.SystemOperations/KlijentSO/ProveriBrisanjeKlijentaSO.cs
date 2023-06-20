using Project.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.SystemOperations.KlijentSO
{
	public class ProveriBrisanjeKlijentaSO : SystemOperationBase
	{
		private Klijent klijent;

		public ProveriBrisanjeKlijentaSO(Klijent klijent)
		{
			this.klijent = klijent;
		}

		protected override void Execute()
		{
			List<Klijent> rezervacijeKlijenta = repository.CheckInsertUpdateDelete(klijent).OfType<Klijent>().ToList();
			Result = (rezervacijeKlijenta == null || rezervacijeKlijenta.Count == 0);
		}
	}
}

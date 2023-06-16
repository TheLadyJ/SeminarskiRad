using Project.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.SystemOperations.KlijentSO
{
	public class PretraziKlijentaSO : SystemOperationBase
	{
		private Klijent klijent;

		public PretraziKlijentaSO(Klijent klijent)
		{
			this.klijent = klijent;
		}

		protected override void Execute()
		{
			Result = repository.Search(klijent, "").OfType<Klijent>().ToList();
		}
	}
}

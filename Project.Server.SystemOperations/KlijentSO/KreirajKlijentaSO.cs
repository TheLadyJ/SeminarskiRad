using Project.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.SystemOperations.KlijentSO
{
	public class KreirajKlijentaSO : SystemOperationBase
	{
		private Klijent klijent;

		public KreirajKlijentaSO(Klijent klijent)
		{
			this.klijent = klijent;
		}

		protected override void Execute()
		{
			repository.Insert(klijent);
		}
	}
}

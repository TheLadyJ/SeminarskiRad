using Project.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.SystemOperations.StoSO
{
	public class ProveriBrisanjeStolaSO : SystemOperationBase
	{
		private Sto sto;

		public ProveriBrisanjeStolaSO(Sto sto)
		{
			this.sto = sto;
		}

		protected override void Execute()
		{
			List<Rezervacija> rezervacijeStola = repository.CheckInsertUpdateDelete(sto).OfType<Rezervacija>().ToList();
			Result = (rezervacijeStola == null || rezervacijeStola.Count == 0);
		}
	}
}

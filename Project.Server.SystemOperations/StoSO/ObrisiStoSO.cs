using Project.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.SystemOperations.StoSO
{
	public class ObrisiStoSO : SystemOperationBase
	{
		private Sto sto;

		public ObrisiStoSO(Sto sto)
		{
			this.sto = sto;
		}

		protected override void Execute()
		{
			repository.Delete(sto);
		}
	}
}

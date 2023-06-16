using Project.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.SystemOperations.StoSO
{
	public class UnesiStoSO : SystemOperationBase
	{
		private Sto sto;

		public UnesiStoSO(Sto sto)
		{
			this.sto = sto;
		}

		protected override void Execute()
		{
			repository.Insert(sto);
		}
	}
}

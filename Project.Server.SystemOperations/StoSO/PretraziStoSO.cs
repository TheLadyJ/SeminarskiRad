using Project.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.SystemOperations.StoSO
{
	public class PretraziStoSO : SystemOperationBase
	{
		private string kriterijum;

		public PretraziStoSO(string kriterijum)
		{
			this.kriterijum = kriterijum;
		}

		protected override void Execute()
		{
			Result = repository.SearchJoin(new Sto(), kriterijum).OfType<Sto>().ToList();
		}
	}
}

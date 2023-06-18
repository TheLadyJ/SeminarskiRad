using Project.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.SystemOperations.RezervacijaSO
{
	public class PretraziRezervacijuSO : SystemOperationBase
	{
		private string kriterijum;

		public PretraziRezervacijuSO(string kriterijum)
		{
			this.kriterijum = kriterijum;
		}

		protected override void Execute()
		{
			Result = repository.SearchJoin(new Rezervacija(), kriterijum).OfType<Rezervacija>().ToList();
		}
	}
}

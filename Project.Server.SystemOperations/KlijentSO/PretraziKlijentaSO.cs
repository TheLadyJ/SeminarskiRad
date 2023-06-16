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
		private string kriterijum;

		public PretraziKlijentaSO(string kriterijum)
		{
			this.kriterijum = kriterijum;
		}

		protected override void Execute()
		{
			Result = repository.Search(new Klijent(), kriterijum).OfType<Klijent>().ToList();
		}
	}
}

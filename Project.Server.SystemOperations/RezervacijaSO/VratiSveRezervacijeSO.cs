using Project.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.SystemOperations.RezervacijaSO
{
	public class VratiSveRezervacijeSO : SystemOperationBase
	{
		protected override void Execute()
		{
			Result = repository.GetAllJoin(new Rezervacija()).OfType<Rezervacija>().ToList();
		}
	}
}

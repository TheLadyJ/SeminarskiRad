using Project.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.SystemOperations.KlijentSO
{
	public class VratiSveKlijenteSO : SystemOperationBase
	{
		protected override void Execute()
		{
			Result = repository.GetAll(new Klijent()).OfType<Klijent>().ToList();
		}
	}
}

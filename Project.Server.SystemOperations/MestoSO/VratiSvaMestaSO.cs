using Project.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.SystemOperations.MestoSO
{
	public class VratiSvaMestaSO : SystemOperationBase
	{
		protected override void Execute()
		{
			Result = repository.GetAll(new Mesto()).OfType<Mesto>().ToList();
		}
	}
}

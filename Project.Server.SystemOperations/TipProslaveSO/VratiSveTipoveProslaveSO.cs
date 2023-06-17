using Project.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.SystemOperations.TipProslaveSO
{
	public class VratiSveTipoveProslaveSO : SystemOperationBase
	{
		protected override void Execute()
		{
			Result = repository.GetAll(new TipProslave()).OfType<TipProslave>().ToList();
		}
	}
}

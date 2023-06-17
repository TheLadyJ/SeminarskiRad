using Project.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.SystemOperations.KeteringMeniSO
{
	public class VratiMenijeFirmeSO : SystemOperationBase
	{
		private KeteringFirma firma;

		public VratiMenijeFirmeSO(KeteringFirma firma)
		{
			this.firma = firma;
		}

		protected override void Execute()
		{
			Result = repository.Search(new KeteringMeni(), firma.KeteringFirmaID.ToString()).OfType<KeteringMeni>().ToList();
		}
	}
}

using Project.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.SystemOperations.RezervisanStoSO
{
	public class VratiStoloveRezervacijeSO : SystemOperationBase
	{
		private Rezervacija rezervacija;

		public VratiStoloveRezervacijeSO(Rezervacija rezervacija)
		{
			this.rezervacija = rezervacija;
		}

		protected override void Execute()
		{
			Result = repository.SearchJoin(new RezervisanSto(), rezervacija.RezervacijaID.ToString()).OfType<RezervisanSto>().ToList();
		}
	}
}

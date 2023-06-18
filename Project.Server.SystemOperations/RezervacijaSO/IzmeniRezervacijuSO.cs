using Project.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.SystemOperations.RezervacijaSO
{
	public class IzmeniRezervacijuSO : SystemOperationBase
	{
		private Rezervacija rezervacija;

		public IzmeniRezervacijuSO(Rezervacija rezervacija)
		{
			this.rezervacija = rezervacija;
		}

		protected override void Execute()
		{
			repository.Update(rezervacija);
		}
	}
}

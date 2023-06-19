using Project.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.SystemOperations.RezervacijaSO
{
	public class ObrisiRezervacijuSO : SystemOperationBase
	{
		private Rezervacija rezervacija;

		public ObrisiRezervacijuSO(Rezervacija rezervacija)
		{
			this.rezervacija = rezervacija;
		}

		protected override void Execute()
		{
			foreach(RezervisanSto rs in rezervacija.RezervisaniStolovi)
			{
				repository.Delete(rs);
			}

			repository.Delete(rezervacija);
		}
	}
}

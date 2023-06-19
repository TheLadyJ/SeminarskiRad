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

			List<RezervisanSto> rezStoloviZaBrisanje = rezervacija.RezervisaniStolovi.Except(rezervacija.NoviRezervisaniStolovi).ToList();
			List<RezervisanSto> rezStoloviZaDodavanje = rezervacija.NoviRezervisaniStolovi.Except(rezervacija.RezervisaniStolovi).ToList();

			foreach(RezervisanSto rsBrisanje in rezStoloviZaBrisanje)
			{
				repository.Delete(rsBrisanje);
			}

			foreach (RezervisanSto rsDodavanje in rezStoloviZaDodavanje)
			{
				repository.Insert(rsDodavanje);
			}
		}
	}
}


using Project.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.SystemOperations.RadnikSO
{
    public class PrijaviRadnikaSO : SystemOperationBase
    {
        private Radnik Radnik;

        public PrijaviRadnikaSO(Radnik Radnik)
        {
            this.Radnik = Radnik;
        }

        protected override void Execute()
        {
            List<Radnik> radnici = repository.GetAll(new Radnik()).OfType<Radnik>().ToList();
            Result = radnici.FirstOrDefault(r => r.KorisnickoIme == Radnik.KorisnickoIme && r.Lozinka == Radnik.Lozinka); 
        }
    }
}

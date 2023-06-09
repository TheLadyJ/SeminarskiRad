using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Common.Domain
{
    public class StoRezervacije : IDomainObject
    {
        public Rezervacija Rezervacija { get; set; }
        public Sto Sto { get; set; }

        public string TableName => "StoRezervacije";

        public string InsertValues => $"{Rezervacija.RezervacijaID}, {Sto.RbStola}";

        public string UpdateValues => $"RezervacijaID = {Rezervacija.RezervacijaID}, RbStola = {Sto.RbStola}";

        public string SearchCondition { get; set; }

        public string IdCondition => $"RezervacijaID = {Rezervacija.RezervacijaID}, RbStola = {Sto.RbStola}";

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            StoRezervacije sr = new StoRezervacije();
            sr.Rezervacija = new Rezervacija
            {
                RezervacijaID = (int)reader["RezervacijaID"]
            };
            sr.Sto = new Sto
            {
                RbStola = (int)reader["RbStola"]
            };
            return sr;
        }
    }
}

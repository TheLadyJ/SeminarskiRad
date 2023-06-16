using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Common.Domain
{
    [Serializable]
    public class Radnik : IDomainObject
    {
        public int RadnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }

        public List<Rezervacija> Rezervacije { get; set; }

        public string TableName => "Radnik";

        public string InsertValues => $"'{Ime}', '{Prezime}', '{KorisnickoIme}', '{Lozinka}'";

        public string UpdateValues => $"Ime = '{Ime}', Prezime = '{Prezime}', KorisnickoIme = '{KorisnickoIme}', Lozinka = '{Lozinka}'";

        public string SearchCondition => "";

		public string IdCondition => $"RadnikID = {RadnikID}";

        public string Join => "";

		public void AddParameters(SqlCommand command)
		{

		}

		public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Radnik r = new Radnik();
            r.RadnikID = (int)reader["RadnikID"];
            r.Ime = (string)reader["Ime"];
            r.Prezime = (string)reader["Prezime"];
            r.KorisnickoIme = (string)reader["KorisnickoIme"];
            r.Lozinka = (string)reader["Lozinka"];
            return r;
        }

        public IDomainObject ReadObjectRowJoin(SqlDataReader reader)
        {
            return ReadObjectRow(reader);
        }

        public override bool Equals(object obj)
        {
            if(obj is Radnik radnik)
            {
                return radnik.RadnikID == RadnikID;
            }
            return false;
        }
		
	}
}

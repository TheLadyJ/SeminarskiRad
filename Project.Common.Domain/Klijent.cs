using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Common.Domain
{
    [Serializable]
    public class Klijent : IDomainObject
    {
        public int KlijentID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public List<Rezervacija> Rezervacije { get; set; }

        public string TableName => "Klijent";

        public string InsertValues => $"'{Ime}', '{Prezime}', '{Telefon}', '{Email}'";

        public string IdCondition => $"KlijentID = {KlijentID}";

        public string UpdateValues => $"Ime = '{Ime}', Prezime = '{Prezime}', Telefon = '{Telefon}', Email = '{Email}'";
        public string SearchCondition =>	$"Ime LIKE '%' + @Kriterijum + '%' OR " +
											$"Prezime LIKE '%' + @Kriterijum + '%' OR " +
											$"Telefon LIKE '%' + @Kriterijum + '%' OR " +
											$"Email LIKE '%' + @Kriterijum + '%'";

		public string Join => "";

		public string Id => $"KlijentID";

		public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Klijent k = new Klijent();
            k.KlijentID = (int)reader["KlijentID"];
            k.Ime = (string)reader["Ime"];
            k.Prezime = (string)reader["Prezime"];
            k.Telefon = (string)reader["Telefon"];
            k.Email = (string)reader["Email"];
            return k;
        }

        public IDomainObject ReadObjectRowJoin(SqlDataReader reader)
        {
            return ReadObjectRow(reader);
        }

		public override bool Equals(object obj)
		{
			if (obj is Klijent k)
			{
				return k.KlijentID == KlijentID;
			}
			return false;
		}
		public override string ToString()
		{
			return $"{Ime} {Prezime}";
		}
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public void SetId(object id)
		{
			KlijentID = (int)id;
		}
	}
}

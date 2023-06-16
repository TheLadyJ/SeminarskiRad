using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Common.Domain
{
    [Serializable]
	public class StoRezervacije : IDomainObject
    {
        public Rezervacija Rezervacija { get; set; }
        public Sto Sto { get; set; }

        public string TableName => "StoRezervacije";

        public string InsertValues => $"{Rezervacija.RezervacijaID}, {Sto.RbStola}";

        public string UpdateValues => $"RezervacijaID = {Rezervacija.RezervacijaID}, RbStola = {Sto.RbStola}";

        public string SearchCondition => "";

		public string IdCondition => $"RezervacijaID = {Rezervacija.RezervacijaID}, RbStola = {Sto.RbStola}";

        public string Join => "join Rezervacija on Rezervacija.RezervacijaID = StoRezervacije.RezervacijaID " +
                                "join Sto on Sto.RbStola=StoRezervacije.RbStola";

		public void AddParameters(SqlCommand command)
		{
			
		}

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

        public IDomainObject ReadObjectRowJoin(SqlDataReader reader)
        {
            StoRezervacije sr = new StoRezervacije();
            sr.Rezervacija = new Rezervacija
            {
                RezervacijaID = reader.GetInt32(2),
                Datum = reader.GetDateTime(3),
                TipProslave = new TipProslave
                {
                    TipProslaveID = reader.GetInt32(4)
                },
                UkupnaCena = reader.GetDouble(5),
                Radnik = new Radnik
                {
                    RadnikID = reader.GetInt32(6)
                },
                Klijent = new Klijent
                {
                    KlijentID = reader.GetInt32(7)
                },
                Mesto = new Mesto
                {
                    MestoID = reader.GetInt32(8)
                },
                KeteringMeni = new KeteringMeni
                {
                    KeteringMeniID = reader.GetInt32(9)
                }
            };
            sr.Sto = new Sto
            {
                RbStola = (int)reader["RbStola"],
                Kapacitet = (int)reader["Kapacitet"],
                CenaStola = (double)reader["CenaStola"],
                Proizvodjac = new Proizvodjac
                {
                    ProizvodjacID = (int)reader["ProizvodjacID"],
                }
            };
    
            return sr;
        }
}
}

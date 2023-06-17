using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Common.Domain
{
    [Serializable]
	public class RezervisanSto : IDomainObject
    {
        public Rezervacija Rezervacija { get; set; } = new Rezervacija();
        public Sto Sto { get; set; }
        public int RbStola { get; set; }

        public string TableName => "StoRezervacije";

        public string InsertValues => $"{Rezervacija.RezervacijaID}, {Sto.StoID}";

        public string UpdateValues => $"RezervacijaID = {Rezervacija.RezervacijaID}, StoID = {Sto.StoID}";

        public string SearchCondition => "";

		public string IdCondition => $"RezervacijaID = {Rezervacija.RezervacijaID}, StoID = {Sto.StoID}";

        public string Join => "join Rezervacija on Rezervacija.RezervacijaID = StoRezervacije.RezervacijaID " +
								"join Sto on Sto.StoID=StoRezervacije.StoID";

		public void AddParameters(SqlCommand command, string kriterijum)
		{
			
		}

		public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            RezervisanSto sr = new RezervisanSto();
            sr.Rezervacija = new Rezervacija
            {
                RezervacijaID = (int)reader["RezervacijaID"]
            };
            sr.Sto = new Sto
            {
                StoID = (int)reader["StoID"]
            };
            sr.RbStola = (int)reader["RbStola"];

			return sr;
        }

        public IDomainObject ReadObjectRowJoin(SqlDataReader reader)
        {
            RezervisanSto sr = new RezervisanSto();
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
                StoID = (int)reader["StoID"],
                Kapacitet = (int)reader["Kapacitet"],
                CenaStola = (double)reader["CenaStola"],
                Proizvodjac = new Proizvodjac
                {
                    ProizvodjacID = (int)reader["ProizvodjacID"],
                }
            };
			sr.RbStola = (int)reader["RbStola"];


			return sr;
        }

		public override bool Equals(object obj)
		{
			if (obj is RezervisanSto sr)
			{
				return (sr.Sto.StoID == Sto.StoID && sr.Rezervacija.RezervacijaID == Rezervacija.RezervacijaID);
			}
			return false;
		}
		public override string ToString()
		{
			return $"Sto: [{Sto}] za rezervaciju: [{Rezervacija}], redni broj: {RbStola}";
		}
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
}

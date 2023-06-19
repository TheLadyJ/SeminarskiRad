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

        public string TableName => "RezervisanSto";

        public string InsertValues => $"{Rezervacija.RezervacijaID}, {Sto.RbStola}";

        public string UpdateValues => $"RezervacijaID = {Rezervacija.RezervacijaID}, RbStola = {Sto.RbStola}";

        public string SearchCondition => "CAST(Rezervacija.RezervacijaID AS VARCHAR(100)) = @Kriterijum";

		public string IdCondition => $"RezervacijaID = {Rezervacija.RezervacijaID} AND RbStola = {Sto.RbStola}";

        public string Join => "join Rezervacija on Rezervacija.RezervacijaID = RezervisanSto.RezervacijaID " +
								"join Sto on Sto.RbStola =RezervisanSto.RbStola " +
								"join Proizvodjac on Sto.ProizvodjacID = Proizvodjac.ProizvodjacID";

		public string Id => $"RbStola";
		public string InsertUpdateCondition => "";



		public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            RezervisanSto sr = new RezervisanSto();
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
            RezervisanSto sr = new RezervisanSto();
            sr.Rezervacija = new Rezervacija
            {
                RezervacijaID = reader.GetInt32(0),
                DatumVremeOd = (DateTime)reader["Datum"],
                TipProslave = new TipProslave
                {
                    TipProslaveID = (int)reader["TipProslaveID"]
				},
                UkupnaCena = (double)reader["UkupnaCena"],
				Mesto = new Mesto
                {
                    MestoID = (int)reader["MestoID"]
				},
                Radnik = new Radnik
                {
                    RadnikID = (int)reader["RadnikID"]
				},
                Klijent = new Klijent
                {
                    KlijentID = (int)reader["KlijentID"]
				},
                KeteringMeni = new KeteringMeni
                {
                    KeteringMeniID = (int)reader["KeteringMeniID"]
				}
            };
            sr.Sto = new Sto
            {
				RbStola = reader.GetInt32(1),
                Kapacitet = (int)reader["Kapacitet"],
                CenaStola = (double)reader["CenaStola"],
                Proizvodjac = new Proizvodjac
                {
                    ProizvodjacID = reader.GetInt32(14),
                    NazivProizvodjaca = (string)reader["NazivProizvodjaca"],
                    Telefon = (string)reader["Telefon"],
                    Email = (string)reader["Email"],
				}
            };


			return sr;
        }

		public override bool Equals(object obj)
		{
			if (obj is RezervisanSto sr)
			{
				return (sr.Sto.RbStola == Sto.RbStola && sr.Rezervacija.RezervacijaID == Rezervacija.RezervacijaID);
			}
			return false;
		}
		public override string ToString()
		{
			return $"Sto: [{Sto}] za rezervaciju: [{Rezervacija}]";
		}
		//public override int GetHashCode()
		//{
		//	return base.GetHashCode();
		//}

		public void SetId(object id)
		{
            Sto.RbStola = (int)id;
		}
	}
}

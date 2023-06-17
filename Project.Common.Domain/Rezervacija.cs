using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Common.Domain
{
	[Serializable]
	public class Rezervacija : IDomainObject
    {
        public int RezervacijaID { get; set; }
        public DateTime Datum { get; set; }
        public TipProslave TipProslave { get; set; }
        public double UkupnaCena { get; set; }
        public Radnik Radnik { get; set; }
        public Klijent Klijent { get; set; }
        public Mesto Mesto { get; set; }
        public KeteringMeni KeteringMeni { get; set; }

        public List<RezervisanSto> StoloviRezervacije { get; set; }

        public string TableName => "Rezervacija";

        public string InsertValues => $"{Datum}, {TipProslave.TipProslaveID}, {UkupnaCena}, {Radnik.RadnikID}, {Klijent.KlijentID}, {Mesto.MestoID}, {KeteringMeni.KeteringMeniID}";

        public string UpdateValues => $"Datum = {Datum}, TipProslaveID = {TipProslave.TipProslaveID}, UkupnaCena = {UkupnaCena}, RadnikID = {Radnik.RadnikID}, KlijentID = {Klijent.KlijentID}, MestoID = {Mesto.MestoID}, KeteringMeniID = {KeteringMeni.KeteringMeniID}";

        public string SearchCondition => "";

		public string IdCondition => $"RezervacijaID = {RezervacijaID}";

        public string Join => "join TipProslave on TipProslave.TipProslaveID = Rezervacija.TipProslaveID " +
                                "join Radnik on Radnik.RadnikID = Rezervacija.RadnikID " +
                                "join Klijent on Klijent.KlijentID = Rezervacija.KlijentID " +
                                "join Mesto on Mesto.MestoID = Rezervacija.MestoID " +
                                "join KeteringMeni on KeteringMeni.KeteringMeniID = Rezervacija.KeteringMeniID" +
                                "join KeteringFirma on KeteringMeni.KeteringFirmaID=KeteringFirma.KeteringFirmaID";

		public void AddParameters(SqlCommand command, string kriterijum)
		{

		}

		public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Rezervacija r = new Rezervacija();
            r.RezervacijaID = (int)reader["RezervacijaID"];
            r.Datum = (DateTime)reader["Datum"];
            r.TipProslave = new TipProslave
            {
                TipProslaveID = (int)reader["TipProslaveID"]
            };
            r.UkupnaCena = (double)reader["UkupnaCena"];
            r.Radnik = new Radnik
            {
                RadnikID = (int)reader["RadnikID"]
            };
            r.Klijent = new Klijent
            {
                KlijentID = (int)reader["KlijentID"]
            };
            r.Mesto = new Mesto
            {
                MestoID = (int)reader["MestoID"]
            };
            r.KeteringMeni = new KeteringMeni
            {
                KeteringMeniID = (int)reader["KeteringMeniID"]
            };
            return r;
        }

        public IDomainObject ReadObjectRowJoin(SqlDataReader reader)
        {
            Rezervacija r = new Rezervacija();
            r.RezervacijaID = (int)reader["RezervacijaID"];
            r.Datum = (DateTime)reader["Datum"];
            r.TipProslave = new TipProslave
            {
                TipProslaveID = reader.GetInt32(8),
                NazivTipaProslave = reader.GetString(9)
            };
            r.UkupnaCena = (double)reader["UkupnaCena"];
            r.Radnik = new Radnik
            {
                RadnikID = reader.GetInt32(10),
                Ime = reader.GetString(11),
                Prezime = reader.GetString(12),
                KorisnickoIme = reader.GetString(13),
                Lozinka = reader.GetString(14),
            };
            r.Klijent = new Klijent
            {
                KlijentID = reader.GetInt32(15),
                Ime = reader.GetString(16),
                Prezime = reader.GetString(17),
                Telefon = reader.GetString(18),
                Email = reader.GetString(19),
            };
            r.Mesto = new Mesto
            {
                MestoID = reader.GetInt32(20),
                Grad = reader.GetString(21),
                PostanskiBroj = reader.GetString(22),
                Adresa = reader.GetString(23),
            };
            r.KeteringMeni = new KeteringMeni
            {
                KeteringMeniID = reader.GetInt32(24),
                Predjelo = reader.GetString(25),
                GlavnoJelo = reader.GetString(26),
                Dezert = reader.GetString(27),
                CenaHranePoOsobi = reader.GetDouble(28),
                KeteringFirma = new KeteringFirma
                {
                    KeteringFirmaID = reader.GetInt32(30),
                    NazivFirme = reader.GetString(31),
                    Telefon = reader.GetString(32),
                    Email = reader.GetString(33)
                }
            };
            return r;
        }

		public override bool Equals(object obj)
		{
			if (obj is Rezervacija r)
			{
				return r.RezervacijaID == RezervacijaID;
			}
			return false;
		}
		public override string ToString()
		{
			return $"Rezervacija za klijenta: {Klijent}; Tip Proslave: {TipProslave}; Mesto: {Mesto}; Datum i vreme: {Datum}";
		}
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
}

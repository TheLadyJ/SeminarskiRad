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
        public int RezervacijaID { get; set; } = -1;
        public DateTime DatumVremeOd { get; set; }
        public DateTime DatumVremeDo { get; set; }
        public TipProslave TipProslave { get; set; }
        public double UkupnaCena { get; set; }
        public Radnik Radnik { get; set; }
        public Klijent Klijent { get; set; }
        public Mesto Mesto { get; set; }
        public KeteringMeni KeteringMeni { get; set; }

        public List<RezervisanSto> RezervisaniStolovi { get; set; }
        public List<RezervisanSto> NoviRezervisaniStolovi { get; set; }

        public string TableName => "Rezervacija";

        public string InsertValues => $"'{DatumVremeOd}', {TipProslave.TipProslaveID}, {UkupnaCena}, {Mesto.MestoID}, {Radnik.RadnikID}, {Klijent.KlijentID}, {KeteringMeni.KeteringMeniID}, '{DatumVremeDo}'";

        public string UpdateValues => $"Datum = '{DatumVremeOd}', TipProslaveID = {TipProslave.TipProslaveID}, UkupnaCena = {UkupnaCena}, RadnikID = {Radnik.RadnikID}, KlijentID = {Klijent.KlijentID}, MestoID = {Mesto.MestoID}, KeteringMeniID = {KeteringMeni.KeteringMeniID}";

        public string SearchCondition =>    $"CONVERT(VARCHAR(100), DatumVremeOd, 34) LIKE '%' + @Kriterijum + '%' OR " +
			                                $"CONVERT(VARCHAR(100), DatumVremeOd, 8) LIKE '%' + @Kriterijum + '%' OR " +
			                                $"CONVERT(VARCHAR(100), DatumVremeDo, 8) LIKE '%' + @Kriterijum + '%' OR " +
											$"CAST(UkupnaCena AS VARCHAR(100)) LIKE '%' + @Kriterijum + '%' OR " +
											$"NazivTipaProslave LIKE '%' + @Kriterijum + '%' OR " +
											$"Grad LIKE '%' + @Kriterijum + '%' OR " +
											$"PostanskiBroj LIKE '%' + @Kriterijum + '%' OR " +
											$"Adresa LIKE '%' + @Kriterijum + '%' OR " +
											$"Radnik.Ime LIKE '%' + @Kriterijum + '%' OR " +
											$"Radnik.Prezime LIKE '%' + @Kriterijum + '%' OR " +
											$"Klijent.Ime LIKE '%' + @Kriterijum + '%' OR " +
			                                $"Klijent.Prezime LIKE '%' + @Kriterijum + '%'";

		public string IdCondition => $"RezervacijaID = {RezervacijaID}";

        public string Join => "join TipProslave on TipProslave.TipProslaveID = Rezervacija.TipProslaveID " +
                                "join Radnik on Radnik.RadnikID = Rezervacija.RadnikID " +
                                "join Klijent on Klijent.KlijentID = Rezervacija.KlijentID " +
                                "join Mesto on Mesto.MestoID = Rezervacija.MestoID " +
                                "join KeteringMeni on KeteringMeni.KeteringMeniID = Rezervacija.KeteringMeniID " +
                                "join KeteringFirma on KeteringMeni.KeteringFirmaID=KeteringFirma.KeteringFirmaID ";

		public string Id => $"RezervacijaID";

		public string InsertUpdateCondition => $"MestoID = {Mesto.MestoID} AND " +
                                                $"(DatumVremeOd BETWEEN '{DatumVremeOd}' AND '{DatumVremeDo}' OR " +
                                                $"DatumVremeDo BETWEEN '{DatumVremeOd}' AND '{DatumVremeDo}' OR " +
                                                $"'{DatumVremeOd}' BETWEEN DatumVremeOd AND DatumVremeDo)";


		public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Rezervacija r = new Rezervacija();
            r.RezervacijaID = (int)reader["RezervacijaID"];
            r.DatumVremeOd = (DateTime)reader["DatumVremeOd"];
			r.DatumVremeDo = (DateTime)reader["DatumVremeDo"];

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
            r.DatumVremeOd = (DateTime)reader["DatumVremeOd"];
			r.DatumVremeDo = (DateTime)reader["DatumVremeDo"];
			r.TipProslave = new TipProslave
            {
                TipProslaveID = reader.GetInt32(9),
                NazivTipaProslave = reader.GetString(10)
            };
            r.UkupnaCena = (double)reader["UkupnaCena"];
            r.Radnik = new Radnik
            {
                RadnikID = reader.GetInt32(11),
                Ime = reader.GetString(12),
                Prezime = reader.GetString(13),
                KorisnickoIme = reader.GetString(14),
                Lozinka = reader.GetString(15),
            };
            r.Klijent = new Klijent
            {
                KlijentID = reader.GetInt32(16),
                Ime = reader.GetString(17),
                Prezime = reader.GetString(18),
                Telefon = reader.GetString(19),
                Email = reader.GetString(20),
            };
            r.Mesto = new Mesto
            {
                MestoID = reader.GetInt32(21),
                Grad = reader.GetString(22),
                PostanskiBroj = reader.GetString(23),
                Adresa = reader.GetString(24),
            };
            r.KeteringMeni = new KeteringMeni
            {
                KeteringMeniID = reader.GetInt32(25),
                Predjelo = reader.GetString(26),
                GlavnoJelo = reader.GetString(27),
                Dezert = reader.GetString(28),
                CenaHranePoOsobi = reader.GetDouble(29),
                KeteringFirma = new KeteringFirma
                {
                    KeteringFirmaID = reader.GetInt32(31),
                    NazivFirme = reader.GetString(32),
                    Telefon = reader.GetString(33),
                    Email = reader.GetString(34)
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
			return $"Rezervacija za klijenta: {Klijent}; Tip Proslave: {TipProslave}; Mesto: {Mesto}; Datum i vreme od: {DatumVremeOd}, Datum i vreme do: {DatumVremeDo}";
		}
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public void SetId(object id)
		{
            RezervacijaID = (int)id;
		}
	}
}

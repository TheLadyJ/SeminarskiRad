using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Common.Domain
{
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

        public List<StoRezervacije> StoloviRezervacije { get; set; }

        public string TableName => "Rezervacija";

        public string InsertValues => $"{Datum}, {TipProslave.TipProslaveID}, {UkupnaCena}, {Radnik.RadnikID}, {Klijent.KlijentID}, {Mesto.MestoID}, {KeteringMeni.KeteringMeniID}";

        public string UpdateValues => $"Datum = {Datum}, TipProslaveID = {TipProslave.TipProslaveID}, UkupnaCena = {UkupnaCena}, RadnikID = {Radnik.RadnikID}, KlijentID = {Klijent.KlijentID}, MestoID = {Mesto.MestoID}, KeteringMeniID = {KeteringMeni.KeteringMeniID}";

        public string SearchCondition { get; set; }

        public string IdCondition => $"RezervacijaID = {RezervacijaID}";

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
    }
}

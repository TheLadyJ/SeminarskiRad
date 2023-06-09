using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Common.Domain
{
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
        public string SearchCondition { get; set; }

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
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Common.Domain
{
    public class Sto : IDomainObject
    {
        public int RbStola { get; set; }
        public int Kapacitet { get; set; }
        public double CenaStola { get; set; }

        public Proizvodjac Proizvodjac { get; set; }

        public List<StoRezervacije> StoRezervacija { get; set; }

        public string TableName => "Sto";

        public string InsertValues => $"{Kapacitet}, {CenaStola}, {Proizvodjac.ProizvodjacID}";

        public string UpdateValues => $"Kapacitet = {Kapacitet}, CenaStola = {CenaStola}, ProizvodnjacID = {Proizvodjac.ProizvodjacID}";

        public string SearchCondition { get; set; }

        public string IdCondition => $"RbStola = {RbStola}";

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Sto s = new Sto();
            s.RbStola = (int)reader["RbStola"];
            s.Kapacitet = (int)reader["Kapacitet"];
            s.CenaStola = (double)reader["CenaStola"];
            s.Proizvodjac = new Proizvodjac
            {
                ProizvodjacID = (int)reader["ProizvodnjacID"]
            };
            return s;
        }
    }
}

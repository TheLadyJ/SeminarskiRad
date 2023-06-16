using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Common.Domain
{
    [Serializable]
    public class Mesto : IDomainObject
    {
        public int MestoID { get; set; }
        public string Grad { get; set; }
        public int PostanskiBroj { get; set; }
        public string Adresa { get; set; }

        public List<Rezervacija> Rezervacije { get; set; }

        public string TableName => "Mesto";

        public string InsertValues => $"'{Grad}', {PostanskiBroj}, '{Adresa}'";

        public string UpdateValues => $"Grad = '{Grad}', PostanskiBroj = {PostanskiBroj}, Adresa = '{Adresa}'";

        public string SearchCondition => "";

		public string IdCondition => $"MestoID = {MestoID}";

        public string Join => "";

		public void AddParameters(SqlCommand command)
		{
			
		}

		public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Mesto m = new Mesto();
            m.MestoID = (int)reader["MestoID"];
            m.Grad = (string)reader["Grad"];
            m.PostanskiBroj = (int)reader["PostanskiBroj"];
            m.Adresa = (string)reader["Adresa"];
            return m;
        }

        public IDomainObject ReadObjectRowJoin(SqlDataReader reader)
        {
            return ReadObjectRow(reader);
        }
    }
}

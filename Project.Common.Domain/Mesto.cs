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
        public string PostanskiBroj { get; set; }
        public string Adresa { get; set; }

        public List<Rezervacija> Rezervacije { get; set; }

        public string TableName => "Mesto";

        public string InsertValues => $"'{Grad}', '{PostanskiBroj}', '{Adresa}'";

        public string UpdateValues => $"Grad = '{Grad}', PostanskiBroj = '{PostanskiBroj}', Adresa = '{Adresa}'";

        public string SearchCondition => "";

		public string IdCondition => $"MestoID = {MestoID}";

        public string Join => "";

		public string Id => $"MestoID";

		public string InsertUpdateDeleteCondition => "";


		public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Mesto m = new Mesto();
            m.MestoID = (int)reader["MestoID"];
            m.Grad = (string)reader["Grad"];
            m.PostanskiBroj = (string)reader["PostanskiBroj"];
            m.Adresa = (string)reader["Adresa"];
            return m;
        }

        public IDomainObject ReadObjectRowJoin(SqlDataReader reader)
        {
            return ReadObjectRow(reader);
        }

		public override bool Equals(object obj)
		{
			if (obj is Mesto m)
			{
				return m.MestoID == MestoID;
			}
			return false;
		}
		public override string ToString()
		{
			return $"{Adresa}, {Grad}, {PostanskiBroj}";
		}
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public void SetId(object id)
		{
			MestoID = (int)id;
		}
	}
}

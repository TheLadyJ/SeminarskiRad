using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Common.Domain
{
    [Serializable]
    public class Proizvodjac : IDomainObject
    {
        public int ProizvodjacID { get; set; }
        public string NazivProizvodjaca { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }

        public List<Sto> Stolovi { get; set; }

        public string TableName => "Proizvodjac";

        public string InsertValues => $"'{NazivProizvodjaca}', '{Telefon}', '{Email}'";

        public string UpdateValues => $"NazivProizvodjaca = '{NazivProizvodjaca}', Telefon = '{Telefon}', Email = '{Email}'";

        public string SearchCondition => "";

		public string IdCondition => $"ProizvodnjacID = {ProizvodjacID}";

        public string Join => "";

		public void AddParameters(SqlCommand command)
		{

		}

		public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Proizvodjac p = new Proizvodjac();
            p.ProizvodjacID = (int)reader["ProizvodjacID"];
            p.NazivProizvodjaca = (string)reader["NazivProizvodjaca"];
            p.Telefon = (string)reader["Telefon"];
            p.Email = (string)reader["Email"];
            return p;
        }

        public IDomainObject ReadObjectRowJoin(SqlDataReader reader)
        {
            return ReadObjectRow(reader);
        }
    }
}

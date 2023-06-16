using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Common.Domain
{
    [Serializable]
	public class TipProslave : IDomainObject
    {
        public int TipProslaveID { get; set; }
        public string NazivTipaProslave { get; set; }

        public List<Rezervacija> Rezervacije { get; set; }

        public string TableName => "TipProslave";

        public string InsertValues => $"'{NazivTipaProslave}'";

        public string UpdateValues => $"NazivTipaProslave = '{NazivTipaProslave}'";

        public string SearchCondition => "";

		public string IdCondition => $"TipProslaveID = {TipProslaveID}";

        public string Join => "";

		public void AddParameters(SqlCommand command)
		{
			
		}

		public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            TipProslave tp = new TipProslave();
            tp.TipProslaveID = (int)reader["TipProslaveID"];
            tp.NazivTipaProslave = (string)reader["NazivTipaProslave"];
            return tp;
        }

        public IDomainObject ReadObjectRowJoin(SqlDataReader reader)
        {
            return ReadObjectRow(reader);
        }
    }
}

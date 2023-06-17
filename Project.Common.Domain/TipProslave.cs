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

		public string Id => $"TipProslaveID";

		public void AddParameters(SqlCommand command, string kriterijum)
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

		public override bool Equals(object obj)
		{
			if (obj is TipProslave tp)
			{
				return tp.TipProslaveID == TipProslaveID;
			}
			return false;
		}
		public override string ToString()
		{
			return NazivTipaProslave;
		}
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public void SetId(object id)
		{
			TipProslaveID = (int)id;
		}
	}
}

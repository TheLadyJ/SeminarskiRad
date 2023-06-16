using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Common.Domain
{
    [Serializable]
    public class KeteringFirma : IDomainObject
    {
        public int KeteringFirmaID { get; set; }
        public string NazivFirme { get; set; }

        public string Telefon { get; set; }
        public string Email { get; set; }

        public string TableName => "KeteringFirma";

        public string InsertValues => $"'{NazivFirme}', '{Telefon}', '{Email}'";

        public string IdCondition => $"KeteringFirmaID = {KeteringFirmaID}";

        public string UpdateValues => $"NazivFirme = '{NazivFirme}', Telefon = '{Telefon}', Email = '{Email}'";

        public string SearchCondition => "";

		public string Join => "";

		public void AddParameters(SqlCommand command, string kriterijum)
		{
			
		}


		public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            KeteringFirma kf = new KeteringFirma();
            kf.KeteringFirmaID = (int)reader["KeteringFirmaID"];
            kf.NazivFirme = (string)reader["NazivFirme"];
            kf.Telefon = (string)reader["Telefon"];
            kf.Email = (string)reader["Email"];
            return kf;
        }

        public IDomainObject ReadObjectRowJoin(SqlDataReader reader)
        {
            return ReadObjectRow(reader);
        }

		public override bool Equals(object obj)
		{
            if(obj is KeteringFirma kf)
            {
                return kf.KeteringFirmaID == KeteringFirmaID;
            }
            return false;
		}
		public override string ToString()
		{
            return NazivFirme;
		}
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
}

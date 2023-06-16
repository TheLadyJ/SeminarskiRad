using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Common.Domain
{
    public interface IDomainObject
    {
        string TableName { get; }
        string InsertValues { get; }
        string UpdateValues { get; }
        string Join { get; }

        string SearchCondition { get; }
        string IdCondition { get; }

        IDomainObject ReadObjectRow(SqlDataReader reader);
        IDomainObject ReadObjectRowJoin(SqlDataReader reader);
        void AddParameters(SqlCommand command);
	}
}

using Project.Common.Domain;
using Project.Server.DatabseBroker;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Repository.DatabaseRepository
{
    public class GenericDbRepository : IRepository<IDomainObject>
    {
        private Broker broker = new Broker();

        public void OpenConnection()
        {
            broker.OpenConnection();
        }
        public void BeginTransaction()
        {
            broker.BeginTransaction();
        }
        public void Commit()
        {
            broker.Commit();
        }

        public void Rollback()
        {
            broker.Rollback();
        }

        public void CloseConnection()
        {
            broker.CloseConnection();
        }

        private List<IDomainObject> ReadList(SqlCommand command, IDomainObject obj)
        {
            List<IDomainObject> result = new List<IDomainObject>();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject rowObject = obj.ReadObjectRow(reader);
                    result.Add(rowObject);
                }
            }
            return result;
        }

        private List<IDomainObject> ReadListJoin(SqlCommand command, IDomainObject obj)
        {
            List<IDomainObject> result = new List<IDomainObject>();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject rowObject = obj.ReadObjectRowJoin(reader);
                    result.Add(rowObject);
                }
            }
            return result;
        }


        public void Insert(IDomainObject obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"insert into {obj.TableName} values ({obj.InsertValues})";
            command.ExecuteNonQuery();
        }
        public void Update(IDomainObject obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"update {obj.TableName} set {obj.UpdateValues} where {obj.IdCondition}";
            command.ExecuteNonQuery();
        }

        public void Delete(IDomainObject obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"delete from {obj.TableName} where {obj.IdCondition}";
            command.ExecuteNonQuery();
        }

        public List<IDomainObject> GetAll(IDomainObject obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select * from {obj.TableName}";
            return ReadList(command, obj);
        }

        public List<IDomainObject> GetAllJoin(IDomainObject obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select * from {obj.TableName} {obj.Join}";
            return ReadListJoin(command, obj);
        }


        public List<IDomainObject> Search(IDomainObject obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select * from {obj.TableName} where {obj.SearchCondition}";
            obj.AddParameters(command);
            return ReadList(command, obj);
        }


        public List<IDomainObject> SearchJoin(IDomainObject obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select * from {obj.TableName} {obj.Join} where {obj.SearchCondition}";
            return ReadListJoin(command, obj);
        }


    }
}

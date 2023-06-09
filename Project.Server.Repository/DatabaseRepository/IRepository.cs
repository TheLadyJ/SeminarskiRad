using Project.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Repository.DatabaseRepository
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll(IDomainObject obj);
        void Insert(T obj);
        void Update(T obj);
        void Delete(T obj);
        List<T> Search(IDomainObject obj);
        void OpenConnection();
        void CloseConnection();
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}

using Project.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Repository.DatabaseRepository
{
    public interface IRepository<IDomainObject>
    {
        List<IDomainObject> GetAll(IDomainObject obj);
        List<IDomainObject> GetAllJoin(IDomainObject obj);
        void Insert(IDomainObject obj);
        void Update(IDomainObject obj);
        void Delete(IDomainObject obj);
        List<IDomainObject> Search(IDomainObject obj);
        List<IDomainObject> SearchJoin(IDomainObject obj);
        void OpenConnection();
        void CloseConnection();
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}

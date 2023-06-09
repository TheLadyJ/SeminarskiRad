using Project.Common.Domain;
using Project.Server.Repository.DatabaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.SystemOperations
{
    public abstract class SystemOperationBase
    {
        protected IRepository<IDomainObject> repository = new GenericDbRepository();
        public void ExecuteTemplate()
        {
            try
            {
                repository.OpenConnection();
                repository.BeginTransaction();
                Execute();
                repository.Commit();

            }
            catch (Exception ex)
            {
                repository.Rollback();
                throw;
            }
            finally
            {
                repository.CloseConnection();
            }
        }
        protected abstract void Execute();

        public object Result { get; protected set; }
    }
}

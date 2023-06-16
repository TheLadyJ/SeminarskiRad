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

        private static object lockObject = new object();
        public void ExecuteTemplate()
        {
            lock (lockObject)
            {
                try
                {
                    repository.OpenConnection();
                    repository.BeginTransaction();
                    Execute();
                    repository.Commit();

                }
                catch (Exception)
                {
                    repository.Rollback();
                    throw;
                }
                finally
                {
                    repository.CloseConnection();
                } 
            }
        }
        protected abstract void Execute();

        public object Result { get; protected set; } = null;
    }
}

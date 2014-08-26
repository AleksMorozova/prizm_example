using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Linq;
using System.Threading.Tasks;
using Example.Entities;


namespace Example.DB
{
    public class RepositoryBase : IRepository, IDisposable
    {
        protected ISession _session = null;
        protected ITransaction _transaction = null;

        public RepositoryBase()
        {
            _session = Database.OpenSession();
        }

        public RepositoryBase(ISession session)
        {
            _session = session;
        }

        #region Transaction and Session Management Methods

        public void BeginTransaction()
        {
            _transaction = _session.BeginTransaction();
        }

        public void CommitTransaction()
        {
            // _transaction will be replaced with a new transaction
            // by NHibernate, but we will close to keep a consistent state.
            _transaction.Commit();

            CloseTransaction();
        }

        public void RollbackTransaction()
        {
            // _session must be closed and disposed after a transaction
            // rollback to keep a consistent state.
            _transaction.Rollback();

            CloseTransaction();
            CloseSession();
        }

        private void CloseTransaction()
        {
            _transaction.Dispose();
            _transaction = null;
        }

        public void CloseSession()
        {
            _session.Close();
            _session.Dispose();
            _session = null;
        }

        #endregion

        #region IRepository Members

        public virtual void Save(object obj)
        {
            _session.SaveOrUpdate(obj);
        }

        public virtual void Delete(object obj)
        {
            _session.Delete(obj);
        }

        public virtual void Update(object obj)
        {
            _session.SaveOrUpdate(obj);
        }

        public virtual IList<City> GetCity()
        {
            return _session.CreateCriteria<City>().List<City>();
        }

        public virtual IList<Certificate> GetCertificates()
        {
            return _session.CreateCriteria<Certificate>().List<Certificate>();
        }


        public virtual Person GetPerson()
        {
            return _session.QueryOver<Person>().Where(x => x.FirstName == "AnnM").SingleOrDefault();
        }


        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            if (_transaction != null)
            {
                // Commit transaction by default, unless user explicitly rolls it back.
                // To rollback transaction by default, unless user explicitly commits,
                // comment out the line below.
                CommitTransaction();
            }

            if (_session != null)
            {
                _session.Flush(); // commit session transactions
                CloseSession();
            }
        }

        #endregion
    }
}

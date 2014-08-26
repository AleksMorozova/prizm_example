using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;
using System.Reflection;

namespace Example
{
    public static class Database
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    var nhConfig = new Configuration().Configure();

                    nhConfig.SetProperty(
                     "connection.connection_string", @"Data Source=(LocalDB)\v11.0;AttachDbFilename="
                     + System.Environment.GetEnvironmentVariable("DATABASE")
                     + ";Integrated Security=True;Connect Timeout=30");

                    nhConfig.AddAssembly(Assembly.GetExecutingAssembly());
                    _sessionFactory = nhConfig.BuildSessionFactory();


                }

                return _sessionFactory;
            }
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}

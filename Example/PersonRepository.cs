using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NH    = NHibernate;
using NHCfg = NHibernate.Cfg;
using SRef  = System.Reflection;

namespace Example
{
    class PersonRepository : IPersonRepository
    {
        private Person p;

        /// <summary>
        /// IN REAL LIFE THIS METHOD SHOULD USE HIBERNATE TO RETRIEVE PERSON ENTITY
        /// </summary>
        /// <returns></returns>
        public Person GetPerson()
        {
            var nhConfig = new NHCfg.Configuration().Configure();
            nhConfig.SetProperty(
              "connection.connection_string", @"Data Source=(LocalDB)\v11.0;AttachDbFilename="
              + System.Environment.GetEnvironmentVariable("DATABASE")
              + ";Integrated Security=True;Connect Timeout=30");
            nhConfig.AddAssembly(SRef.Assembly.GetExecutingAssembly());
            var sessionFactory = nhConfig.BuildSessionFactory();

            using (NH.ISession session = sessionFactory.OpenSession())
            {
                var prof = session.QueryOver<Person>().Where(x => x.FirstName == "Aleksandra").SingleOrDefault();
             
                p = prof;
                p.City = prof.City;
               
                StringBuilder sb = new StringBuilder();
                foreach (Automobile auto in prof.Automobile)
                {

                    sb.Append(auto.Registration_number+": "+auto.Description + "| ");
                }

                p.ReturnAutomobile = sb.ToString();
            }


            if (p == null)
            {
                p = new Person();
                p.LastName = "Petrov";
                p.FirstName = "Inan";
                p.Age = 42;
                City c = new City();
                c.Name = "None";
                c.Id = 0;
                p.City = c;
            }
            return (Person) p.Clone();
        }



        /// <summary>
        /// IN REAL LIFE THIS METHOD SHOULD USE HIBERNATE TO SAVE PERSON ENTITY
        /// </summary>
        /// <returns></returns>
        public void SavePerson(Person p)
        {
            this.p.Id = p.Id;
            this.p.Age = p.Age;
            this.p.FirstName = p.FirstName;
            this.p.LastName = p.LastName;

            var nhConfig = new NHCfg.Configuration().Configure();
            nhConfig.AddAssembly(SRef.Assembly.GetExecutingAssembly());
            var sessionFactory = nhConfig.BuildSessionFactory();

            using (NH.ISession session = sessionFactory.OpenSession())
            {
                using (NH.ITransaction transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(p);

                    transaction.Commit();
                }

            }
        }
    }
}

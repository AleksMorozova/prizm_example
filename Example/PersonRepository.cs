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
                var prof = session.QueryOver<Person>().Where(x => x.FirstName == "Tom")
                    .SingleOrDefault();

                p = prof;
                p.City = prof.City;

                if (prof.Automobiles == null)
                {
                    p.PersonAutomobiles.Add(new Automobile { Description = "None", Registration_number = "None", Person_id = prof.Id });
                }
                else
                {
                    p.PersonAutomobiles = new List<Automobile>();
                    foreach (Automobile auto in prof.Automobiles)
                    {
                        p.PersonAutomobiles.Add(auto);
                    }
                }

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
            return (Person)p.Clone();
        }

        /// <summary>
        /// IN REAL LIFE THIS METHOD SHOULD USE HIBERNATE TO SAVE PERSON ENTITY
        /// </summary>
        /// <returns></returns>
        public void SavePerson(Person p)
        {
            p.Id = 2;
            var nhConfig = new NHCfg.Configuration().Configure();
            nhConfig.SetProperty(
              "connection.connection_string", @"Data Source=(LocalDB)\v11.0;AttachDbFilename="
              + System.Environment.GetEnvironmentVariable("DATABASE")
              + ";Integrated Security=True;Connect Timeout=30");
            nhConfig.AddAssembly(SRef.Assembly.GetExecutingAssembly());

            var sessionFactory = nhConfig.BuildSessionFactory();

            using (NH.ISession session = sessionFactory.OpenSession())
            {
                using (NH.ITransaction transaction = session.BeginTransaction())
                {

                    session.Update(p);
                    transaction.Commit();
                }
            }

            //Person person = new Person();
            //person.Id = p.Id;

            //person.Age = p.Age;
            //person.FirstName = p.FirstName;
            //person.LastName = p.LastName;
            ////person.City


            //var nhConfig = new NHCfg.Configuration().Configure();
            //nhConfig.SetProperty(
            //  "connection.connection_string", @"Data Source=(LocalDB)\v11.0;AttachDbFilename="
            //  + System.Environment.GetEnvironmentVariable("DATABASE")
            //  + ";Integrated Security=True;Connect Timeout=30");
            //nhConfig.AddAssembly(SRef.Assembly.GetExecutingAssembly());

            //var sessionFactory = nhConfig.BuildSessionFactory();

            //using (NH.ISession session = sessionFactory.OpenSession())
            //{
            //    using (NH.ITransaction transaction = session.BeginTransaction())
            //    {

            //        session.SaveOrUpdate(person);

            //        person.City = new City { Name = p.City.Name, Id=p.City.Id};

            //        person.Certificates = new List<Certificate>();

            //        foreach (Certificate newCertif in p.Certificates)
            //        {
            //            person.Certificates.Add(new Certificate { Name=newCertif.Name, Id=newCertif.Id});
            //        }

            //        person.Automobiles = new List<Automobile>();

            //        foreach (Automobile newAuto in p.Automobiles)
            //        {
            //            person.Automobiles.Add(new Automobile { Description = newAuto.Description, Registration_number = newAuto.Registration_number, Person_id = person.Id });
            //        }

            //        session.SaveOrUpdate(person);

            //        transaction.Commit();
            //    }

            //}
        }


        /// <summary>
        /// IN REAL LIFE THIS METHOD SHOULD USE HIBERNATE TO UPDATE PERSON ENTITY
        /// </summary>
        /// <returns></returns>
        public void UpdatePerson(Person p)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    p.Id = this.p.Id;
                    repository.Update(p);
                }
                catch 
                {
                    repository.RollbackTransaction();
                }
            }

            //var nhConfig = new NHCfg.Configuration().Configure();
            //nhConfig.SetProperty(
            //  "connection.connection_string", @"Data Source=(LocalDB)\v11.0;AttachDbFilename="
            //  + System.Environment.GetEnvironmentVariable("DATABASE")
            //  + ";Integrated Security=True;Connect Timeout=30");
            //nhConfig.AddAssembly(SRef.Assembly.GetExecutingAssembly());

            //var sessionFactory = nhConfig.BuildSessionFactory();

            //p.Id = this.p.Id;

            //using (NH.ISession session = sessionFactory.OpenSession())
            //{
            //    using (NH.ITransaction transaction = session.BeginTransaction())
            //    {

            //        session.Update(p);
            //        transaction.Commit();
            //    }
            //}
        }


        /// <summary>
        /// IN REAL LIFE THIS METHOD SHOULD USE HIBERNATE TO DELETE PERSON ENTITY
        /// </summary>
        /// <returns></returns>
        public void DeletePerson(Person p)
        {


            var nhConfig = new NHCfg.Configuration().Configure();
            nhConfig.SetProperty(
              "connection.connection_string", @"Data Source=(LocalDB)\v11.0;AttachDbFilename="
              + System.Environment.GetEnvironmentVariable("DATABASE")
              + ";Integrated Security=True;Connect Timeout=30");
            nhConfig.AddAssembly(SRef.Assembly.GetExecutingAssembly());

            var sessionFactory = nhConfig.BuildSessionFactory();

            p.Id = this.p.Id;

            using (NH.ISession session = sessionFactory.OpenSession())
            {
                using (NH.ITransaction transaction = session.BeginTransaction())
                {

                    session.Delete(p);
                    transaction.Commit();
                }
            }
        }
    }
}

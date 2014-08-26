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
            using (RepositoryBase repository = new RepositoryBase())
            {
                Person prof = repository.GetPerson();

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
                repository.CloseSession();
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
            Person person = new Person();

            using (RepositoryBase repository = new RepositoryBase())
            {

                repository.BeginTransaction();

                person.Age = p.Age;
                person.FirstName = p.FirstName;
                person.LastName = p.LastName;

                repository.Save(person);

                person.City = new City { Name = p.City.Name, Id = p.City.Id };
                person.Extra = new AdditionalInformation { DateOfBirth = p.Extra.DateOfBirth, PlaceOfBirth = p.Extra.PlaceOfBirth, Person_id = person.Id };


                person.Certificates = new List<Certificate>();

                foreach (Certificate newCertif in p.Certificates)
                {
                    person.Certificates.Add(new Certificate { Name = newCertif.Name, Id = newCertif.Id });
                }

                person.Automobiles = new List<Automobile>();

                foreach (Automobile newAuto in p.Automobiles)
                {
                    person.Automobiles.Add(new Automobile { Description = newAuto.Description, Person_id = person.Id, Registration_number = newAuto.Registration_number });
                }

                repository.Save(person);
                
                repository.CommitTransaction();
                repository.CloseSession();
            }
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

                    foreach (Automobile a in p.Automobiles)
                    {
                        a.Person_id = this.p.Id;
                    }

                    repository.Update(p);
                }
                catch
                {
                    repository.RollbackTransaction();
                }
            }
        }


        /// <summary>
        /// IN REAL LIFE THIS METHOD SHOULD USE HIBERNATE TO DELETE PERSON ENTITY
        /// </summary>
        /// <returns></returns>
        public void DeletePerson(Person p)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    p.Id = this.p.Id;
                    repository.Delete(p);
                }
                catch
                {
                    repository.RollbackTransaction();
                }
            }
        }
    }
}

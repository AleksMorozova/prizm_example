using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example.Entities;
using Example.DB;
using NHibernate;
using System.Reflection;
using NHibernate.Cfg;
using log4net;

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
                
                p.PersonAutomobiles = new List<Automobile>();
                    foreach (Automobile auto in prof.Automobiles)
                    {
                        p.PersonAutomobiles.Add(auto);
                    }

                repository.CloseSession();

                return (Person)p.Clone();
            }
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
                try 
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
                catch (Exception) 
                {
                    repository.RollbackTransaction();
                }
               
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

                    p.Extra.Person_id = this.p.Id;
                    repository.Update(p);

                    repository.CommitTransaction();
                    repository.CloseSession();
                    
                }
                catch(Exception)
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
                //try
                //{
                    repository.BeginTransaction();
                    p.Id = this.p.Id;
                    repository.Delete(p);
                    repository.CommitTransaction();
                    repository.CloseSession();
                //}
                //catch (Exception)
                //{
                //    repository.RollbackTransaction();
                //}
            }
        }
    }
}

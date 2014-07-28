using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (p == null)
            {
                p = new Person();
                p.LastName = "Petrov";
                p.FirstName = "Inan";
                p.Age = 42;
            }
            return (Person) p.Clone();
        }



        /// <summary>
        /// IN REAL LIFE THIS METHOD SHOULD USE HIBERNATE TO SAVE PERSON ENTITY
        /// </summary>
        /// <returns></returns>
        public void SavePerson(Person p)
        {
            this.p.Age = p.Age;
            this.p.FirstName = p.FirstName;
            this.p.LastName = p.LastName;
        }
    }
}

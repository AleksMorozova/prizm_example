using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example.Entities;

namespace Example
{
    interface IPersonRepository
    {
        Person GetPerson();
        void SavePerson(Person p);
        void UpdatePerson(Person p);
        void DeletePerson(Person p);
    }
}

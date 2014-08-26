using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example.Entities;

namespace Example.DB
{
    public interface IRepository
    {
        void Save(object obj);
        void Delete(object obj);
        void Update(object obj);
        IList<City> GetCity();
    }
}

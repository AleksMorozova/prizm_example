using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public interface IRepository
    {
        void Save(object obj);
        void Delete(object obj);
        void Update(object obj);
        IList<City> GetCity();
       // IQueryable<TEntity> ToList<TEntity>();
    }
}

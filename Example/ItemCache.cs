using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example.Entities;

namespace Example
{
    public class ItemCache<T> where T : class
    {
        private SortedList<int, T> GridToObj;
        private SortedList<int, int> DBIdToGrid;

        public ItemCache() 
        {
            GridToObj  = new SortedList<int, T> ();
            DBIdToGrid= new SortedList<int, int>();
        }

        public void Add(int idGrid,  int idDB, T cInstance)
        {
            GridToObj.Add(idGrid, cInstance);
            DBIdToGrid.Add(idDB, idGrid);
        }


        public int GetIdGrid(int idDB) 
        {
            return DBIdToGrid[idDB];
        }


        public T GetCertificate(int idGrid)
        {
            return GridToObj[idGrid];
        }
        public void Clear() 
        {
            GridToObj.Clear();
            DBIdToGrid.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class ItemCache
    {
        private SortedList<int, Certificate> GridToObj;
        private SortedList<int, int> DBIdToGrid;

        public ItemCache() 
        {
            GridToObj  = new SortedList<int, Certificate> ();
            DBIdToGrid= new SortedList<int, int>();
        }

        public void Add(int idGrid, Certificate cInstance)
        {
            GridToObj.Add(idGrid, cInstance);
            DBIdToGrid.Add(cInstance.Id, idGrid);
        }


        public int GetIdGrid(int idDB) 
        {
            return DBIdToGrid[idDB];
        }


        public Certificate GetCertificate(int idGrid)
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

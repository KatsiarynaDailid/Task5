using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class CheckSortedSet : IMyCollection
    {
        public SortedSet<int> SortedSet { get; set; }

        public CheckSortedSet()
        {
           this.SortedSet = new SortedSet<int>();
        }

        public void AddElement(int n)
        {
            
            for (int i = 0; i < n; i++)
            {
                SortedSet.Add(i);
            }

        }

        public void ReadElement(int n)
        {
            for (int i = 0; i < n; i++)
            {
                var temp = SortedSet.ElementAt(i);
            }
        }


 
        public void RemoveElement(int n)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                int allElem = SortedSet.Count();          
                SortedSet.Remove(rand.Next(allElem / 3, (2 * allElem) / 3)); //remove from the middle of collection
            }
        }

        public void FindElement(int n)
        {
            Random rand = new Random();
            int allElem = SortedSet.Count();
            for (int i = 0; i < n; i++)
            {
                int randElemId = rand.Next(allElem / 3, (2 * allElem) / 3);
                var randElem = SortedSet.ElementAt(randElemId);
                SortedSet.Contains(randElem);
            }
        }

        public override string ToString()

        {
            return "Sorted Set collection: ";
        }
    }
}

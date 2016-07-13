using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class CheckSortedDictionary : IMyCollection
    {

        public SortedDictionary<int, int> SortedDictionary { get; set; }

        public CheckSortedDictionary()
        {
            this.SortedDictionary = new SortedDictionary<int, int>();
        }



        public void AddElement(int n)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                SortedDictionary.Add(i, rand.Next());
            }

        }

        public void ReadElement(int n)
        {
            for (int i = 0; i < n; i++)
            {
                var temp = SortedDictionary.ElementAt(i);              
            }
        }

        public void RemoveElement(int n)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                int allElem = SortedDictionary.Count();
                SortedDictionary.Remove(rand.Next(allElem / 3, (2 * allElem) / 3)); //remove from the middle of collection
            }
        }

        public void FindElement(int n)
        {         
            Random rand = new Random();
            int allElem = SortedDictionary.Count();
            for (int i = 0; i < n; i++)
            {
                int randElemId = rand.Next(allElem / 3, (2 * allElem) / 3);
                var randElem = SortedDictionary.ElementAt(randElemId);
                SortedDictionary.Contains(randElem);
            }
        
    }

        public override string ToString()

        {
            return "Sorted Dicrionary collection: ";
        }
    }
}

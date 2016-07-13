using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class CheckList : IMyCollection
    {

        public List<int> List { get; set; }


        public CheckList()
        {

            this.List = new List<int>();
        }

        public void AddElement(int n)
        {
           Random rand = new Random();
           for(int i = 0; i < n; i++)
            {
                List.Add(rand.Next());
            }          
        }

        public void ReadElement(int n)
        {
            for (int i = 0; i < n; i++)
            {
                var temp = List.ElementAt(i);
            }
        }

        public void RemoveElement(int n)
        {
            Random rand = new Random();          
            for (int i = 0; i < n; i++)
            {
                int allElem = List.Count();
                List.RemoveAt(rand.Next(allElem / 3, (2 * allElem) / 3)); //remove from the middle of collection
            }
        }

        public void FindElement(int n)
        {
            Random rand = new Random();
            int allElem = List.Count();
            for (int i = 0; i < n; i++)
            {
                int randElemId = rand.Next(allElem / 3, (2 * allElem) / 3);
                int randElem = List[randElemId];
                List.Contains(randElem);
            }
        }

        public override string ToString()

        {
            return "List collection: ";
        }
    }
}

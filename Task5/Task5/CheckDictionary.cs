using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class CheckDictionary : IMyCollection
    {

        public Dictionary<int, int> Dictionary { get; set; }


        public CheckDictionary()
        {

            this.Dictionary = new Dictionary<int, int>();

        }
   
        public void AddElement(int n)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                Dictionary.Add(i, rand.Next());
            }
           

        }

        public void ReadElement(int n)
        {
            for (int i = 0; i < n; i++)
            {
                var temp = Dictionary.ElementAt(i);
            }
        }

        public void RemoveElement(int n)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                int allElem = Dictionary.Count();
                Dictionary.Remove(rand.Next(allElem / 3, (2 * allElem) / 3)); //remove from the middle of collection

            }
        }

        public void FindElement(int n)
        {
            Random rand = new Random();
            int allElem = Dictionary.Count();
            for (int i = 0; i < n; i++)
            { 
                int randElem = Dictionary[rand.Next(allElem / 3, (2 * allElem) / 3)];
                Dictionary.ContainsValue(randElem);
            }
        }

        public override string ToString()

        {
            return "Dictionary collection: ";
        }
    }
}

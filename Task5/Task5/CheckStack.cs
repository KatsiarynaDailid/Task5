using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class CheckStack : IMyCollection
    {

        public Stack<int> CollectionStack { get; set; }

        public CheckStack()
        {

            this.CollectionStack = new Stack<int>();
        }
     

        public void AddElement(int n)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                CollectionStack.Push(rand.Next());
            }
        }

        public void ReadElement(int n)
        {
            for (int i = 0; i < n; i++)
            {
                var temp = CollectionStack.ElementAt(i);
            }
        }

        public void RemoveElement(int n)
        {
            for (int i = 0; i < n; i++)
            {
                CollectionStack.Pop();
            }
        }

        public void FindElement(int n)
        {
            Random rand = new Random();
            int allElem = CollectionStack.Count();
            for (int i = 0; i < n; i++)
            {
                int randElemId = rand.Next(allElem / 3, (2 * allElem) / 3);
                var randElem = CollectionStack.ElementAt(randElemId);
                CollectionStack.Contains(randElem);
            }
        }
        public override string ToString()

        {
            return "Stack collection: ";
        }
    }
}

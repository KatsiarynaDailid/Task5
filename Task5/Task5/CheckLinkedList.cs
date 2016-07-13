using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class CheckLinkedList : IMyCollection
    {

        public LinkedList<int> LinkedList { get; set; }

        public CheckLinkedList()
        {

            this.LinkedList = new LinkedList<int>();

        }
        

        public void AddElement(int n)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {       
               LinkedList.AddFirst(rand.Next());
            }
        }

        public void ReadElement(int n)
        {
            for (int i = 0; i < n; i++)
            {
                var temp = LinkedList.ElementAt(i);
            }
        }

        public void RemoveElement(int n)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                int allElem = LinkedList.Count();
                LinkedList.Remove(rand.Next(allElem / 3, (2 * allElem) / 3)); //remove from the middle of collection

            }
        }

        public void FindElement(int n)
        {
            Random rand = new Random();
            int allElem = LinkedList.Count();
            for (int i = 0; i < n; i++)
            {
                int randElemId = rand.Next(allElem / 3, (2 * allElem) / 3);
                int randElem = LinkedList.ElementAt(randElemId);
                LinkedList.Contains(randElem);
            }
        }

        public override string ToString()

        {
            return "Linked List collection: ";
        }

    }
}

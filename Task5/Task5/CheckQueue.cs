using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class CheckQueue : IMyCollection
    {

        public Queue<int> Queue { get; set; }

        public CheckQueue()
        {
            this.Queue = new Queue<int>();
        }


        public void AddElement(int n)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                Queue.Enqueue(rand.Next());

            }
        }

        public void ReadElement(int n)
        {
            int temp;
            for (int i = 0; i < n; i++)
            {
                temp = Queue.ElementAt(i);
            }
        }

        public void RemoveElement(int n)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                int allElem = Queue.Count();
                Queue.Dequeue(); //remove from the middle of collection

            }
        }

        public void FindElement(int n)
        {
            Random rand = new Random();
            int allElem = Queue.Count();
            for (int i = 0; i < n; i++)
            {
                int randElemId = rand.Next(allElem / 3, (2 * allElem) / 3);
                int randElem = Queue.ElementAt(randElemId);
                Queue.Contains(randElem);
            }
        }

        public override string ToString()

        {
            return "Queue collection: ";
        }
    }
}

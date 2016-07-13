using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
   public interface IMyCollection
    {       
        void AddElement(int n);
        void ReadElement(int n);
        void RemoveElement(int n);
        void FindElement(int n);

    }
}

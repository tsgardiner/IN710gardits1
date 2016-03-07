using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUnitTesting
{
    class Stack
    {

        StringNodeList linkedList;

        public Stack()
        {
            linkedList = new StringNodeList();
        }


        public void Push(string newString)
        {
            linkedList.addFirst(newString);   
        }

        public string Pop()
        {
            try
            {
               return linkedList.deleteFirst();
            }
            catch (InvalidOperationException)
            {                
                throw new InvalidOperationException();
            }
        }

        public string Peek()
        {
            try
            {
                return linkedList.getFirstData();
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException();
            }            
        }

        public int Count()
        {
            return linkedList.Count();
        }

        public bool isEmpty()
        {
            return linkedList.isEmpty();
        }

    }
}

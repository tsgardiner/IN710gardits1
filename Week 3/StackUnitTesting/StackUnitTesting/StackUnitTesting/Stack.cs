using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUnitTesting
{
    public class Stack
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
            catch (NullReferenceException)
            {                
                throw new NullReferenceException("Cannot perfom delete on an empty stack.");
            }
        }

        public string Peek()
        {
            try
            {
                return linkedList.getFirstData();
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException("The stack currently has no data.");
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

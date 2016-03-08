using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUnitTesting
{
    class StringNodeList
    {
        StringNode head;

        public StringNodeList()
        {
            head = null;
        }

        //Adds a new node at the top of the stack
        public void addFirst(string newString)
        {
            StringNode newNode = new StringNode(newString);
            newNode.Next = head;
            head = newNode;
        }

        public int Count()
        {
            int count = 0;
            StringNode nodeWalker = head;

            while (nodeWalker != null)
            {
                count++;
                nodeWalker = nodeWalker.Next;
            }
            return count;
        }

        public string deleteFirst()
        {
            string data = null;
            StringNode toDelete = new StringNode(data);

            toDelete = head;
            head = head.Next;
            return toDelete.Data;            
        }

        public string getFirstData()
        {
            return head.Data;
        }

        public bool isEmpty()
        {
            return (head == null);
        }

    }
}

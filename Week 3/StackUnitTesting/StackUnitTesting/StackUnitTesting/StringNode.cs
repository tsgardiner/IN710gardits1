using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUnitTesting
{
    class StringNode
    {
        public string Data;
        public StringNode Next { get; set; }

        public StringNode(string data)
        {
            Data = data;
            Next = null;
        }
    }
}

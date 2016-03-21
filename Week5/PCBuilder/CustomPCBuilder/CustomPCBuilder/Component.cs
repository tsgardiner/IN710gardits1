using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPCBuilder
{
    public abstract class Component
    {
        protected double price;
        protected string name;

        public Component(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
    }
}

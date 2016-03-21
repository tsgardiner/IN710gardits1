using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPCBuilder
{
    public class Machines
    {
        protected double totalPrice;
        protected string name;
        protected IComponetsFactory componentsFactoy;

        public Machines(string name, double totalPrice, IComponetsFactory componentsFactory)
        {
            this.name = name;
            this.totalPrice = totalPrice;
        }
    }
}

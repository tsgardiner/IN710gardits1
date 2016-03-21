using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomPCBuilder
{
    public class MachineSpecPrinter
    {
        private IComponentsFactory componentsFactory;
        private RichTextBox displayBox;

        public MachineSpecPrinter(IComponentsFactory componentsFactory, RichTextBox displayBox)
        {
            this.componentsFactory = componentsFactory;
            this.displayBox = displayBox;
        }

        public void print()
        {
            CPU currentCPU          = componentsFactory.createCPU();
            GPU currentGPU          = componentsFactory.createGPU();
            RAM currentRAM          = componentsFactory.createRAM();
            Monitor currentMonitory = componentsFactory.createMonitor();

            double totalPrice = currentCPU.Price + currentGPU.Price + currentRAM.Price + currentMonitory.Price;

            displayBox.Clear();
            displayBox.AppendText("Price\tComponent\n");
            displayBox.AppendText("-----------------------------------------------------------------------------------------------\n");
            displayBox.AppendText(currentCPU.ToString()+"\n");
            displayBox.AppendText(currentGPU.ToString() + "\n");
            displayBox.AppendText(currentRAM.ToString() + "\n");
            displayBox.AppendText(currentMonitory.ToString() + "\n");
            displayBox.AppendText("-----------------------------------------------------------------------------------------------\n");
            displayBox.AppendText(totalPrice.ToString()+"\tTotal Cost");

        }

    }
}

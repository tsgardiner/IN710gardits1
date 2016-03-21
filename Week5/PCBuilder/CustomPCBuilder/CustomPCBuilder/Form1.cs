using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomPCBuilder
{
    public partial class Form1 : Form
    {

        IComponentsFactory componentsFactory;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplaySpec_Click(object sender, EventArgs e)
        {
            if (rbGaming.Checked)
                componentsFactory = new GamingFactory();
            else if (rbBusiness.Checked)
                componentsFactory = new BusinessFactory();
            else if (rbMultimedia.Checked)
                componentsFactory = new MultimediaFactory();

            MachineSpecPrinter currentSpec = new MachineSpecPrinter(componentsFactory, rtbDisplay);
            currentSpec.print();
        }        
    }
}

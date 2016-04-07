using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomHandlers
{
    public partial class Form1 : Form
    {

        FirstHandler firstHandler;
        SecondHandler secondHandler;        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the Forms handler.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            firstHandler = new FirstHandler(btnTest);
            secondHandler = new SecondHandler(btnTest);
        }
    }
}

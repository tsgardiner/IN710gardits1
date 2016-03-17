using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalWorld
{
    public partial class Form1 : Form
    {
        private const int ANIMALTYPES = 4;
        Random randomGen;
        Graphics canvas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            randomGen = new Random();
            canvas = this.CreateGraphics();
        }

        private void btnAus_Click(object sender, EventArgs e)
        {
            rtDisplay.Clear();
            canvas.Clear(SystemColors.Control);
            Continent aus = new Australia(rtDisplay, randomGen, ANIMALTYPES, canvas);
            aus.RunSimulation();
        }

        private void btnNorthAmerica_Click(object sender, EventArgs e)
        {
            rtDisplay.Clear();
            canvas.Clear(SystemColors.Control);
            Continent northA = new NorthAmerica(rtDisplay, randomGen, ANIMALTYPES, canvas);
            northA.RunSimulation();
        }

        private void btnAfrica_Click(object sender, EventArgs e)
        {
            rtDisplay.Clear();
            canvas.Clear(SystemColors.Control);
            Continent africa = new Africa(rtDisplay, randomGen, ANIMALTYPES, canvas);
            africa.RunSimulation();
        }
    }
}

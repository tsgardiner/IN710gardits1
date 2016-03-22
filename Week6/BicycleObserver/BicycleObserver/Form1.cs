using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleObserver
{
    public partial class Form1 : Form
    {
        BicycleSubject bicycleSubject;
        RPMObserver rpmObserver;
        KPHObserver kphObserver;
        CPHObserver cphObserver;


        public Form1()
        {
            InitializeComponent();

            bicycleSubject = new BicycleSubject(0);
            rpmObserver = new RPMObserver(lbDisplayRPM, bicycleSubject);
            kphObserver = new KPHObserver(lbKPH, bicycleSubject);
            cphObserver = new CPHObserver(lbCalPerHour, bicycleSubject);
        }

        private void btnChangeSpeed_Click(object sender, EventArgs e)
        {
            bicycleSubject.Data = Int32.Parse(tbInputSpeed.Text);

            bicycleSubject.NotifyObservers();
            
        }

    }
}

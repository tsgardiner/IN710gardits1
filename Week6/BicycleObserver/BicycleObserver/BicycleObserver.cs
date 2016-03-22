using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleObserver
{
    public abstract class BicycleObserver : IObserver
    {
        protected Label displaylabel;
        protected BicycleSubject bicycleSubject;
        protected int currentRPM;
        protected double currentValue;

        public BicycleObserver(Label displayLabel, BicycleSubject bicycleSubject)
        {
            this.displaylabel = displayLabel;
            currentRPM = 0;
            this.bicycleSubject = bicycleSubject;
            currentValue = 0;

            bicycleSubject.AddObserver(this);
        }

        public abstract void Update(int data);

        public void Display()
        {
            displaylabel.Text = currentValue.ToString("F2");
        }
    }
}

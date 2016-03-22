﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleObserver
{
    public class RPMObserver : BicycleObserver
    {
        public RPMObserver(Label displayLabel, BicycleSubject bicycleSubject)
            :base(displayLabel, bicycleSubject)
        {
            
        }

        public override void Update(int data)
        {
            currentValue = data;
            currentRPM = data;
        }
    }


    public class CPHObserver : BicycleObserver
    {
        public CPHObserver(Label displayLabel, BicycleSubject bicycleSubject)
            : base(displayLabel, bicycleSubject)
        {
             
        }

        public override void Update(int data)
        {
            
        }
    }

    public class KPHObserver : BicycleObserver
    {
        public KPHObserver(Label displayLabel, BicycleSubject bicycleSubject)
            : base(displayLabel, bicycleSubject)
        {

        }

        public override void Update(int data)
        {
            throw new NotImplementedException();
        }
    }
}

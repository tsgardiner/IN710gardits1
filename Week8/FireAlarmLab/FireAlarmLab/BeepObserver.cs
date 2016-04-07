using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarmLab
{
    public class BeepObserver : FireAlarmObserverBase
    {
        [DllImport("kernel32.dll")]

        public static extern bool Beep(int freq, int duration);

        public  BeepObserver(FireAlarmSubject fireSubject)
            :base(fireSubject)
        {

        }

        public override void FireAlarm(object fireObject, FireAlarmEvent fe)
        {
            switch (fe.FireCategory)
            {
                case EFireCategory.Minor:
                    Beep(800, 1000);
                    break;
                case EFireCategory.Serious:
                    Beep(1200, 1000);
                    break;
                case EFireCategory.Inferno:
                    Beep(1800, 1000);
                    break;
                default:
                    break;
            } 
        }
    }
}

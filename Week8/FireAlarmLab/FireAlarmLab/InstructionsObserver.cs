using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireAlarmLab
{
    public class InstructionsObserver: FireAlarmObserverBase
    {

        public InstructionsObserver(FireAlarmSubject fireAlarmSubject)
            :base(fireAlarmSubject)
        {

        }


        public override void FireAlarm(object fireObject, FireAlarmEvent fe)
        {
            String message = "Fire is " + fe.FireCategory.ToString() + ". ";
            switch (fe.FireCategory)
            {
                case EFireCategory.Minor:
                    message += "Use a fire extinguisher.";
                    break;
                case EFireCategory.Serious:
                    message += "Yup that's a fire.";
                    break;
                case EFireCategory.Inferno:
                    message += "Run!!.";
                    break;
                default:
                    break;
            }
            MessageBox.Show(message);
        }
    }
}

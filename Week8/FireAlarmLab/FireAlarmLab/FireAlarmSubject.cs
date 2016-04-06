using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarmLab
{
    public class FireAlarmSubject
    {
        public delegate void DFireEventHandler(object fireObject, FireAlarmEvent fe);
        public event DFireEventHandler DFireEvent;

        public void OnFireEvent(EFireCategory fireCategory)
        {
            FireAlarmEvent fe = new FireAlarmEvent(fireCategory);

            if (DFireEvent != null)
                DFireEvent(this, fe);            
        }

    }
}

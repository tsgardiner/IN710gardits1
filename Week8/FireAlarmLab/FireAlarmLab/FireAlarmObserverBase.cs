using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarmLab
{
    public abstract class FireAlarmObserverBase
    {
        protected FireAlarmSubject fireAlarmSubject;

        public FireAlarmObserverBase(FireAlarmSubject fireSubject)
        {
            this.fireAlarmSubject = fireSubject;

            FireAlarmSubject.DFireEventHandler fireEventHandler = new FireAlarmSubject.DFireEventHandler(FireAlarm);

            fireSubject.DFireEvent += fireEventHandler;
        }

        public abstract void FireAlarm(object fireObject, FireAlarmEvent fe);

    }
}

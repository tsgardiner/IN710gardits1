using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarmLab
{
    public enum EFireCategory {Minor, Serious, Inferno};

    public class FireAlarmEvent : EventArgs
    {
        public EFireCategory FireCategory { get; set; }

        public FireAlarmEvent(EFireCategory fireCategory)
        {
            FireCategory = fireCategory;
        }
    }
}

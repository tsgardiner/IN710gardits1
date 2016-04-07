using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomHandlers
{

    public class FirstHandler : CustomHandler
    {
        public FirstHandler(Button buttonSubject)
            :base(buttonSubject)
        {

        }
    }

    public class SecondHandler : CustomHandler
    {
        public SecondHandler(Button buttonSubject)
            :base(buttonSubject)
        {

        }
    }

}

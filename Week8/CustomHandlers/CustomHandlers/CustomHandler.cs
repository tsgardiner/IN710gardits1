using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomHandlers
{
    public abstract class CustomHandler
    {

        protected Button buttonSubject;
        protected Random random;
        protected int codeNumber;

        public CustomHandler(Button buttonSubject)
        {                
            this.buttonSubject = buttonSubject;

            random = new Random();
            codeNumber = random.Next(100);

            buttonSubject.Click += new EventHandler(OnClickEvent);
        }

        public void OnClickEvent(object sender, EventArgs e)
        {
            String message = "";

            message = "This is a custom handler.\n";
            message += "My code number is " + codeNumber.ToString() + "\n";
            message += "My type is CustomHandler \n";
            message += "I am responding to the Button: btnTest.";

            MessageBox.Show(message);
        }


    }
}

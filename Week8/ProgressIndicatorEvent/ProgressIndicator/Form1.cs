using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProgressIndicator
{
    public partial class Form1 : Form
    {
        
        public delegate void DFeedBack(object subject, EventArgs e);
        DFeedBack dfeedback;
        ProgressSubject slowWorker;

        public Form1()
        {
            InitializeComponent();            
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            slowWorker.SlowMethod();           
        }

        

        

       
    }
}

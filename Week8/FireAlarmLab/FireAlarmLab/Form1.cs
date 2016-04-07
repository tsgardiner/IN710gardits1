using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireAlarmLab
{
    public partial class Form1 : Form
    {
        FireAlarmSubject fireAlarmSubject;
        InstructionsObserver fireInstructions;
        BeepObserver beepObserver;
        EFireCategory selectedCat;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fireAlarmSubject = new FireAlarmSubject();
            fireInstructions = new InstructionsObserver(fireAlarmSubject);
            beepObserver = new BeepObserver(fireAlarmSubject);
        }

        private void rbFireAlarm_Click(object sender, EventArgs e)
        {         

            if (rbSerious.Checked)
                selectedCat = EFireCategory.Serious;
            if (rbMinor.Checked)
                selectedCat = EFireCategory.Minor;
            if (rbInferno.Checked)
                selectedCat = EFireCategory.Inferno;

            fireAlarmSubject.OnFireEvent(selectedCat);           
        }

       
    }
}

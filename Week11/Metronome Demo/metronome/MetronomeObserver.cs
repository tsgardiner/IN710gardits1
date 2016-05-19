using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace metronome
{
    public class MetronomeObserver
    {
        protected Metronome metronome;

        public MetronomeObserver(Metronome metronome)
        {
            this.metronome = metronome;
            metronome.metronomeEvent += new Metronome.metronomeEventHandler(onMetronomeEvent);
        }

        public virtual void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            MessageBox.Show("My metronome clicked");
        }

    }

    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class Beeper : MetronomeObserver
    {
        private String soundFileName;
        private SoundPlayer soundPlayer;

        public Beeper(Metronome metronome, String soundFileName)
            : base(metronome)
        {
            this.soundFileName = soundFileName;
            soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = soundFileName;
        }


        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            soundPlayer.Play();
        }

    } // end TBeeper
    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class Counter : MetronomeObserver
    {
        private NumericUpDown spinBox;
        private delegate void IncrementSpinBoxCallback(int count);
        private IncrementSpinBoxCallback incrementSpinBoxCallback;
        private int count;

        public Counter(Metronome metronome, NumericUpDown spinBox)
            : base(metronome)
        {
            this.spinBox = spinBox;
            count = 0;
        }

        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            count++;

            if (spinBox.InvokeRequired)
            {
                incrementSpinBoxCallback = SetSpinBox;
                spinBox.Invoke(incrementSpinBoxCallback, count);
            }    
            else
            {
                SetSpinBox(count);
            }
              
        }

        public void SetSpinBox(int count)
        {
            spinBox.Value = count;
        }
    } // end TCounter

    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class TimeDisplay : MetronomeObserver
    {
        private ListBox listBox;
        private delegate void SetDateTimeCallback(DateTime currentTime);
        private SetDateTimeCallback setDateTimeCallback;

        public TimeDisplay(Metronome metronome, ListBox listBox)
            : base(metronome)
        {
            this.listBox = listBox;
        }

        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            DateTime currDateTime = e.currentTime;

            if (listBox.InvokeRequired)
            {
                setDateTimeCallback = SetText;
                listBox.Invoke(setDateTimeCallback, currDateTime);
            }
            else
            {
                SetText(currDateTime);
            }

                     
        }

        private void SetText(DateTime currentTime)
        {
            listBox.Items.Add(currentTime.ToString());
        }
    }






            
}

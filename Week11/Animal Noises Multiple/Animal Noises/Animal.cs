using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading;

namespace Animal_Noises
{
    public class Animal
    {
        private SoundPlayer soundPlayer;
        private String soundFileName;
        private String threadLock;

        public Animal(String soundFileName, String threadLock)
        {
            soundPlayer = new SoundPlayer(soundFileName);
            this.threadLock = threadLock;
        }

        public void speak()
        {
            lock (threadLock)
            {
                    soundPlayer.Play();
                    Thread.Sleep(500);
            }
        }

    }
}

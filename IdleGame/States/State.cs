using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.States
{
    public abstract class State
    {
        //public enum States { Bleeding, Poisoned, Feared, Angered, Burning, Freezing };

        public string flavourText;

        public int duration;
        public int startTime;
        public int tickSpeed;
        public int lastTime;

        public Image image;

        public abstract double Effect();
    }
}

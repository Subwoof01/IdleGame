using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.States
{
    [Serializable]
    public abstract class State
    {
        //public enum States { Bleeding, Poisoned, Feared, Enraged, Burning, Freezing };
        public enum Target { Player, Enemy };

        public string flavourText;
        public Target target;

        public int duration;
        public int startTime;
        public int tickSpeed;
        public int lastTime;

        public Image image;

        public abstract double Effect();

        public bool firstApplied;
    }
}

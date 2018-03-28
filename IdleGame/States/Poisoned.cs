using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.States
{
    public class Poisoned : State
    {
        private double Damage()
        {
            return 0;
        }

        public override double Effect()
        {
            throw new NotImplementedException();
        }
    }
}

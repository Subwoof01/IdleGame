using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame
{
    [Serializable]
    public class Living : Entity
    {
        public int level;
        public int gold;
        public int healthBase;
        public double healthRegenerationBase;
        public int healthCurrent;
        public int manaBase;
        public double manaRegenerationBase;
        public int manaCurrent;
        public int armour;
        public int damageBaseMin;
        public int damageBaseMax;
    }
}

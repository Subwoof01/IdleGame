﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame
{
    public class Living : Entity
    {
        public int level;
        public int gold;
        public int healthBase;
        public int healthRegenerationBase;
        public int healthCurrent;
        public int manaBase;
        public int manaRegenerationBase;
        public int manaCurrent;
        public int armour;
        public int damageBaseMin;
        public int damageBaseMax;
    }
}

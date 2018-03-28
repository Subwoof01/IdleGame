using IdleGame.Attributes;
using IdleGame.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.Enemies
{
    public abstract class Enemy : Living
    {
        protected static Random random = new Random();
        public enum Type { Goblinoid, Humanoid, Undead, Dragonkin, Ethereal, Beast, Elemental, Demon, Giant, Mechanical, Abberation };

        public double attackSpeed;
        public Type type;

        public string currentAction;

        public double fireResistance;
        public double lightningResistance;
        public double coldResistance;
        public double poisonResistance;

        public abstract double PhysicalResistance();

        public abstract string Action(Player player);
    }
}

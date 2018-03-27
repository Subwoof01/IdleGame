using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.Skills
{
    public abstract class Skill
    {
        public enum Type { Active, Passive };
        public enum DamageType { Elemental, Physical };
        public int[] levelRank;
        public int currentRank;
        public Type type;
        public double castTime;
        public Image image;
        public string name;
        public DamageType damageType;

        public void SetRank(Player player)
        {
            this.currentRank = 0;

            for (int i = 0; i < this.levelRank.Length; i++)
            {
                if (player.level >= this.levelRank[i])
                    this.currentRank++;
            }
        }
        
        public virtual double Damage()
        {
            return 0;
        }

        public abstract string ToolTip();

        public abstract double Effect(Enemy enemy, int _startTime);
    }
}

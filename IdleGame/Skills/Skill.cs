﻿using IdleGame.Enemies;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.Skills
{
    [Serializable]
    public abstract class Skill
    {
        public enum Type { Active, Passive };
        public enum DamageType { Elemental, Physical };
        public int[] levelRank;
        public int currentRank;
        public Type type;
        public double castTime;
        public bool onCooldown = false;
        public double cooldown;
        public double timeCasted = 0;
        public Image image;
        public Image cooldownImage;
        public string name;
        public DamageType damageType;
        public int manaCost;

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

        public abstract double Effect(Enemy enemy, int _timeCasted);
    }
}

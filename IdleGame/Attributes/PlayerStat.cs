﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.Attributes
{
    public abstract class PlayerStat
    {
        public enum Attribute
        {
            Strength,
            Intelligence,
            Dexterity,
            Health,
            Mana,
            Armour,
            PhysicalDamage,
            ElementalDamage,
            CriticalChance,
            CriticalDamage,
            PhysicalResistance,
            ElementalResistance,
            HealthRegeneration,
            ManaRegeneration
        };

        protected Player _player;

        public double base_;
        public int pointBonus;
        abstract public double ItemBonus();
        abstract public double TalentBonus();
        abstract public double SkillBonus();
        abstract public double Final();
    }
}

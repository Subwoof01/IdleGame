﻿using IdleGame.Attributes;
using IdleGame.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.Enemies.Types
{
    public class Mechanical : Enemy
    {
        private enum SubType { Warrior };

        private SubType subType;

        public override double PhysicalResistance() { return this.armour * 0.0002; }

        public override string Action(Player player)
        {
            int damage = (int)(random.Next(this.damageBaseMin, this.damageBaseMax) * (1 - player.attributes[(int)PlayerStat.Attribute.PhysicalResistance].Final()));
            player.healthCurrent -= damage;

            // Combat log message.
            return $"{this.name} hits {player.name} for {damage} Physical.";
        }

        public static Mechanical Generate(int level)
        {
            #region Variables that will be generated.
            string name;
            SubType _subType;
            int enemyLevel;
            int reward;
            int health = 1;
            double healthRegen;
            int mana = 1;
            double manaRegen = 1;
            int armour = 0;
            double fireResist;
            double lightningResist;
            double coldResist;
            int damageMin = 0;
            int damageMax = 0;
            double attackSpeed = 0;
            #endregion

            enemyLevel = random.Next(level - 5, level + 5);
            if (enemyLevel < 1)
                enemyLevel = 1;

            _subType = (SubType)random.Next(1);

            name = "Mechanical " + Enum.GetName(typeof(SubType), _subType);

            reward = 2 * (int)Math.Pow(1.05, enemyLevel);

            health = random.Next(120 * (int)Math.Pow(1.08, enemyLevel), 160 * (int)Math.Pow(1.1, enemyLevel));
            healthRegen = health * 0.001;

            if (_subType.Equals(SubType.Warrior))
                armour = 100 * (int)Math.Pow(1.02, enemyLevel);

            fireResist = 0.20;
            lightningResist = -0.30;
            coldResist = 0.30;

            if (_subType.Equals(SubType.Warrior))
            {
                damageMin = 51 * (int)Math.Pow(1.03, enemyLevel);
                damageMax = 91 * (int)Math.Pow(1.03, enemyLevel);
            }

            if (_subType.Equals(SubType.Warrior))
                attackSpeed = 2;

            return new Mechanical(name, enemyLevel, reward, health, healthRegen, mana, manaRegen, armour, fireResist, lightningResist, coldResist, damageMin, damageMax, attackSpeed);
        }

        public Mechanical(string _name, int lvl, int reward, int hpBase, double hpRegen, int mpBase, double mpRegen, int _armour, double fireRes, double lightningRes, double coldRes, int damageMin, int damageMax, double atkSpeed)
        {
            name = _name;
            type = Type.Beast;

            states = new List<State>();

            level = lvl;
            gold = reward;

            healthBase = hpBase;
            healthCurrent = hpBase;
            manaBase = mpBase;
            manaCurrent = mpBase;

            healthRegenerationBase = hpRegen;
            manaRegenerationBase = mpRegen;

            armour = _armour;

            damageBaseMin = damageMin;
            damageBaseMax = damageMax;

            attackSpeed = atkSpeed;
        }
    }
}

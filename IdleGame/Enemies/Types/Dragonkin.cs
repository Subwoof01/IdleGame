using IdleGame.Attributes;
using IdleGame.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.Enemies.Types
{
    public class Dragonkin : Enemy
    {
        private enum SubType { Warrior, Ranger, Dragon, Sorcerer };

        private SubType subType;

        public override double PhysicalResistance() { return this.armour * 0.0002; }

        public override string Action(Player player)
        {
            int damage = (int)(random.Next(this.damageBaseMin, this.damageBaseMax) * (1 - player.attributes[(int)PlayerStat.Attribute.PhysicalResistance].Final()));
            player.healthCurrent -= damage;

            // Combat log message.
            return $"{this.name} hits {player.name} for {damage} Physical.";
        }

        public static Dragonkin Generate(int level)
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

            _subType = (SubType)random.Next(4);

            if (_subType.Equals(SubType.Warrior) || _subType.Equals(SubType.Ranger) || _subType.Equals(SubType.Sorcerer))
                name = "Dragonborn " + Enum.GetName(typeof(SubType), _subType);
            else
                name = "Dragon";

            reward = 2 * (int)Math.Pow(1.05, enemyLevel);

            health = random.Next(90 * (int)Math.Pow(1.08, enemyLevel), 130 * (int)Math.Pow(1.1, enemyLevel));
            healthRegen = health * 0.001;

            if (_subType.Equals(SubType.Warrior))
                armour = 72 * (int)Math.Pow(1.02, enemyLevel);
            if (_subType.Equals(SubType.Ranger))
                armour = 68 * (int)Math.Pow(1.02, enemyLevel);
            if (_subType.Equals(SubType.Sorcerer))
                armour = 59 * (int)Math.Pow(1.02, enemyLevel);
            if (_subType.Equals(SubType.Dragon))
                armour = 98 * (int)Math.Pow(1.02, enemyLevel);

            fireResist = 0.20;
            lightningResist = 0.20;
            coldResist = 0.20;

            if (_subType.Equals(SubType.Warrior))
            {
                damageMin = 25 * (int)Math.Pow(1.03, enemyLevel);
                damageMax = 35 * (int)Math.Pow(1.03, enemyLevel);
            }
            if (_subType.Equals(SubType.Ranger))
            {
                damageMin = 30 * (int)Math.Pow(1.03, enemyLevel);
                damageMax = 40 * (int)Math.Pow(1.03, enemyLevel);
            }
            if (_subType.Equals(SubType.Sorcerer))
            {
                damageMin = 20 * (int)Math.Pow(1.03, enemyLevel);
                damageMax = 30 * (int)Math.Pow(1.03, enemyLevel);
            }
            if (_subType.Equals(SubType.Dragon))
            {
                damageMin = 45 * (int)Math.Pow(1.03, enemyLevel);
                damageMax = 65 * (int)Math.Pow(1.03, enemyLevel);
            }

            if (_subType.Equals(SubType.Warrior))
                attackSpeed = 1.5;
            if (_subType.Equals(SubType.Ranger))
                attackSpeed = 1;
            if (_subType.Equals(SubType.Sorcerer))
                attackSpeed = 2;
            if (_subType.Equals(SubType.Dragon))
                attackSpeed = 2.5;

            return new Dragonkin(name, enemyLevel, reward, health, healthRegen, mana, manaRegen, armour, fireResist, lightningResist, coldResist, damageMin, damageMax, attackSpeed);
        }

        public Dragonkin(string _name, int lvl, int reward, int hpBase, double hpRegen, int mpBase, double mpRegen, int _armour, double fireRes, double lightningRes, double coldRes, int damageMin, int damageMax, double atkSpeed)
        {
            name = _name;
            type = Type.Dragonkin;

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

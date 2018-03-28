using IdleGame.Attributes;
using IdleGame.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.Enemies.Types
{
    public class Beast : Enemy
    {
        private enum SubType { Bear, Spider, Wolf, Fox, Snake, Boar, Moose, Gorilla };

        private SubType subType;

        public override double PhysicalResistance() { return this.armour * 0.0002; }

        public override string Action(Player player)
        {
            int damage = (int)(random.Next(this.damageBaseMin, this.damageBaseMax) * (1 - player.attributes[(int)PlayerStat.Attribute.PhysicalResistance].Final()));
            player.healthCurrent -= damage;

            // Combat log message.
            return $"{this.name} hits {player.name} for {damage} Physical.";
        }

        public static Beast Generate(int level)
        {
            #region Variables that will be generated.
            string name;
            SubType _subType;
            int enemyLevel;
            int reward;
            int health = 1;
            double healthRegen = 0.5;
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

            _subType = (SubType)random.Next(8);

            name = Enum.GetName(typeof(SubType), _subType);

            reward = 2 * (int)Math.Pow(1.05, enemyLevel);

            health = random.Next(50 * (int)Math.Pow(1.08, enemyLevel), 60 * (int)Math.Pow(1.1, enemyLevel));
            healthRegen = health * 0.001;

            if (_subType.Equals(SubType.Bear))
                armour = 25 * (int)Math.Pow(1.02, enemyLevel);
            if (_subType.Equals(SubType.Spider))
                armour = 15 * (int)Math.Pow(1.02, enemyLevel);
            if (_subType.Equals(SubType.Wolf))
                armour = 20 * (int)Math.Pow(1.02, enemyLevel);
            if (_subType.Equals(SubType.Fox))
                armour = 10 * (int)Math.Pow(1.02, enemyLevel);
            if (_subType.Equals(SubType.Snake))
                armour = 12 * (int)Math.Pow(1.02, enemyLevel);
            if (_subType.Equals(SubType.Boar))
                armour = 21 * (int)Math.Pow(1.02, enemyLevel);
            if (_subType.Equals(SubType.Moose))
                armour = 19 * (int)Math.Pow(1.02, enemyLevel);
            if (_subType.Equals(SubType.Gorilla))
                armour = 23 * (int)Math.Pow(1.02, enemyLevel);

            fireResist = -0.05;
            lightningResist = 0.2;
            coldResist = -0.02;

            if (_subType.Equals(SubType.Bear))
            {
                damageMin = 15 * (int)Math.Pow(1.03, enemyLevel);
                damageMax = 25 * (int)Math.Pow(1.03, enemyLevel);
            }
            if (_subType.Equals(SubType.Spider))
            {
                damageMin = 20 * (int)Math.Pow(1.03, enemyLevel);
                damageMax = 30 * (int)Math.Pow(1.03, enemyLevel);
            }
            if (_subType.Equals(SubType.Wolf))
            {
                damageMin = 18 * (int)Math.Pow(1.03, enemyLevel);
                damageMax = 28 * (int)Math.Pow(1.03, enemyLevel);
            }
            if (_subType.Equals(SubType.Fox))
            {
                damageMin = 12 * (int)Math.Pow(1.03, enemyLevel);
                damageMax = 22 * (int)Math.Pow(1.03, enemyLevel);
            }
            if (_subType.Equals(SubType.Snake))
            {
                damageMin = 14 * (int)Math.Pow(1.03, enemyLevel);
                damageMax = 24 * (int)Math.Pow(1.03, enemyLevel);
            }
            if (_subType.Equals(SubType.Boar))
            {
                damageMin = 16 * (int)Math.Pow(1.03, enemyLevel);
                damageMax = 26 * (int)Math.Pow(1.03, enemyLevel);
            }
            if (_subType.Equals(SubType.Moose))
            {
                damageMin = 19 * (int)Math.Pow(1.03, enemyLevel);
                damageMax = 29 * (int)Math.Pow(1.03, enemyLevel);
            }
            if (_subType.Equals(SubType.Gorilla))
            {
                damageMin = 30 * (int)Math.Pow(1.03, enemyLevel);
                damageMax = 40 * (int)Math.Pow(1.03, enemyLevel);
            }

            if (_subType.Equals(SubType.Bear))
                attackSpeed = 2;
            if (_subType.Equals(SubType.Spider))
                attackSpeed = 1.5;
            if (_subType.Equals(SubType.Wolf))
                attackSpeed = 1.5;
            if (_subType.Equals(SubType.Fox))
                attackSpeed = 1;
            if (_subType.Equals(SubType.Snake))
                attackSpeed = 1.2;
            if (_subType.Equals(SubType.Boar))
                attackSpeed = 1.8;
            if (_subType.Equals(SubType.Moose))
                attackSpeed = 2;
            if (_subType.Equals(SubType.Gorilla))
                attackSpeed = 2.5;

            return new Beast(name, enemyLevel, reward, health, healthRegen, mana, manaRegen, armour, fireResist, lightningResist, coldResist, damageMin, damageMax, attackSpeed);
        }

        public Beast(string _name, int lvl, int reward, int hpBase, double hpRegen, int mpBase, double mpRegen, int _armour, double fireRes, double lightningRes, double coldRes, int damageMin, int damageMax, double atkSpeed)
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

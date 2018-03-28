using IdleGame.Attributes;
using IdleGame.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.Enemies.Types
{
    public class Elemental : Enemy
    {
        private enum SubType { Wind, Fire, Lightning, Ice, Earth };

        private SubType subType;

        public override double PhysicalResistance() { return this.armour * 0.0002; }

        public override string Action(Player player)
        {
            int damage = (int)(random.Next(this.damageBaseMin, this.damageBaseMax) * (1 - player.attributes[(int)PlayerStat.Attribute.PhysicalResistance].Final()));
            player.healthCurrent -= damage;

            // Combat log message.
            return $"{this.name} hits {player.name} for {damage} Physical.";
        }

        public static Elemental Generate(int level)
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
            double fireResist = 0;
            double lightningResist = 0;
            double coldResist = 0;
            int damageMin = 0;
            int damageMax = 0;
            double attackSpeed = 0;
            #endregion

            enemyLevel = random.Next(level - 5, level + 5);
            if (enemyLevel < 1)
                enemyLevel = 1;

            _subType = (SubType)random.Next(5);

            name = Enum.GetName(typeof(SubType), _subType) + "Elemental";

            reward = 2 * (int)Math.Pow(1.05, enemyLevel);

            health = random.Next(50 * (int)Math.Pow(1.08, enemyLevel), 60 * (int)Math.Pow(1.1, enemyLevel));
            healthRegen = health * 0.001;

            if (_subType.Equals(SubType.Earth))
                armour = 74 * (int)Math.Pow(1.02, enemyLevel);

            if (_subType.Equals(SubType.Fire))
                fireResist = 0.90;
            if (_subType.Equals(SubType.Lightning))
                lightningResist = 0.90;
            if (_subType.Equals(SubType.Ice))
                coldResist = 0.90;

            if (_subType.Equals(SubType.Wind))
            {
                damageMin = 25 * (int)Math.Pow(1.03, enemyLevel);
                damageMax = 35 * (int)Math.Pow(1.03, enemyLevel);
            }
            if (_subType.Equals(SubType.Fire))
            {
                damageMin = 45 * (int)Math.Pow(1.03, enemyLevel);
                damageMax = 55 * (int)Math.Pow(1.03, enemyLevel);
            }
            if (_subType.Equals(SubType.Lightning))
            {
                damageMin = 40 * (int)Math.Pow(1.03, enemyLevel);
                damageMax = 50 * (int)Math.Pow(1.03, enemyLevel);
            }
            if (_subType.Equals(SubType.Ice))
            {
                damageMin = 35 * (int)Math.Pow(1.03, enemyLevel);
                damageMax = 45 * (int)Math.Pow(1.03, enemyLevel);
            }
            if (_subType.Equals(SubType.Earth))
            {
                damageMin = 45 * (int)Math.Pow(1.03, enemyLevel);
                damageMax = 65 * (int)Math.Pow(1.03, enemyLevel);
            }

            if (_subType.Equals(SubType.Wind))
                attackSpeed = 1;
            if (_subType.Equals(SubType.Fire))
                attackSpeed = 1.5;
            if (_subType.Equals(SubType.Lightning))
                attackSpeed = 1.2;
            if (_subType.Equals(SubType.Ice))
                attackSpeed = 2;
            if (_subType.Equals(SubType.Earth))
                attackSpeed = 2.5;

            return new Elemental(name, enemyLevel, reward, health, healthRegen, mana, manaRegen, armour, fireResist, lightningResist, coldResist, damageMin, damageMax, attackSpeed);
        }

        public Elemental(string _name, int lvl, int reward, int hpBase, double hpRegen, int mpBase, double mpRegen, int _armour, double fireRes, double lightningRes, double coldRes, int damageMin, int damageMax, double atkSpeed)
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

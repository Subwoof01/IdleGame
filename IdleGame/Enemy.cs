using IdleGame.Attributes;
using IdleGame.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame
{
    public class Enemy : Living
    {
        Random random = new Random();
        public enum Type { Goblinoid, Humanoid, Undead, Dragonkin, Ethereal, Beast, Elemental, Demon, Giant, Mechanical, Abberation };
        public double attackSpeed;
        public Type type;


        public double PhysicalResistance() { return this.armour * 0.0002; }

        public double Attack(Player player)
        {
            int damage = random.Next(this.damageBaseMin, this.damageBaseMax);
            player.healthCurrent -= (int)(damage * (1 - player.attributes[(int)PlayerStat.Attribute.PhysicalResistance].Final()));

            return damage * (1 - player.attributes[(int)PlayerStat.Attribute.PhysicalResistance].Final());
        }

        public Enemy(string _name, Type _type, int lvl, int reward, int hpBase, double hpRegen, int mpBase, double mpRegen, int _armour, int damageMin, int damageMax, double atkSpeed)
        {
            name = _name;
            type = _type;

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

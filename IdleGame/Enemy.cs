using IdleGame.Attributes;
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
        public double attackSpeed;

        public double PhysicalResistance() { return this.armour * 0.0002; }

        public void Attack(Player player)
        {
            int damage = random.Next(this.damageBaseMin, this.damageBaseMax);
            player.healthCurrent -= (int)(damage * (1 - player.attributes[(int)PlayerStat.Attribute.PhysicalResistance].Final()));
        }

        public Enemy(string _name, int lvl, int reward, int hpBase, double hpRegen, int mpBase, double mpRegen, int _armour, int damageMin, int damageMax, double atkSpeed)
        {
            name = _name;

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

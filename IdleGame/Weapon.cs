using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame
{
    public class Weapon : Item
    {
        public enum Type { Axe, Mace, Sword, Staff, Polearm, Bow, Crossbow };
        
        // true = Two-Handed, false = One-Handed.
        public bool twoHanded;

        // Weapon damage.
        public int damageMin;
        public int damageMax;

        // Critical chance/damage.
        public double criticalChanceBonus;
        public double criticalDamageBonus;

        public Weapon(string _name, Equip slot, Enum weaponType, bool _twoHanded, int levelReq, int strReq, int intReq, int dexReq, int strBonus, int intBonus, int dexBonus, double physDmgBonus, double eleDmgBonus, int dmgMin, int dmgMax, double critChc, double critDmg, int gold)
        {
            equipSlot = slot;
            type = weaponType;
            twoHanded = _twoHanded;
            name = _name;
            price = gold;

            levelRequirement = levelReq;
            strengthRequirement = strReq;
            intelligenceRequirement = intReq;
            dexterityRequirement = dexReq;

            strengthBonus = strBonus;
            intelligenceBonus = intBonus;
            dexterityBonus = dexBonus;
            physicalDamageBonus = physDmgBonus;
            elementalDamageBonus = eleDmgBonus;
            damageMin = dmgMin;
            damageMax = dmgMax;
            criticalChanceBonus = critChc;
            criticalDamageBonus = critDmg;
        }
    }
}

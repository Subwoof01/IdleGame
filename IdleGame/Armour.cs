using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame
{
    public class Armour : Item
    {
        // Flat bonuses.
        public int healthBonus;
        public int manaBonus;
        public int armourBonus;

        public double healthRegenerationBonus;
        public double manaRegenerationBonus;

        // Percentual bonuses.
        public double physicalResistanceBonus;
        public double elementalResistance;

        public Armour(string _name, int slot, int levelReq, int strReq, int intReq, int dexReq, int strBonus, int intBonus, int dexBonus, int health, int mana, int armour, double hpRegen, double mpRegen, double physRes, double eleRes, double physDmgBonus, double eleDmgBonus, int gold)
        {
            equipSlot = slot;
            name = _name;
            price = gold;

            levelRequirement = levelReq;
            strengthRequirement = strReq;
            intelligenceRequirement = intReq;
            dexterityRequirement = dexReq;

            strengthBonus = strBonus;
            intelligenceBonus = intBonus;
            dexterityBonus = dexBonus;

            healthBonus = health;
            manaBonus = mana;
            armourBonus = armour;
            healthRegenerationBonus = hpRegen;
            manaRegenerationBonus = mpRegen;
            physicalResistanceBonus = physRes;
            elementalResistance = eleRes;

            physicalDamageBonus = physDmgBonus;
            elementalDamageBonus = eleDmgBonus;
        }
    }
}

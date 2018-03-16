using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame
{
    public class Item : Entity
    {
        public enum Equip { Head, Neck, Shoulder, Chest, Hands, Ring, Waist, Feet, MainHand, OffHand };

        public int affix;
        public int equipSlot;

        public int price;

        // Requirements
        public int levelRequirement;
        public int strengthRequirement;
        public int intelligenceRequirement;
        public int dexterityRequirement;

        // Flat Bonuses
        public int strengthBonus;
        public int intelligenceBonus;
        public int dexterityBonus;

        // Percentual Bonuses
        public double physicalDamageBonus;
        public double elementalDamageBonus;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame
{
    [Serializable]
    public abstract class Item : Entity
    {
        protected static Random random = new Random();
        public enum Equip { Head, Neck, Shoulder, Chest, Hands, Ring, Waist, Feet, MainHand, OffHand };

        public static int id = 0;
        public int itemID;
        public int affix;
        public Equip equipSlot;
        public Enum type;
        public string tooltip;

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
        public double fireDamageBonus;
        public double lightningDamageBonus;
        public double coldDamageBonus;
        public double poisonDamageBonus;

        public string Name
        {
            get
            {
                return name;
            }
        }
    }
}

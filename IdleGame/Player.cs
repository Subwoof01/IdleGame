using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame
{
    public class Player : Living
    {
        int[] experienceThresholds = new int[] { 0, 100, 607, 1756, 3757, 6822, 11174, 17045, 24687, 34367, 46372, 61006, 78596, 99486, 124046, 152661 };

        public Item[] inventory;
        public int inventorySlotsMax;
        public int inventorySlotsUsed;

        // 0 = Head, 1 = Neck, 2 = Shoulder, 3 = Chest, 4 = Hands, 5 = Ring, 6 = Waist, 7 = Feet, 8 = MainHand, 9 = OffHand
        public Item[] equipment = new Item[10];

        public string playerClass;
        public int skillPoints;
        public int experienceNextLevel;
        public int experienceCurrent;
        public int strengthBase;
        public int intelligenceBase;
        public int dexterityBase;

        // Stat calculations.
        // TODO: add item stats to calculations.

        public int strengthFinal()
        {
            int itemBonus = 0;

            // For every item equipped, add the bonus.
            foreach (Item i in equipment)
            {
                if (i != null) itemBonus += i.strengthBonus;
            }

            return strengthBase + itemBonus;
        }
        public int intelligenceFinal()
        {
            int itemBonus = 0;

            // For every item equipped, add the bonus.
            foreach (Item i in equipment)
            {
                if (i != null) itemBonus += i.intelligenceBonus;
            }

            return intelligenceBase + itemBonus;
        }
        public int dexterityFinal()
        {
            int itemBonus = 0;

            // For every item equipped, add the bonus.
            foreach (Item i in equipment)
            {
                if (i != null) itemBonus += i.dexterityBonus;
            }

            return dexterityBase + itemBonus;
        }

        public int healthFinal()
        {
            Armour armour;
            int itemBonus = 0;

            for (int i = 0; i < equipment.Length; i++)
            {
                if (equipment[i] is Armour)
                {
                    armour = (Armour)equipment[i];
                    itemBonus += armour.healthBonus;
                }
            }

            return this.healthBase + (this.strengthBase * 2) + itemBonus;
        }
        public int manaFinal()
        {
            Armour armour;
            int itemBonus = 0;

            for (int i = 0; i < equipment.Length; i++)
            {
                if (equipment[i] is Armour)
                {
                    armour = (Armour)equipment[i];
                    itemBonus += armour.manaBonus;
                }
            }

            return this.manaBase + (this.intelligenceBase * 2) + itemBonus;
        }
        public int armourFinal()
        {
            Armour armour;
            int itemBonus = 0;

            for (int i = 0; i < equipment.Length; i++)
            {
                if (equipment[i] is Armour)
                {
                    armour = (Armour)equipment[i];
                    itemBonus += armour.armourBonus;
                }
            }

            return this.armour + this.dexterityBase + itemBonus;
        }

        public double physicalDamageIncrease()
        {
            double itemBonus = 0;

            // For every item equipped, add the physical damage bonus. (Additive)
            foreach (Item i in equipment)
            {
                if (i != null) itemBonus += i.physicalDamageBonus;
            }

            // (STR Bonus) + (Item Bonus)
            return (0.01 * this.strengthBase) + (itemBonus);
        }
        public int physicalDamage()
        {
            Weapon mainHand;

            // If main hand is of type Weapon, add it to the equation otherwise do not.
            if (equipment[(int)Item.Equip.MainHand] is Weapon) mainHand = (Weapon)equipment[(int)Item.Equip.MainHand];
            else mainHand = null;

            // (Avg Base Damage) + (Avg Weapon Damage) * (Phys DMG Increase)
            return (int)(((this.damageBaseMin + this.damageBaseMax) / 2) + ((((mainHand != null) ? mainHand.damageMin : 0) + ((mainHand != null) ? mainHand.damageMax : 0)) / 2) * (1 + this.physicalDamageIncrease()));
        }

        public double elementalDamageIncrease()
        {
            double itemBonus = 0;

            // For every item equipped, add the bonus. (Additive)
            foreach (Item i in equipment)
            {
                if (i != null) itemBonus += i.elementalDamageBonus;
            }

            return (0.01 * this.intelligenceBase) + (itemBonus);
        }
        public int elementalDamage()
        {
            Armour armour;
            double itemBonus = 0;

            for (int i = 0; i < equipment.Length; i++)
            {
                if (equipment[i] is Armour)
                {
                    armour = (Armour)equipment[i];
                    itemBonus += armour.elementalDamageBonus;
                }
            }

            return (int)(((this.damageBaseMin + this.damageBaseMax) / 2) * (1 + this.elementalDamageIncrease()) + itemBonus);
        }

        public double criticalChance()
        {
            Weapon mainHand;

            // If main hand is of type Weapon, add it to the equation otherwise do not.
            if (equipment[(int)Item.Equip.MainHand] is Weapon) mainHand = (Weapon)equipment[(int)Item.Equip.MainHand];
            else mainHand = null;

            return (this.dexterityBase * 0.001) + ((mainHand != null) ? mainHand.criticalChanceBonus : 0);
        }
        public double criticalDamage()
        {
            Weapon mainHand;

            // If main hand is of type Weapon, add it to the equation otherwise do not.
            if (equipment[(int)Item.Equip.MainHand] is Weapon) mainHand = (Weapon)equipment[(int)Item.Equip.MainHand];
            else mainHand = null;

            return (this.dexterityBase * 0.01) + ((mainHand != null) ? mainHand.criticalDamageBonus : 0);
        }

        public double physicalResistance()
        {
            Armour armour;
            double itemBonus = 0;

            for (int i = 0; i < equipment.Length; i++)
            {
                if (equipment[i] is Armour)
                {
                    armour = (Armour)equipment[i];
                    itemBonus += armour.physicalResistanceBonus;
                }
            }

            return (this.armourFinal() * 0.0002) + itemBonus;
        }
        public double elementalResistance()
        {
            Armour armour;
            double itemBonus = 0;

            for (int i = 0; i < equipment.Length; i++)
            {
                if (equipment[i] is Armour)
                {
                    armour = (Armour)equipment[i];
                    itemBonus += armour.elementalResistance;
                }
            }

            return itemBonus;
        }

        public double healthRegeneration()
        {
            Armour armour;
            double itemBonus = 0;

            for (int i = 0; i < equipment.Length; i++)
            {
                if (equipment[i] is Armour)
                {
                    armour = (Armour)equipment[i];
                    itemBonus += armour.healthRegenerationBonus;
                }
            }

            return (healthRegenerationBase + (this.strengthBase * 0.2)) + itemBonus;
        }
        public double manaRegeneraion()
        {
            Armour armour;
            double itemBonus = 0;

            for (int i = 0; i < equipment.Length; i++)
            {
                if (equipment[i] is Armour)
                {
                    armour = (Armour)equipment[i];
                    itemBonus += armour.manaRegenerationBonus;
                }
            }

            return (manaRegenerationBase + (this.intelligenceBase * 0.1)) + itemBonus;
        }

        // Constructor.
        public Player()
        {
            inventorySlotsMax = 20;
            inventory = new Item[inventorySlotsMax];
            inventorySlotsUsed = 0;

            name = "Subwoofy";
            healthBase = 100;
            healthRegenerationBase = 1;
            manaBase = 25;
            manaRegenerationBase = 1;
            armour = 5;
            damageBaseMin = 1;
            damageBaseMax = 3;
            playerClass = "Warrior";
            level = 1;
            gold = 10;
            skillPoints = 5;
            experienceNextLevel = experienceThresholds[level];
            experienceCurrent = 0;
            strengthBase = 5;
            intelligenceBase = 5;
            dexterityBase = 5;
            healthCurrent = healthFinal();
            manaCurrent = manaFinal();


            // DEBUG WEAPON CREATION - FIX ASAP
            Weapon broadsword = new Weapon("Broadsword", (int)Item.Equip.MainHand, 1, 5, 3, 1, 4, 3, 0, 0.10, 0, 4, 12, 0.05, 0.20, 10);
            Armour chestplate = new Armour("Chestplate", (int)Item.Equip.Chest, 1, 1, 4, 1, 10, 13, 0, 99, 1, 55, 0.70, 0.30, 0.05, 0, 0.10, 0.05, 15);
            Armour chestplate2 = new Armour("Leather Chestplate", (int)Item.Equip.Chest, 1, 1, 4, 1, 0, 0, 0, 99, 0, 61, 0, 0, 0, 0, 0, 0, 0);
            inventory[0] = broadsword;
            inventorySlotsUsed++;
            inventory[1] = chestplate;
            inventorySlotsUsed++;
            inventory[2] = chestplate2;
            inventorySlotsUsed++;
        }

        public void IncreaseExp(int exp)
        {
            // Increase experience.
            this.experienceCurrent += exp;

            // Levelup.
            if (experienceCurrent >= experienceNextLevel)
            {
                // Increase level by 1.
                this.level++;
                // Set next level experience.
                this.experienceNextLevel = experienceThresholds[this.level];
                // Give 5 skill points.
                this.skillPoints += 5;
                // Reset current experience.
                this.experienceCurrent = 0;
            }
        }
    }
}

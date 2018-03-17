using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame
{
    public class CharacterClass : Living
    {
        public enum Classes { Warrior, Sorcerer, Ranger };
        public TalentTree playerTalentTree;

        public int[] experienceThresholds = new int[] { 0, 100, 607, 1756, 3757, 6822, 11174, 17045, 24687, 34367, 46372, 61006, 78596, 99486, 124046, 152661 };

        // 0 = Head, 1 = Neck, 2 = Shoulder, 3 = Chest, 4 = Hands, 5 = Ring, 6 = Waist, 7 = Feet, 8 = MainHand, 9 = OffHand
        public Item[] equipment = new Item[10];

        public int skillPoints;
        public int talentPoints;
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
            // Flat bonus.
            int itemBonus = 0;
            // Percentual bonus.
            double talentBonus = 0;

            for (int i = 0; i < equipment.Length; i++)
            {
                if (equipment[i] is Armour)
                {
                    armour = (Armour)equipment[i];
                    itemBonus += armour.armourBonus;
                }
            }

            // Warrior talent bonuses.
            if (playerTalentTree is WarriorTree)
            {
                WarriorTree warrior = (WarriorTree)playerTalentTree;
                talentBonus = warrior.IronSkinBonus();
            }

            return (int)((this.armour + this.dexterityBase + itemBonus) * (1 + talentBonus));
        }

        public double physicalDamageIncrease()
        {
            double itemBonus = 0;
            double talentBonus = 0;

            // For every item equipped, add the physical damage bonus. (Additive)
            foreach (Item i in equipment)
            {
                if (i != null) itemBonus += i.physicalDamageBonus;
            }

            // Warrior talent bonuses.
            if (playerTalentTree is WarriorTree)
            {
                WarriorTree warrior = (WarriorTree)playerTalentTree;
                talentBonus = warrior.WeaponMasteryBonus() + warrior.ArmouredToTheTeethBonus();
            }

            // (STR Bonus) + (Item Bonus)
            return (0.01 * this.strengthBase) + (itemBonus) + (talentBonus);
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
        
        private void SetWarriorStats()
        {
            healthBase = 110;
            manaBase = 20;
            armour = 15;

            strengthBase = 10;
            intelligenceBase = 3;
            dexterityBase = 6;
        }

        private void SetSorcererStats()
        {
            healthBase = 85;
            manaBase = 55;
            armour = 8;

            strengthBase = 3;
            intelligenceBase = 10;
            dexterityBase = 6;
        }

        private void SetRangerStats()
        {
            healthBase = 95;
            manaBase = 35;
            armour = 12;

            strengthBase = 4;
            intelligenceBase = 5;
            dexterityBase = 10;
        }

        public CharacterClass(Classes playerClass)
        {
            switch (playerClass)
            {
                case Classes.Warrior:
                    SetWarriorStats();
                    playerTalentTree = new WarriorTree();
                    break;
                case Classes.Sorcerer:
                    SetSorcererStats();
                    // Add Sorcerer tree.
                    break;
                case Classes.Ranger:
                    SetRangerStats();
                    // Add Ranger tree.
                    break;
            }
        }
    }
}

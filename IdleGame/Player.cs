using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame
{
    public class Player : CharacterClass
    {
        public CharacterClass.Classes playerClass;

        public Item[] inventory;
        public int inventorySlotsMax;
        public int inventorySlotsUsed;

        public void AddItem(Item item)
        {
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == null)
                {
                    inventory[i] = item;
                    inventorySlotsUsed++;
                    break;
                }
            }
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
                // Give the player 1 talent point.
                this.talentPoints++;
                // Reset current experience.
                this.experienceCurrent = 0;
            }
        }

        // Constructor.
        public Player(CharacterClass.Classes _playerClass) : base(_playerClass)
        {
            inventorySlotsMax = 20;
            inventory = new Item[inventorySlotsMax];
            inventorySlotsUsed = 0;

            name = "Subwoofy";
            healthRegenerationBase = 1;
            manaRegenerationBase = 1;
            damageBaseMin = 1;
            damageBaseMax = 3;
            playerClass = _playerClass;
            level = 1;
            gold = 1000;
            skillPoints = 5;
            talentPoints = 0;
            experienceNextLevel = 100;
            experienceCurrent = 0;
            healthCurrent = healthFinal();
            manaCurrent = manaFinal();
        }
    }
}

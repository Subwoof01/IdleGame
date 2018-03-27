using IdleGame.Attributes;
using IdleGame.Skills;
using IdleGame.Talents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame
{
    public class Player : Living
    {
        public enum Class { Warrior, Sorcerer, Ranger };
        public Class playerClass;

        public PlayerStat[] attributes;
        public Talent[] talents;
        public Skill[] skills;
        public Skill[] actionBar;
        public Item[] inventory;
        public Item[] equipment;
        public int inventorySlotsMax;
        public int inventorySlotsUsed;

        public int skillPoints;
        public int talentPoints;
        public int experienceNextLevel;
        public int experienceCurrent;

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

        public void SetActionBar(Skill[] skills)
        {
            actionBar = skills;
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
                // Set current experience.
                if (experienceCurrent > experienceNextLevel)
                    this.experienceCurrent -= experienceNextLevel;
                else
                    this.experienceCurrent = 0;
                // Set next level experience.
                this.experienceNextLevel = 100 * (int)Math.Pow(1.59, level);
                // Give 5 skill points.
                this.skillPoints += 5;
                // Give the player 1 talent point.
                this.talentPoints++;

                foreach (Skill skill in skills)
                {
                    skill.SetRank(this);
                }
            }
        }

        public double WeaponAttack(Enemy enemy)
        {
            Random random = new Random();
            PhysicalDamage physicalDamage = (PhysicalDamage)this.attributes[(int)PlayerStat.Attribute.PhysicalDamage];

            int damage = random.Next((int)physicalDamage.MinFinal(), (int)physicalDamage.MaxFinal());
            enemy.healthCurrent -= (int)(damage * (1 - enemy.PhysicalResistance()));

            return damage * (1 - enemy.PhysicalResistance());
        }

        // Constructor.
        public Player(Class _playerClass)
        {
            inventorySlotsMax = 20;
            inventory = new Item[inventorySlotsMax];
            equipment = new Item[10];
            inventorySlotsUsed = 0;

            actionBar = new Skill[9];

            name = "Subwoofy";
            healthRegenerationBase = 1;
            manaRegenerationBase = 1;
            damageBaseMin = 1;
            damageBaseMax = 3;
            level = 1;
            gold = 1000;
            skillPoints = 5;
            talentPoints = 0;
            experienceNextLevel = 100;
            experienceCurrent = 0;
        }
    }
}

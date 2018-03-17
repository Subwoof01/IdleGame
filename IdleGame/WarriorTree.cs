using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame
{
    public class WarriorTree : TalentTree
    {
        private Player _player;

        public enum Talent { WeaponMastery, IronSkin, ArmouredToTheTeeth };

        public int weaponMasteryLevel;
        public int weaponMasteryMax;
        public double WeaponMasteryBonus() { return 0.01 * weaponMasteryLevel; }

        public int ironSkinLevel;
        public int ironSkinMax;
        public double IronSkinBonus() { return 0.02 * ironSkinLevel; }

        public int armouredToTheTeethLevel;
        public int armouredToTheTeethMax;
        public double ArmouredToTheTeethBonus() { return (0.01 * (_player.armourFinal() / (6 - armouredToTheTeethLevel))); }

        private int GetLevel(Talent talent)
        {
            switch(talent)
            {
                case Talent.WeaponMastery:
                    return weaponMasteryLevel;
                case Talent.IronSkin:
                    return ironSkinLevel;
                case Talent.ArmouredToTheTeeth:
                    return armouredToTheTeethLevel;

            }
            return 0;
        }
        private int GetMax(Talent talent)
        {
            switch (talent)
            {
                case Talent.WeaponMastery:
                    return weaponMasteryMax;
                case Talent.IronSkin:
                    return ironSkinMax;
                case Talent.ArmouredToTheTeeth:
                    return armouredToTheTeethMax;

            }
            return 0;
        }

        public void IncreaseTalentLevel(Talent talent)
        {
            if (_player.talentPoints > 0)
            {
                switch (talent)
                {
                    case Talent.WeaponMastery:
                        if (weaponMasteryLevel < weaponMasteryMax)
                        {
                            _player.talentPoints--;
                            weaponMasteryLevel++;
                        }
                        break;
                    case Talent.IronSkin:
                        if (ironSkinLevel < ironSkinMax)
                        {
                            _player.talentPoints--;
                            ironSkinLevel++;
                        }
                        break;
                    case Talent.ArmouredToTheTeeth:
                        if (armouredToTheTeethLevel < armouredToTheTeethMax && GetLevel(Talent.WeaponMastery) == GetMax(Talent.WeaponMastery) && GetLevel(Talent.IronSkin) == GetMax(Talent.IronSkin))
                        {
                            _player.talentPoints--;
                            armouredToTheTeethLevel++;
                        }
                        break;
                }
            }
        }

        public void WarriorTreeSetPlayer(Player player)
        {
            _player = player;
        }

        public WarriorTree()
        {
            weaponMasteryLevel = 0;
            weaponMasteryMax = 5;
            
            ironSkinLevel = 0;
            ironSkinMax = 5;

            armouredToTheTeethLevel = 0;
            armouredToTheTeethMax = 3;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.Attributes
{
    [Serializable]
    public class ArmourStat : PlayerStat
    {
        public override double SkillBonus()
        {
            throw new NotImplementedException();
        }

        public override double TalentBonus()
        {
            if (_player.playerClass.Equals(Player.Class.Warrior))
            {
                return _player.talents[(int)WarriorTalentTree.Talent.IronSkin].Effect();
            }
            return 0;
        }

        public override double ItemBonus()
        {
            Armour armour;

            int bonus = 0;

            for (int i = 0; i < _player.equipment.Length; i++)
            {
                if (_player.equipment[i] is Armour)
                {
                    armour = (Armour)_player.equipment[i];
                    bonus += armour.armourBonus;
                }
            }

            return bonus;
        }

        private double StrengthBonus()
        {
            return _player.attributes[(int)Attribute.Dexterity].Final() * 1.2;
        }

        public override double Final()
        {
            return (int)((base_ + StrengthBonus() + ItemBonus()) * (1 + TalentBonus()));
        }

        public ArmourStat(Player player)
        {
            _player = player;
        }
    }
}

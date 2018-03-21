using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.Attributes
{
    public class Mana : PlayerStat
    {
        public override double SkillBonus()
        {
            throw new NotImplementedException();
        }

        public override double TalentBonus()
        {
            throw new NotImplementedException();
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
                    bonus += armour.manaBonus;
                }
            }

            return bonus;
        }

        private double AttributeBonus()
        {
            return _player.attributes[(int)Attribute.Intelligence].Final() * 2;
        }

        public override double Final()
        {
            return base_ + AttributeBonus() + ItemBonus();
        }

        public Mana(Player player, double _base)
        {
            _player = player;
            base_ = _base;
        }
    }
}

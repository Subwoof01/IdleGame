using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.Attributes
{
    [Serializable]
    public class Health : PlayerStat
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
                    bonus += armour.healthBonus;
                }
            }

            return bonus;
        }

        private double AttributeBonus()
        {
            return _player.attributes[(int)Attribute.Strength].Final() * 2;
        }

        public override double Final()
        {
            return base_ + AttributeBonus() + ItemBonus();
        }

        public Health(Player player, double _base)
        {
            _player = player;
            base_ = _base;
        }
    }
}

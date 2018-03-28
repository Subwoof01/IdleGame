using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.Attributes
{
    public class FireResistance : PlayerStat
    {
        public override double Final()
        {
            return AttributeBonus() + ItemBonus();
        }

        private double AttributeBonus()
        {
            return _player.attributes[(int)Attribute.Intelligence].Final() * 0.0001;
        }

        public override double ItemBonus()
        {
            Armour armour;

            double bonus = 0;

            for (int i = 0; i < _player.equipment.Length; i++)
            {
                if (_player.equipment[i] is Armour)
                {
                    armour = (Armour)_player.equipment[i];
                    bonus += armour.elementalResistance;
                    bonus += armour.fireResistance;
                }
            }

            return bonus;
        }

        public override double SkillBonus()
        {
            throw new NotImplementedException();
        }

        public override double TalentBonus()
        {
            throw new NotImplementedException();
        }

        public FireResistance(Player player)
        {
            _player = player;
        }
    }
}

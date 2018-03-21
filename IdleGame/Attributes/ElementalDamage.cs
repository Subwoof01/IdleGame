using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.Attributes
{
    public class ElementalDamage : PlayerStat
    {
        public override double Final()
        {
            return (1 + AttributeBonus()) * (1 + ItemBonus());
        }

        private double AttributeBonus()
        {
            return 0.01 * _player.attributes[(int)Attribute.Intelligence].Final();
        }

        public override double ItemBonus()
        {
            double bonus = 0;

            foreach (Item i in _player.equipment)
            {
                if (i != null) bonus += i.elementalDamageBonus;
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

        public ElementalDamage(Player player)
        {
            _player = player;
        }
    }
}

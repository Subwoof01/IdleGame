using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.Attributes
{
    [Serializable]
    public class FireDamage : PlayerStat
    {
        public override double Final()
        {
            return AttributeBonus() + ItemBonus();
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
                if (i != null)
                {
                    bonus += i.elementalDamageBonus;
                    bonus += i.fireDamageBonus;
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

        public FireDamage(Player player)
        {
            _player = player;
        }
    }
}

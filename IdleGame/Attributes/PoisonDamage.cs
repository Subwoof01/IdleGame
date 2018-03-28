using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.Attributes
{
    public class PoisonDamage : PlayerStat
    {
        public override double Final()
        {
            return AttributeBonus() + ItemBonus();
        }

        private double AttributeBonus()
        {
            return 0;
        }

        public override double ItemBonus()
        {
            double bonus = 0;

            foreach (Item i in _player.equipment)
            {
                if (i != null)
                {
                    bonus += i.elementalDamageBonus;
                    bonus += i.poisonDamageBonus;
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

        public PoisonDamage(Player player)
        {
            _player = player;
        }
    }
}

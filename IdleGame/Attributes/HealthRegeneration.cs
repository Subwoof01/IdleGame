using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.Attributes
{
    public class HealthRegeneration : PlayerStat
    {
        public override double Final()
        {
            return AttributeBonus() + ItemBonus();
        }

        private double AttributeBonus()
        {
            return _player.attributes[(int)Attribute.Strength].Final() * 0.02;
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
                    bonus += armour.healthRegenerationBonus;
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

        public HealthRegeneration(Player player)
        {
            _player = player;
        }
    }
}

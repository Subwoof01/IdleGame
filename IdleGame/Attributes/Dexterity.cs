using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.Attributes
{
    public class Dexterity : PlayerStat
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
            int bonus = 0;

            foreach (Item i in _player.equipment)
            {
                if (i != null)
                    bonus += i.dexterityBonus;
            }

            return bonus;
        }

        public override double Final()
        {
            return base_ + pointBonus + ItemBonus();
        }

        public Dexterity(Player player, double _base)
        {
            _player = player;
            base_ = _base;
            pointBonus = 0;
        }
    }
}

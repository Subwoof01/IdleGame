using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdleGame;

namespace IdleGame.Talents.Warrior
{
    public class WeaponMastery : Talent
    {
        public override double Effect()
        {
            return 0.01 * currentLevel;
        }

        public WeaponMastery(Player player)
        {
            talentClass = Player.Class.Warrior;
            maxLevel = 5;
            currentLevel = 0;

            _player = player;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.Talents.Warrior
{
    public class IronSkin : Talent
    {
        public override double Effect()
        {
            return 0.02 * currentLevel;
        }

        public IronSkin(Player player)
        {
            talentClass = Player.Class.Warrior;
            maxLevel = 5;
            currentLevel = 0;

            _player = player;
        }
    }
}

using IdleGame.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.Talents.Warrior
{
    [Serializable]
    class ArmouredToTheTeeth : Talent
    {
        public override double Effect()
        {
            return (currentLevel > 0) ? (0.01 * (_player.attributes[(int)PlayerStat.Attribute.Armour].Final() / (6 - currentLevel))) : 0;
        }

        public override Talent[] Prerequisites()
        {
            return new Talent[] { _player.talents[(int)WarriorTalentTree.Talent.WeaponMastery], _player.talents[(int)WarriorTalentTree.Talent.IronSkin] };
        }

        public ArmouredToTheTeeth(Player player)
        {
            talentClass = Player.Class.Warrior;
            maxLevel = 3;
            currentLevel = 0;
            
            prerequisitesCount = 2;

            _player = player;
        }
    }
}

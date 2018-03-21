using IdleGame.Attributes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.Skills.Warrior
{
    public class PowerStrike : Skill
    {
        private Player _player;

        public override double Damage()
        {
            PhysicalDamage damagePhysical = (PhysicalDamage)_player.attributes[(int)PlayerStat.Attribute.PhysicalDamage];

            return damagePhysical.MaxFinal() * (1 + 0.05 * currentRank);
        }

        public override void Effect(Enemy enemy)
        {
            enemy.healthCurrent -= (int)(Damage() * (1 - enemy.PhysicalResistance()));
        }

        public override string ToolTip()
        {
            return $"Prepare your weapon for a powerful strike dealing {this.Damage().ToString("0.##")} physical damage after {this.castTime} seconds.";
        }

        public PowerStrike(Player player)
        {
            _player = player;
            name = "Power Strike";
            type = Type.Active;
            levelRank = new int[] { 2, 6, 9, 14, 19, 25, 31, 39, 47, 58, 71, 92 };
            currentRank = 0;
            castTime = 2;
            image = Image.FromFile(@"Resources\SpellIcons\Warrior\PowerStrike.png");
        }
    }
}

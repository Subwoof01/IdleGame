using IdleGame.Attributes;
using IdleGame.Enemies;
using IdleGame.States;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.Skills.Warrior
{
    [Serializable]
    public class Gut : Skill
    {
        private Player _player;
        private Random _random;

        public override double Damage()
        {
            PhysicalDamage weaponDamage = (PhysicalDamage)_player.attributes[(int)PlayerStat.Attribute.PhysicalDamage];

            double damage = _random.Next((int)weaponDamage.MinFinal(), (int)weaponDamage.MaxFinal());

            return damage;
        }

        public override double Effect(Enemy enemy, int _timeCasted)
        {
            timeCasted = _timeCasted;
            enemy.states.Add(new Bleeding(_timeCasted, 10000, 1000, enemy, _player, State.Target.Enemy, this));
            return Damage() * (1 - enemy.PhysicalResistance());
        }

        public override string ToolTip()
        {
            double damage = 0;
            bool checkedOnce = false;

            if (!checkedOnce)
            {
                damage = this.Damage() * 0.2;
                checkedOnce = true;
            }

            return $"Gut your enemy, making it bleed for {damage.ToString("0.##")} physical damage over 10 seconds.";
        }

        public Gut(Player player)
        {
            _player = player;
            name = "Gut";
            type = Type.Active;
            damageType = DamageType.Physical;
            levelRank = new int[] { 2, 6, 9, 14, 19, 25, 31, 39, 47, 58, 71, 92 };
            currentRank = 0;
            castTime = 0.01;
            cooldown = 10;
            image = Image.FromFile(@"Resources\SpellIcons\Warrior\Gut.png");
            cooldownImage = Image.FromFile(@"Resources\SpellIcons\Warrior\Gut_Cooldown.png");
            manaCost = 5;
            _random = new Random();
        }
    }
}

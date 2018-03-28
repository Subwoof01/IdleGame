using IdleGame.Attributes;
using IdleGame.Enemies;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.States
{
    public class Burning : State
    {
        private Player _player;
        private Enemy _enemy;

        private double Damage()
        {
            PhysicalDamage damagePhysical = (PhysicalDamage)_player.attributes[(int)PlayerStat.Attribute.PhysicalDamage];

            return damagePhysical.MaxFinal();
        }

        public override double Effect()
        {
            _enemy.healthCurrent -= (int)Damage();
            return Damage();
        }

        public Burning(int _startTime, int _duration, int _tickSpeed, Enemy enemy, Player player, Target _target)
        {
            _player = player;
            _enemy = enemy;
            target = _target;

            flavourText = $"{((target.Equals(Target.Player)) ? _enemy.name : _player.name)} " +
                $"burns {((target.Equals(Target.Player)) ? _player.name : _enemy.name)} for " +
                $"{Damage().ToString("0")} Fire.";

            image = Image.FromFile(@"Resources\StateIcons\Burning.png");

            startTime = _startTime;
            duration = _duration;
            tickSpeed = _tickSpeed;
            lastTime = 0;
        }
    }
}

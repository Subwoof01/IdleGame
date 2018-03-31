using IdleGame.Attributes;
using IdleGame.Enemies;
using IdleGame.Skills;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.States
{
    [Serializable]
    public class Freezing : State
    {
        private Player _player;
        private Enemy _enemy;
        private Skill _skill;
        
        public override double Effect()
        {
            _enemy.attackSpeed *= 2;
            firstApplied = true;
            return 0;
        }

        public Freezing(int _startTime, int _duration, Enemy enemy, Player player, Target _target, Skill skill)
        {
            _player = player;
            _enemy = enemy;
            target = _target;
            _skill = skill;

            flavourText = $"{((target.Equals(Target.Player)) ? _enemy.name : _player.name)} " +
                $"freezes {((target.Equals(Target.Player)) ? _player.name : _enemy.name)}.";

            image = Image.FromFile(@"Resources\StateIcons\Freezing.png");

            startTime = _startTime;
            duration = _duration;
            tickSpeed = _duration;
            lastTime = 0;
            firstApplied = false;
        }
    }
}

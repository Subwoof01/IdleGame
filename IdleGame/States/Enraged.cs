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
    public class Enraged : State
    {
        private Player _player;
        private Enemy _enemy;
        private Skill _skill;
        
        public override double Effect()
        {
            if (target.Equals(Target.Enemy))
                _enemy.damageBaseMin = (int)(_enemy.damageBaseMin * 1.30);
            else
                _player.attributes[(int)PlayerStat.Attribute.PhysicalDamage].base_ += 0.30;

            firstApplied = true;

            return 0;
        }

        public Enraged(int _startTime, int _duration, Enemy enemy, Player player, Target _target, Skill skill)
        {
            _player = player;
            _enemy = enemy;
            target = _target;
            _skill = skill;

            flavourText = $"{((target.Equals(Target.Player)) ? _player.name : _enemy.name)} enrages.";

            image = Image.FromFile(@"Resources\StateIcons\Angered.png");

            startTime = _startTime;
            duration = _duration;
            tickSpeed = _duration;
            lastTime = 0;
            firstApplied = false;
        }
    }
}

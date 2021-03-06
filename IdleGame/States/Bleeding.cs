﻿using IdleGame.Attributes;
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
    public class Bleeding : State
    {
        private Player _player;
        private Enemy _enemy;
        private Skill _skill;

        private double Damage()
        {
            return (_skill.Damage() * 0.20) * (1 + _player.attributes[(int)PlayerStat.Attribute.PhysicalDamage].Final());
        }

        public override double Effect()
        {
            _enemy.healthCurrent -= (int)Damage();
            return Damage();
        }

        public Bleeding(int _startTime, int _duration, int _tickSpeed, Enemy enemy, Player player, Target _target, Skill skill)
        {
            _player = player;
            _enemy = enemy;
            target = _target;
            _skill = skill;

            flavourText = $"{((target.Equals(Target.Player)) ? _player.name : _enemy.name)} bleeds for " +
                $"{Damage().ToString("0")} Physical.";

            image = Image.FromFile(@"Resources\StateIcons\Bleeding.png");

            startTime = _startTime;
            duration = _duration;
            tickSpeed = _tickSpeed;
            lastTime = 0;
        }
    }
}

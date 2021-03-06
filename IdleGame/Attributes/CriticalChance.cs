﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.Attributes
{
    [Serializable]
    public class CriticalChance : PlayerStat
    {
        public override double Final()
        {
            return base_ + AttributeBonus() + ItemBonus();
        }

        private double AttributeBonus()
        {
            return _player.attributes[(int)Attribute.Dexterity].Final() * 0.001;
        }

        public override double ItemBonus()
        {
            Weapon mainHand;
            double mainHandCrit = 0;

            // If main hand is of type Weapon, add it to the equation otherwise do not.
            if (_player.equipment[(int)Item.Equip.MainHand] is Weapon) mainHand = (Weapon)_player.equipment[(int)Item.Equip.MainHand];
            else mainHand = null;

            if (mainHand != null)
                mainHandCrit = mainHand.criticalChanceBonus;

            return mainHandCrit;
        }

        public override double SkillBonus()
        {
            throw new NotImplementedException();
        }

        public override double TalentBonus()
        {
            throw new NotImplementedException();
        }

        public CriticalChance(Player player, double _base)
        {
            _player = player;
            base_ = _base;
        }
    }
}

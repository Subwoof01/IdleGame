using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.Attributes
{
    [Serializable]
    public class PhysicalDamage : PlayerStat
    {
        private int _baseMin;
        private int _baseMax;

        public override double Final()
        {
            return AttributeBonus() + ItemBonus();
        }

        public double MinFinal()
        {
            Weapon mainHand;
            double mainHandDamageMin = 0;

            if (_player.equipment[(int)Item.Equip.MainHand] is Weapon) mainHand = (Weapon)_player.equipment[(int)Item.Equip.MainHand];
            else mainHand = null;

            if (mainHand != null)
                mainHandDamageMin = mainHand.damageMin;

            return (_baseMin + mainHandDamageMin) * (1 + AttributeBonus()) * (1 + ItemBonus()) * (1 + TalentBonus());
        }

        public double MaxFinal()
        {
            Weapon mainHand;
            double mainHandDamageMax = 0;

            if (_player.equipment[(int)Item.Equip.MainHand] is Weapon) mainHand = (Weapon)_player.equipment[(int)Item.Equip.MainHand];
            else mainHand = null;

            if (mainHand != null)
                mainHandDamageMax = mainHand.damageMax;

            return (_baseMax + mainHandDamageMax) * (1 + AttributeBonus()) * (1 + ItemBonus()) * (1 + TalentBonus());
        }

        private double AttributeBonus()
        {
            return 0.01 * _player.attributes[(int)Attribute.Strength].Final();
        }

        public override double ItemBonus()
        {
            double bonus = 0;

            foreach (Item i in _player.equipment)
            {
                if (i != null) bonus += i.physicalDamageBonus;
            }

            return bonus;
        }

        public override double SkillBonus()
        {
            throw new NotImplementedException();
        }

        public override double TalentBonus()
        {
            if (_player.playerClass.Equals(Player.Class.Warrior))
            {
                return _player.talents[(int)WarriorTalentTree.Talent.WeaponMastery].Effect() + _player.talents[(int)WarriorTalentTree.Talent.ArmouredToTheTeeth].Effect();
            }

            return 0;
        }

        public PhysicalDamage(Player player, int baseMin, int baseMax)
        {
            _player = player;
            _baseMin = baseMin;
            _baseMax = baseMax;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdleGame
{
    public partial class WarriorTalentTree : Form
    {
        private Player _player;
        private WarriorTree _warrior;
        private CharacterForm _characterForm;

        private void pbWeaponMastery_Click(object sender, EventArgs e)
        {
            _warrior.IncreaseTalentLevel(WarriorTree.Talent.WeaponMastery);
            UpdateText();
            _characterForm.UpdateStats();
        }

        private void pbIronSkin_Click(object sender, EventArgs e)
        {
            _warrior.IncreaseTalentLevel(WarriorTree.Talent.IronSkin);
            UpdateText();
            _characterForm.UpdateStats();
        }

        private void pbArmouredToTheTeeth_Click(object sender, EventArgs e)
        {
            _warrior.IncreaseTalentLevel(WarriorTree.Talent.ArmouredToTheTeeth);
            UpdateText();
            _characterForm.UpdateStats();
        }

        public void UpdateText()
        {
            tbTalentPoints.Text = _player.talentPoints.ToString();

            lblWeaponMasteryLevel.Text = $"{_warrior.weaponMasteryLevel}/{_warrior.weaponMasteryMax}";
            ttWeaponMastery.SetToolTip(pbWeaponMastery, $"Increases physical damage by {_warrior.WeaponMasteryBonus() * 100}%");

            lblIronSkinLevel.Text = $"{_warrior.ironSkinLevel}/{_warrior.ironSkinMax}";
            ttIronSkin.SetToolTip(pbIronSkin, $"Increases armour by {_warrior.IronSkinBonus()*100}%");

            lblArmouredToTheTeeth.Text = $"{_warrior.armouredToTheTeethLevel}/{_warrior.armouredToTheTeethMax}";
            ttArmouredToTheTeeth.SetToolTip(pbArmouredToTheTeeth, $"Increases physical damage by 1% for every {6 - _warrior.armouredToTheTeethLevel} points of armour you have.");
        }

        public WarriorTalentTree(TalentTree talentTree, Player player, CharacterForm characterForm)
        {
            InitializeComponent();

            _characterForm = characterForm;
            _player = player;

            // We do this to make sure the program doesn't crash if something fucks up somewhere.
            if (talentTree is WarriorTree)
                _warrior = (WarriorTree)talentTree;

            UpdateText();
        }
    }
}

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
        private CharacterForm _characterForm;
        public enum Talent { WeaponMastery, IronSkin, ArmouredToTheTeeth };

        private void pbWeaponMastery_Click(object sender, EventArgs e)
        {
            _player.talents[(int)Talent.WeaponMastery].IncreaseLevel();
            UpdateText();
            _characterForm.UpdateStats();
        }

        private void pbIronSkin_Click(object sender, EventArgs e)
        {
            _player.talents[(int)Talent.IronSkin].IncreaseLevel();
            UpdateText();
            _characterForm.UpdateStats();
        }

        private void pbArmouredToTheTeeth_Click(object sender, EventArgs e)
        {
            _player.talents[(int)Talent.ArmouredToTheTeeth].IncreaseLevel();
            UpdateText();
            _characterForm.UpdateStats();
        }

        public void UpdateText()
        {
            tbTalentPoints.Text = _player.talentPoints.ToString();

            lblWeaponMasteryLevel.Text = $"{_player.talents[(int)Talent.WeaponMastery].currentLevel}/{_player.talents[(int)Talent.WeaponMastery].maxLevel}";
            ttWeaponMastery.SetToolTip(pbWeaponMastery, $"Increases physical damage by {_player.talents[(int)Talent.WeaponMastery].Effect() * 100}%");

            lblIronSkinLevel.Text = $"{_player.talents[(int)Talent.IronSkin].currentLevel}/{_player.talents[(int)Talent.IronSkin].maxLevel}";
            ttIronSkin.SetToolTip(pbIronSkin, $"Increases armour by {_player.talents[(int)Talent.IronSkin].Effect() * 100}%");

            lblArmouredToTheTeeth.Text = $"{_player.talents[(int)Talent.ArmouredToTheTeeth].currentLevel}/{_player.talents[(int)Talent.ArmouredToTheTeeth].maxLevel}";
            ttArmouredToTheTeeth.SetToolTip(pbArmouredToTheTeeth, $"Increases physical damage by 1% for every {6 - _player.talents[(int)Talent.ArmouredToTheTeeth].currentLevel} points of armour you have.");
        }

        public WarriorTalentTree(Player player, CharacterForm characterForm)
        {
            InitializeComponent();

            _characterForm = characterForm;
            _player = player;

            UpdateText();
        }
    }
}

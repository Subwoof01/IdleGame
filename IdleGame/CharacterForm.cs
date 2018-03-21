using IdleGame.Attributes;
using IdleGame.Talents;
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
    public partial class CharacterForm : Form
    {
        private MainForm _mainForm;
        private Player _player;
        private InventoryForm _inventoryForm;
        private WarriorTalentTree warriorTalentForm;
        private SkillBook skillBook;


        public void OnOpen()
        {
            _mainForm.UpdateText();
        }

        public void UpdateStats()
        {
            PhysicalDamage physicalDamage = (PhysicalDamage)_player.attributes[(int)PlayerStat.Attribute.PhysicalDamage];

            // Update player stat display.
            tbNameSet.Text = _player.name;
            tbClass.Text = Enum.GetName(typeof(Player.Class), _player.playerClass);
            tbLevel.Text = _player.level.ToString();
            tbExperience.Text = $"{_player.experienceCurrent}/{_player.experienceNextLevel}";
            tbSkillPoints.Text = _player.skillPoints.ToString();
            tbTalentPoints.Text = _player.talentPoints.ToString();

            tbStrength.Text = _player.attributes[(int)PlayerStat.Attribute.Strength].Final().ToString();
            tbIntelligence.Text = _player.attributes[(int)PlayerStat.Attribute.Intelligence].Final().ToString();
            tbDexterity.Text = _player.attributes[(int)PlayerStat.Attribute.Dexterity].Final().ToString();
            tbHealth.Text = _player.attributes[(int)PlayerStat.Attribute.Health].Final().ToString();
            tbMana.Text = _player.attributes[(int)PlayerStat.Attribute.Mana].Final().ToString();
            tbArmour.Text = _player.attributes[(int)PlayerStat.Attribute.Armour].Final().ToString();

            tbPhysicalDamage.Text = $"{physicalDamage.MinFinal().ToString("0.##")}-{physicalDamage.MaxFinal().ToString("0.##")}";
            tbPhysicalDamageIncrease.Text = $"{((_player.attributes[(int)PlayerStat.Attribute.PhysicalDamage].Final() - 1) * 100).ToString("0.##")}%";
            tbElementalDamage.Text = "W.I.P.";
            tbElementalDamageIncrease.Text = $"{((_player.attributes[(int)PlayerStat.Attribute.ElementalDamage].Final() - 1) * 100).ToString("0.##")}%";
            tbCriticalChance.Text = $"{((_player.attributes[(int)PlayerStat.Attribute.CriticalChance].Final() - 1) * 100).ToString("0.##")}%";
            tbCriticalDamage.Text = $"{((_player.attributes[(int)PlayerStat.Attribute.CriticalDamage].Final() - 1) * 100).ToString("0.##")}%";

            tbPhysicalReduction.Text = $"{((_player.attributes[(int)PlayerStat.Attribute.PhysicalResistance].Final() - 1) * 100).ToString("0.##")}%";
            tbElementalResistance.Text = $"{((_player.attributes[(int)PlayerStat.Attribute.ElementalResistance].Final() - 1) * 100).ToString("0.##")}%";
            tbHealthRegeneration.Text = $"{_player.attributes[(int)PlayerStat.Attribute.HealthRegeneration].Final()}/s";
            tbManaRegeneration.Text = $"{_player.attributes[(int)PlayerStat.Attribute.ManaRegeneration].Final()}/s";

            // Enable skill up buttons if player has skill points. Disable if player doesn't.
            if (_player.skillPoints > 0)
            {
                btnIncreaseStrength.Enabled = true;
                btnIncreaseIntelligence.Enabled = true;
                btnIncreaseDexterity.Enabled = true;
            }
            else
            {
                btnIncreaseStrength.Enabled = false;
                btnIncreaseIntelligence.Enabled = false;
                btnIncreaseDexterity.Enabled = false;
            }

            if (warriorTalentForm != null)
                warriorTalentForm.UpdateText();
            if (skillBook != null)
                skillBook.UpdateForm();
        }

        private void ClosedForm(object sender, FormClosedEventArgs e)
        {
            _mainForm.UpdateText();
        }

        private void btnSetName_Click(object sender, EventArgs e)
        {
            _player.name = tbNameSet.Text;
            _mainForm.UpdateText();
        }

        private void btnIncreaseStrength_Click(object sender, EventArgs e)
        {
            _player.attributes[(int)PlayerStat.Attribute.Strength].pointBonus++;
            _player.skillPoints--;
            _mainForm.UpdateText();
        }

        private void btnIncreaseIntelligence_Click(object sender, EventArgs e)
        {
            _player.attributes[(int)PlayerStat.Attribute.Intelligence].pointBonus++;
            _player.skillPoints--;
            _mainForm.UpdateText();
        }

        private void btnIncreaseDexterity_Click(object sender, EventArgs e)
        {
            _player.attributes[(int)PlayerStat.Attribute.Dexterity].pointBonus++;
            _player.skillPoints--;
            _mainForm.UpdateText();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            _mainForm.UpdateText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _player.IncreaseExp(150);
            _mainForm.UpdateText();
        }

        private void btnTalentTree_Click(object sender, EventArgs e)
        {
            if (_player.playerClass.Equals(Player.Class.Warrior))
            {
                warriorTalentForm = new WarriorTalentTree(_player, this);
                warriorTalentForm.Show();
            }
        }

        private void btnSpells_Click(object sender, EventArgs e)
        {
            skillBook = new SkillBook(_player);
            skillBook.Show();
        }

        public CharacterForm(MainForm mainForm, Player player, InventoryForm inventoryForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _player = player;
            _inventoryForm = inventoryForm;
        }
    }
}

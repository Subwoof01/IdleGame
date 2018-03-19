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
        private WarriorTalentTree warriorForm;

        public void OnOpen()
        {
            _mainForm.UpdateText();
        }

        public void UpdateStats()
        {
            // Update player stat display.
            tbNameSet.Text = _player.name;
            tbClass.Text = Enum.GetName(typeof(CharacterClass.Classes), _player.playerClass);
            tbLevel.Text = _player.level.ToString();
            tbExperience.Text = $"{_player.experienceCurrent}/{_player.experienceNextLevel}";
            tbSkillPoints.Text = _player.skillPoints.ToString();
            tbTalentPoints.Text = _player.talentPoints.ToString();

            tbStrength.Text = _player.strengthFinal().ToString();
            tbIntelligence.Text = _player.intelligenceFinal().ToString();
            tbDexterity.Text = _player.dexterityFinal().ToString();
            tbHealth.Text = _player.healthFinal().ToString();
            tbMana.Text = _player.manaFinal().ToString();
            tbArmour.Text = _player.armourFinal().ToString();

            tbPhysicalDamage.Text = _player.physicalDamage().ToString();
            tbPhysicalDamageIncrease.Text = $"{_player.physicalDamageIncrease() * 100}%";
            tbElementalDamage.Text = _player.elementalDamage().ToString();
            tbElementalDamageIncrease.Text = $"{_player.elementalDamageIncrease() * 100}%";
            tbCriticalChance.Text = $"{_player.criticalChance() * 100}%";
            tbCriticalDamage.Text = $"{_player.criticalDamage() * 100}%";

            tbPhysicalReduction.Text = $"{_player.physicalResistance() * 100}%";
            tbElementalResistance.Text = $"{_player.elementalResistance() * 100}%";
            tbHealthRegeneration.Text = $"{_player.healthRegeneration()}/s";
            tbManaRegeneration.Text = $"{_player.manaRegeneraion()}/s";

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

            if (warriorForm != null)
                warriorForm.UpdateText();
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
            _player.strengthBase++;
            _player.skillPoints--;
            _mainForm.UpdateText();
        }

        private void btnIncreaseIntelligence_Click(object sender, EventArgs e)
        {
            _player.intelligenceBase++;
            _player.skillPoints--;
            _mainForm.UpdateText();
        }

        private void btnIncreaseDexterity_Click(object sender, EventArgs e)
        {
            _player.dexterityBase++;
            _player.skillPoints--;
            _mainForm.UpdateText();
        }

        private void btnSpells_Click(object sender, EventArgs e)
        {

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

        public CharacterForm(MainForm mainForm, Player player, InventoryForm inventoryForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _player = player;
            _inventoryForm = inventoryForm;
        }

        private void btnTalentTree_Click(object sender, EventArgs e)
        {
            if (_player.playerTalentTree is WarriorTree)
            {
                warriorForm = new WarriorTalentTree(_player.playerTalentTree, _player, this);
                warriorForm.Show();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdleGame
{
    public partial class MainForm : Form
    {
        private Player _player;

        CharacterForm character;
        InventoryForm inventory;
        ShopForm shop;

        private void btnInventory_Click(object sender, EventArgs e)
        {
            inventory = new InventoryForm(_player, character);
            inventory.Show();
        }

        private void btnCharacter_Click(object sender, EventArgs e)
        {
            character = new CharacterForm(this, _player, inventory);
            character.OnOpen();
            character.Show();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            shop = new ShopForm(_player);
            shop.Show();
        }

        public void UpdateText()
        {
            // Update player stat text.
            lblName.Text = _player.name;
            lblClass.Text = Enum.GetName(typeof(CharacterClass.Classes), _player.playerClass);
            lblHealth.Text = $"{_player.healthCurrent}/{_player.healthFinal()}";
            lblMana.Text = $"{_player.manaCurrent}/{_player.manaFinal()}";
            lblExperience.Text = $"{_player.experienceCurrent}/{_player.experienceNextLevel}";

            healthBar.Maximum = _player.healthFinal();
            healthBar.Value = _player.healthCurrent;

            manaBar.Maximum = _player.manaFinal();
            manaBar.Value = _player.manaCurrent;

            experienceBar.Maximum = _player.experienceNextLevel;
            experienceBar.Value = _player.experienceCurrent;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // TODO
        }

        public MainForm(Player player)
        {
            InitializeComponent();

            // Pass the player instance to the WarriorTree object so we can read its values there. (Needed for tooltips).
            WarriorTree warrior;
            if (player.playerTalentTree is WarriorTree)
            {
                warrior = (WarriorTree)player.playerTalentTree;
                warrior.WarriorTreeSetPlayer(player);
            }
            
            _player = player;
            UpdateText();
        }
    }
}

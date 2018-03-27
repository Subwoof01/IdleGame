using IdleGame.Attributes;
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

        private CharacterForm character;
        private InventoryForm inventory;
        private ShopForm shop;
        private CombatForm combat;

        private void btnInventory_Click(object sender, EventArgs e)
        {
            inventory = new InventoryForm(_player, this);
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
            bool firstTime = true;
            var oldTime = DateTime.UtcNow;
            if (oldTime.AddHours(1) > oldTime || firstTime)
            {
                oldTime = DateTime.UtcNow;
                firstTime = false;
            }
            shop = new ShopForm(_player, this);
            shop.FillShop(_player.level);
            shop.Show();
        }

        public void UpdateText()
        {
            // Update player stat text.
            lblName.Text = _player.name;
            lblClass.Text = Enum.GetName(typeof(Player.Class), _player.playerClass);
            lblHealth.Text = $"{_player.healthCurrent}/{(int)_player.attributes[(int)PlayerStat.Attribute.Health].Final()}";
            lblMana.Text = $"{_player.manaCurrent}/{(int)_player.attributes[(int)PlayerStat.Attribute.Mana].Final()}";
            lblExperience.Text = $"{_player.experienceCurrent}/{_player.experienceNextLevel}";

            healthBar.Maximum = (int)_player.attributes[(int)PlayerStat.Attribute.Health].Final();
            healthBar.Value = _player.healthCurrent;

            manaBar.Maximum = (int)_player.attributes[(int)PlayerStat.Attribute.Mana].Final();
            manaBar.Value = _player.manaCurrent;

            experienceBar.Maximum = _player.experienceNextLevel;
            experienceBar.Value = _player.experienceCurrent;

            if (character != null)
                character.UpdateStats();
            if (inventory != null)
                inventory.UpdateText();
            if (shop != null)
                shop.UpdateText();
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
            //WarriorTalent warrior;
            //if (player.playerClass.Equals(Player.Class.Warrior))
            //{
            //    warrior = player.warriorTree;
            //    warrior.WarriorTreeSetPlayer(player);
            //}
            
            _player = player;
            UpdateText();
        }

        private void btnTravel_Click(object sender, EventArgs e)
        {
            combat = new CombatForm(_player);
            combat.Show();
        }
    }
}

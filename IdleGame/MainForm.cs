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

        private CharacterForm _character;
        private InventoryForm _inventory;
        private ShopForm _shop;
        private TravelForm _travel;

        private void btnInventory_Click(object sender, EventArgs e)
        {
            _inventory = new InventoryForm(_player, this);
            _inventory.Show();
        }

        private void btnCharacter_Click(object sender, EventArgs e)
        {
            _character = new CharacterForm(this, _player, _inventory);
            _character.OnOpen();
            _character.Show();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            _shop = new ShopForm(_player, this);

            // Store if it's the first time opening the shop.
            bool firstTime = true;

            // Store the time of opening the shop.
            DateTime oldTime = new DateTime();

            // If it's the first time opening the shop window, or an hour has past since last generating items.
            if (oldTime.AddHours(1) > oldTime || firstTime)
            {
                // Save the current time.
                oldTime = DateTime.UtcNow;
                firstTime = false;

                // Generate items to fill the shop.
                _shop.FillShop(_player.level);
            }

            _shop.Show();
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

            if (_character != null)
                _character.UpdateStats();
            if (_inventory != null)
                _inventory.UpdateText();
            if (_shop != null)
                _shop.UpdateText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // TODO: Figure out how serialization works.
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
            _travel = new TravelForm(_player, this);
            _travel.Show();
        }
    }
}

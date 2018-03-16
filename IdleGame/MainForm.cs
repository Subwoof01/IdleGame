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
        Player player = new Player();
        CharacterForm character;
        InventoryForm inventory;

        public MainForm()
        {
            InitializeComponent();
            UpdateText();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            inventory = new InventoryForm(player, character);
            inventory.Show();
        }

        private void btnCharacter_Click(object sender, EventArgs e)
        {
            character = new CharacterForm(this, player, inventory);
            character.OnOpen();
            character.Show();
        }

        public void UpdateText()
        {
            // Update player stat text.
            lblName.Text = player.name;
            lblClass.Text = player.playerClass;
            lblHealth.Text = $"{player.healthCurrent}/{player.healthFinal()}";
            lblMana.Text = $"{player.manaCurrent}/{player.manaFinal()}";
            lblExperience.Text = $"{player.experienceCurrent}/{player.experienceNextLevel}";

            healthBar.Maximum = player.healthFinal();
            healthBar.Value = player.healthCurrent;

            manaBar.Maximum = player.manaFinal();
            manaBar.Value = player.manaCurrent;

            experienceBar.Maximum = player.experienceNextLevel;
            experienceBar.Value = player.experienceCurrent;
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
    }
}

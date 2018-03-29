using IdleGame.Attributes;
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
    public partial class ShopForm : Form
    {
        private MainForm _mainForm;
        private Player _player;
        private int _healCost;

        private List<Item> _general;
        private List<Armour> _armour;
        private List<Weapon> _weapons;

        public void FillShop(int currentPlayerLevel)
        {
            Random random = new Random();
            //int generalAmount = random.Next(20);
            int armourAmount = random.Next(3, 20);
            int weaponAmount = random.Next(3, 20);

            //for (int i = 0; i < generalAmount; i++)
            //{
            //    general.Add();
            //}

            // Generate a random amount of armours and weapons to populate the shop.
            for (int i = 0; i < armourAmount; i++)
            {
                _armour.Add(Armour.Generate((currentPlayerLevel > 5) ? currentPlayerLevel - 5 : 1, currentPlayerLevel + 5));
            }

            for (int i = 0; i < weaponAmount; i++)
            {
                _weapons.Add(Weapon.Generate((currentPlayerLevel > 5) ? currentPlayerLevel - 5 : 1, currentPlayerLevel + 5));
            }
        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            if (_player.gold >= _healCost)
            {
                _player.healthCurrent = (int)_player.attributes[(int)PlayerStat.Attribute.Health].Final();
                _player.gold -= _healCost;
            }
            _mainForm.UpdateText();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (tcBuy.SelectedTab == tcBuy.Controls[1])
            {
                // NullReferenceException catcher.
                if (lbArmour.SelectedItem != null)
                {
                    // Check all used slots to find the selected item.
                    for (int i = 0; i < _player.inventory.Length; i++)
                    {
                        if (_player.inventory[i] == null)
                        {
                            _player.AddItem(_armour[lbArmour.SelectedIndex]);
                            _player.gold -= _armour[lbArmour.SelectedIndex].price;
                            _armour.RemoveAt(lbArmour.SelectedIndex);
                            break;
                        }
                    }
                }
            }

            if (tcBuy.SelectedTab == tcBuy.Controls[2])
            {
                // NullReferenceException catcher.
                if (lbWeapons.SelectedItem != null)
                {
                    // Check all used slots to find the selected item.
                    for (int i = 0; i < _player.inventory.Length; i++)
                    {
                        // Find first empty slot in inventory.
                        if (_player.inventory[i] == null)
                        {
                            // Add the item to the inventory.
                            _player.AddItem(_weapons[lbWeapons.SelectedIndex]);

                            // Decrease player gold.
                            _player.gold -= _weapons[lbWeapons.SelectedIndex].price;

                            // Remove the item from the shop.
                            _weapons.RemoveAt(lbWeapons.SelectedIndex);

                            break;
                        }
                    }
                }
            }

            _mainForm.UpdateText();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            // NullReferenceException catcher.
            if (lbInventory.SelectedItem != null)
            {
                // Check all used slots to find the selected item.
                for (int i = 0; i < _player.inventory.Length; i++)
                {
                    // Store selected item in itemEquip.
                    if (_player.inventory[i] != null && lbInventory.SelectedItem != null && _player.inventory[i].name == lbInventory.SelectedItem.ToString())
                    {
                        // Increase player gold.
                        _player.gold += _player.inventory[i].price;

                        // Remove the item from the inventory.
                        _player.inventory[i] = null;

                        // Increase available inventory slots.
                        _player.inventorySlotsUsed--;

                        // Update texts.
                        _mainForm.UpdateText();

                        break;
                    }
                }
            }
        }

        public void UpdateText()
        {
            lbGeneral.Items.Clear();
            lbArmour.Items.Clear();
            lbWeapons.Items.Clear();
            lbInventory.Items.Clear();

            foreach (Armour a in _armour)
            {
                lbArmour.Items.Add(a);
            }

            lbArmour.ValueMember = "itemID";
            lbArmour.DisplayMember = "Name";

            foreach (Weapon w in _weapons)
            {
                lbWeapons.Items.Add(w);
            }

            lbWeapons.ValueMember = "itemID";
            lbWeapons.DisplayMember = "Name";

            foreach (Item i in _player.inventory)
            {
                if (i != null)
                    lbInventory.Items.Add(i);
            }

            lbInventory.ValueMember = "itemID";
            lbInventory.DisplayMember = "Name";

            _healCost = ((int)_player.attributes[(int)PlayerStat.Attribute.Health].Final() - _player.healthCurrent) / 3;
            btnHeal.Text = $"Heal ({_healCost}g)";

            tbGold.Text = _player.gold.ToString();
            tbInventorySpace.Text = $"{_player.inventorySlotsUsed}/{_player.inventorySlotsMax}";
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            _mainForm.UpdateText();
        }

        private void lbArmour_SelectedIndexChanged(object sender, EventArgs e)
        {
            // NullReferenceException catcher.
            if (lbArmour.SelectedItem != null)
            {
                tbItemStats.Text = (lbArmour.SelectedItem as Armour).tooltip;
            }
        }

        private void lbWeapons_SelectedIndexChanged(object sender, EventArgs e)
        {
            // NullReferenceException catcher.
            if (lbWeapons.SelectedItem != null)
            {
                tbItemStats.Text = (lbWeapons.SelectedItem as Weapon).tooltip;
            }
        }

        private void lbInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // NullReferenceException catcher.
            if (lbInventory.SelectedItem != null)
            {
                tbItemStats.Text = (lbInventory.SelectedItem as Item).tooltip;
            }
        }

        public ShopForm(Player player, MainForm mainForm)
        {
            InitializeComponent();
            _player = player;
            _mainForm = mainForm;

            _general = new List<Item>();
            _armour = new List<Armour>();
            _weapons = new List<Weapon>();
        }
    }
}

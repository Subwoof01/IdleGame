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
    public partial class InventoryForm : Form
    {
        private Player _player;
        private MainForm _mainForm;

        // For debug item spawning
        private Random random = new Random();

        private Dictionary<string, int> inventoryItems;

        private void InventoryForm_Load(object sender, EventArgs e)
        {
             _mainForm.UpdateText();
        }

        private void EquipItem(Item.Equip slot)
        {
            // Initialise itemEquip variable. Holds the item we'll attempt to equip.
            Item itemEquip = null;
            // Initialise the equipped variable. Holds the item (if there is) we currently have equipped.
            Item equipped = null;

            // NullReferenceException catcher.
            if (lbInventory.SelectedItem != null)
            {
                // Check all used slots to find the selected item.
                for (int i = 0; i < _player.inventory.Length; i++)
                {
                    // Store selected item in itemEquip.
                    if (_player.inventory[i] != null && _player.inventory[i] == (lbInventory.SelectedItem as Item))
                        itemEquip = _player.inventory[i];
                }

                // If player meets lvl/str/int/dex requirements and item is of correct equip slot, equip item.
                if (itemEquip != null && itemEquip.equipSlot.Equals(slot) && _player.level >= itemEquip.levelRequirement && _player.attributes[(int)PlayerStat.Attribute.Strength].Final() >= itemEquip.strengthRequirement && _player.attributes[(int)PlayerStat.Attribute.Intelligence].Final() >= itemEquip.intelligenceRequirement && _player.attributes[(int)PlayerStat.Attribute.Dexterity].Final() >= itemEquip.dexterityRequirement)
                {
                    if (_player.equipment[(int)slot] != null)
                        equipped = _player.equipment[(int)slot];

                    // Equip item.
                    _player.equipment[(int)slot] = itemEquip;

                    // Remove from inventory.
                    for (int i = 0; i < _player.inventory.Length; i++)
                    {
                        if (_player.inventory[i] != null && _player.inventory[i] == (lbInventory.SelectedItem as Item))
                            _player.inventory[i] = null;
                    }

                    // Decrease available inventory slots.
                    _player.inventorySlotsUsed--;

                    // If we had an item equipped.
                    if (equipped != null)
                    {
                        // Find the first empty slot in the inventory.
                        for (int i = 0; i < _player.inventory.Length; i++)
                        {
                            if (_player.inventory[i] == null)
                            {
                                // Put it in inventory.
                                _player.inventory[i] = equipped;

                                // Increase available inventory slots.
                                _player.inventorySlotsUsed++;

                                // Show item on screen.
                                _mainForm.UpdateText();

                                // Job done, exist for-loop.
                                break;
                            }
                        }
                    }
                }
                // Otherwise, show dialog box telling player cannot equip item.
                else
                {
                    DialogResult notYetDialog = MessageBox.Show($"You do not meet the requirements to equip this item. \n" +
                        $"\t\t Player - Item \n" +
                        $"Slot:\t\t {Enum.GetName(typeof(Item.Equip), slot)} - {Enum.GetName(typeof(Item.Equip), itemEquip.equipSlot)} \n" +
                        $"Level:\t\t {_player.level} - {itemEquip.levelRequirement} \n" +
                        $"Strength:\t {_player.attributes[(int)PlayerStat.Attribute.Strength].Final()} - {itemEquip.strengthRequirement} \n" +
                        $"Intelligence:\t {_player.attributes[(int)PlayerStat.Attribute.Intelligence].Final()} - {itemEquip.intelligenceRequirement} \n" +
                        $"Dexterity:\t {_player.attributes[(int)PlayerStat.Attribute.Dexterity].Final()} - {itemEquip.dexterityRequirement}", "Not Yet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            _mainForm.UpdateText();
        }

        private void btnHead_Click(object sender, EventArgs e)
        {
            EquipItem(Item.Equip.Head);
        }

        private void btnWeapon_Click(object sender, EventArgs e)
        {
            EquipItem(Item.Equip.MainHand);
        }

        private void btnChest_Click(object sender, EventArgs e)
        {
            EquipItem(Item.Equip.Chest);
        }

        public void UpdateText()
        {
            lbInventory.Items.Clear();

            for (int i = 0; i < _player.inventory.Length; i++)
            {
                if (_player.inventory[i] != null)
                    lbInventory.Items.Add(_player.inventory[i]);
            }

            lbInventory.ValueMember = "itemID";
            lbInventory.DisplayMember = "Name";

            tbGold.Text = _player.gold.ToString();
            tbInventorySpace.Text = $"{_player.inventorySlotsUsed}/{_player.inventorySlotsMax}";

            if (_player.equipment[(int)Item.Equip.Head] != null)
                tbHeadEquipped.Text = _player.equipment[(int)Item.Equip.Head].name;
            else
                tbHeadEquipped.Text = "<Empty>";

            if (_player.equipment[(int)Item.Equip.Chest] != null)
                tbChestEquipped.Text = _player.equipment[(int)Item.Equip.Chest].name;
            else
                tbChestEquipped.Text = "<Empty>";

            if (_player.equipment[(int)Item.Equip.MainHand] != null)
                tbMainHandEquipped.Text = _player.equipment[(int)Item.Equip.MainHand].name;
            else
                tbMainHandEquipped.Text = "<Empty>";
        }

        private void lbInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // NullReferenceException catcher.
            if (lbInventory.SelectedItem != null)
            {
                tbItemStats.Text = (lbInventory.SelectedItem as Item).tooltip;
            }
        }

        private void btnHeadShow_Click(object sender, EventArgs e)
        {
            _mainForm.UpdateText();
            if (_player.equipment[(int)Item.Equip.Head] != null)
                tbItemStats.Text = _player.equipment[(int)Item.Equip.Head].tooltip;
        }

        private void btnChestShow_Click(object sender, EventArgs e)
        {
            _mainForm.UpdateText();
            if (_player.equipment[(int)Item.Equip.Chest] != null)
                tbItemStats.Text = _player.equipment[(int)Item.Equip.Chest].tooltip;
        }

        private void btnWeaponShow_Click(object sender, EventArgs e)
        {
            _mainForm.UpdateText();
            if (_player.equipment[(int)Item.Equip.MainHand] != null)
                tbItemStats.Text = _player.equipment[(int)Item.Equip.MainHand].tooltip;
        }

        private void btnHeadUnequip_Click(object sender, EventArgs e)
        {
            Unequip(Item.Equip.Head);
        }

        private void btnChestUnequip_Click(object sender, EventArgs e)
        {
            Unequip(Item.Equip.Chest);
        }

        private void btnWeaponUnequip_Click(object sender, EventArgs e)
        {
            Unequip(Item.Equip.MainHand);
        }

        private void Unequip(Item.Equip slot)
        {
            // Check if slot contains an item.
            if (_player.equipment[(int)slot] != null)
            {
                // Set item to the equipped item.
                Item item = _player.equipment[(int)slot];

                // Find the first empty slot in the inventory.
                for (int i = 0; i < _player.inventory.Length; i++)
                {
                    if (_player.inventory[i] == null)
                    {
                        // Unequip item and put it in inventory.
                        _player.inventory[i] = item;
                        _player.equipment[(int)slot] = null;

                        // Increase available inventory slots.
                        _player.inventorySlotsUsed++;

                        // Show item on screen.
                        _mainForm.UpdateText();
                        break;
                    }
                }
            }
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            // NullReferenceException catcher.
            if (lbInventory.SelectedItem != null)
            {
                // Check all used slots to find the selected item.
                for (int i = 0; i < _player.inventory.Length; i++)
                {
                    // Store selected item in itemEquip.
                    if (_player.inventory[i] != null && lbInventory.SelectedItem != null && _player.inventory[i] == (lbInventory.SelectedItem as Item))
                    {
                        // Remove the item from the inventory.
                        _player.inventory[i] = null;

                        // Increase available inventory slots.
                        _player.inventorySlotsUsed--;

                        // Update texts.
                        _mainForm.UpdateText();
                    }
                }
            }
        }

        public InventoryForm(Player player, MainForm mainForm)
        {
            InitializeComponent();
            _player = player;
            _mainForm = mainForm;
            inventoryItems = new Dictionary<string, int>();
        }

        private void btnSpawnArmour_Click(object sender, EventArgs e)
        {
            int itemChance = random.Next();

            if (itemChance % 2 == 0)
                _player.AddItem(Armour.Generate(1, 100));
            else
                _player.AddItem(Weapon.Generate(1, 100));

            _mainForm.UpdateText();
        }
    }
}

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
        private int healCost;

        private List<Item> general;
        private List<Armour> armour;
        private List<Weapon> weapons;

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

            for (int i = 0; i < armourAmount; i++)
            {
                armour.Add(Armour.Generate((currentPlayerLevel > 5) ? currentPlayerLevel - 5 : 1, currentPlayerLevel + 5));
            }

            for (int i = 0; i < weaponAmount; i++)
            {
                weapons.Add(Weapon.Generate((currentPlayerLevel > 5) ? currentPlayerLevel - 5 : 1, currentPlayerLevel + 5));
            }
        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            if (_player.gold >= healCost)
            {
                _player.healthCurrent = (int)_player.attributes[(int)PlayerStat.Attribute.Health].Final();
                _player.gold -= healCost;
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
                            _player.AddItem(armour[lbArmour.SelectedIndex]);
                            _player.gold -= armour[lbArmour.SelectedIndex].price;
                            armour.RemoveAt(lbArmour.SelectedIndex);
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
                            _player.AddItem(weapons[lbWeapons.SelectedIndex]);

                            // Decrease player gold.
                            _player.gold -= weapons[lbWeapons.SelectedIndex].price;

                            // Remove the item from the shop.
                            weapons.RemoveAt(lbWeapons.SelectedIndex);

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

            foreach (Armour a in armour)
            {
                lbArmour.Items.Add(a.name);
            }
            foreach (Weapon w in weapons)
            {
                lbWeapons.Items.Add(w.name);
            }

            foreach (Item i in _player.inventory)
            {
                if (i != null)
                    lbInventory.Items.Add(i.name);
            }

            healCost = ((int)_player.attributes[(int)PlayerStat.Attribute.Health].Final() - _player.healthCurrent) / 3;
            btnHeal.Text = $"Heal ({healCost}g)";

            tbGold.Text = _player.gold.ToString();
            tbInventorySpace.Text = $"{_player.inventorySlotsUsed}/{_player.inventorySlotsMax}";
        }

        private void ShowWeaponStats(Weapon weapon)
        {
            // Show weapon stats on the textbox.
            tbItemStats.Text = $"{weapon.name}\r\n---------------\r\n" +
                ((weapon.twoHanded) ? "Two-Handed " : "One-Handed ") + $"{Enum.GetName(typeof(Weapon.Type), weapon.type)}\r\n" +
                $"{weapon.speed.ToString("#.#")} speed\r\n" +
                $"{weapon.damageMin} - {weapon.damageMax} damage\r\n---------------\r\n" +
                $"Lvl: {weapon.levelRequirement}, Str: {weapon.strengthRequirement}, Int: {weapon.intelligenceRequirement}, Dex: {weapon.dexterityRequirement}\r\n---------------\r\n" +
                ((weapon.strengthBonus != 0) ? $"+{weapon.strengthBonus} to strength\r\n" : "") +
                ((weapon.intelligenceBonus != 0) ? $"+{weapon.intelligenceBonus} to intelligence\r\n" : "") +
                ((weapon.dexterityBonus != 0) ? $"+{weapon.dexterityBonus} to dexterity\r\n" : "") +
                ((weapon.physicalDamageBonus != 0) ? $"+{weapon.physicalDamageBonus * 100}% to physical damage\r\n" : "") +
                ((weapon.elementalDamageBonus != 0) ? $"+{weapon.elementalDamageBonus * 100}% to elemental damage\r\n" : "") +
                ((weapon.criticalChanceBonus != 0) ? $"+{weapon.criticalChanceBonus * 100}% to critical strike chance\r\n" : "") +
                ((weapon.criticalDamageBonus != 0) ? $"+{weapon.criticalDamageBonus * 100}% to critical strike damage\r\n" : "") +
                $"---------------\r\n" +
                $"Cost: {weapon.price}g";
        }

        private void ShowArmourStats(Armour armour)
        {
            // Show armour stats on the textbox.
            tbItemStats.Text = $"{armour.name}\r\n---------------\r\n" +
                $"{Enum.GetName(typeof(Item.Equip), armour.equipSlot)} ({Enum.GetName(typeof(Armour.Type), armour.type)})\r\n" +
                $"{armour.armourBonus} armour\r\n---------------\r\n" +
                $"Lvl: {armour.levelRequirement}, Str: {armour.strengthRequirement}, Int: {armour.intelligenceRequirement}, Dex: {armour.dexterityRequirement}\r\n---------------\r\n" +
                ((armour.strengthBonus != 0) ? $"+{armour.strengthBonus} to strength\r\n" : "") +
                ((armour.intelligenceBonus != 0) ? $"+{armour.intelligenceBonus} to intelligence\r\n" : "") +
                ((armour.dexterityBonus != 0) ? $"+{armour.dexterityBonus} to dexterity\r\n" : "") +
                ((armour.physicalDamageBonus != 0) ? $"+{armour.physicalDamageBonus * 100}% to physical damage\r\n" : "") +
                ((armour.elementalDamageBonus != 0) ? $"+{armour.elementalDamageBonus * 100}% to elemental damage\r\n" : "") +
                ((armour.healthBonus != 0) ? $"+{armour.healthBonus} health\r\n" : "") +
                ((armour.manaBonus != 0) ? $"+{armour.manaBonus} mana\r\n" : "") +
                ((armour.healthRegenerationBonus != 0) ? $"+{armour.healthRegenerationBonus} health per second\r\n" : "") +
                ((armour.manaRegenerationBonus != 0) ? $"+{armour.manaRegenerationBonus} mana per second\r\n" : "") +
                ((armour.physicalResistanceBonus != 0) ? $"+{armour.physicalResistanceBonus * 100}% to physical damage reduction\r\n" : "") +
                ((armour.elementalResistance != 0) ? $"+{armour.elementalResistance * 100}% to elemental resistance\r\n" : "") +
                $"---------------\r\n" +
                $"Cost: {armour.price}g";
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            _mainForm.UpdateText();
        }

        public ShopForm(Player player, MainForm mainForm)
        {
            InitializeComponent();
            _player = player;
            _mainForm = mainForm;

            general = new List<Item>();
            armour = new List<Armour>();
            weapons = new List<Weapon>();
        }

        private void lbArmour_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Initialise item variable.
            Armour item = null;

            // NullReferenceException catcher.
            if (lbArmour.SelectedItem != null)
            {
                // Check every used inventory slot to find the selected item.
                for (int i = 0; i < armour.Count; i++)
                {
                    // Store the selected item in item.
                    if (armour[i] != null && armour[i].name == lbArmour.SelectedItem.ToString()) item = armour[i];
                }
            }

            ShowArmourStats(item);
        }

        private void lbWeapons_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Initialise item variable.
            Weapon item = null;

            // NullReferenceException catcher.
            if (lbWeapons.SelectedItem != null)
            {
                // Check every used inventory slot to find the selected item.
                for (int i = 0; i < weapons.Count; i++)
                {
                    // Store the selected item in item.
                    if (weapons[i] != null && weapons[i].name == lbWeapons.SelectedItem.ToString()) item = weapons[i];
                }
            }

            ShowWeaponStats(item);
        }

        private void lbInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Initialise item variable.
            Item item = null;

            // NullReferenceException catcher.
            if (lbInventory.SelectedItem != null)
            {
                // Check every used inventory slot to find the selected item.
                for (int i = 0; i < _player.inventory.Length; i++)
                {
                    // Store the selected item in item.
                    if (_player.inventory[i] != null && _player.inventory[i].name == lbInventory.SelectedItem.ToString()) item = _player.inventory[i];
                }
            }

            // Show stats of selected item.
            if (item is Weapon) ShowWeaponStats((Weapon)item);
            if (item is Armour) ShowArmourStats((Armour)item);
        }
    }
}

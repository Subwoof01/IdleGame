﻿using System;
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
        private CharacterForm _characterForm;

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            UpdateText();
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
                    if (_player.inventory[i] != null && _player.inventory[i].name == lbInventory.SelectedItem.ToString())
                        itemEquip = _player.inventory[i];
                }

                // If player meets lvl/str/int/dex requirements and item is of correct equip slot, equip item.
                if (itemEquip != null && itemEquip.equipSlot.Equals(slot) && _player.level >= itemEquip.levelRequirement && _player.strengthFinal() >= itemEquip.strengthRequirement && _player.intelligenceFinal() >= itemEquip.intelligenceRequirement && _player.dexterityFinal() >= itemEquip.dexterityRequirement)
                {
                    if (_player.equipment[(int)slot] != null)
                        equipped = _player.equipment[(int)slot];

                    // Equip item.
                    _player.equipment[(int)slot] = itemEquip;

                    // Remove from inventory.
                    for (int i = 0; i < _player.inventory.Length; i++)
                    {
                        if (_player.inventory[i] != null && _player.inventory[i].name.Equals(lbInventory.SelectedItem.ToString()))
                            _player.inventory[i] = null;
                    }
                    lbInventory.Items.RemoveAt(lbInventory.SelectedIndex);

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
                                UpdateText();

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
                        $"Strength:\t {_player.strengthFinal()} - {itemEquip.strengthRequirement} \n" +
                        $"Intelligence:\t {_player.intelligenceFinal()} - {itemEquip.intelligenceRequirement} \n" +
                        $"Dexterity:\t {_player.dexterityFinal()} - {itemEquip.dexterityRequirement}", " Not Yet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            UpdateText();
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

        private void UpdateText()
        {
            lbInventory.Items.Clear();

            for (int i = 0; i < _player.inventory.Length; i++)
            {
                if (_player.inventory[i] != null) lbInventory.Items.Add(_player.inventory[i].name);
            }

            tbGold.Text = _player.gold.ToString();
            tbInventorySpace.Text = $"{_player.inventorySlotsUsed}/{_player.inventorySlotsMax}";

            if (_player.equipment[(int)Item.Equip.Head] != null) tbHeadEquipped.Text = _player.equipment[(int)Item.Equip.Head].name;
            else tbHeadEquipped.Text = "<Empty>";
            if (_player.equipment[(int)Item.Equip.Chest] != null) tbChestEquipped.Text = _player.equipment[(int)Item.Equip.Chest].name;
            else tbChestEquipped.Text = "<Empty>";
            if (_player.equipment[(int)Item.Equip.MainHand] != null) tbMainHandEquipped.Text = _player.equipment[(int)Item.Equip.MainHand].name;
            else tbMainHandEquipped.Text = "<Empty>";

            if (_characterForm != null) _characterForm.UpdateStats();
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
                ((weapon.criticalDamageBonus != 0) ? $"+{weapon.criticalDamageBonus * 100}% to critical strike damage" : "");
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
                ((armour.elementalResistance != 0) ? $"+{armour.elementalResistance * 100}% to elemental resistance" : "");
        }

        private void btnHeadShow_Click(object sender, EventArgs e)
        {
            UpdateText();
            if (_player.equipment[(int)Item.Equip.Head] != null) ShowArmourStats((Armour)_player.equipment[(int)Item.Equip.Head]);
        }

        private void btnChestShow_Click(object sender, EventArgs e)
        {
            UpdateText();
            if (_player.equipment[(int)Item.Equip.Chest] != null) ShowArmourStats((Armour)_player.equipment[(int)Item.Equip.Chest]);
        }

        private void btnWeaponShow_Click(object sender, EventArgs e)
        {
            UpdateText();
            if (_player.equipment[(int)Item.Equip.MainHand] != null) ShowWeaponStats((Weapon)_player.equipment[(int)Item.Equip.MainHand]);
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
                        UpdateText();
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
                    if (_player.inventory[i] != null && lbInventory.SelectedItem != null && _player.inventory[i].name == lbInventory.SelectedItem.ToString())
                    {
                        // Remove the item from the inventory.
                        _player.inventory[i] = null;

                        // Increase available inventory slots.
                        _player.inventorySlotsUsed--;

                        // Update texts.
                        UpdateText();
                    }
                }
            }
        }

        public InventoryForm(Player player, CharacterForm characterForm)
        {
            InitializeComponent();
            _player = player;
            _characterForm = characterForm;
        }

        private void btnSpawnArmour_Click(object sender, EventArgs e)
        {
            _player.AddItem(Weapon.Generate(1, 90));
            UpdateText();
        }
    }
}

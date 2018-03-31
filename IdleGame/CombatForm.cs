using IdleGame.Attributes;
using IdleGame.Enemies;
using IdleGame.Enemies.Types;
using IdleGame.Skills;
using IdleGame.States;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static IdleGame.Item;

namespace IdleGame
{
    public partial class CombatForm : Form
    {
        private enum Action { ActionSlot1, ActionSlot2, ActionSlot3, ActionSlot4, ActionSlot5, ActionSlot6, ActionSlot7, ActionSlot8, ActionSlot9, WeaponAttack };

        private Player _player;
        private Enemy _enemy;
        private MainForm _mainForm;
        private PictureBox[] _actionSlots;
        private ToolTip[] _actionSlotTooltips;

        private int _playerAttackSpeed;
        private int _playerAttackProgress;
        private string _playerCurrentActionText;
        private Action _playerCurrentAction;

        private int _enemyAttackSpeed;
        private int _enemyAttackProgress;
        private string _enemyCurrentActionText;

        private int _time;

        private void UpdateFrame()
        {
            // Player updates.
            actionSpeedBar.Maximum = _playerAttackSpeed;
            healthBar.Maximum = (int)_player.attributes[(int)PlayerStat.Attribute.Health].Final();
            healthBar.Value = _player.healthCurrent;
            manaBar.Maximum = (int)_player.attributes[(int)PlayerStat.Attribute.Mana].Final();
            manaBar.Value = _player.manaCurrent;
            actionSpeedBar.Value = _playerAttackProgress;
            tbCurrentAction.Text = _playerCurrentActionText;

            // Action Bar.
            for (int i = 0; i < _actionSlots.Length; i++)
            {
                if (_player.actionBar[i] != null)
                {
                    if (_player.actionBar[i].onCooldown)
                        _actionSlots[i].Image = _player.actionBar[i].cooldownImage;
                    else
                        _actionSlots[i].Image = _player.actionBar[i].image;

                    if (!_actionSlotTooltips[i].ToolTipTitle.Equals(_player.actionBar[i].name))
                        _actionSlotTooltips[i].ToolTipTitle = _player.actionBar[i].name;

                    if (!_actionSlotTooltips[i].GetToolTip(_actionSlots[i]).Equals(_player.actionBar[i].ToolTip()))
                        _actionSlotTooltips[i].SetToolTip(_actionSlots[i], _player.actionBar[i].ToolTip());
                }
            }

            // Enemy updates.
            lblEnemyName.Text = $"(Lv{_enemy.level}) {_enemy.name}";
            lblEnemyType.Text = Enum.GetName(typeof(Enemy.Type), _enemy.type);
            actionSpeedBarEnemy.Maximum = _enemyAttackSpeed;
            healthBarEnemy.Maximum = _enemy.healthBase;
            healthBarEnemy.Value = _enemy.healthCurrent;
            manaBarEnemy.Maximum = _enemy.manaBase;
            manaBarEnemy.Value = _enemy.manaCurrent;
            actionSpeedBarEnemy.Value = _enemyAttackProgress;
            tbCurrentActionEnemy.Text = _enemyCurrentActionText;

            // State updates.
            if (_time % 500 == 0)
            {
                tlpPlayerStates.Controls.Clear();
                tlpEnemyStates.Controls.Clear();

                if (_player.states.Count > 0)
                {
                    for (int i = 0; i < _player.states.Count; i++)
                    {
                        PictureBox state = new PictureBox();
                        state.Image = _player.states[i].image;
                        state.SizeMode = PictureBoxSizeMode.StretchImage;
                        state.Size = new Size(20, 20);
                        tlpPlayerStates.Controls.Add(state);
                    }
                }

                if (_enemy.states.Count > 0)
                {
                    for (int i = 0; i < _enemy.states.Count; i++)
                    {
                        PictureBox state = new PictureBox();
                        state.Image = _enemy.states[i].image;
                        state.SizeMode = PictureBoxSizeMode.StretchImage;
                        state.Size = new Size(20, 20);
                        tlpEnemyStates.Controls.Add(state);
                    }
                }
            }

            // Combatlog updates.
            lbCombatLog.TopIndex = lbCombatLog.Items.Count - 1;
        }

        private void SetAttackSpeed()
        {
            Weapon mainHand = null;

            if (_player.equipment[(int)Item.Equip.MainHand] is Weapon)
                mainHand = (Weapon)_player.equipment[(int)Item.Equip.MainHand];

            if (mainHand != null)
            {
                _playerAttackSpeed = (int)(mainHand.speed * 1000);
            }
            else
            {
                _playerAttackSpeed = 3000;
            }

            if (_enemy.attackSpeed != 0)
            {
                _enemyAttackSpeed = (int)(_enemy.attackSpeed * 1000);
            }

            UpdateFrame();
        }

        private void timerAction_Tick(object sender, EventArgs e)
        {
            _playerAttackProgress += timerAction.Interval;
            _enemyAttackProgress += timerAction.Interval;
            _time += timerAction.Interval;

            for (int i = 0; i < _player.actionBar.Length; i++)
            {
                if (_player.actionBar[i] != null)
                {
                    if (_time > (_player.actionBar[i].timeCasted + (_player.actionBar[i].cooldown * 1000)))
                        _player.actionBar[i].onCooldown = false; ;
                }
            }

            double lastDamage;
            if (_playerAttackProgress >= _playerAttackSpeed)
            {
                if (_playerCurrentAction.Equals(Action.WeaponAttack))
                {
                    Weapon weapon = (Weapon)_player.equipment[(int)Item.Equip.MainHand];

                    if (weapon != null)
                    {
                        _playerCurrentActionText = weapon.name;
                        _playerAttackSpeed = (int)(weapon.speed * 1000);
                    }
                    else
                    {
                        _playerCurrentActionText = "Unarmed Strike";
                        _playerAttackSpeed = 1500;
                    }

                    lastDamage = _player.WeaponAttack(_enemy);
                    
                    lbCombatLog.Items.Add($"{((weapon != null) ? weapon.name : _player.name)} hits {_enemy.name} for {lastDamage.ToString("0")} Physical.");
                }
                else if (_player.actionBar[(int)_playerCurrentAction] != null && !_player.actionBar[(int)_playerCurrentAction].onCooldown)
                {
                    _player.actionBar[(int)_playerCurrentAction].onCooldown = true;
                    _player.manaCurrent -= _player.actionBar[(int)_playerCurrentAction].manaCost;
                    lastDamage = _player.actionBar[(int)_playerCurrentAction].Effect(_enemy, _time);
                    lbCombatLog.Items.Add($"{_player.actionBar[(int)_playerCurrentAction].name} hits {_enemy.name} for {lastDamage.ToString("0")} {Enum.GetName(typeof(Skill.DamageType), _player.actionBar[(int)_playerCurrentAction].damageType)}.");
                    _playerCurrentAction = Action.WeaponAttack;

                    Weapon weapon = (Weapon)_player.equipment[(int)Item.Equip.MainHand];

                    if (weapon != null)
                    {
                        _playerCurrentActionText = weapon.name;
                        _playerAttackSpeed = (int)(weapon.speed * 1000);
                    }
                    else
                    {
                        _playerCurrentActionText = "Unarmed Strike";
                        _playerAttackSpeed = 1500;
                    }
                }
                else
                {
                    _playerCurrentAction = Action.WeaponAttack;
                }

                _playerAttackProgress = 0;
            }

            //if (_playerAttackProgress >= _playerAttackSpeed)
            //{
            //    double lastDamage;

            //    #region Action Effects (Player)
            //    switch (_playerCurrentAction)
            //    {
            //        case Action.ActionSlot1:
            //            if (_player.actionBar[(int)Action.ActionSlot1] != null && !_player.actionBar[(int)Action.ActionSlot1].onCooldown)
            //            {
            //                _player.actionBar[(int)Action.ActionSlot1].onCooldown = true;
            //                lastDamage = _player.actionBar[(int)Action.ActionSlot1].Effect(_enemy, _time);
            //                lbCombatLog.Items.Add($"{_player.actionBar[(int)Action.ActionSlot1].name} hits {_enemy.name} for {lastDamage.ToString("0")} {Enum.GetName(typeof(Skill.DamageType), _player.actionBar[(int)Action.ActionSlot1].damageType)}.");
            //                _playerCurrentAction = Action.WeaponAttack;
            //            }
            //            break;
            //        case Action.ActionSlot2:
            //            if (_player.actionBar[(int)Action.ActionSlot2] != null && !_player.actionBar[(int)Action.ActionSlot2].onCooldown)
            //            {
            //                _player.actionBar[(int)Action.ActionSlot2].onCooldown = true;
            //                lastDamage = _player.actionBar[(int)Action.ActionSlot2].Effect(_enemy, _time);
            //                lbCombatLog.Items.Add($"{_player.actionBar[(int)Action.ActionSlot2].name} hits {_enemy.name} for {lastDamage.ToString("0")} {Enum.GetName(typeof(Skill.DamageType), _player.actionBar[(int)Action.ActionSlot2].damageType)}.");
            //            }
            //            break;
            //        case Action.ActionSlot3:
            //            if (_player.actionBar[(int)Action.ActionSlot3] != null && !_player.actionBar[(int)Action.ActionSlot3].onCooldown)
            //            {
            //                _player.actionBar[(int)Action.ActionSlot3].onCooldown = true;
            //                lastDamage = _player.actionBar[(int)Action.ActionSlot3].Effect(_enemy, _time);
            //                lbCombatLog.Items.Add($"{_player.actionBar[(int)Action.ActionSlot3].name} hits {_enemy.name} for {lastDamage.ToString("0")} {Enum.GetName(typeof(Skill.DamageType), _player.actionBar[(int)Action.ActionSlot3].damageType)}.");
            //                _playerCurrentAction = Action.WeaponAttack;
            //            }
            //            break;
            //        case Action.ActionSlot4:
            //            if (_player.actionBar[(int)Action.ActionSlot4] != null && !_player.actionBar[(int)Action.ActionSlot4].onCooldown)
            //            {
            //                _player.actionBar[(int)Action.ActionSlot4].onCooldown = true;
            //                lastDamage = _player.actionBar[(int)Action.ActionSlot4].Effect(_enemy, _time);
            //                lbCombatLog.Items.Add($"{_player.actionBar[(int)Action.ActionSlot4].name} hits {_enemy.name} for {lastDamage.ToString("0")} {Enum.GetName(typeof(Skill.DamageType), _player.actionBar[(int)Action.ActionSlot4].damageType)}.");
            //                _playerCurrentAction = Action.WeaponAttack;
            //            }
            //            break;
            //        case Action.ActionSlot5:
            //            if (_player.actionBar[(int)Action.ActionSlot5] != null && !_player.actionBar[(int)Action.ActionSlot5].onCooldown)
            //            {
            //                _player.actionBar[(int)Action.ActionSlot5].onCooldown = true;
            //                lastDamage = _player.actionBar[(int)Action.ActionSlot5].Effect(_enemy, _time);
            //                lbCombatLog.Items.Add($"{_player.actionBar[(int)Action.ActionSlot5].name} hits {_enemy.name} for {lastDamage.ToString("0")} {Enum.GetName(typeof(Skill.DamageType), _player.actionBar[(int)Action.ActionSlot5].damageType)}.");
            //                _playerCurrentAction = Action.WeaponAttack;
            //            }
            //            break;
            //        case Action.ActionSlot6:
            //            if (_player.actionBar[(int)Action.ActionSlot6] != null && !_player.actionBar[(int)Action.ActionSlot6].onCooldown)
            //            {
            //                _player.actionBar[(int)Action.ActionSlot6].onCooldown = true;
            //                lastDamage = _player.actionBar[(int)Action.ActionSlot6].Effect(_enemy, _time);
            //                lbCombatLog.Items.Add($"{_player.actionBar[(int)Action.ActionSlot6].name} hits {_enemy.name} for {lastDamage.ToString("0")} {Enum.GetName(typeof(Skill.DamageType), _player.actionBar[(int)Action.ActionSlot6].damageType)}.");
            //                _playerCurrentAction = Action.WeaponAttack;
            //            }
            //            break;
            //        case Action.ActionSlot7:
            //            if (_player.actionBar[(int)Action.ActionSlot7] != null && !_player.actionBar[(int)Action.ActionSlot7].onCooldown)
            //            {
            //                _player.actionBar[(int)Action.ActionSlot7].onCooldown = true;
            //                lastDamage = _player.actionBar[(int)Action.ActionSlot7].Effect(_enemy, _time);
            //                lbCombatLog.Items.Add($"{_player.actionBar[(int)Action.ActionSlot7].name} hits {_enemy.name} for {lastDamage.ToString("0")} {Enum.GetName(typeof(Skill.DamageType), _player.actionBar[(int)Action.ActionSlot7].damageType)}.");
            //                _playerCurrentAction = Action.WeaponAttack;
            //            }
            //            break;
            //        case Action.ActionSlot8:
            //            if (_player.actionBar[(int)Action.ActionSlot8] != null && !_player.actionBar[(int)Action.ActionSlot8].onCooldown)
            //            {
            //                _player.actionBar[(int)Action.ActionSlot8].onCooldown = true;
            //                lastDamage = _player.actionBar[(int)Action.ActionSlot8].Effect(_enemy, _time);
            //                lbCombatLog.Items.Add($"{_player.actionBar[(int)Action.ActionSlot8].name} hits {_enemy.name} for {lastDamage.ToString("0")} {Enum.GetName(typeof(Skill.DamageType), _player.actionBar[(int)Action.ActionSlot8].damageType)}.");
            //                _playerCurrentAction = Action.WeaponAttack;
            //            }
            //            break;
            //        case Action.ActionSlot9:
            //            if (_player.actionBar[(int)Action.ActionSlot9] != null && !_player.actionBar[(int)Action.ActionSlot9].onCooldown)
            //            {
            //                _player.actionBar[(int)Action.ActionSlot9].onCooldown = true;
            //                lastDamage = _player.actionBar[(int)Action.ActionSlot9].Effect(_enemy, _time);
            //                lbCombatLog.Items.Add($"{_player.actionBar[(int)Action.ActionSlot9].name} hits {_enemy.name} for {lastDamage.ToString("0")} {Enum.GetName(typeof(Skill.DamageType), _player.actionBar[(int)Action.ActionSlot9].damageType)}.");
            //                _playerCurrentAction = Action.WeaponAttack;
            //            }
            //            break;
            //        case Action.WeaponAttack:
            //            lastDamage = _player.WeaponAttack(_enemy);
            //            if (_player.equipment[(int)Equip.MainHand] != null)
            //            {
            //                Weapon weapon = (Weapon)_player.equipment[(int)Equip.MainHand];
            //                lbCombatLog.Items.Add($"{weapon.name} hits {_enemy.name} for {lastDamage.ToString("0")} Physical.");
            //            }
            //            break;

            //    }
            //    _playerAttackProgress = 0;
            //}

            if (_enemyAttackProgress >= _enemyAttackSpeed)
            {
                string lastAction;

                lastAction = _enemy.Action(_player);

                lbCombatLog.Items.Add(lastAction);

                _enemyAttackProgress = 0;
            }

            #region State management.
            if (_player.states.Count > 0)
            {
                for (int i = _player.states.Count - 1; i >= 0; i--)
                {
                    if (_player.states[i].startTime + _player.states[i].duration < _time)
                    {
                        _player.states.Remove(_player.states[i]);
                    }
                    else if (_time > _player.states[i].lastTime + _player.states[i].tickSpeed)
                    {
                        _player.states[i].lastTime = _time;
                        lastDamage = _player.states[i].Effect();
                        lbCombatLog.Items.Add(_player.states[i].flavourText);
                    }
                }
            }

            if (_enemy.states.Count > 0)
            {
                for (int i = _enemy.states.Count - 1; i >= 0; i--)
                {
                    if (_enemy.states[i].startTime + _enemy.states[i].duration < _time)
                    {
                        _enemy.states.Remove(_enemy.states[i]);
                    }
                    else if (_time > _enemy.states[i].lastTime + _enemy.states[i].tickSpeed || (_enemy.states[i].duration - 1 == _enemy.states[i].tickSpeed && !_enemy.states[i].firstApplied))
                    {
                        _enemy.states[i].lastTime = _time;
                        lastDamage = _enemy.states[i].Effect();
                        lbCombatLog.Items.Add(_enemy.states[i].flavourText);
                    }
                }
            }
            #endregion

            #region Health and Mana regeneration.
            if (_time % 1000 == 0)
            {
                if (_player.healthCurrent + (int)_player.attributes[(int)PlayerStat.Attribute.HealthRegeneration].Final() > _player.attributes[(int)PlayerStat.Attribute.Health].Final())
                    _player.healthCurrent = (int)_player.attributes[(int)PlayerStat.Attribute.Health].Final();
                else
                    _player.healthCurrent += (int)_player.attributes[(int)PlayerStat.Attribute.HealthRegeneration].Final();

                if (_player.manaCurrent + (int)_player.attributes[(int)PlayerStat.Attribute.ManaRegeneration].Final() > (int)_player.attributes[(int)PlayerStat.Attribute.Mana].Final())
                    _player.manaCurrent = (int)_player.attributes[(int)PlayerStat.Attribute.Mana].Final();
                else
                    _player.manaCurrent += (int)_player.attributes[(int)PlayerStat.Attribute.ManaRegeneration].Final();

                if (_enemy.healthCurrent + _enemy.healthRegenerationBase > _enemy.healthBase)
                    _enemy.healthCurrent = _enemy.healthBase;
                else
                    _enemy.healthCurrent += (int)_enemy.healthRegenerationBase;

                if (_enemy.manaCurrent + _enemy.manaRegenerationBase > _enemy.manaBase)
                    _enemy.manaCurrent = _enemy.manaBase;
                else
                    _enemy.manaCurrent += (int)_enemy.manaRegenerationBase;
            }
            #endregion

            if (_enemy.healthCurrent <= 0)
            {
                if (_enemy.healthCurrent < 0)
                    _enemy.healthCurrent = 0;
                UpdateFrame();
                timerAction.Stop();
                _enemy.Die(_player, this, _mainForm);
            }
            if (_player.healthCurrent <= 0)
            {
                if (_player.healthCurrent < 0)
                    _player.healthCurrent = 0;
                UpdateFrame();
                timerAction.Stop();
                _player.Die(this, _mainForm);
            }

            UpdateFrame();
        }

        #region Action selection.
        private void btnWeaponAttack_Click(object sender, EventArgs e)
        {
            Weapon weapon = (Weapon)_player.equipment[(int)Item.Equip.MainHand];
            if (weapon != null)
            {
                _playerCurrentActionText = weapon.name;
                _playerAttackSpeed = (int)(weapon.speed * 1000);
            }
            else
            {
                _playerCurrentActionText = "Unarmed Strike";
                _playerAttackSpeed = 1500;
            }
            _playerCurrentAction = Action.WeaponAttack;
        }

        private void pbActionBarSlot1_Click(object sender, EventArgs e)
        {
            if (_player.actionBar[(int)Action.ActionSlot1] != null && !_player.actionBar[(int)Action.ActionSlot1].onCooldown && _player.manaCurrent >= _player.actionBar[(int)Action.ActionSlot1].manaCost)
            {
                _playerCurrentActionText = _player.actionBar[(int)Action.ActionSlot1].name;
                _playerAttackProgress = 0;
                _playerAttackSpeed = (int)(_player.actionBar[(int)Action.ActionSlot1].castTime * 1000);
                _playerCurrentAction = Action.ActionSlot1;
            }
        }

        private void pbActionBarSlot2_Click(object sender, EventArgs e)
        {
            if (_player.actionBar[(int)Action.ActionSlot2] != null && !_player.actionBar[(int)Action.ActionSlot2].onCooldown && _player.manaCurrent >= _player.actionBar[(int)Action.ActionSlot2].manaCost)
            {
                _playerCurrentActionText = _player.actionBar[(int)Action.ActionSlot2].name;
                _playerAttackProgress = 0;
                _playerAttackSpeed = (int)(_player.actionBar[(int)Action.ActionSlot2].castTime * 1000);
                _playerCurrentAction = Action.ActionSlot2;
            }
        }

        private void pbActionBarSlot3_Click(object sender, EventArgs e)
        {
            if (_player.actionBar[(int)Action.ActionSlot3] != null && !_player.actionBar[(int)Action.ActionSlot3].onCooldown && _player.manaCurrent >= _player.actionBar[(int)Action.ActionSlot3].manaCost)
            {
                _playerCurrentActionText = _player.actionBar[(int)Action.ActionSlot3].name;
                _playerAttackProgress = 0;
                _playerAttackSpeed = (int)(_player.actionBar[(int)Action.ActionSlot3].castTime * 1000);
                _playerCurrentAction = Action.ActionSlot3;
            }
        }

        private void pbActionBarSlot4_Click(object sender, EventArgs e)
        {
            if (_player.actionBar[(int)Action.ActionSlot4] != null && !_player.actionBar[(int)Action.ActionSlot4].onCooldown && _player.manaCurrent >= _player.actionBar[(int)Action.ActionSlot4].manaCost)
            {
                _playerCurrentActionText = _player.actionBar[(int)Action.ActionSlot4].name;
                _playerAttackProgress = 0;
                _playerAttackSpeed = (int)(_player.actionBar[(int)Action.ActionSlot4].castTime * 1000);
                _playerCurrentAction = Action.ActionSlot4;
            }
        }

        private void pbActionBarSlot5_Click(object sender, EventArgs e)
        {
            if (_player.actionBar[(int)Action.ActionSlot5] != null && !_player.actionBar[(int)Action.ActionSlot5].onCooldown && _player.manaCurrent >= _player.actionBar[(int)Action.ActionSlot5].manaCost)
            {
                _playerCurrentActionText = _player.actionBar[(int)Action.ActionSlot5].name;
                _playerAttackProgress = 0;
                _playerAttackSpeed = (int)(_player.actionBar[(int)Action.ActionSlot5].castTime * 1000);
                _playerCurrentAction = Action.ActionSlot5;
            }
        }

        private void pbActionBarSlot6_Click(object sender, EventArgs e)
        {
            if (_player.actionBar[(int)Action.ActionSlot6] != null && !_player.actionBar[(int)Action.ActionSlot6].onCooldown && _player.manaCurrent >= _player.actionBar[(int)Action.ActionSlot6].manaCost)
            {
                _playerCurrentActionText = _player.actionBar[(int)Action.ActionSlot6].name;
                _playerAttackProgress = 0;
                _playerAttackSpeed = (int)(_player.actionBar[(int)Action.ActionSlot6].castTime * 1000);
                _playerCurrentAction = Action.ActionSlot6;
            }
        }

        private void pbActionBarSlot7_Click(object sender, EventArgs e)
        {
            if (_player.actionBar[(int)Action.ActionSlot7] != null && !_player.actionBar[(int)Action.ActionSlot7].onCooldown && _player.manaCurrent >= _player.actionBar[(int)Action.ActionSlot7].manaCost)
            {
                _playerCurrentActionText = _player.actionBar[(int)Action.ActionSlot7].name;
                _playerAttackProgress = 0;
                _playerAttackSpeed = (int)(_player.actionBar[(int)Action.ActionSlot7].castTime * 1000);
                _playerCurrentAction = Action.ActionSlot7;
            }
        }

        private void pbActionBarSlot8_Click(object sender, EventArgs e)
        {
            if (_player.actionBar[(int)Action.ActionSlot8] != null && !_player.actionBar[(int)Action.ActionSlot8].onCooldown && _player.manaCurrent >= _player.actionBar[(int)Action.ActionSlot8].manaCost)
            {
                _playerCurrentActionText = _player.actionBar[(int)Action.ActionSlot8].name;
                _playerAttackProgress = 0;
                _playerAttackSpeed = (int)(_player.actionBar[(int)Action.ActionSlot8].castTime * 1000);
                _playerCurrentAction = Action.ActionSlot8;
            }
        }

        private void pbActionBarSlot9_Click(object sender, EventArgs e)
        {
            if (_player.actionBar[(int)Action.ActionSlot9] != null && !_player.actionBar[(int)Action.ActionSlot9].onCooldown && _player.manaCurrent >= _player.actionBar[(int)Action.ActionSlot9].manaCost)
            {
                _playerCurrentActionText = _player.actionBar[(int)Action.ActionSlot9].name;
                _playerAttackProgress = 0;
                _playerAttackSpeed = (int)(_player.actionBar[(int)Action.ActionSlot9].castTime * 1000);
                _playerCurrentAction = Action.ActionSlot9;
            }
        }
        #endregion

        private Enemy SpawnEnemy(TravelForm.Selection type)
        {
            Random random = new Random();

            int choose;

            switch (type)
            {
                case TravelForm.Selection.Forest:
                    choose = random.Next(11);
                    if (choose == 0)
                        return Humanoid.Generate((_player.level + 5 > 10) ? 5 : _player.level);
                    else
                        return Beast.Generate((_player.level + 5 > 10) ? 5 : _player.level);

                case TravelForm.Selection.Cave:
                    choose = random.Next(11);
                    if (choose == 0)
                        return Humanoid.Generate((_player.level + 5 > 20) ? 15 : (_player.level - 5 < 10) ? 15 : _player.level);
                    else
                        return Goblinoid.Generate((_player.level + 5 > 20) ? 15 : (_player.level - 5 < 10) ? 15 : _player.level);

                case TravelForm.Selection.Ethereal:
                    return Ethereal.Generate((_player.level + 5 > 90) ? 85 : (_player.level - 5 < 70) ? 75 : _player.level);

                case TravelForm.Selection.Graveyard:
                    choose = random.Next(11);
                    if (choose == 0)
                        return Humanoid.Generate((_player.level + 5 > 40) ? 35 : (_player.level - 5 < 20) ? 25 : _player.level);
                    else
                        return Undead.Generate((_player.level + 5 > 40) ? 35 : (_player.level - 5 < 20) ? 25 : _player.level);

                case TravelForm.Selection.Mountains:
                    choose = random.Next(21);
                    if (choose == 0)
                        return Humanoid.Generate((_player.level + 5 > 55) ? 50 : (_player.level - 5 < 40) ? 45 : _player.level);
                    else if (choose > 0 && choose < 15)
                        return Giant.Generate((_player.level + 5 > 55) ? 50 : (_player.level - 5 < 40) ? 45 : _player.level);
                    else
                        return Dragonkin.Generate((_player.level + 5 > 55) ? 50 : (_player.level - 5 < 40) ? 45 : _player.level);

                case TravelForm.Selection.Ruins:
                    choose = random.Next(11);
                    if (choose == 0)
                        return Humanoid.Generate((_player.level + 5 > 70) ? 65 : (_player.level - 5 < 55) ? 60 : _player.level);
                    else
                        return Mechanical.Generate((_player.level + 5 > 70) ? 65 : (_player.level - 5 < 55) ? 60 : _player.level);

                case TravelForm.Selection.Underworld:
                    return Demon.Generate((_player.level - 5 < 90) ? 95 : _player.level);
            }
            return null;
        }

        public CombatForm(Player player, MainForm mainForm, TravelForm.Selection type)
        {
            InitializeComponent();
            _player = player;
            _enemy = SpawnEnemy(type);
            _mainForm = mainForm;

            _playerAttackProgress = 0;
            _enemyAttackProgress = 0;

            lblName.Text = _player.name;
            lblClass.Text = Enum.GetName(typeof(Player.Class), _player.playerClass);

            _playerCurrentActionText = "Weapon Attack";
            _enemyCurrentActionText = "Weapon Attack";

            _actionSlots = new PictureBox[] { pbActionBarSlot1, pbActionBarSlot2, pbActionBarSlot3, pbActionBarSlot4, pbActionBarSlot5, pbActionBarSlot6, pbActionBarSlot7, pbActionBarSlot8, pbActionBarSlot9 };
            _actionSlotTooltips = new ToolTip[] { ttActionSlot1, ttActionSlot2, ttActionSlot3, ttActionSlot4, ttActionSlot5, ttActionSlot6, ttActionSlot7, ttActionSlot8, ttActionSlot9 };

            _time = 0;

            SetAttackSpeed();
        }
    }
}

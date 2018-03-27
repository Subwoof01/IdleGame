using IdleGame.Attributes;
using IdleGame.Skills;
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
        private PictureBox[] _actionSlots;
        private ToolTip[] _actionSlotTooltips;

        private int _playerAttackSpeed;
        private int _playerAttackProgress;
        private string _playerCurrentActionText;
        private Action _playerCurrentAction;

        private int _enemyAttackSpeed;
        private int _enemyAttackProgress;
        private string _enemyCurrentActionText;

        private void UpdateFrame()
        {
            // Player updates.
            actionSpeedBar.Maximum = _playerAttackSpeed;
            healthBar.Maximum = (int)_player.attributes[(int)PlayerStat.Attribute.Health].Final();
            healthBar.Value = _player.healthCurrent;
            lblHealth.Text = $"{_player.healthCurrent}/{_player.attributes[(int)PlayerStat.Attribute.Health].Final()}";
            manaBar.Maximum = (int)_player.attributes[(int)PlayerStat.Attribute.Mana].Final();
            manaBar.Value = _player.manaCurrent;
            lblMana.Text = $"{_player.manaCurrent}/{_player.attributes[(int)PlayerStat.Attribute.Mana].Final()}";
            actionSpeedBar.Value = _playerAttackProgress;
            tbCurrentAction.Text = _playerCurrentActionText;

            // Action Bar.
            for (int i = 0; i < _actionSlots.Length; i++)
            {
                if (_player.actionBar[i] != null)
                {
                    if (_actionSlots[i].Image != _player.actionBar[i].image)
                        _actionSlots[i].Image = _player.actionBar[i].image;
                    if (!_actionSlotTooltips[i].ToolTipTitle.Equals(_player.actionBar[i].name))
                        _actionSlotTooltips[i].ToolTipTitle = _player.actionBar[i].name;
                    if (!_actionSlotTooltips[i].GetToolTip(_actionSlots[i]).Equals(_player.actionBar[i].ToolTip()))
                        _actionSlotTooltips[i].SetToolTip(_actionSlots[i], _player.actionBar[i].ToolTip());
                }
            }

            // Enemy updates.
            lblEnemyName.Text = _enemy.name;
            lblEnemyType.Text = Enum.GetName(typeof(Enemy.Type), _enemy.type);
            actionSpeedBarEnemy.Maximum = _enemyAttackSpeed;
            healthBarEnemy.Maximum = _enemy.healthBase;
            healthBarEnemy.Value = _enemy.healthCurrent;
            lblHealthEnemy.Text = $"{_enemy.healthCurrent}/{_enemy.healthBase}";
            manaBarEnemy.Maximum = _enemy.manaBase;
            manaBarEnemy.Value = _enemy.manaCurrent;
            lblManaEnemy.Text = $"{_enemy.manaCurrent}/{_enemy.manaBase}";
            actionSpeedBarEnemy.Value = _enemyAttackProgress;
            tbCurrentActionEnemy.Text = _enemyCurrentActionText;

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

            if (_playerAttackProgress >= _playerAttackSpeed)
            {
                double lastDamage;

                #region Action Effects (Player)
                switch (_playerCurrentAction)
                {
                    case Action.ActionSlot1:
                        if (_player.actionBar[(int)Action.ActionSlot1] != null)
                        {
                            lastDamage = _player.actionBar[(int)Action.ActionSlot1].Effect(_enemy);
                            lbCombatLog.Items.Add($"{_player.actionBar[(int)Action.ActionSlot1].name} hits {_enemy.name} for {lastDamage.ToString("0")} {Enum.GetName(typeof(Skill.DamageType), _player.actionBar[(int)Action.ActionSlot1].damageType)}.");
                        }
                        break;
                    case Action.ActionSlot2:
                        if(_player.actionBar[(int)Action.ActionSlot2] != null)
                        {
                            lastDamage = _player.actionBar[(int)Action.ActionSlot2].Effect(_enemy);
                            lbCombatLog.Items.Add($"{_player.actionBar[(int)Action.ActionSlot2].name} hits {_enemy.name} for {lastDamage.ToString("0")} {Enum.GetName(typeof(Skill.DamageType), _player.actionBar[(int)Action.ActionSlot2].damageType)}.");
                        }
                        break;
                    case Action.ActionSlot3:
                        if (_player.actionBar[(int)Action.ActionSlot3] != null)
                        {
                            lastDamage = _player.actionBar[(int)Action.ActionSlot3].Effect(_enemy);
                            lbCombatLog.Items.Add($"{_player.actionBar[(int)Action.ActionSlot3].name} hits {_enemy.name} for {lastDamage.ToString("0")} {Enum.GetName(typeof(Skill.DamageType), _player.actionBar[(int)Action.ActionSlot3].damageType)}.");
                        }
                        break;
                    case Action.ActionSlot4:
                        if (_player.actionBar[(int)Action.ActionSlot4] != null)
                        {
                            lastDamage = _player.actionBar[(int)Action.ActionSlot4].Effect(_enemy);
                            lbCombatLog.Items.Add($"{_player.actionBar[(int)Action.ActionSlot4].name} hits {_enemy.name} for {lastDamage.ToString("0")} {Enum.GetName(typeof(Skill.DamageType), _player.actionBar[(int)Action.ActionSlot4].damageType)}.");
                        }
                        break;
                    case Action.ActionSlot5:
                        if (_player.actionBar[(int)Action.ActionSlot5] != null)
                        {
                            lastDamage = _player.actionBar[(int)Action.ActionSlot5].Effect(_enemy);
                            lbCombatLog.Items.Add($"{_player.actionBar[(int)Action.ActionSlot5].name} hits {_enemy.name} for {lastDamage.ToString("0")} {Enum.GetName(typeof(Skill.DamageType), _player.actionBar[(int)Action.ActionSlot5].damageType)}.");
                        }
                        break;
                    case Action.ActionSlot6:
                        if (_player.actionBar[(int)Action.ActionSlot6] != null)
                        {
                            lastDamage = _player.actionBar[(int)Action.ActionSlot6].Effect(_enemy);
                            lbCombatLog.Items.Add($"{_player.actionBar[(int)Action.ActionSlot6].name} hits {_enemy.name} for {lastDamage.ToString("0")} {Enum.GetName(typeof(Skill.DamageType), _player.actionBar[(int)Action.ActionSlot6].damageType)}.");
                        }
                        break;
                    case Action.ActionSlot7:
                        if (_player.actionBar[(int)Action.ActionSlot7] != null)
                        {
                            lastDamage = _player.actionBar[(int)Action.ActionSlot7].Effect(_enemy);
                            lbCombatLog.Items.Add($"{_player.actionBar[(int)Action.ActionSlot7].name} hits {_enemy.name} for {lastDamage.ToString("0")} {Enum.GetName(typeof(Skill.DamageType), _player.actionBar[(int)Action.ActionSlot7].damageType)}.");
                        }
                        break;
                    case Action.ActionSlot8:
                        if (_player.actionBar[(int)Action.ActionSlot8] != null)
                        {
                            lastDamage = _player.actionBar[(int)Action.ActionSlot8].Effect(_enemy);
                            lbCombatLog.Items.Add($"{_player.actionBar[(int)Action.ActionSlot8].name} hits {_enemy.name} for {lastDamage.ToString("0")} {Enum.GetName(typeof(Skill.DamageType), _player.actionBar[(int)Action.ActionSlot8].damageType)}.");
                        }
                        break;
                    case Action.ActionSlot9:
                        if (_player.actionBar[(int)Action.ActionSlot9] != null)
                        {
                            lastDamage = _player.actionBar[(int)Action.ActionSlot9].Effect(_enemy);
                            lbCombatLog.Items.Add($"{_player.actionBar[(int)Action.ActionSlot9].name} hits {_enemy.name} for {lastDamage.ToString("0")} {Enum.GetName(typeof(Skill.DamageType), _player.actionBar[(int)Action.ActionSlot9].damageType)}.");
                        }
                        break;
                    case Action.WeaponAttack:
                        lastDamage = _player.WeaponAttack(_enemy);
                        if (_player.equipment[(int)Equip.MainHand] != null)
                        {
                            Weapon weapon = (Weapon)_player.equipment[(int)Equip.MainHand];
                            lbCombatLog.Items.Add($"{weapon.name} hits {_enemy.name} for {lastDamage.ToString("0")} Physical.");
                        }
                        break;

                }
                _playerAttackProgress = 0;
            }
            #endregion

            if (_enemyAttackProgress >= _enemyAttackSpeed)
            {
                double lastDamage;

                lastDamage = _enemy.Attack(_player);

                lbCombatLog.Items.Add($"{_enemy.name} hits you for {lastDamage.ToString("0")} Physical.");

                _enemyAttackProgress = 0;
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
            if (_player.actionBar[(int)Action.ActionSlot1] != null)
            {
                _playerCurrentActionText = _player.actionBar[(int)Action.ActionSlot1].name;
                _playerAttackSpeed = (int)(_player.actionBar[(int)Action.ActionSlot1].castTime * 1000);
                _playerCurrentAction = Action.ActionSlot1;
            }
        }

        private void pbActionBarSlot2_Click(object sender, EventArgs e)
        {
            if (_player.actionBar[(int)Action.ActionSlot2] != null)
            {
                _playerCurrentActionText = _player.actionBar[(int)Action.ActionSlot2].name;
                _playerAttackSpeed = (int)(_player.actionBar[(int)Action.ActionSlot2].castTime * 1000);
                _playerCurrentAction = Action.ActionSlot2;
            }
        }

        private void pbActionBarSlot3_Click(object sender, EventArgs e)
        {
            if (_player.actionBar[(int)Action.ActionSlot3] != null)
            {
                _playerCurrentActionText = _player.actionBar[(int)Action.ActionSlot3].name;
                _playerAttackSpeed = (int)(_player.actionBar[(int)Action.ActionSlot3].castTime * 1000);
                _playerCurrentAction = Action.ActionSlot3;
            }
        }

        private void pbActionBarSlot4_Click(object sender, EventArgs e)
        {
            if (_player.actionBar[(int)Action.ActionSlot4] != null)
            {
                _playerCurrentActionText = _player.actionBar[(int)Action.ActionSlot4].name;
                _playerAttackSpeed = (int)(_player.actionBar[(int)Action.ActionSlot4].castTime * 1000);
                _playerCurrentAction = Action.ActionSlot4;
            }
        }

        private void pbActionBarSlot5_Click(object sender, EventArgs e)
        {
            if (_player.actionBar[(int)Action.ActionSlot5] != null)
            {
                _playerCurrentActionText = _player.actionBar[(int)Action.ActionSlot5].name;
                _playerAttackSpeed = (int)(_player.actionBar[(int)Action.ActionSlot5].castTime * 1000);
                _playerCurrentAction = Action.ActionSlot5;
            }
        }

        private void pbActionBarSlot6_Click(object sender, EventArgs e)
        {
            if (_player.actionBar[(int)Action.ActionSlot6] != null)
            {
                _playerCurrentActionText = _player.actionBar[(int)Action.ActionSlot6].name;
                _playerAttackSpeed = (int)(_player.actionBar[(int)Action.ActionSlot6].castTime * 1000);
                _playerCurrentAction = Action.ActionSlot6;
            }
        }

        private void pbActionBarSlot7_Click(object sender, EventArgs e)
        {
            if (_player.actionBar[(int)Action.ActionSlot7] != null)
            {
                _playerCurrentActionText = _player.actionBar[(int)Action.ActionSlot7].name;
                _playerAttackSpeed = (int)(_player.actionBar[(int)Action.ActionSlot7].castTime * 1000);
                _playerCurrentAction = Action.ActionSlot7;
            }
        }

        private void pbActionBarSlot8_Click(object sender, EventArgs e)
        {
            if (_player.actionBar[(int)Action.ActionSlot8] != null)
            {
                _playerCurrentActionText = _player.actionBar[(int)Action.ActionSlot8].name;
                _playerAttackSpeed = (int)(_player.actionBar[(int)Action.ActionSlot8].castTime * 1000);
                _playerCurrentAction = Action.ActionSlot8;
            }
        }

        private void pbActionBarSlot9_Click(object sender, EventArgs e)
        {
            if (_player.actionBar[(int)Action.ActionSlot9] != null)
            {
                _playerCurrentActionText = _player.actionBar[(int)Action.ActionSlot9].name;
                _playerAttackSpeed = (int)(_player.actionBar[(int)Action.ActionSlot9].castTime * 1000);
                _playerCurrentAction = Action.ActionSlot9;
            }
        }
        #endregion

        public CombatForm(Player player)
        {
            InitializeComponent();
            _player = player;
            _enemy = new Enemy("Goblin", Enemy.Type.Goblinoid, 2, 100, 10000, 0.5, 24, 0.5, 10, 10, 20, 1.9);

            _playerAttackProgress = 0;
            _enemyAttackProgress = 0;

            lblName.Text = _player.name;
            lblClass.Text = Enum.GetName(typeof(Player.Class), _player.playerClass);

            _playerCurrentActionText = "Weapon Attack";
            _enemyCurrentActionText = "Melee Strike";

            _actionSlots = new PictureBox[] { pbActionBarSlot1, pbActionBarSlot2, pbActionBarSlot3, pbActionBarSlot4, pbActionBarSlot5, pbActionBarSlot6, pbActionBarSlot7, pbActionBarSlot8, pbActionBarSlot9 };
            _actionSlotTooltips = new ToolTip[] { ttActionSlot1, ttActionSlot2, ttActionSlot3, ttActionSlot4, ttActionSlot5, ttActionSlot6, ttActionSlot7, ttActionSlot8, ttActionSlot9 };
            
            SetAttackSpeed();
        }
    }
}

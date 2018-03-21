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
    public partial class CombatForm : Form
    {
        private Player _player;
        private Enemy _enemy;

        private int playerAttackSpeed;
        private int playerAttackProgress;
        private string playerCurrentAction;
        private int enemyAttackSpeed;
        private int enemyAttackProgress;
        private string enemyCurrentAction;

        private void UpdateFrame()
        {
            // Player updates.
            actionSpeedBar.Maximum = playerAttackSpeed;
            healthBar.Maximum = (int)_player.attributes[(int)PlayerStat.Attribute.Health].Final();
            healthBar.Value = _player.healthCurrent;
            lblHealth.Text = $"{_player.healthCurrent}/{_player.attributes[(int)PlayerStat.Attribute.Health].Final()}";
            manaBar.Maximum = (int)_player.attributes[(int)PlayerStat.Attribute.Mana].Final();
            manaBar.Value = _player.manaCurrent;
            lblMana.Text = $"{_player.manaCurrent}/{_player.attributes[(int)PlayerStat.Attribute.Mana].Final()}";
            actionSpeedBar.Value = playerAttackProgress;
            tbCurrentAction.Text = playerCurrentAction;

            // Enemy updates.
            actionSpeedBarEnemy.Maximum = enemyAttackSpeed;
            healthBarEnemy.Maximum = _enemy.healthBase;
            healthBarEnemy.Value = _enemy.healthCurrent;
            lblHealthEnemy.Text = $"{_enemy.healthCurrent}/{_enemy.healthBase}";
            manaBarEnemy.Maximum = _enemy.manaBase;
            manaBarEnemy.Value = _enemy.manaCurrent;
            lblManaEnemy.Text = $"{_enemy.manaCurrent}/{_enemy.manaBase}";
            actionSpeedBarEnemy.Value = enemyAttackProgress;
            tbCurrentActionEnemy.Text = enemyCurrentAction;

            // Combat log updates.
        }

        private void SetAttackSpeed()
        {
            Weapon mainHand = null;

            if (_player.equipment[(int)Item.Equip.MainHand] is Weapon)
                mainHand = (Weapon)_player.equipment[(int)Item.Equip.MainHand];

            if (mainHand != null)
            {
                playerAttackSpeed = (int)(mainHand.speed * 1000);
            }
            else
            {
                playerAttackSpeed = 3000;
            }

            if (_enemy.attackSpeed != 0)
            {
                enemyAttackSpeed = (int)(_enemy.attackSpeed * 1000);
            }

            UpdateFrame();
        }

        private void timerAction_Tick(object sender, EventArgs e)
        {
            playerAttackProgress += timerAction.Interval;
            enemyAttackProgress += timerAction.Interval;

            if (playerAttackProgress >= playerAttackSpeed)
            {
                _player.WeaponAttack(_enemy);
                playerAttackProgress = 0;
            }

            if (enemyAttackProgress >= enemyAttackSpeed)
            {
                _enemy.Attack(_player);
                enemyAttackProgress = 0;
            }

            UpdateFrame();
        }

        private void btnWeaponAttack_Click(object sender, EventArgs e)
        {
            playerAttackSpeed = 1500;
        }

        public CombatForm(Player player)
        {
            InitializeComponent();
            _player = player;
            _enemy = new Enemy("Enemy", 2, 100, 100, 0.5, 24, 0.5, 10, 1, 10, 1.9);

            playerAttackProgress = 0;
            enemyAttackProgress = 0;

            lblName.Text = _player.name;
            lblClass.Text = Enum.GetName(typeof(Player.Class), _player.playerClass);

            playerCurrentAction = "Weapon Attack";
            enemyCurrentAction = "Melee Strike";

            SetAttackSpeed();
        }
    }
}

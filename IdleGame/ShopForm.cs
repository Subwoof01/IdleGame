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

        private void btnHeal_Click(object sender, EventArgs e)
        {
            if (_player.gold >= healCost)
            {
                _player.healthCurrent = (int)_player.attributes[(int)PlayerStat.Attribute.Health].Final();
                _player.gold -= healCost;
            }
            _mainForm.UpdateText();
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {

        }

        private void btnWeapons_Click(object sender, EventArgs e)
        {

        }

        private void btnArmour_Click(object sender, EventArgs e)
        {

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {

        }

        private void btnSell_Click(object sender, EventArgs e)
        {

        }

        public void UpdateText()
        {
            healCost = ((int)_player.attributes[(int)PlayerStat.Attribute.Health].Final() - _player.healthCurrent) / 3;
            btnHeal.Text = $"Heal ({healCost}g)";
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
        }
    }
}

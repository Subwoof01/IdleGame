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
    public partial class TravelForm : Form
    {
        public enum Selection { Forest, Cave, Graveyard, Mountains, Ruins, Ethereal, Underworld, Town, Arena, HuntingGrounds };

        private Selection _selected;
        private Button[] _buttons;
        private Player _player;
        private CombatForm _combatForm;
        private MainForm _mainForm;

        public void UpdateFrame()
        {
            switch (_selected)
            {
                case Selection.Forest:
                    pbSelectedBanner.Image = Image.FromFile(@"Resources\Zone Banners\Forest.png");
                    ButtonSwitch(Selection.Forest);
                    lblZoneName.Text = "Forest (Lv1-10)";
                    tbEnemyTypes.Text = "Beasts\r\nHumanoids";
                    break;
                case Selection.Cave:
                    pbSelectedBanner.Image = Image.FromFile(@"Resources\Zone Banners\Cave.png");
                    ButtonSwitch(Selection.Cave);
                    lblZoneName.Text = "Cave (Lv10-20)";
                    tbEnemyTypes.Text = "Goblinoids\r\nHumanoids";
                    break;
                case Selection.Graveyard:
                    pbSelectedBanner.Image = Image.FromFile(@"Resources\Zone Banners\Graveyard.png");
                    ButtonSwitch(Selection.Graveyard);
                    lblZoneName.Text = "Graveyard (Lv20-40)";
                    tbEnemyTypes.Text = "Undead\r\nHumanoids";
                    break;
                case Selection.Mountains:
                    pbSelectedBanner.Image = Image.FromFile(@"Resources\Zone Banners\Mountains.png");
                    ButtonSwitch(Selection.Mountains);
                    lblZoneName.Text = "Mountains (Lv40-55)";
                    tbEnemyTypes.Text = "Giants\r\nDragonkin\r\nHumanoids";
                    break;
                case Selection.Ruins:
                    pbSelectedBanner.Image = Image.FromFile(@"Resources\Zone Banners\Ruins.png");
                    ButtonSwitch(Selection.Ruins);
                    lblZoneName.Text = "Ruins (Lv55-70)";
                    tbEnemyTypes.Text = "Mechanical\r\nHumanoids";
                    break;
                case Selection.Ethereal:
                    pbSelectedBanner.Image = Image.FromFile(@"Resources\Zone Banners\Ethereal.png");
                    ButtonSwitch(Selection.Ethereal);
                    lblZoneName.Text = "Ethereal Planes (Lv70-90)";
                    tbEnemyTypes.Text = "Ethereal";
                    break;
                case Selection.Underworld:
                    pbSelectedBanner.Image = Image.FromFile(@"Resources\Zone Banners\Underworld.png");
                    ButtonSwitch(Selection.Underworld);
                    lblZoneName.Text = "The Underworld (Lv90+)";
                    tbEnemyTypes.Text = "Demons";
                    break;
                case Selection.Town:
                    pbSelectedBanner.Image = Image.FromFile(@"Resources\Zone Banners\Town.png");
                    ButtonSwitch(Selection.Town);
                    lblZoneName.Text = "Town (Quest-Hub)";
                    tbEnemyTypes.Text = "None";
                    break;
                case Selection.Arena:
                    pbSelectedBanner.Image = Image.FromFile(@"Resources\Zone Banners\Arena.png");
                    ButtonSwitch(Selection.Arena);
                    lblZoneName.Text = "The Arena (Lv65+)";
                    tbEnemyTypes.Text = "WIP";
                    break;
                case Selection.HuntingGrounds:
                    pbSelectedBanner.Image = Image.FromFile(@"Resources\Zone Banners\HuntingGrounds.png");
                    ButtonSwitch(Selection.HuntingGrounds);
                    lblZoneName.Text = "The Hunting Grounds (Lv80+)";
                    tbEnemyTypes.Text = "WIP";
                    break;
            }
        }

        private void ButtonSwitch(Selection selection)
        {
            _buttons[(int)selection].Enabled = false;

            foreach (Button b in _buttons)
            {
                if (b != _buttons[(int)selection])
                {
                    b.Enabled = true;
                }
            }
        }

        private void btnForest_Click(object sender, EventArgs e)
        {
            _selected = Selection.Forest;
            UpdateFrame();
        }

        private void btnCave_Click(object sender, EventArgs e)
        {
            _selected = Selection.Cave;
            UpdateFrame();
        }

        private void btnGraveyard_Click(object sender, EventArgs e)
        {
            _selected = Selection.Graveyard;
            UpdateFrame();
        }

        private void btnMountains_Click(object sender, EventArgs e)
        {
            _selected = Selection.Mountains;
            UpdateFrame();
        }

        private void btnRuins_Click(object sender, EventArgs e)
        {
            _selected = Selection.Ruins;
            UpdateFrame();
        }

        private void btnEthereal_Click(object sender, EventArgs e)
        {
            _selected = Selection.Ethereal;
            UpdateFrame();
        }

        private void btnUnderworld_Click(object sender, EventArgs e)
        {
            _selected = Selection.Underworld;
            UpdateFrame();
        }

        private void btnTown_Click(object sender, EventArgs e)
        {
            _selected = Selection.Town;
            UpdateFrame();
        }

        private void btnArena_Click(object sender, EventArgs e)
        {
            _selected = Selection.Arena;
            UpdateFrame();
        }

        private void btnHuntingGround_Click(object sender, EventArgs e)
        {
            _selected = Selection.HuntingGrounds;
            UpdateFrame();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (_selected.Equals(Selection.Arena))
            {
                // TODO: Dedicated form.
            }
            else if (_selected.Equals(Selection.HuntingGrounds))
            {
                // TODO: Dedicated form.
            }
            else if (_selected.Equals(Selection.Town))
            {
                // TODO: Dedicated form.
            }
            else
            {
                _combatForm = new CombatForm(_player, _mainForm,  _selected);
                _combatForm.Show();
            }
        }

        public TravelForm(Player player, MainForm mainForm)
        {
            InitializeComponent();
            _player = player;
            _mainForm = mainForm;
            _selected = Selection.Forest;
            _buttons = new Button[] { btnForest, btnCave, btnGraveyard, btnMountains, btnRuins, btnEthereal, btnUnderworld, btnTown, btnArena, btnHuntingGround };
            tbEnemyTypes.Text = "Beasts\r\nHumanoids";
        }
    }
}

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

namespace IdleGame
{
    public partial class SkillBook : Form
    {
        private Player _player;
        private PictureBox[] _skillImage;
        private Label[] _skillLearned;
        private Label[] _skillNextRank;
        private Label[] _skillType;
        private ToolTip[] _skillTooltip;
        private PictureBox[] _actionBar;

        private Image _actionSlotEmpty;
        private Image _actionSlotSelected;

        private PictureBox _selectedSlot;
        private int _actionSlotIndex;

        public void UpdateForm()
        {
            for (int i = 0; i < _player.skills.Length; i++)
            {
                if (_player.skills[i] != null)
                {
                    _skillImage[i].Image = _player.skills[i].image;
                    _skillImage[i].Tag = _player.skills[i].name;
                    _skillLearned[i].Text = (_player.skills[i].currentRank > 0) ? $"{_player.skills[i].name} (Rank {_player.skills[i].currentRank})" : $"{_player.skills[i].name} (Unlearned)";
                    _skillNextRank[i].Text = $"Next Rank: level {_player.skills[i].levelRank[_player.skills[i].currentRank]}";
                    _skillType[i].Text = Enum.GetName(typeof(Skill.Type), _player.skills[i].type);
                    _skillTooltip[i].ToolTipTitle = _player.skills[i].name;
                    _skillTooltip[i].SetToolTip(_skillImage[i], _player.skills[i].ToolTip());
                }
            }

            for (int i = 0; i < _player.actionBar.Length; i++)
            {
                if (_player.actionBar[i] != null)
                    _actionBar[i].Image = _player.actionBar[i].image;
                else if (_actionBar[i] == _selectedSlot)
                    _actionBar[i].Image = _actionSlotSelected;
                else
                    _actionBar[i].Image = _actionSlotEmpty;
            }
        }

        private void pbActionBarSlot1_Click(object sender, EventArgs e)
        {
            _selectedSlot = pbActionBarSlot1;
            _actionSlotIndex = 0;
            UpdateForm();
        }

        private void pbActionBarSlot2_Click(object sender, EventArgs e)
        {
            _selectedSlot = pbActionBarSlot2;
            _actionSlotIndex = 1;
            UpdateForm();
        }

        private void pbActionBarSlot3_Click(object sender, EventArgs e)
        {
            _selectedSlot = pbActionBarSlot3;
            _actionSlotIndex = 2;
            UpdateForm();
        }

        private void pbActionBarSlot4_Click(object sender, EventArgs e)
        {
            _selectedSlot = pbActionBarSlot4;
            _actionSlotIndex = 3;
            UpdateForm();
        }

        private void pbActionBarSlot5_Click(object sender, EventArgs e)
        {
            _selectedSlot = pbActionBarSlot5;
            _actionSlotIndex = 4;
            UpdateForm();
        }

        private void pbActionBarSlot6_Click(object sender, EventArgs e)
        {
            _selectedSlot = pbActionBarSlot6;
            _actionSlotIndex = 5;
            UpdateForm();
        }

        private void pbActionBarSlot7_Click(object sender, EventArgs e)
        {
            _selectedSlot = pbActionBarSlot7;
            _actionSlotIndex = 6;
            UpdateForm();
        }

        private void pbActionBarSlot8_Click(object sender, EventArgs e)
        {
            _selectedSlot = pbActionBarSlot8;
            _actionSlotIndex = 7;
            UpdateForm();
        }

        private void pbActionBarSlot9_Click(object sender, EventArgs e)
        {
            _selectedSlot = pbActionBarSlot9;
            _actionSlotIndex = 8;
            UpdateForm();
        }

        private void pbSkillOne_Click(object sender, EventArgs e)
        {
            if (_player.skills[0] != null)
            {
                _selectedSlot.Image = _player.skills[0].image;
                _player.actionBar[_actionSlotIndex] = _player.skills[0];
            }
        }

        private void pbSkillTwo_Click(object sender, EventArgs e)
        {
            if (_player.skills[1] != null)
            {
                _selectedSlot.Image = _player.skills[1].image;
                _player.actionBar[_actionSlotIndex] = _player.skills[1];
            }
        }

        private void pbSkillThree_Click(object sender, EventArgs e)
        {
            if (_player.skills[2] != null)
            {
                _selectedSlot.Image = _player.skills[2].image;
                _player.actionBar[_actionSlotIndex] = _player.skills[2];
            }
        }

        private void pbSkillFour_Click(object sender, EventArgs e)
        {
            if (_player.skills[3] != null)
            {
                _selectedSlot.Image = _player.skills[3].image;
                _player.actionBar[_actionSlotIndex] = _player.skills[3];
            }
        }

        private void pbSkillFive_Click(object sender, EventArgs e)
        {
            if (_player.skills[4] != null)
            {
                _selectedSlot.Image = _player.skills[4].image;
                _player.actionBar[_actionSlotIndex] = _player.skills[4];
            }
        }

        private void pbSkillSix_Click(object sender, EventArgs e)
        {
            if (_player.skills[5] != null)
            {
                _selectedSlot.Image = _player.skills[5].image;
                _player.actionBar[_actionSlotIndex] = _player.skills[5];
            }
        }

        private void pbSkillSeven_Click(object sender, EventArgs e)
        {
            if (_player.skills[6] != null)
            {
                _selectedSlot.Image = _player.skills[6].image;
                _player.actionBar[_actionSlotIndex] = _player.skills[6];
            }
        }

        private void pbSkillEight_Click(object sender, EventArgs e)
        {
            if (_player.skills[7] != null)
            {
                _selectedSlot.Image = _player.skills[7].image;
                _player.actionBar[_actionSlotIndex] = _player.skills[7];
            }
        }

        private void pbSkillNine_Click(object sender, EventArgs e)
        {
            if (_player.skills[8] != null)
            {
                _selectedSlot.Image = _player.skills[8].image;
                _player.actionBar[_actionSlotIndex] = _player.skills[8];
            }
        }

        private void pbSkillTen_Click(object sender, EventArgs e)
        {
            if (_player.skills[9] != null)
            {
                _selectedSlot.Image = _player.skills[9].image;
                _player.actionBar[_actionSlotIndex] = _player.skills[9];
            }
        }

        public SkillBook(Player player)
        {
            InitializeComponent();
            _player = player;

            _actionSlotEmpty = Image.FromFile(@"Resources\ActionBarSlot.png");
            _actionSlotSelected = Image.FromFile(@"Resources\ActionBarSlotSelected.png");

            _skillImage = new PictureBox[] { pbSkillOne, pbSkillTwo, pbSkillThree, pbSkillFour, pbSkillFive, pbSkillSix, pbSkillSeven, pbSkillEight, pbSkillNine, pbSkillTen };
            _skillLearned = new Label[] { lblSkillOneLearned, lblSkillTwoLearned, lblSkillThreeLearned, lblSkillFourLearned, lblSkillFiveLearned, lblSkillSixLearned, lblSkillSevenLearned, lblSkillEightLearned, lblSkillNineLearned, lblSkillTenLearned };
            _skillNextRank = new Label[] { lblSkillOneNextRank, lblSkillTwoNextRank, lblSkillThreeNextRank, lblSkillFourNextRank, lblSkillFiveNextRank, lblSkillSixNextRank, lblSkillSevenNextRank, lblSkillEightNextRank, lblSkillNineNextRank, lblSkillThreeNextRank };
            _skillType = new Label[] { lblSkillOneType, lblSkillTwoType, lblSkillThreeType, lblSkillFourType, lblSkillFiveType, lblSkillSixType, lblSkillSevenType, lblSkillEightType, lblSkillNineType, lblSkillTenType };
            _skillTooltip = new ToolTip[] { ttSkillOne, ttSkillTwo, ttSkillThree, ttSkillFour, ttSkillFive, ttSkillSix, ttSkillSeven, ttSkillEight, ttSkillNine, ttSkillTen };

            _actionBar = new PictureBox[] { pbActionBarSlot1, pbActionBarSlot2, pbActionBarSlot3, pbActionBarSlot4, pbActionBarSlot5, pbActionBarSlot6, pbActionBarSlot7, pbActionBarSlot8, pbActionBarSlot9 };

            UpdateForm();
        }
    }
}

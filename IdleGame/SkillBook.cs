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
        private PictureBox[] _actionBar;

        private Image _actionSlotEmpty;
        private Image _actionSlotSelected;

        private PictureBox _selectedSlot;
        private int _actionSlotIndex;

        private List<Skill> _skillCheck;

        private TabPage _tabPage2;
        private TableLayoutPanel _tlPage2;

        public void UpdateForm()
        {
            if (!_player.skills.SequenceEqual(_skillCheck))
            {
                tlPage1.Controls.Clear();
                if (_tlPage2 != null)
                    _tlPage2.Controls.Clear();

                if (_player.skills.Count > 0)
                {
                    for (int i = 0; i < ((_player.skills.Count > 12) ? 12 : _player.skills.Count); i++)
                    {
                        tlPage1.Controls.Add(new SkillBookPanel(_player, _player.skills[i], this));
                    }

                    if (_player.skills.Count > 12)
                    {
                        _tabPage2 = new TabPage("Page 2");
                        tcPages.Controls.Add(_tabPage2);

                        _tlPage2 = new TableLayoutPanel();
                        _tlPage2.AutoSize = true;
                        _tlPage2.AutoSizeMode = AutoSizeMode.GrowOnly;
                        _tabPage2.Controls.Add(_tlPage2);

                        for (int i = 12; i < _player.skills.Count; i++)
                        {
                            _tlPage2.Controls.Add(new SkillBookPanel(_player, _player.skills[i], this));
                        }

                        if (_tlPage2.Controls.Count > 0)
                        {
                            int index = 12;

                            foreach (SkillBookPanel sbp in _tlPage2.Controls)
                            {
                                sbp.pbSkill.Image = _player.skills[index].image;
                                sbp.lblSkillLearned.Text = (_player.skills[index].currentRank > 0) ? $"{_player.skills[index].name} (Rank {_player.skills[index].currentRank})" : $"{_player.skills[index].name} (Unlearned)";
                                sbp.lblSkillNextRank.Text = $"Next Rank: level {_player.skills[index].levelRank[_player.skills[index].currentRank]}";
                                sbp.lblSkillType.Text = Enum.GetName(typeof(Skill.Type), _player.skills[index].type);
                                sbp.ttSkillEffect.ToolTipTitle = _player.skills[index].name;
                                sbp.ttSkillEffect.SetToolTip(sbp.pbSkill, _player.skills[index].ToolTip());
                                index++;
                            }
                        }
                    }

                    if (tlPage1.Controls.Count > 0)
                    {
                        int index = 0;

                        foreach (SkillBookPanel sbp in tlPage1.Controls)
                        {
                            sbp.pbSkill.Image = _player.skills[index].image;
                            sbp.lblSkillLearned.Text = (_player.skills[index].currentRank > 0) ? $"{_player.skills[index].name} (Rank {_player.skills[index].currentRank})" : $"{_player.skills[index].name} (Unlearned)";
                            sbp.lblSkillNextRank.Text = $"Next Rank: level {_player.skills[index].levelRank[_player.skills[index].currentRank]}";
                            sbp.lblSkillType.Text = Enum.GetName(typeof(Skill.Type), _player.skills[index].type);
                            sbp.ttSkillEffect.ToolTipTitle = _player.skills[index].name;
                            sbp.ttSkillEffect.SetToolTip(sbp.pbSkill, _player.skills[index].ToolTip());
                            index++;
                        }
                    }
                }
                _skillCheck = _player.skills;
            }

            if (tlPage1 != null)
            {
                foreach (SkillBookPanel sbp in tlPage1.Controls)
                {
                    sbp.SetSelection(_actionSlotIndex);
                }

            }

            if (_tlPage2 != null)
            {
                foreach (SkillBookPanel sbp in _tlPage2.Controls)
                {
                    sbp.SetSelection(_actionSlotIndex);
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

        public SkillBook(Player player)
        {
            InitializeComponent();
            _player = player;

            _actionSlotEmpty = Image.FromFile(@"Resources\ActionBarSlot.png");
            _actionSlotSelected = Image.FromFile(@"Resources\ActionBarSlotSelected.png");
            _actionBar = new PictureBox[] { pbActionBarSlot1, pbActionBarSlot2, pbActionBarSlot3, pbActionBarSlot4, pbActionBarSlot5, pbActionBarSlot6, pbActionBarSlot7, pbActionBarSlot8, pbActionBarSlot9 };
            _skillCheck = new List<Skill>();

            _tabPage2 = null;
            _tlPage2 = null;

            UpdateForm();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IdleGame.Skills;

namespace IdleGame
{
    public partial class SkillBookPanel : UserControl
    {
        private Player _player;
        private Skill _skill;
        private SkillBook _skillBook;
        private int _actionSlotIndex;

        public SkillBookPanel(Player player, Skill skill, SkillBook skillBook)
        {
            InitializeComponent();
            _player = player;
            _skill = skill;
            _skillBook = skillBook;
        }

        public void SetSelection(int actionSlotIndex)
        {
            _actionSlotIndex = actionSlotIndex;
        }

        private void pbSkill_Click(object sender, EventArgs e)
        {
            _player.actionBar[_actionSlotIndex] = _skill;
            _skillBook.UpdateForm();
        }
    }
}

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
    public partial class WarriorSkillTree : Form
    {
        private WarriorSkill _warriorSkill;

        public WarriorSkillTree(WarriorSkill warriorSkill)
        {
            InitializeComponent();
            _warriorSkill = warriorSkill;
        }
    }
}

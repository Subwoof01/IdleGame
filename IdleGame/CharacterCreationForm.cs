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
    public partial class CharacterCreationForm : Form
    {
        public Player player;
        public MainForm mainForm;

        private void ChooseClass(CharacterClass.Classes playerClass)
        {
            Player player = new Player(playerClass);
            MainForm mainForm = new MainForm(player);
            this.Hide();
            mainForm.FormClosed += (s, args) => this.Close();
            mainForm.Show();
        }

        private void btnWarrior_Click(object sender, EventArgs e)
        {
            ChooseClass(CharacterClass.Classes.Warrior);
        }

        private void btnSorcerer_Click(object sender, EventArgs e)
        {
            ChooseClass(CharacterClass.Classes.Sorcerer);
        }

        private void btnRanger_Click(object sender, EventArgs e)
        {
            ChooseClass(CharacterClass.Classes.Ranger);
        }

        public CharacterCreationForm()
        {
            InitializeComponent();
        }
    }
}

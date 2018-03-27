using IdleGame.Attributes;
using IdleGame.Skills;
using IdleGame.Skills.Warrior;
using IdleGame.Talents;
using IdleGame.Talents.Warrior;
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

        private void OpenMainForm()
        {
            MainForm mainForm = new MainForm(player);
            this.Hide();
            mainForm.FormClosed += (s, args) => this.Close();
            mainForm.Show();
        }

        private void Warrior()
        {
            player = new Player(Player.Class.Warrior);

            player.attributes = new PlayerStat[]
            {
                new Strength(player, 10),
                new Intelligence(player, 3),
                new Dexterity(player, 6),
                new Health(player, 1000),
                new Mana(player, 20),
                new ArmourStat(player),
                new PhysicalDamage(player, 1, 2),
                new ElementalDamage(player),
                new CriticalChance(player, 0.05),
                new CriticalDamage(player, 0.2),
                new PhysicalResistance(player),
                new ElementalResistance(player),
                new HealthRegeneration(player),
                new ManaRegeneration(player),
            };

            player.talents = new Talent[]
            {
                new WeaponMastery(player),
                new IronSkin(player),
                new ArmouredToTheTeeth(player)
            };

            player.skills = new Skill[]
            {
                new PowerStrike(player),
                new PowerStrike(player),
                new PowerStrike(player),
                new PowerStrike(player),
                new PowerStrike(player),
                new PowerStrike(player),
                new PowerStrike(player),
                new PowerStrike(player),
                new PowerStrike(player)
            };

            player.healthCurrent = (int)player.attributes[(int)PlayerStat.Attribute.Health].Final();
            player.manaCurrent = (int)player.attributes[(int)PlayerStat.Attribute.Mana].Final();

            OpenMainForm();
        }

        private void btnWarrior_Click(object sender, EventArgs e)
        {
            Warrior();
        }

        private void btnSorcerer_Click(object sender, EventArgs e)
        {
        }

        private void btnRanger_Click(object sender, EventArgs e)
        {
        }

        public CharacterCreationForm()
        {
            InitializeComponent();
        }
    }
}

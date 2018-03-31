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
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdleGame
{
    public partial class CharacterCreationForm : Form
    {
        public Player player;
        public MainForm mainForm;

        private Player.Class playerClass;

        private void OpenMainForm()
        {
            mainForm = new MainForm(player, this);
            this.Hide();
            mainForm.FormClosed += (s, args) => this.Close();
            mainForm.Show();
        }

        private void Warrior()
        {
            player = new Player(Player.Class.Warrior);

            player.name = tbPlayerName.Text;

            player.attributes = new PlayerStat[]
            {
                new Strength(player, 10),
                new Intelligence(player, 3),
                new Dexterity(player, 6),
                new Health(player, 100),
                new Mana(player, 20),
                new ArmourStat(player),
                new PhysicalDamage(player, 1, 2),
                new FireDamage(player),
                new LightningDamage(player),
                new ColdDamage(player),
                new PoisonDamage(player),
                new CriticalChance(player, 0.05),
                new CriticalDamage(player, 0.2),
                new PhysicalResistance(player),
                new FireResistance(player),
                new LightningResistance(player),
                new ColdResistance(player),
                new PoisonResistance(player),
                new HealthRegeneration(player),
                new ManaRegeneration(player),
            };

            player.talents = new Talent[]
            {
                new WeaponMastery(player),
                new IronSkin(player),
                new ArmouredToTheTeeth(player)
            };

            player.skills = new List<Skill>();

            player.skills.Add(new PowerStrike(player));
            player.skills.Add(new Gut(player));

            player.healthCurrent = (int)player.attributes[(int)PlayerStat.Attribute.Health].Final();
            player.manaCurrent = (int)player.attributes[(int)PlayerStat.Attribute.Mana].Final();

            OpenMainForm();
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbClass.SelectedItem)
            {
                case "Warrior":
                    playerClass = Player.Class.Warrior;
                    tbMaxHealth.Text = "100";
                    tbMaxMana.Text = "20";
                    tbStrength.Text = "10";
                    tbIntelligence.Text = "3";
                    tbDexterity.Text = "6";
                    break;
                case "Sorcerer":
                    playerClass = Player.Class.Sorcerer;
                    tbMaxHealth.Text = "70";
                    tbMaxMana.Text = "50";
                    tbStrength.Text = "3";
                    tbIntelligence.Text = "10";
                    tbDexterity.Text = "6";
                    break;
                case "Ranger":
                    playerClass = Player.Class.Ranger;
                    tbMaxHealth.Text = "85";
                    tbMaxMana.Text = "35";
                    tbStrength.Text = "5";
                    tbIntelligence.Text = "5";
                    tbDexterity.Text = "10";
                    break;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!tbPlayerName.Text.Equals("") && cbClass.SelectedItem != null)
            {
                switch (playerClass)
                {
                    case Player.Class.Warrior:
                        Warrior();
                        break;
                    case Player.Class.Sorcerer:
                        break;
                    case Player.Class.Ranger:
                        break;
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadFileDialog.InitialDirectory = @"Saves\save.dat";
            if (loadFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(loadFileDialog.FileName))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    FileStream file = File.Open(loadFileDialog.FileName, FileMode.Open);
                    player = (Player)bf.Deserialize(file);
                    file.Close();
                    OpenMainForm();
                }
            }
        }

        public CharacterCreationForm()
        {
            InitializeComponent();
        }
    }
}

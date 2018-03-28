using IdleGame.Attributes;
using IdleGame.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdleGame.Enemies
{
    public abstract class Enemy : Living
    {
        protected static Random random = new Random();
        public enum Type { Goblinoid, Humanoid, Undead, Dragonkin, Ethereal, Beast, Elemental, Demon, Giant, Mechanical, Aberration };

        public double attackSpeed;
        public Type type;

        public string currentAction;

        public double fireResistance;
        public double lightningResistance;
        public double coldResistance;
        public double poisonResistance;

        public int expReward(int level)
        {
            return (int)(100 * Math.Pow(level, 0.1) + Math.Pow(level, 2.5) + Math.Pow(level - 1, 2.5));
        }

        public abstract double PhysicalResistance();

        public abstract string Action(Player player);

        public void Die(Player player, CombatForm combatForm, MainForm mainForm)
        {
            DialogResult victory = MessageBox.Show(combatForm,
                $"{this.name} defeated!\n" +
                $"Experience earned: {this.expReward(this.level)}\n" +
                $"Gold found: {this.gold}g\n" +
                $"Items found: wip",
                "Victory!",
                MessageBoxButtons.OK);

            player.IncreaseExp(this.expReward(this.level));
            player.gold += this.gold;

            mainForm.UpdateText();

            if (victory == DialogResult.OK)
            {
                combatForm.Close();
            }
        }
    }
}

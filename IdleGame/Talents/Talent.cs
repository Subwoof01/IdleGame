using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame.Talents
{
    [Serializable]
    abstract public class Talent
    {

        protected Player _player;
        public Player.Class talentClass;
        virtual public Talent[] Prerequisites()
        {
            return null;
        }
        public int prerequisitesCount;
        public int maxLevel;
        public int currentLevel;

        abstract public double Effect();

        /// <summary>
        /// Increases the level of the talent by 1.
        /// </summary>
        public void IncreaseLevel()
        {
            int prerequisitesCounter = 0;
            if (Prerequisites() != null)
            {
                for (int i = 0; i < Prerequisites().Length; i++)
                {
                    if (Prerequisites()[i].currentLevel == Prerequisites()[i].maxLevel)
                        prerequisitesCounter++;
                }
            }
            
            if (Prerequisites() == null || prerequisitesCount == prerequisitesCounter)
                if (this.currentLevel < maxLevel && _player.talentPoints > 0)
                {
                    this.currentLevel++;
                    _player.talentPoints--;
                }
        }

        /// <summary>
        /// Returns the current level the talent.
        /// </summary>
        /// <returns>currentLevel</returns>
        public int GetLevel()
        {
            return this.currentLevel;
        }

        /// <summary>
        /// Returns the maximum level the talent.
        /// </summary>
        /// <returns></returns>
        public int GetMax()
        {
            return this.maxLevel;
        }
    }
}

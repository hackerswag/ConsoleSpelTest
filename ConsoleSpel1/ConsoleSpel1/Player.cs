using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSpel1
{
    class Player
    {
        int level;
        double currentLife;
        static double maxLife = 100;

        public Player(int le)
        { 
            level = le;
        }
        public void IncreaseLife(double hp)
        {
            maxLife += hp;
        }
        public double MaxLife
        {
            set { maxLife = value; }
            get { return maxLife * 0.2 * level; }
        }

        public void LevelUp()
        {
            level++;
        }

        public int Level
        {
            get { return level; }
        }
        
        public double CurrentLife
        {
            set { currentLife =- value; }
            get { return currentLife; }
        }

    }
    

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSpel1
{
    class goblin
    {
        int level;
        static double maxLife = 100;
        int currentLife;


        public goblin(int le)
        {
            level = le;
        }

        public double MaxLife
        {
            get{return maxLife * 0.2 * level; }
        }

        public int Level
        {
            get { return level; }
        }
        public int CurrentLife
        {
            get { return currentLife; }
        }

    }
}

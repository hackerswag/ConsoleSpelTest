using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSpel1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(2);
            goblin g = new goblin(5);
            player.IncreaseLife(100);
            Console.WriteLine(g.MaxLife);
            Console.WriteLine(player.MaxLife);
            Console.ReadLine();


        }
    }
}

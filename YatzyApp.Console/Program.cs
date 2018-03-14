using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YatzyApp.Core;

namespace YatzyApp.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice d = new Dice(10);

          
            //d.Value = 1;

            System.Console.WriteLine(d.DiceValue());
            d.RollDice();
            System.Console.WriteLine(d.DiceValue());

            System.Console.ReadKey();
        }


    }
}

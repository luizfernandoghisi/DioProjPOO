using DioProj.src.Entities;
using System;

namespace DioProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Arus", 42, 749, 72);
            Ninja ninja = new Ninja("Wedge", 42, 574, 89);
            Wizard witheWizard = new Wizard("Jennica", 42, HeroType.WhiteWizard , 601, 482);
            Wizard blackWizard = new Wizard("Topapa", 42, HeroType.BlackWizard, 385, 641);

            Console.WriteLine(knight);
            Console.WriteLine(ninja);
            Console.WriteLine(witheWizard);
            Console.WriteLine(blackWizard);
            Console.WriteLine(witheWizard.Attack(1));
            Console.WriteLine(knight.Attack(7));
            Console.WriteLine(ninja.Attack());
            Console.WriteLine(blackWizard.Attack(3));
        }
    }
}

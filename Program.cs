using static System.Console;
using D_and_O.src.Entities;

namespace dotnetRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight firstHero = new Knight("Amon", 24, "Knight");
            Wizard firstWizard = new Wizard("Yennefer", 24, "White wizard");

            firstHero.ToString();
            firstWizard.ToString();
            
            WriteLine(firstWizard.Attack());
            WriteLine(firstHero.Attack());
            WriteLine(firstWizard.Attack(25));
        }
    }
}

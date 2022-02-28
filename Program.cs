using static System.Console;
using System;
using D_and_O.src.Entities;

namespace dotnetRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Arus firstHero = new Arus("Amon", 24, "Rogue");

            WriteLine($@" 
            Name: {firstHero.Name}
            Level: {firstHero.Level}
            Type: {firstHero.HeroType}
            ");

            WriteLine(firstHero);
        }
    }
}

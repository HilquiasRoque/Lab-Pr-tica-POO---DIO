using PraticaPOO_RPG.Source.Entities;
using System;

namespace PraticaPOO_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard janine = new Wizard("Janine", "Feiticeira", 42);
            Console.WriteLine(janine);
            Console.WriteLine(janine.Attack());
            Console.WriteLine();

            Knight arus = new Knight("Arus", "Guerreiro", 42);
            Console.WriteLine(arus);
            Console.WriteLine(arus.Attack());
            Console.WriteLine();

            Ninja wedge = new Ninja("Wedge", "Ninja", 42);
            Console.WriteLine(wedge);
            Console.WriteLine(wedge.Attack());
        }
    }
}

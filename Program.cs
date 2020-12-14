using System;
using Polimorfismo.classes;
namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Megaman megaman = new Megaman();
            Console.WriteLine($"{megaman.personagem} {megaman.Correr()}");

            Zero zero = new Zero();
            Console.WriteLine($"{zero.personagem} {zero.Correr()}");
        }
    }
}

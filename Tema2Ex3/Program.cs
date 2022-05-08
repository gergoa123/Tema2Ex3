using System;

namespace Tema2Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul");
            int numar = int.Parse(Console.ReadLine());
            int aux = 0;
            int original = numar;
            while (numar > 0)
            {
                int x = numar % 10;
                aux = aux * 10 + x;
                numar = numar / 10;
            }
            if (original == aux)
            {
                Console.WriteLine("numarul este palindrom");
            }
            else
            {
                Console.WriteLine("nu este palindrom");
            }
             

        }
    }
}

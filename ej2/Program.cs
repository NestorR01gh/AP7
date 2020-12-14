using System;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Frase 1: ");
            string f1 = Console.ReadLine();
            Console.Write("Frase 2: ");
            string f2 = Console.ReadLine();
            if (f1 == f2)
            {
                Console.Write("Las frases son iguales");
            }
            else
            {
                Console.Write("Las frases no son iguales");
            }
            Console.ReadKey();
        }
    }
}

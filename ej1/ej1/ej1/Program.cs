using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce número(1..10): ");
            int n = int.Parse(Console.ReadLine());
            
            switch (n)
            {
                case 1:
                    Console.WriteLine("Número 'I' en números romanos");
                    break;
                case 2:
                    Console.WriteLine("Número 'II' en números romanos");
                    break;
                case 3:
                    Console.WriteLine("Número 'III' en números romanos");
                    break;
                case 4:
                    Console.WriteLine("Número 'IV' en números romanos");
                    break;
                case 5:
                    Console.WriteLine("Número 'V' en números romanos");
                    break;
                case 6:
                    Console.WriteLine("Número 'VI' en números romanos");
                    break;
                case 7:
                    Console.WriteLine("Número 'VII' en números romanos");
                    break;
                case 8:
                    Console.WriteLine("Número 'VIII' en números romanos");
                    break;
                case 9:
                    Console.WriteLine("Número 'IX' en números romanos");
                    break;
                case 10:
                    Console.WriteLine("Número 'X' en números romanos");
                    break;
                default:
                    Console.WriteLine("No es un número del 1 al 10");
                    break;
            }
            Console.ReadKey();
        }
    }
}

using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            double gb, mb, capCD, totalCDs;

            Console.Write("Cantidad de información a almacenar(GB): ");
            gb = int.Parse(Console.ReadLine());
            mb = gb * 1024;
            capCD = 700;
            totalCDs = (int) Math.Ceiling(mb / capCD);
            Console.WriteLine("Necesitaremos {0} CDs", totalCDs);
            Console.ReadKey();
        }
    }
}
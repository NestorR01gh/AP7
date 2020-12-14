using System;

namespace ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.Write("Introduce número 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Introduce número 2: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Introduce número 3: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 != num2 && num1 != num3 && num2 != num3)
            {
                if (num1 > num2)
                {
                    if (num1 > num3)
                    {
                        Console.WriteLine("El número {0} es el mayor", num1);
                    }
                    else
                    {
                        Console.WriteLine("El número {0} es el mayor", num3);
                    }
                }
                else
                {
                    if (num2 > num3)
                    {
                        Console.WriteLine("El número {0} es el mayor", num2);
                    }
                    else
                    {
                        Console.WriteLine("El número {0} es el mayor", num3);
                    }
                }
            }
            else
            {
                Console.WriteLine("Hay números repetidos, los números deben ser diferentes");
            }
            Console.ReadKey();
        }
    }
}

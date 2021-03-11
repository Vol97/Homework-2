using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number A: ");
            double numberA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number B: ");
            double numberB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number C: ");
            double numberC = Convert.ToDouble(Console.ReadLine());
            double x;
            double x2;
            double d = numberB * numberB - (4 * numberA * numberC);

            if(d >= 0)
            {
                if(d > 0)
                {
                    x = (-numberB + Math.Sqrt(d)) / (2 * numberA);
                    x2 = (-numberB - Math.Sqrt(d)) / (2 * numberA);

                    Console.WriteLine($"X1: {x}\nX2: {x2}");
                }
                else
                {
                    x = -numberB / (2 * numberA);
                    Console.WriteLine($"X1: {x}");
                }
            }
            else
            {
                Console.WriteLine("No solution");
            }
        }
    }
}

using System;

namespace Task_3
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

            if(numberA > numberB && numberA > numberC)
            {
                if(numberB > numberC)
                {
                    Console.WriteLine($"{numberC}, {numberB}, {numberA}");
                }
                else
                {
                    Console.WriteLine($"{numberB}, {numberC}, {numberA}");
                }
            }
            if(numberB > numberA && numberB > numberC)
            {
                if (numberA > numberC)
                {
                    Console.WriteLine($"{numberC}, {numberA}, {numberB}");
                }
                else
                {
                    Console.WriteLine($"{numberA}, {numberC}, {numberB}");
                }
            }
            if (numberC > numberA && numberC > numberB)
            {
                if (numberA > numberB)
                {
                    Console.WriteLine($"{numberB}, {numberA}, {numberC}");
                }
                else
                {
                    Console.WriteLine($"{numberA}, {numberB}, {numberC}");
                }
            }
        }
    }
}
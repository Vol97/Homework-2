using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number A: ");
            double numberA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number B: ");
            double numberB = Convert.ToDouble(Console.ReadLine());

            if(numberA > numberB)
            {
                Console.WriteLine(numberA + numberB);
            }
            else
            {
                if(numberA == numberB)
                {
                    Console.WriteLine(numberA * numberB);
                }
                else
                {
                    if (numberA < numberB)
                    {
                        Console.WriteLine(numberA - numberB);
                    }
                }
            }
        }
    }
}

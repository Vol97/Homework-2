using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            if(x * y > 0)
            {
                if (x > 0)
                {
                    Console.WriteLine("1st quadrant");
                }
                else
                {
                    Console.WriteLine("3rd quadrant");
                }
            }
            if (x * y < 0)
            {
                if(x > 0)
                {
                    Console.WriteLine("4th quadrant");
                }
                else
                {
                    Console.WriteLine("2nd quadrant");
                }
            }
            if(x * y == 0)
            {
                if(x == 0 && y == 0)
                {
                    Console.WriteLine("The coordinate plane origin");
                }
                else if(x != 0)
                {
                    Console.WriteLine("X axis");
                }
                else
                {
                    Console.WriteLine("Y axis");
                }
            }
            
        }
    }
}

using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a two digit number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int ten = number / 10;
            int digits = number % 10;
            string tenText = null;
            string digitsText = null;

            if (number >= 10 && number <= 19)
            {
                switch(number)
                {
                    case (10):
                        Console.WriteLine("десять");
                        break;
                    case (11):
                        Console.WriteLine("одинадцать");
                        break;
                    case (12):
                        Console.WriteLine("двенадцать");
                        break;
                    case (13):
                        Console.WriteLine("тринадцать");
                        break;
                    case (14):
                        Console.WriteLine("четырнадцать");
                        break;
                    case (15):
                        Console.WriteLine("пятнадцать");
                        break;
                    case (16):
                        Console.WriteLine("шестнадцать");
                        break;
                    case (17):
                        Console.WriteLine("семнадцать");
                        break;
                    case (18):
                        Console.WriteLine("восемнадцать");
                        break;
                    case (19):
                        Console.WriteLine("девятнадцать");
                        break;
                }
            }
            else
            {
                switch (ten)
                {
                    case (2):
                        tenText = "двадцать";
                        break;
                    case (3):
                        tenText = "тридцать";
                        break;
                    case (4):
                        tenText = "сорок";
                        break;
                    case (5):
                        tenText = "пятьдесят";
                        break;
                    case (6):
                        tenText = "шестьдесят";
                        break;
                    case (7):
                        tenText = "семьдесят";
                        break;
                    case (8):
                        tenText = "восемьдесят";
                        break;
                    case (9):
                        tenText = "девяносто";
                        break;
                }
                switch (digits)
                {
                    case (1):
                        digitsText = "один";
                        break;
                    case (2):
                        digitsText = "два";
                        break;
                    case (3):
                        digitsText = "три";
                        break;
                    case (4):
                        digitsText = "четыре";
                        break;
                    case (5):
                        digitsText = "пять";
                        break;
                    case (6):
                        digitsText = "шесть";
                        break;
                    case (7):
                        digitsText = "семь";
                        break;
                    case (8):
                        digitsText = "восемь";
                        break;
                    case (9):
                        digitsText = "девять";
                        break;
                }
                Console.WriteLine($"{tenText} {digitsText}");
            }

        }
    }
}

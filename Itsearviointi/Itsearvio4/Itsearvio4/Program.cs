using System;

namespace Itsearvio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma pyytää kaksi lukua ja tulostaa perusaritmeettiset laskutoimitukset");
            double number1 = 0;
            double number2 = 0;

            Console.WriteLine("Syötä luku1: ");
            number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Syötä luku2: ");
            number2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{number1 + number2}");
            Console.WriteLine($"{number1 - number2}");
            Console.WriteLine($"{number1 * number2}");
            Console.WriteLine($"{number1 / number2}");
        }
    }
}

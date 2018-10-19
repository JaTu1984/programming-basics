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
            int k = 0;

            Console.WriteLine("Syötä luku1: ");
            number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Syötä luku2: ");                                                                 
            number2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{k}. {number1}+{number2} = {number1 + number2}");
            k = k + 1;
            Console.WriteLine($"{k}. {number1}-{number2} = {number1 - number2}");
            k = k + 1;
            Console.WriteLine($"{k}. {number1}*{number2} = {number1 * number2}");
            k = k + 1;
            Console.WriteLine($"{k}. {number1}/{number2} = {number1 / number2}");
            k = k + 1;
        }
    }
}

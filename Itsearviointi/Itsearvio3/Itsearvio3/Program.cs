using System;

namespace Itsearvio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma, joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun -1. Ohjelma tulostaa näytölle syötettyjen lukujen summan");
            int number = 0;
            int sum = 0;
            do
            {
                Console.WriteLine("Anna kokonaisluku: ");
                number = int.Parse(Console.ReadLine());
                sum = sum + number;
            }
            while (number != -1);
            Console.WriteLine($"{sum + 1}");

        }    
    }
}

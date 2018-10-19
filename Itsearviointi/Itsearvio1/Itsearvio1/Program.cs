using System;

namespace Itsearvio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma pyytää käyttäjältä lauseen ja tulostaa sen näytölle 5 kertaa");
            Console.WriteLine("Anna lause: ");

            string userInput = Console.ReadLine();
            for (int i = 0; i < 5; i++)
                Console.WriteLine(userInput);
        }
    }
}

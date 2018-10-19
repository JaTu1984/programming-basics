using System;

namespace Itsearvio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma, joka kysyy käyttäjältä sanan tai lauseen ja tulostaa sen niin monta kertaa näytölle kuin sanassa on kirjaimia");
            Console.WriteLine("Anna sana tai lause: ");
            string userInput = Console.ReadLine();
            
            int len = userInput.Length;
            int k = 0;

            Console.WriteLine($"Merkkien lukumäärä: {len}");
            for (int i = 0; i < len; i++)
            {
                k = k + 1;
                Console.WriteLine($"{k}. {userInput}");
            }
            
        }
    }
}

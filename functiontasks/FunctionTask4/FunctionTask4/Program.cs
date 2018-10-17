using System;

namespace FunctionTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Funktio, joka pyytää käyttäjältä 10 positiivista kokonaislukua ja palauttaa niistä suurimman");

            int number = 0;
            int i = 0;
            int j = 1;

            while (i < 10)
            { 
                    Console.WriteLine($"Anna positiivinen kokonaisluku{j}: ");
                    j = j + 1;
                bool isNumber = int.TryParse(Console.ReadLine(), out number);
                if (number > 0)
                    i = i + 1;
                if (!isNumber)
                    Console.WriteLine("Virheellinen syöte!");
                else if (number <= 0)
                    Console.WriteLine("Virheellinen luku!");
            }
                Console.WriteLine($"Syötit seuraavat luvut\n{number}");
                
                Console.WriteLine($"Suurin luvuista oli {number}");
            
        }
    }
}
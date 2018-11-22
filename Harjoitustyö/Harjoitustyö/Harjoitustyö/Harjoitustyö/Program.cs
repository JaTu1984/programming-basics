using System;

namespace Harjoitustyö
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kansallinen viitenumero");

            Console.WriteLine("Valitse toiminto [1-3]: ");

            int userAddedReferenceNumber = 0;

            Console.WriteLine($"1. Haluan tarkastaa kansallisen viitenumeron");
            Console.WriteLine($"2. Haluan luoda kansallisen viitenumeron");
            Console.WriteLine($"3. Haluan määrittää monta viitenumeroa luodaan ja tulostetaan tiedostoon");

            {
                int caseSwitch = int.Parse(Console.ReadLine());

                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("Syötä viitenumero");
                        userAddedReferenceNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine($"{userAddedReferenceNumber}");
                        Console.WriteLine("Viitenumero on oikein");
                        break;
                    case 2:
                        Console.WriteLine("Viitenumero luotu");
                        break;
                    default:
                        int viitteet = 0;
                        int i = 0;
                        Console.WriteLine("Syötä tiedostoon tulostettavien viitteiden lukumäärä");
                        viitteet = int.Parse(Console.ReadLine());
                        for (i = 0; i < viitteet; i++)
                        Console.WriteLine("viitteet tulostetaan tiedostoon");
                        break;
                }
            }
        }
    }
}

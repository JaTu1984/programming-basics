using System;

namespace Harjoitustyö
{
    class Program
    {

        
        static void Main(string[] args)
        {

            int userAddedReferenceNumber = 0;
            
            do
            {

                Console.WriteLine();
                Console.WriteLine("Kansallinen viitenumero");

                Console.WriteLine("Valitse toiminto [1-3]: ");

                Console.WriteLine($"1. Haluan tarkastaa kansallisen viitenumeron");
                Console.WriteLine($"2. Haluan luoda kansallisen viitenumeron");
                Console.WriteLine($"3. Haluan määrittää monta viitenumeroa luodaan ja tulostetaan tiedostoon");

                //bool isNumber = int.TryParse(Console.ReadKey().KeyChar.ToString(), out int caseSwitch);
                //if (isNumber)

                int caseSwitch = int.Parse(Console.ReadLine());
                {
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
                        case 3:
                            int viitteet = 0;
                            int i = 0;
                            Console.WriteLine("Syötä tiedostoon tulostettavien viitteiden lukumäärä");
                            viitteet = int.Parse(Console.ReadLine());
                            for (i = 0; i < viitteet; i++)
                                Console.WriteLine("viitteet tulostetaan tiedostoon");
                            break;
                        default:
                            Console.WriteLine("Virhe!!!");
                            break;
                    }
                }
                Console.Clear();

            } while (true);

            
        }


        static void Delay()

        {

            for (int i = 0; i < 3; i++)

            {

                Console.Write(".");

                System.Threading.Thread.Sleep(1000);

            }

            Console.WriteLine();

        }
    }
}

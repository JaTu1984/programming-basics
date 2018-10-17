using System;

namespace FunctionTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Funktio pyytää käyttäjältä luvun annetulta väliltä ja tarkastaa luvun kelpoisuuden");
            int number = 0;
           

            do
            {
                Console.Write("Syötä luku väliltä -10 - +10: ");

                bool isNumber = int.TryParse(Console.ReadLine(), out number);

                if (!isNumber)

                {

                    Console.WriteLine("Virheellinen syöte!");

                }

                else if (number > 10)
                {
                    Console.WriteLine($"Luku {number} ei ole kelvollinen!");
                }

                else if (number < -10)

                    Console.WriteLine($"Luku {number} ei ole kelvollinen!");

                else

                {

                    break;

                }



            } while (true);



            {

                if (number > 10)

                {
                    Console.WriteLine("Luku ei ole annetulta väliltä");
                }

                else if (number < -10)

                {
                    Console.WriteLine("Luku ei ole annetulta väliltä");
                }

                else

                    Console.WriteLine($"Luku {number} on kelvollinen");

            }
           
        }
    }
}

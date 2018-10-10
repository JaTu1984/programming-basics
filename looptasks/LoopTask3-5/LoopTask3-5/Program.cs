using System;

namespace LoopTask3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int i = 0;
            int evenSum = 0;
            int oddSum = 0;
            Console.WriteLine("Ohjelma laskee parittomien ja parillisten lukujen summan, myös negatiivisesti");
            Console.Write("Syötä luku: ");
            number = int.Parse(Console.ReadLine());

            while (i != number)
            {
                if (number > 0)
                {
                    i++;
                }
                else
                {
                    i--;
                }

                if (i % 2 == 0)
                {
                    evenSum += i;
                }
                else
                {
                    oddSum += i;
                }
            }
            Console.WriteLine($"Parillisten summa on {evenSum}");
            Console.WriteLine($"Parittomien summa on {oddSum}");
        }
    }
}

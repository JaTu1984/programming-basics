using System;

namespace LoopTask4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma, joka tulostaa 20 satunnaista kokonaislukua väliltä [0-50].");

            Random rnd = new Random();
            int rndNumber;

             {
                for (int i = 1; i <= 4; i++)
                {
                    Console.Write($"{i}\t");
                    for (int j = 1; j <= 5; j++)
                    {
                        rndNumber = rnd.Next(0, 51);
                        Console.Write($"{rndNumber},\t");
                    }
                    Console.WriteLine();
                }
            }
        }
        
    }
}

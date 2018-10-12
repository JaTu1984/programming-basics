using System;

namespace LoopTask4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rndNumber;
            int i = 0;

            Console.WriteLine("Ohjelma tulostaa vakioveikkausrivin");

            do
            {
                rndNumber = rnd.NextDouble();
                Console.WriteLine($"{i + 1}.\t{rndNumber}\t");
                i = i + 1; //i++
            } while (i < 13);


        }
    }
}

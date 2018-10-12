using System;

namespace LoopTask4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double rndNumber;
            int i = 0;

            Console.WriteLine("Ohjelma tulostaa vakioveikkausrivin");

            do
            {
                rndNumber = rnd.NextDouble();
                if (rndNumber <= 0.4)
                Console.WriteLine($"{i + 1}.\t1\t");
                if (rndNumber >= 0.6)
                Console.WriteLine($"{i + 1}.\t2\t");
                else
                Console.WriteLine($"{i + 1}.\tX\t");
                i = i + 1; //i++
            } while (i < 13);


        }
    }
}

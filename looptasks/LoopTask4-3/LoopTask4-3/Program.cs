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
            int i = 0;
            int j = 0;
       

            do
            {
                rndNumber = rnd.Next(0, 51);
                Console.WriteLine($"{i + 1}.\t{rndNumber}\t");
                i = i + 1; //i++
            } while (i < 50);
        }
    }
}

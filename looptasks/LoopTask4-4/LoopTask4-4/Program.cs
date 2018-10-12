using System;

namespace LoopTask4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int throws = 0;
            Random rnd = new Random();
            double rndNumber;
            int i = 0;
            int heads = 0;
            int tails = 0;

            Console.WriteLine("Ohjelma kysyy ensin heittojen lukumäärän n ja simuloi sitten rahan heittoa n kertaa(0 = klaava, 1 = kruuna)");

            Console.Write("Syötä heittojen lukumäärä: ");

            string userInput = Console.ReadLine();
            throws = int.Parse(userInput);
            do
            {
                rndNumber = rnd.NextDouble();
                {
                    if (rndNumber < 0.5)
                    tails = tails + 1;
                    else
                    heads = heads + 1;
                }
                i = i + 1;
            }
            while (i < throws);

            Console.WriteLine($"Rahaa on heitetty {throws} kertaa");
            Console.WriteLine($"Klaavojen lukumäärä = {tails}");
            Console.WriteLine($"Kruunujen lukumäärä = {heads}");

            
            
        }
    }
}

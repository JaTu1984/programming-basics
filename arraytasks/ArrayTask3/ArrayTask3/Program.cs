using System;

namespace ArrayTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo 7 eri lukua 1-40 ja tulostaa arvotut luvut pienimmästä suurimpaan.");
            int[] lottery = new int[9];
            Random rnd = new Random(); 
            for (int i = 0; i < 7; i++)
            {
                lottery[i] = rnd.Next(1, 40);
            }
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"{i+1}. {lottery[i]}");
            }
            for (int j = 0; j < 1; j++)
                {
                    lottery[j] = rnd.Next(1, 40);
                }
            for (int k = 0; k < 1; k++)
                {
                    lottery[k] = rnd.Next(1, 40);
                }
            for (int j = 0; j < 1; j++)
            {
                Console.WriteLine($"Lisänumero {lottery[j]}");
            }
            for (int k = 0; k < 1; k++)
            {
                Console.WriteLine($"Tuplausnumero {lottery[k]}");
            }
        }
    }
}

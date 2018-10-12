using System;

namespace LoopTask4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma simulois nopanheittoa 1000 kertaa ja ilmoittaa kuutosen esiintymiskerrat:");
            Random rnd = new Random();
            int rndNumber;
            int sixes = 0;
            int i = 0;
            do
            {
                rndNumber = rnd.Next(1, 7);
                Console.WriteLine($"{i + 1}.\t{rndNumber}\t");
                i = i + 1; //i++
                if (rndNumber == 6)

                    sixes = sixes + 1;

            } while (i < 1000);

            Console.WriteLine($"Silmäluku kuusi {sixes} kertaa");

               
        }
    }
}

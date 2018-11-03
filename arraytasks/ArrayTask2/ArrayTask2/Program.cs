using System;

namespace ArrayTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma, joka arpoo 100 lukua [0...50] väliltä ja tallettaa ne taulukkoon iT. Arvotut luvut sekä luvuista saatu keskiarvo ilmoitetaan käyttäjälle.");
            int[] iT = new int[100];
            Random rnd = new Random();
            int average = 0;
            for (int i = 0; i < 100; i++)
            {
                iT[i] = rnd.Next(50);
            }
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"{i+1}. {iT[i]}");
                average = average + iT[i];
            }
            Console.WriteLine($"Keskiarvo on {average/100}");
        }
    }
}

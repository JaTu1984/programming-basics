using System;

namespace Taulukkoharjoitus3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo yksiulotteiseen taulukkoon luvut 0-20");

            int[] array = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = rnd.Next(20);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"[{i + 1}]. {array[i]}");
            }
        }
    }
}

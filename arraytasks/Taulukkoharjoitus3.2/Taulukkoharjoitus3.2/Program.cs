using System;

namespace Taulukkoharjoitus3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo kaksiulotteiseen taulukkoon luvut 0-20");

            int[,] array = new int[10, 20];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            for (int j = 0; j < 20; j++)
            {
                array[i, j] = rnd.Next(100);
            }
            for (int i = 0; i < 10; i++)
            for (int j = 0; j < 20; j++)
            {
                Console.WriteLine($"[{i + 1}, {j+1}]. {array[i, j]}");
            }
        }
    }
}


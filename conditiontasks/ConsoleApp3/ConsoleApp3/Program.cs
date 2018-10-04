using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1;
            Console.WriteLine("Anna ohjelmalle 1 kokonaisluku:");
            luku1 = Int32.Parse(Console.ReadLine());

                    if ((luku1 > 0) && ((luku1 % 2) == 0))

                    Console.WriteLine("Luku on positiivinen ja parillinen");

            else

                    if ((luku1 < 0) && ((luku1 % 2) == 0))

                    Console.WriteLine("Luku on negatiivinen ja parillinen");

            else

                    if ((luku1 == 0) && ((luku1 % 2) == 0))

                    Console.WriteLine("Luku on nolla ja parillinen");

            else

                    if ((luku1 > 0 && ((luku1 % 2 == 1))))

                    Console.WriteLine("Luku on positiivinen ja pariton");

            else

                    if ((luku1 < 0) && ((luku1 % 2) == 1))

                    Console.WriteLine("Luku on negatiivinen ja pariton");



        }
    }
}

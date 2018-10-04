using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1;
            Console.WriteLine("Anna ohjelmalle 1 kokonaisluku:");
            luku1 = Int32.Parse(Console.ReadLine());

            if (luku1%2 == 0)

                Console.WriteLine("Luku on parillinen");

            else

                Console.WriteLine("Luku on pariton");

        }
    }
}

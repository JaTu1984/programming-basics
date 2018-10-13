using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1;
            Console.WriteLine("Anna ohjelmalle 1 kokonaisluku:");
            luku1 = Int32.Parse(Console.ReadLine());

            if (luku1 > 0)
            
            Console.WriteLine("Luku on positiivinen");
            else
                if (luku1 < 0)
                Console.WriteLine("Luku on negatiivinen");
                else
                Console.WriteLine("Luku on nolla");

            Console.ReadLine();
            
            
        }
    }
}
